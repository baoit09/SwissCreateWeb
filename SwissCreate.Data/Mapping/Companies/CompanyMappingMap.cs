using SwissCreate.Core.Domain.Companies;

namespace SwissCreate.Data.Mapping.Companies
{
    public partial class CompanyMappingMap : SwissCreateEntityTypeConfiguration<CompanyMapping>
    {
        public CompanyMappingMap()
        {
            this.ToTable("CompanyMapping");
            this.HasKey(sm => sm.Id);

            this.Property(sm => sm.EntityName).IsRequired().HasMaxLength(400);

            this.HasRequired(sm => sm.Company)
                .WithMany()
                .HasForeignKey(sm => sm.CompanyId)
                .WillCascadeOnDelete(true);
        }
    }
}