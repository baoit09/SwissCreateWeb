using SwissCreate.Core.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Logging
{
    public class LogMap : SwissCreateEntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Table Name
            this.ToTable("Log");

            // Table Keys
            this.HasKey(l => l.Id);

            // Table Properties
            this.Property(l => l.ShortMessage).IsRequired();
            this.Property(l => l.IpAddress).HasMaxLength(200);

            // Table Foreign Keys
            this.HasOptional(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId)
                .WillCascadeOnDelete(true);

            // Ignore Fields
            this.Ignore(l => l.LogLevel);
        }
    }
}
