using SwissCreate.Core;
using SwissCreate.Core.Caching;
using SwissCreate.Core.Domain.Localization;
using SwissCreate.Services.Localization;
using SwissCreateWeb.Framework.Localization;
using SwissCreateWeb.Models.Common;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwissCreateWeb.Controllers
{
    public class CommonController : Controller
    {
        #region Constants
        /// <summary>
        /// Key for available languages
        /// </summary>
        /// <remarks>
        /// {0} : current store ID
        /// </remarks>
        public const string AVAILABLE_LANGUAGES_MODEL_KEY = "Nop.pres.languages.all";
        public const string AVAILABLE_LANGUAGES_PATTERN_KEY = "Nop.pres.languages";

        #endregion

        #region Fields

        private readonly ICacheManager _cacheManager;
        private readonly ILanguageService _languageService;
        private readonly ILocalizationService _localizationService;
        private readonly IWorkContext _workContext;
        private readonly ICompanyContext _companyContext;

        private readonly LocalizationSettings _localizationSettings;

        #endregion

        #region Constructors

        public CommonController(
            ICacheManager cacheManager,
            ILanguageService languageService,
            ILocalizationService localizationService,
            IWorkContext workContext,
            ICompanyContext companyContext,
            
            LocalizationSettings localizationSettings)
        {
            this._cacheManager = cacheManager;
            this._languageService = languageService;
            this._localizationService = localizationService;
            this._workContext = workContext;
            this._companyContext = companyContext;
            this._localizationSettings = localizationSettings;
          }

        #endregion

        #region Language Selector

        public ActionResult LanguageSelector()
        {
            var availableLanguages = _cacheManager.Get(AVAILABLE_LANGUAGES_MODEL_KEY, () =>
            {
                var result = _languageService
                    .GetAllLanguages()
                    .Select(x => new LanguageModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        FlagImageFileName = x.FlagImageFileName,
                    })
                    .ToList();
                return result;
            });

            var model = new LanguageSelectorModel
            {
                CurrentLanguageId = _workContext.WorkingLanguage.Id,
                AvailableLanguages = availableLanguages,
                UseImages = _localizationSettings.UseImagesForLanguageSelection
            };

            if (model.AvailableLanguages.Count == 1)
                Content("");

            return PartialView(model);
        }

        public ActionResult SetLanguage(int langid, string returnUrl = "")
        {
            var language = _languageService.GetLanguageById(langid);
            if (language != null && language.Published)
            {
                _workContext.WorkingLanguage = language;
            }

            //home page
            if (String.IsNullOrEmpty(returnUrl))
                returnUrl = Url.RouteUrl("HomePage");

            //prevent open redirection attack
            if (!Url.IsLocalUrl(returnUrl))
                returnUrl = Url.RouteUrl("HomePage");

            //language part in URL
            if (_localizationSettings.SeoFriendlyUrlsForLanguagesEnabled)
            {
                string applicationPath = HttpContext.Request.ApplicationPath;
                if (returnUrl.IsLocalizedUrl(applicationPath, true))
                {
                    //already localized URL
                    returnUrl = returnUrl.RemoveLanguageSeoCodeFromRawUrl(applicationPath);
                }
                returnUrl = returnUrl.AddLanguageSeoCodeToRawUrl(applicationPath, _workContext.WorkingLanguage);
            }
            return Redirect(returnUrl);
        }

        #endregion
    }
}