using SwissCreate.Core;
using SwissCreate.Core.Domain.Directory;
using SwissCreate.Core.Domain.Localization;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Fakes;
using SwissCreate.Services.Authentication;
using SwissCreate.Services.Common;
using SwissCreate.Services.Directory;
using SwissCreate.Services.Localization;
using SwissCreate.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SwissCreate.Core.Domain.Localization;
using SwissCreateWeb.Framework.Localization;

namespace SwissCreateWeb.Framework
{
    public partial class WebWorkContext : IWorkContext
    {
        #region Const

        private const string UserCookieName = "SwissCreate.User";

        #endregion

        #region Fields

        private readonly HttpContextBase _httpContext;
        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;
        private readonly ILanguageService _languageService;
        private readonly ICurrencyService _currencyService;
        private readonly ICompanyContext _companyContext;
        private readonly IGenericAttributeService _genericAttributeService;

        private readonly LocalizationSettings _localizationSettings;

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
            IAuthenticationService authenticationService,
            IGenericAttributeService genericAttributeService,
            LocalizationSettings localizationSettings)
        {
            this._httpContext = httpContext;
            this._userService = userService;
            this._languageService = languageService;
            this._currencyService = currencyService;
            this._companyContext = companyContext;
            this._authenticationService = authenticationService;
            this._genericAttributeService = genericAttributeService;

            this._localizationSettings = localizationSettings;
        }

        #endregion

        #region Utilities

        protected virtual HttpCookie GetUserCookie()
        {
            if (_httpContext == null || _httpContext.Request == null)
                return null;

            return _httpContext.Request.Cookies[UserCookieName];
        }

        protected virtual void SetUserCookie(Guid customerGuid)
        {
            if (_httpContext != null && _httpContext.Response != null)
            {
                var cookie = new HttpCookie(UserCookieName);
                cookie.HttpOnly = true;
                cookie.Value = customerGuid.ToString();
                if (customerGuid == Guid.Empty)
                {
                    cookie.Expires = DateTime.Now.AddMonths(-1);
                }
                else
                {
                    int cookieExpires = 24 * 365; //TODO make configurable
                    cookie.Expires = DateTime.Now.AddHours(cookieExpires);
                }

                _httpContext.Response.Cookies.Remove(UserCookieName);
                _httpContext.Response.Cookies.Add(cookie);
            }
        }


        protected virtual Language GetLanguageFromUrl()
        {
            if (_httpContext == null || _httpContext.Request == null)
                return null;

            string virtualPath = _httpContext.Request.AppRelativeCurrentExecutionFilePath;
            string applicationPath = _httpContext.Request.ApplicationPath;
            if (!virtualPath.IsLocalizedUrl(applicationPath, false))
                return null;

            var seoCode = virtualPath.GetLanguageSeoCodeFromUrl(applicationPath, false);
            if (String.IsNullOrEmpty(seoCode))
                return null;

            var language = _languageService
                .GetAllLanguages()
                .FirstOrDefault(l => seoCode.Equals(l.UniqueSeoCode, StringComparison.InvariantCultureIgnoreCase));
            if (language != null && language.Published)
            {
                return language;
            }

            return null;
        }

        protected virtual Language GetLanguageFromBrowserSettings()
        {
            if (_httpContext == null ||
                _httpContext.Request == null ||
                _httpContext.Request.UserLanguages == null)
                return null;

            var userLanguage = _httpContext.Request.UserLanguages.FirstOrDefault();
            if (String.IsNullOrEmpty(userLanguage))
                return null;

            var language = _languageService
                .GetAllLanguages()
                .FirstOrDefault(l => userLanguage.Equals(l.LanguageCulture, StringComparison.InvariantCultureIgnoreCase));
            if (language != null && language.Published)
            {
                return language;
            }

            return null;
        }

        #endregion

        #region Properties

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

                Language detectedLanguage = null;
                if (_localizationSettings.SeoFriendlyUrlsForLanguagesEnabled)
                {
                    //get language from URL
                    detectedLanguage = GetLanguageFromUrl();
                }
                if (detectedLanguage == null && _localizationSettings.AutomaticallyDetectLanguage)
                {
                    //get language from browser settings
                    //but we do it only once
                    if (this.CurrentUser != null && !this.CurrentUser.GetAttribute<bool>(SystemCustomerAttributeNames.LanguageAutomaticallyDetected,
                        _genericAttributeService))
                    {
                        detectedLanguage = GetLanguageFromBrowserSettings();
                        if (detectedLanguage != null)
                        {
                            _genericAttributeService.SaveAttribute(this.CurrentUser, SystemCustomerAttributeNames.LanguageAutomaticallyDetected,
                                 true);
                        }
                    }
                }
                if (detectedLanguage != null)
                {
                    //the language is detected. now we need to save it
                    if (this.CurrentUser != null && this.CurrentUser.GetAttribute<int>(SystemCustomerAttributeNames.LanguageId,
                        _genericAttributeService) != detectedLanguage.Id)
                    {
                        _genericAttributeService.SaveAttribute(this.CurrentUser, SystemCustomerAttributeNames.LanguageId,
                            detectedLanguage.Id);
                    }
                }

                Language language = null;
                var allLanguages = _languageService.GetAllLanguages();
                if (this.CurrentUser != null)
                {
                    //find current user's language
                    var languageId = this.CurrentUser.GetAttribute<int>(SystemCustomerAttributeNames.LanguageId,
                        _genericAttributeService);
                    language = allLanguages.FirstOrDefault(x => x.Id == languageId);
                    if (language == null)
                    {
                        //it not specified, then return the first (filtered by current store) found one
                        language = allLanguages.FirstOrDefault();
                    }
                }

                if (language == null)
                {
                    //it not specified, then return the first found one
                    language = _languageService.GetAllLanguages().FirstOrDefault();
                }
                
                //cache
                _cachedLanguage = language;
                return _cachedLanguage;
            }
            set
            {
                if (this.CurrentUser != null)
                {
                    var languageId = value != null ? value.Id : 0;
                    _genericAttributeService.SaveAttribute(this.CurrentUser,
                        SystemCustomerAttributeNames.LanguageId,
                        languageId);

                }
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

        #endregion
    }
}
