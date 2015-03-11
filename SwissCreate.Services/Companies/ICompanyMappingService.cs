using System.Collections.Generic;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Companies;

namespace SwissCreate.Services.Companies
{
    /// <summary>
    /// Company mapping service interface
    /// </summary>
    public partial interface ICompanyMappingService
    {
        /// <summary>
        /// Deletes a store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping record</param>
        void DeleteCompanyMapping(CompanyMapping storeMapping);

        /// <summary>
        /// Gets a store mapping record
        /// </summary>
        /// <param name="storeMappingId">Company mapping record identifier</param>
        /// <returns>Company mapping record</returns>
        CompanyMapping GetCompanyMappingById(int storeMappingId);

        /// <summary>
        /// Gets store mapping records
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Company mapping records</returns>
        IList<CompanyMapping> GetCompanyMappings<T>(T entity) where T : BaseEntity, ICompanyMappingSupported;

        /// <summary>
        /// Inserts a store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping</param>
        void InsertCompanyMapping(CompanyMapping storeMapping);

        /// <summary>
        /// Inserts a store mapping record
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="storeId">Company id</param>
        /// <param name="entity">Entity</param>
        void InsertCompanyMapping<T>(T entity, int storeId) where T : BaseEntity, ICompanyMappingSupported;

        /// <summary>
        /// Updates the store mapping record
        /// </summary>
        /// <param name="storeMapping">Company mapping</param>
        void UpdateCompanyMapping(CompanyMapping storeMapping);

        /// <summary>
        /// Find store identifiers with granted access (mapped to the entity)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Wntity</param>
        /// <returns>Company identifiers</returns>
        int[] GetCompanysIdsWithAccess<T>(T entity) where T : BaseEntity, ICompanyMappingSupported;

        /// <summary>
        /// Authorize whether entity could be accessed in the current store (mapped to this store)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Wntity</param>
        /// <returns>true - authorized; otherwise, false</returns>
        bool Authorize<T>(T entity) where T : BaseEntity, ICompanyMappingSupported;

        /// <summary>
        /// Authorize whether entity could be accessed in a store (mapped to this store)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="storeId">Company identifier</param>
        /// <returns>true - authorized; otherwise, false</returns>
        bool Authorize<T>(T entity, int storeId) where T : BaseEntity, ICompanyMappingSupported;
    }
}