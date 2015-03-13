using FluentValidation;
using FluentValidation.Results;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Services.Directory;
using SwissCreate.Services.Localization;
using SwissCreateWeb.Framework.Validators;
using SwissCreateWeb.Models.User;


namespace SwissCreateWeb.Validators.User
{
    public class UserProfileValidator : BaseSwissCreateValidator<UserProfileModel>
    {
        public UserProfileValidator(ILocalizationService localizationService,            
            UserSettings userSettings)
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(localizationService.GetResource("Account.UserProfile.Fields.FirstName.Required"));
            RuleFor(x => x.Surname).NotEmpty().WithMessage(localizationService.GetResource("Account.UserProfile.Fields.Surname.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.UserProfile.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
           
            if (userSettings.UsernamesEnabled && userSettings.AllowUsersToChangeUsernames)
            {
                RuleFor(x => x.Username).NotEmpty().WithMessage(localizationService.GetResource("Account.UserProfile.Fields.Username.Required"));
            }
        }
    }
}