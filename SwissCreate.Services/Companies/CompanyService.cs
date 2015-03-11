using System;
using System.Collections.Generic;
using System.Linq;
using SwissCreate.Core.Caching;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Companies;
using SwissCreate.Services.Events;

namespace SwissCreate.Services.Companies
{
    /// <summary>
    /// Company service
    /// </summary>
    public partial class CompanyService : ICompanyService
    {
        #region Constants

        /// <summary>
        /// Key for caching
        /// </summary>
        private const string STORES_ALL_KEY = "SwissCreate.stores.all";
        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        private const string STORES_BY_ID_KEY = "SwissCreate.stores.id-{0}";
        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        private const string STORES_PATTERN_KEY = "SwissCreate.stores.";

        #endregion
        
        #region Fields
        
        private readonly IRepository<Company> _companyRepository;
        private readonly IEventPublisher _eventPublisher;
        private readonly ICacheManager _cacheManager;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cacheManager">Cache manager</param>
        /// <param name="storeRepository">Company repository</param>
        /// <param name="eventPublisher">Event published</param>
        public CompanyService(ICacheManager cacheManager,
            IRepository<Company> storeRepository,
            IEventPublisher eventPublisher)
        {
            this._cacheManager = cacheManager;
            this._companyRepository = storeRepository;
            this._eventPublisher = eventPublisher;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes a store
        /// </summary>
        /// <param name="store">Company</param>
        public virtual void DeleteCompany(Company store)
        {
            if (store == null)
                throw new ArgumentNullException("store");

            var allCompanys = GetAllCompanys();
            if (allCompanys.Count == 1)
                throw new Exception("You cannot delete the only configured store");

            _companyRepository.Delete(store);

            _cacheManager.RemoveByPattern(STORES_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityDeleted(store);
        }

        /// <summary>
        /// Gets all stores
        /// </summary>
        /// <returns>Company collection</returns>
        public virtual IList<Company> GetAllCompanys()
        {
            string key = STORES_ALL_KEY;
            return _cacheManager.Get(key, () =>
            {
                var query = from s in _companyRepository.Table
                            orderby s.DisplayOrder, s.Id
                            select s;
                var stores = query.ToList();
                return stores;
            });
        }

        /// <summary>
        /// Gets a store 
        /// </summary>
        /// <param name="storeId">Company identifier</param>
        /// <returns>Company</returns>
        public virtual Company GetCompanyById(int storeId)
        {
            if (storeId == 0)
                return null;
            
            string key = string.Format(STORES_BY_ID_KEY, storeId);
            return _cacheManager.Get(key, () => _companyRepository.GetById(storeId));
        }

        /// <summary>
        /// Inserts a store
        /// </summary>
        /// <param name="store">Company</param>
        public virtual void InsertCompany(Company store)
        {
            if (store == null)
                throw new ArgumentNullException("store");

            _companyRepository.Insert(store);

            _cacheManager.RemoveByPattern(STORES_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityInserted(store);
        }

        /// <summary>
        /// Updates the store
        /// </summary>
        /// <param name="store">Company</param>
        public virtual void UpdateCompany(Company store)
        {
            if (store == null)
                throw new ArgumentNullException("store");

            _companyRepository.Update(store);

            _cacheManager.RemoveByPattern(STORES_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityUpdated(store);
        }

        #endregion
    }
}