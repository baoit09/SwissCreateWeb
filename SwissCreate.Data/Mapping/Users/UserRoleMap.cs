using SwissCreate.Core.Domain.Users;

namespace SwissCreate.Data.Mapping.Customers
{
    public partial class CustomerRoleMap : SwissCreateEntityTypeConfiguration<UserRole>
    {
        public CustomerRoleMap()
        {
            this.ToTable("UserRole");
            this.HasKey(cr => cr.Id);
            this.Property(cr => cr.Name).IsRequired().HasMaxLength(255);
            this.Property(cr => cr.SystemName).HasMaxLength(255);
        }
    }
}