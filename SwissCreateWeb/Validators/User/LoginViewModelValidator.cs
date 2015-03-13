using FluentValidation;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Services.Localization;
using SwissCreateWeb.Framework.Validators;
using SwissCreateWeb.Models;

namespace SwissCreateWeb.Validators.User
{
    public class LoginViewModelValidator : BaseSwissCreateValidator<LoginViewModel>
    {
        public LoginViewModelValidator(ILocalizationService localizationService, UserSettings userSettings)
        {
            if (!userSettings.UsernamesEnabled)
            {
                //login by email
                RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.Login.Fields.Email.Required"));
                RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            }
        }
    }
}