using SwissCreate.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Users
{
    public partial class UserMap : SwissCreateEntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Table Name
            this.ToTable("User");

            // Primary Keys
            this.HasKey(u => u.Id);

            // Fields
            this.Property(u => u.FirstName).HasMaxLength(1000);
            this.Property(u => u.MiddleName).HasMaxLength(1000);
            this.Property(u => u.Surname).HasMaxLength(1000);
            this.Property(u => u.Email).HasMaxLength(1000);
            this.Property(u => u.Mobile).HasMaxLength(1000);
            this.Property(u => u.Username).HasMaxLength(1000);
            this.Property(u => u.Password).HasMaxLength(1000);
            this.Property(u => u.Active);
            this.Property(u => u.Deleted);
            this.Property(u => u.LastIpAddress).HasMaxLength(1000);
            this.Property(u => u.CreatedOnUtc);
            this.Property(u => u.LastLoginDateUtc);
            this.Property(u => u.LastActivityDateUtc);

            this.Ignore(u => u.PasswordFormat);

            // Foreign Keys
            this.HasMany(u => u.UserRoles)
                .WithMany()
                .Map(m => m.ToTable("Customer_CustomerRole_Mapping"));
        }
    }
}
