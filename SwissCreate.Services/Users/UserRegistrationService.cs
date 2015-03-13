using System;
using System.Linq;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Services.Security;
using System.Threading.Tasks;
using SwissCreate.Services.Localization;

namespace SwissCreate.Services.Users
{
    /// <summary>
    /// User registration service
    /// </summary>
    public partial class UserRegistrationService : IUserRegistrationService
    {
        #region Fields

        private readonly IUserService _userService;
        private readonly ILocalizationService _localizationService;
        private readonly IEncryptionService _encryptionService;
        private readonly UserSettings _userSettings;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="userService">User service</param>
        /// <param name="encryptionService">Encryption service</param>
        /// <param name="newsLetterSubscriptionService">Newsletter subscription service</param>
        /// <param name="localizationService">Localization service</param>
        /// <param name="storeService">Store service</param>
        /// <param name="rewardPointsSettings">Reward points settings</param>
        /// <param name="userSettings">User settings</param>
        public UserRegistrationService(IUserService userService, 
            IEncryptionService encryptionService, 
            ILocalizationService localizationService,
            UserSettings userSettings)
        {
            this._userService = userService;
            this._encryptionService = encryptionService;
            this._localizationService = localizationService;
            this._userSettings = userSettings;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Validate User
        /// </summary>
        /// <param name="usernameOrEmail">Username or email</param>
        /// <param name="password">Password</param>
        /// <returns>Result</returns>
        public virtual async Task<UserLoginResults> ValidateUser(string usernameOrEmail, string password)
        {
            User User;
            if (_userSettings.UsernamesEnabled)
                User = _userService.GetUserByUsername(usernameOrEmail);
            else
                User = _userService.GetUserByEmail(usernameOrEmail);

            if (User == null)
                return UserLoginResults.UserNotExist;
            if (User.Deleted)
                return UserLoginResults.Deleted;
            if (!User.Active)
                return UserLoginResults.NotActive;
          
            string pwd = "";
            switch (User.PasswordFormat)
            {
                case PasswordFormat.Encrypted:
                    pwd = _encryptionService.EncryptText(password);
                    break;
                case PasswordFormat.Hashed:
                    pwd = _encryptionService.CreatePasswordHash(password, User.PasswordSalt, _userSettings.HashedPasswordFormat);
                    break;
                default:
                    pwd = password;
                    break;
            }

            bool isValid = pwd == User.Password;
            if (!isValid)
                return UserLoginResults.WrongPassword;

            //save last login date
            User.LastLoginDateUtc = DateTime.UtcNow;
            _userService.UpdateUser(User);
            return UserLoginResults.Successful;
        }

        /// <summary>
        /// Register User
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>Result</returns>
        public virtual UserRegistrationResult RegisterUser(UserRegistrationRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.User == null)
                throw new ArgumentException("Can't load current User");

            var result = new UserRegistrationResult();
            //if (request.User.IsSearchEngineAccount())
            //{
            //    result.AddError("Search engine can't be registered");
            //    return result;
            //}
            //if (request.User.IsBackgroundTaskAccount())
            //{
            //    result.AddError("Background task account can't be registered");
            //    return result;
            //}
            //if (request.User.IsRegistered())
            //{
            //    result.AddError("Current User is already registered");
            //    return result;
            //}
            //if (String.IsNullOrEmpty(request.Email))
            //{
            //    result.AddError(_localizationService.GetResource("Account.Register.Errors.EmailIsNotProvided"));
            //    return result;
            //}
            //if (!CommonHelper.IsValidEmail(request.Email))
            //{
            //    result.AddError(_localizationService.GetResource("Common.WrongEmail"));
            //    return result;
            //}
            //if (String.IsNullOrWhiteSpace(request.Password))
            //{
            //    result.AddError(_localizationService.GetResource("Account.Register.Errors.PasswordIsNotProvided"));
            //    return result;
            //}
            //if (_userSettings.UsernamesEnabled)
            //{
            //    if (String.IsNullOrEmpty(request.Username))
            //    {
            //        result.AddError(_localizationService.GetResource("Account.Register.Errors.UsernameIsNotProvided"));
            //        return result;
            //    }
            //}

            //validate unique user
            //if (_userService.GetUserByEmail(request.Email) != null)
            //{
            //    result.AddError(_localizationService.GetResource("Account.Register.Errors.EmailAlreadyExists"));
            //    return result;
            //}
            //if (_userSettings.UsernamesEnabled)
            //{
            //    if (_UserService.GetUserByUsername(request.Username) != null)
            //    {
            //        result.AddError(_localizationService.GetResource("Account.Register.Errors.UsernameAlreadyExists"));
            //        return result;
            //    }
            //}

            //at this point request is valid
            request.User.Username = request.Username;
            request.User.Email = request.Email;
            request.User.PasswordFormat = request.PasswordFormat;

            switch (request.PasswordFormat)
            {
                case PasswordFormat.Clear:
                    {
                        request.User.Password = request.Password;
                    }
                    break;
                case PasswordFormat.Encrypted:
                    {
                        request.User.Password = _encryptionService.EncryptText(request.Password);
                    }
                    break;
                case PasswordFormat.Hashed:
                    {
                        string saltKey = _encryptionService.CreateSaltKey(5);
                        request.User.PasswordSalt = saltKey;
                        request.User.Password = _encryptionService.CreatePasswordHash(request.Password, saltKey, _userSettings.HashedPasswordFormat);
                    }
                    break;
                default:
                    break;
            }

            request.User.Active = request.IsApproved;
            
            ////add to 'Registered' role
            //var registeredRole = _userService.GetUserRoleBySystemName(SystemUserRoleNames.Registered);
            //if (registeredRole == null)
            //    throw new NopException("'Registered' role could not be loaded");
            //request.User.UserRoles.Add(registeredRole);
            ////remove from 'Guests' role
            //var guestRole = request.User.UserRoles.FirstOrDefault(cr => cr.SystemName == SystemUserRoleNames.Guests);
            //if (guestRole != null)
            //    request.User.UserRoles.Remove(guestRole);
            
            ////Add reward points for User registration (if enabled)
            //if (_rewardPointsSettings.Enabled &&
            //    _rewardPointsSettings.PointsForRegistration > 0)
            //    request.User.AddRewardPointsHistoryEntry(_rewardPointsSettings.PointsForRegistration, _localizationService.GetResource("RewardPoints.Message.EarnedForRegistration"));

            //_UserService.UpdateUser(request.User);
            return result;
        }
        
        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>Result</returns>
        public virtual PasswordChangeResult ChangePassword(ChangePasswordRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            var result = new PasswordChangeResult();

            if (String.IsNullOrWhiteSpace(request.Email))
            {
                result.AddError(_localizationService.GetResource("Account.ChangePassword.Errors.EmailIsNotProvided"));
                return result;
            }
            if (String.IsNullOrWhiteSpace(request.NewPassword))
            {
                result.AddError(_localizationService.GetResource("Account.ChangePassword.Errors.PasswordIsNotProvided"));
                return result;
            }

            var user = _userService.GetUserByEmail(request.Email);
            if (user == null)
            {
                result.AddError(_localizationService.GetResource("Account.ChangePassword.Errors.EmailNotFound"));
                return result;
            }


            var requestIsValid = false;
            if (request.ValidateRequest)
            {
                //password
                string oldPwd = "";
                switch (user.PasswordFormat)
                {
                    case PasswordFormat.Encrypted:
                        oldPwd = _encryptionService.EncryptText(request.OldPassword);
                        break;
                    case PasswordFormat.Hashed:
                        oldPwd = _encryptionService.CreatePasswordHash(request.OldPassword, user.PasswordSalt, _userSettings.HashedPasswordFormat);
                        break;
                    default:
                        oldPwd = request.OldPassword;
                        break;
                }

                bool oldPasswordIsValid = oldPwd == user.Password;
                if (!oldPasswordIsValid)
                    result.AddError(_localizationService.GetResource("Account.ChangePassword.Errors.OldPasswordDoesntMatch"));

                if (oldPasswordIsValid)
                    requestIsValid = true;
            }
            else
                requestIsValid = true;


            //at this point request is valid
            if (requestIsValid)
            {
                switch (request.NewPasswordFormat)
                {
                    case PasswordFormat.Clear:
                        {
                            user.Password = request.NewPassword;
                        }
                        break;
                    case PasswordFormat.Encrypted:
                        {
                            user.Password = _encryptionService.EncryptText(request.NewPassword);
                        }
                        break;
                    case PasswordFormat.Hashed:
                        {
                            string saltKey = _encryptionService.CreateSaltKey(5);
                            user.PasswordSalt = saltKey;
                            user.Password = _encryptionService.CreatePasswordHash(request.NewPassword, saltKey, _userSettings.HashedPasswordFormat);
                        }
                        break;
                    default:
                        break;
                }

                user.PasswordFormat = request.NewPasswordFormat;
                _userService.UpdateUser(user);
            }

            return result;
        }

        /// <summary>
        /// Sets a user email
        /// </summary>
        /// <param name="User">User</param>
        /// <param name="newEmail">New email</param>
        public virtual void SetEmail(User User, string newEmail)
        {
            if (User == null)
                throw new ArgumentNullException("User");

            newEmail = newEmail.Trim();
            string oldEmail = User.Email;

            //if (!CommonHelper.IsValidEmail(newEmail))
            //    throw new NopException(_localizationService.GetResource("Account.EmailUsernameErrors.NewEmailIsNotValid"));

            //if (newEmail.Length > 100)
            //    throw new NopException(_localizationService.GetResource("Account.EmailUsernameErrors.EmailTooLong"));

            //var User2 = _UserService.GetUserByEmail(newEmail);
            //if (User2 != null && User.Id != User2.Id)
            //    throw new NopException(_localizationService.GetResource("Account.EmailUsernameErrors.EmailAlreadyExists"));

            User.Email = newEmail;
            _userService.UpdateUser(User);

            //update newsletter subscription (if required)
            //if (!String.IsNullOrEmpty(oldEmail) && !oldEmail.Equals(newEmail, StringComparison.InvariantCultureIgnoreCase))
            //{
            //    foreach (var store in _storeService.GetAllStores())
            //    {
            //        var subscriptionOld = _newsLetterSubscriptionService.GetNewsLetterSubscriptionByEmailAndStoreId(oldEmail, store.Id);
            //        if (subscriptionOld != null)
            //        {
            //            subscriptionOld.Email = newEmail;
            //            _newsLetterSubscriptionService.UpdateNewsLetterSubscription(subscriptionOld);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Sets a User username
        /// </summary>
        /// <param name="User">User</param>
        /// <param name="newUsername">New Username</param>
        public virtual void SetUsername(User User, string newUsername)
        {
            if (User == null)
                throw new ArgumentNullException("User");

            if (!_userSettings.UsernamesEnabled)
                throw new SwissCreateException("Usernames are disabled");

            if (!_userSettings.AllowUsersToChangeUsernames)
                throw new SwissCreateException("Changing usernames is not allowed");

            newUsername = newUsername.Trim();

            if (newUsername.Length > 100)
                throw new SwissCreateException(_localizationService.GetResource("Account.EmailUsernameErrors.UsernameTooLong"));

            var user2 = _userService.GetUserByUsername(newUsername);
            if (user2 != null && User.Id != user2.Id)
                throw new SwissCreateException(_localizationService.GetResource("Account.EmailUsernameErrors.UsernameAlreadyExists"));

            User.Username = newUsername;
            _userService.UpdateUser(User);
        }

        #endregion
    }
}