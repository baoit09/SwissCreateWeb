using SwissCreate.Core.Domain.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Email
{
    public class EmailTemplateMap : SwissCreateEntityTypeConfiguration<EmailTemplate>
    {
        public EmailTemplateMap()
        {
            this.ToTable("EmailTemplates");
            this.HasKey(et => et.Id);

            this.Property(lp => lp.Name).IsRequired().HasMaxLength(50);
            this.Property(lp => lp.Subject).HasMaxLength(250);
        }
    }
}
