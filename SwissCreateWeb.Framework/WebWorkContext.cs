using SwissCreate.Core;
using SwissCreate.Core.Domain.Directory;
using SwissCreate.Core.Domain.Localization;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Fakes;
using SwissCreate.Services.Authentication;
using SwissCreate.Services.Directory;
using SwissCreate.Services.Localization;
using SwissCreate.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SwissCreateWeb.Framework
{
    public partial class WebWorkContext : IWorkContext
    {
        #region Const

        #endregion

        #region Fields

        private readonly HttpContextBase _httpContext;
        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;
        private readonly ILanguageService _languageService;
        private readonly ICurrencyService _currencyService;
        private readonly ICompanyContext _companyContext;

        private User _cachedUser;
        private Language _cachedLanguage;
        private Currency _cachedCurrency;

        #endregion

        #region Ctor

        public WebWorkContext(HttpContextBase httpContext, 
            IUserService userService,
            ILanguageService languageService,
            ICurrencyService currencyService,
            ICompanyContext companyContext,
            IAuthenticationService authenticationService)
        {
            this._httpContext = httpContext;
            this._userService = userService;
            this._languageService = languageService;
            this._currencyService = currencyService;
            this._companyContext = companyContext;
            this._authenticationService = authenticationService;
        }

        #endregion

        /// <summary>
        /// Gets or sets the current customer
        /// </summary>
        public virtual User CurrentUser
        {
            get
            {
                if (_cachedUser != null)
                    return _cachedUser;

                User user = null;
                if (_httpContext == null || _httpContext is FakeHttpContext)
                {
                    //check whether request is made by a background task
                    //in this case return built-in customer record for background task
                    user = _userService.GetUserBySystemName(SystemUserNames.BackgroundTask);
                }

                //registered user
                if (user == null || user.Deleted || !user.Active)
                {
                    user = _authenticationService.GetAuthenticatedUser();
                }

                _cachedUser = user;

                return _cachedUser;
            }
            set {
                _cachedUser = value;
            }
        }

        /// <summary>
        /// Get or set current user working language
        /// </summary>
        public virtual Language WorkingLanguage
        {
            get
            {
                if (_cachedLanguage != null)
                    return _cachedLanguage;

                var allLanguages = _languageService.GetAllLanguages();
                
                var language = allLanguages.FirstOrDefault();
                
                //cache
                _cachedLanguage = language;
                return _cachedLanguage;
            }
            set
            {
                //reset cache
                _cachedLanguage = null;
            }
        }

        /// <summary>
        /// Get or set current user working currency
        /// </summary>
        public virtual Currency WorkingCurrency
        {
            get
            {
                if (_cachedCurrency != null)
                    return _cachedCurrency;

                var allCurrencies = _currencyService.GetAllCurrencies();
                var currency = allCurrencies.FirstOrDefault();
                
                //cache
                _cachedCurrency = currency;
                return _cachedCurrency;
            }
            set
            {
                //reset cache
                _cachedCurrency = null;
            }
        }
    }
}
