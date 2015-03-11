using System;
using System.Linq;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Companies;
using SwissCreate.Services.Companies;

namespace SwissCreate.Web.Framework
{
    /// <summary>
    /// Company context for web application
    /// </summary>
    public partial class WebCompanyContext : ICompanyContext
    {
        private readonly ICompanyService _storeService;
        private readonly IWebHelper _webHelper;

        private Company _cachedCompany;

        public WebCompanyContext(ICompanyService storeService, IWebHelper webHelper)
        {
            this._storeService = storeService;
            this._webHelper = webHelper;
        }

        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        public virtual Company CurrentCompany
        {
            get
            {
                if (_cachedCompany != null)
                    return _cachedCompany;

                //ty to determine the current store by HTTP_HOST
                var host = _webHelper.ServerVariables("HTTP_HOST");
                var allCompanys = _storeService.GetAllCompanys();
                var store = allCompanys.FirstOrDefault(s => s.ContainsHostValue(host));

                if (store == null)
                {
                    //load the first found store
                    store = allCompanys.FirstOrDefault();
                }
                if (store == null)
                    throw new Exception("No store could be loaded");

                _cachedCompany = store;
                return _cachedCompany;
            }
        }
    }
}
