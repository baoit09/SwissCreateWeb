namespace SwissCreate.Core.Domain.Companies
{
    /// <summary>
    /// Represents an entity which supports store mapping
    /// </summary>
    public partial interface ICompanyMappingSupported
    {
        /// <summary>
        /// Gets or sets a value indicating whether the entity is limited/restricted to certain stores
        /// </summary>
        bool LimitedToCompanys { get; set; }
    }
}
