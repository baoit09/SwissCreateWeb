using System.Collections.Generic;
using SwissCreate.Core.Domain.Companies;

namespace SwissCreate.Services.Companies
{
    /// <summary>
    /// Company service interface
    /// </summary>
    public partial interface ICompanyService
    {
        /// <summary>
        /// Deletes a store
        /// </summary>
        /// <param name="store">Company</param>
        void DeleteCompany(Company store);

        /// <summary>
        /// Gets all stores
        /// </summary>
        /// <returns>Company collection</returns>
        IList<Company> GetAllCompanys();

        /// <summary>
        /// Gets a store 
        /// </summary>
        /// <param name="storeId">Company identifier</param>
        /// <returns>Company</returns>
        Company GetCompanyById(int storeId);

        /// <summary>
        /// Inserts a store
        /// </summary>
        /// <param name="store">Company</param>
        void InsertCompany(Company store);

        /// <summary>
        /// Updates the store
        /// </summary>
        /// <param name="store">Company</param>
        void UpdateCompany(Company store);
    }
}