using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SwissCreateWeb.Models;
using SwissCreate.Services.Users;
using SwissCreate.Core.Domain.Users;
using SwissCreateWeb.Framework.UI.Captcha;
using SwissCreate.Services.Authentication;
using SwissCreate.Services.Localization;
using SwissCreate.Core;
using SwissCreate.Services.Logging;
using SwissCreate.Core.Domain.Localization;
using SwissCreate.Services.Helpers;
using SwissCreate.Services.Companies;
using SwissCreateWeb.Extensions;
using SwissCreateWeb.Models.User;
using SwissCreate.Services.UserRoles;
using SwissCreate.Core.Domain.Email;
using SwissCreate.Data;
using SwissCreate.Core.Infrastructure;
using SwissCreateWeb.CustomAttributes;


namespace SwissCreateWeb.Controllers
{
    [Authorize]
    [HasPermission_AuthorizeFilter(SystemName = "Management.Users")]
    public class UserController : Controller
    {
        #region Fields

        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IAuthenticationService _authenticationService;
        private readonly ILocalizationService _localizationService;
        private readonly IWorkContext _workContext;
        private readonly ICompanyContext _companyContext;
        private readonly ICompanyMappingService _companyMappingService;
        private readonly IUserService _userService;
        private readonly IUserRoleService _userRoleService;
        private readonly IUserActivityService _userActivityService;
        private readonly IWebHelper _webHelper;
        private readonly IDateTimeHelper _dateTimeHelper;

        private readonly DateTimeSettings _dateTimeSettings;
        private readonly UserSettings _userSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly LocalizationSettings _localizationSettings;
        #endregion

        #region Ctor

        public UserController(
            IWorkContext workContext,
            ICompanyContext companyContext,
            IWebHelper webHelper,

            IUserRegistrationService userRegistrationService,
            IAuthenticationService authenticationService,
            ILocalizationService localizationService,
            IDateTimeHelper dateTimeHelper,


            ICompanyMappingService companyMappingService,
            IUserService userService,
            IUserRoleService userRoleService,
            IUserActivityService userActivityService,

            UserSettings userSettings,
            LocalizationSettings localizationSettings,
            CaptchaSettings captchaSettings,
            DateTimeSettings dateTimeSettings)
        {
            this._workContext = workContext;
            this._companyContext = companyContext;
            this._webHelper = webHelper;

            this._userRegistrationService = userRegistrationService;
            this._authenticationService = authenticationService;
            this._localizationService = localizationService;
            this._dateTimeHelper = dateTimeHelper;

            this._companyMappingService = companyMappingService;
            this._userService = userService;
            this._userRoleService = userRoleService;
            this._userActivityService = userActivityService;

            this._userSettings = userSettings;
            this._dateTimeSettings = dateTimeSettings;
            this._localizationSettings = localizationSettings;
            this._captchaSettings = captchaSettings;
        }
        #endregion

        //
        // GET: /User/
        public ActionResult Index()
        {
            var userManagementModel = new UserManagementModel();
            userManagementModel.UserItemModels = new List<UserItemModel>();
            userManagementModel.UserRoleModels = new List<UserRoleModel>();

            var userEntities = _userService.GetAllUsers();
            foreach (var userEntity in userEntities)
	        {
		        userManagementModel.UserItemModels.Add(userEntity.ToUserItemModel());
	        }


            var userRoleEntities = _userRoleService.GetAllUserRoles();
            foreach (var userRoleEntity in userRoleEntities)
            {
                userManagementModel.UserRoleModels.Add(userRoleEntity.ToModel());
            }
            userManagementModel.UserRoleModels.Insert(0, new UserRoleModel() { Id = 0, Name = string.Empty, Active = true });

            return View(userManagementModel);
        }

        public ActionResult GetUserManagementModel()
        {
            var userManagementModel = new UserManagementModel();
            userManagementModel.UserItemModels = new List<UserItemModel>();
            userManagementModel.UserRoleModels = new List<UserRoleModel>();

            var userEntities = _userService.GetAllUsers();
            foreach (var userEntity in userEntities)
            {
                userManagementModel.UserItemModels.Add(userEntity.ToUserItemModel());
            }


            var userRoleEntities = _userRoleService.GetAllUserRoles();
            foreach (var userRoleEntity in userRoleEntities)
            {
                userManagementModel.UserRoleModels.Add(userRoleEntity.ToModel());
            }
            userManagementModel.UserRoleModels.Insert(0, new UserRoleModel() { Id = 0, Name = string.Empty, Active = true });

            return Json(userManagementModel);
        }

        public ActionResult UpdateUserManagementModel(UserManagementModel userManagementModel)
        {
            var allEntities = _userService.GetAllUsers();
            var allUserRoles = _userRoleService.GetAllUserRoles();

            // for updated users, do update
            var updatedUsersClient = userManagementModel.UserItemModels.Where(u => u.Id > 0).ToList();
            var updatedIds = updatedUsersClient.Select(u => u.Id).ToArray();
            var updatedUsersServer = allEntities.Where(u => updatedIds.Contains(u.Id)).ToList();
            for (int i = 0; i < updatedUsersServer.Count(); i++)
			{
                AutoMapper.Mapper.Map(updatedUsersClient[i], updatedUsersServer[i]);

                var newUserRoles = new List<UserRole>();
                if (updatedUsersClient[i].AccountType.HasValue)
                {
                    if (updatedUsersServer[i].UserRoles != null && updatedUsersServer[i].UserRoles.Any(ur => ur.Id == updatedUsersClient[i].AccountType.Value))
                        continue;

                    var foundUR = allUserRoles.FirstOrDefault(ur => ur.Id == updatedUsersClient[i].AccountType.Value);
                    if (foundUR != null)
                    {
                        newUserRoles.Add(foundUR);
                    }
                }
                updatedUsersServer[i].UserRoles = newUserRoles;
			}
            _userService.UpdateUser(updatedUsersServer[0]);

            // for new users
            List<User> usersTobeAdded = new List<User>();
            var newEntitiesClient = userManagementModel.UserItemModels.Where(u => u.Id == 0).ToList();
            foreach (var newEntityClient in newEntitiesClient)
            {
                var newUser = newEntityClient.ToEntity2();
                newUser.Deleted = false;
                newUser.CreatedOnUtc = DateTime.UtcNow;
                newUser.PasswordFormat = PasswordFormat.Hashed;
                usersTobeAdded.Add(newUser);
            }
            _userService.InsertUsers(usersTobeAdded);

            // for deleted users
            var deleteUsers = allEntities.Where(u => !updatedIds.Contains(u.Id));
            foreach (var deleteUser in deleteUsers)
            {
                _userService.DeleteUser(deleteUser);
            }

            bool bSuccess = true;
            return Json(new { success = bSuccess });
        }

        public ActionResult GenerateUserPassword(UserItemModel userItemModel)
        {
            // Update some changes on data first.
            User user = UpdateAUserItemModel(userItemModel);

            if (user == null)
            {
                return Json(new { success = false, errorMsg = "There is a error on Server." });
            }

            string sNewPassWord = DoGeneratePassword();

            var changePasswordRequest = new ChangePasswordRequest(user.Email,
                    false, _userSettings.DefaultPasswordFormat, sNewPassWord, string.Empty);

            var changePasswordResult = _userRegistrationService.ChangePassword(changePasswordRequest);
            if (changePasswordResult.Success)
            {
                // Do Send Notification Email to user
                SendNotificationEmailOfPasswordChangedToUser("Swiss Create Password Changed", user, sNewPassWord);

                return Json(new { success = true, updatedUserModelItem = user.ToUserItemModel(), isRefreshData = false  });
            }
            else
            {
                return Json(new { success = false, errorMsg = "Generate Password failed." });
            }
        }

        private User UpdateAUserItemModel(UserItemModel userItemModel)
        {
            if (userItemModel == null)
            {
                return null;
            }

            User user = null;
            if (userItemModel.Id < 1)
            {
                user = userItemModel.ToEntity2();
            }
            else
            {
                user = _userService.GetUserById(userItemModel.Id);
                AutoMapper.Mapper.Map(userItemModel, user);
            }

            var allUserRoles = _userRoleService.GetAllUserRoles();
            var newUserRoles = new List<UserRole>();
            if (userItemModel.AccountType.HasValue)
            {
                if (user.UserRoles == null || !user.UserRoles.Any(ur => ur.Id == userItemModel.AccountType.Value))
                {
                    var foundUR = allUserRoles.FirstOrDefault(ur => ur.Id == userItemModel.AccountType.Value);
                    if (foundUR != null)
                    {
                        newUserRoles.Add(foundUR);
                    }
                }
            }
            user.UserRoles = newUserRoles;

            if (user.Id < 1)
            {
                _userService.InsertUser(user);
            }
            else
            {
                _userService.UpdateUser(user);
            }

            return user;
        }

        private string DoGeneratePassword()
        {
            string sGeneratePassword = Guid.NewGuid().ToString();
            sGeneratePassword = sGeneratePassword.Substring(0, 6);
            return sGeneratePassword;
        }

        public bool SendNotificationEmailOfPasswordChangedToUser(string sEmailTemplateName, User user, string sGeneratedPassword)
        {
            var scobjectData = EngineContext.Current.Resolve<IDbContext>();
            var emailTemplate = new EfRepository<EmailTemplate>(scobjectData).TableNoTracking.FirstOrDefault(et => et.Name == sEmailTemplateName);

            if (emailTemplate == null)
                return false;

            MessageQueue message = new MessageQueue();
            message.Recipient = user.Email;

            var sSubject = "The password in Swiss Create site changed ";
            message.Subject = string.Format(emailTemplate.Subject, sSubject);

            var sBody = "Your account in Swiss Create site has been changed as below:" + "\r\n";
            sBody += "Username : " + user.Username + "\r\n";
            sBody += "Password : " + sGeneratedPassword + "\r\n";
            message.MessageBody = string.Format(emailTemplate.Body, sBody);

            message.Sender = "noreply_swisscreate@swisscreate.com.au";
            message.Date_Send = DateTime.Now;

            var repo = new EfRepository<MessageQueue>(scobjectData);
            repo.Insert(message);

            return true;
        }
	}
}