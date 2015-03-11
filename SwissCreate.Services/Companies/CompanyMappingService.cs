using System;
using System.Collections.Generic;
using System.Linq;
using SwissCreate.Core;
using SwissCreate.Core.Caching;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Companies;

namespace SwissCreate.Services.Companies
{
    /// <summary>
    /// Company mapping service
    /// </summary>
    public partial class CompanyMappingService : ICompanyMappingService
    {
        #region Constants

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : entity ID
        /// {1} : entity name
        /// </remarks>
        private const string STOREMAPPING_BY_ENTITYID_NAME_KEY = "SwissCreate.storemapping.entityid-name-{0}-{1}";
        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        private const string STOREMAPPING_PATTERN_KEY = "SwissCreate.storemapping.";

        #endregion

        #region Fields

        private readonly IRepository<CompanyMapping> _storeMappingRepository;
        private readonly ICompanyContext _storeContext;
        private readonly ICacheManager _cacheManager;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cacheManager">Cache manager</param>
        /// <param name="storeContext">Company context</param>
        /// <param name="storeMappingRepository">Company mapping repository</param>
        /// <param name="catalogSettings">Catalog settings</param>
        public CompanyMappingService(ICacheManager cacheManager, 
            ICompanyContext storeContext,
            IRepository<CompanyMapping> storeMappingRepository)
        {
            this._cacheManager = cacheManager;
            this._storeContext = storeContext;
            this._storeMappingRepository = storeMappingRepository;            
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes a store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping record</param>
        public virtual void DeleteCompanyMapping(CompanyMapping storeMapping)
        {
            if (storeMapping == null)
                throw new ArgumentNullException("storeMapping");

            _storeMappingRepository.Delete(storeMapping);

            //cache
            _cacheManager.RemoveByPattern(STOREMAPPING_PATTERN_KEY);
        }

        /// <summary>
        /// Gets a store mapping record
        /// </summary>
        /// <param name="storeMappingId">Company mapping record identifier</param>
        /// <returns>Company mapping record</returns>
        public virtual CompanyMapping GetCompanyMappingById(int storeMappingId)
        {
            if (storeMappingId == 0)
                return null;

            return _storeMappingRepository.GetById(storeMappingId);
        }

        /// <summary>
        /// Gets store mapping records
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Company mapping records</returns>
        public virtual IList<CompanyMapping> GetCompanyMappings<T>(T entity) where T : BaseEntity, ICompanyMappingSupported
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            int entityId = entity.Id;
            string entityName = typeof(T).Name;

            var query = from sm in _storeMappingRepository.Table
                        where sm.EntityId == entityId &&
                        sm.EntityName == entityName
                        select sm;
            var storeMappings = query.ToList();
            return storeMappings;
        }


        /// <summary>
        /// Inserts a store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping</param>
        public virtual void InsertCompanyMapping(CompanyMapping storeMapping)
        {
            if (storeMapping == null)
                throw new ArgumentNullException("storeMapping");

            _storeMappingRepository.Insert(storeMapping);

            //cache
            _cacheManager.RemoveByPattern(STOREMAPPING_PATTERN_KEY);
        }

        /// <summary>
        /// Inserts a store mapping record
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="storeId">Company id</param>
        /// <param name="entity">Entity</param>
        public virtual void InsertCompanyMapping<T>(T entity, int storeId) where T : BaseEntity, ICompanyMappingSupported
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            if (storeId == 0)
                throw new ArgumentOutOfRangeException("storeId");

            int entityId = entity.Id;
            string entityName = typeof(T).Name;

            var storeMapping = new CompanyMapping
            {
                EntityId = entityId,
                EntityName = entityName,
                CompanyId = storeId
            };

            InsertCompanyMapping(storeMapping);
        }

        /// <summary>
        /// Updates the store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping</param>
        public virtual void UpdateCompanyMapping(CompanyMapping storeMapping)
        {
            if (storeMapping == null)
                throw new ArgumentNullException("storeMapping");

            _storeMappingRepository.Update(storeMapping);

            //cache
            _cacheManager.RemoveByPattern(STOREMAPPING_PATTERN_KEY);
        }

        /// <summary>
        /// Find store identifiers with granted access (mapped to the entity)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Wntity</param>
        /// <returns>Company identifiers</returns>
        public virtual int[] GetCompanysIdsWithAccess<T>(T entity) where T : BaseEntity, ICompanyMappingSupported
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            int entityId = entity.Id;
            string entityName = typeof(T).Name;

            string key = string.Format(STOREMAPPING_BY_ENTITYID_NAME_KEY, entityId, entityName);
            return _cacheManager.Get(key, () =>
            {
                var query = from sm in _storeMappingRepository.Table
                            where sm.EntityId == entityId &&
                            sm.EntityName == entityName
                            select sm.CompanyId;
                return query.ToArray();
            });
        }

        /// <summary>
        /// Authorize whether entity could be accessed in the current store (mapped to this store)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Wntity</param>
        /// <returns>true - authorized; otherwise, false</returns>
        public virtual bool Authorize<T>(T entity) where T : BaseEntity, ICompanyMappingSupported
        {
            return Authorize(entity, _storeContext.CurrentCompany.Id);
        }

        /// <summary>
        /// Authorize whether entity could be accessed in a store (mapped to this store)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="storeId">Company identifier</param>
        /// <returns>true - authorized; otherwise, false</returns>
        public virtual bool Authorize<T>(T entity, int storeId) where T : BaseEntity, ICompanyMappingSupported
        {
            if (entity == null)
                return false;

            if (storeId == 0)
                //return true if no store specified/found
                return true;

            if (!entity.LimitedToCompanys)
                return true;

            foreach (var storeIdWithAccess in GetCompanysIdsWithAccess(entity))
                if (storeId == storeIdWithAccess)
                    //yes, we have such permission
                    return true;

            //no permission found
            return false;
        }

        #endregion
    }
}