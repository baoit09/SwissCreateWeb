using SwissCreate.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Projects
{
    public class ProjectMap : SwissCreateEntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // table name
            this.ToTable("Project");

            // table primary keys
            this.HasKey(p => p.Id);

            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.StartedDate).IsOptional();

            // table foreign keys
            this.HasRequired(p => p.User)
                .WithMany(u => u.Projects)
                .HasForeignKey(p => p.UserId)
                .WillCascadeOnDelete(false);

            this.HasOptional(p => p.ProjectCategory)
                .WithMany(pc => pc.Projects)
                .HasForeignKey(p => p.ProjectCategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
