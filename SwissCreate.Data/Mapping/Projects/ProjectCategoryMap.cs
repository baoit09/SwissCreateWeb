using SwissCreate.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping.Projects
{
    public class ProjectCategoryMap : SwissCreateEntityTypeConfiguration<ProjectCategory>
    {
        public ProjectCategoryMap()
        {
            // table name
            this.ToTable("ProjectCategory");

            // table properties
            this.Property(pc => pc.Name).IsRequired().HasMaxLength(400);
            this.Property(pc => pc.Description).HasMaxLength(400);

            // table primary keys
            this.HasKey(pc => pc.Id);

            // table foreign keys to ParentProjectCategoryId
            this.HasOptional(pc => pc.ParentProjectCategory)
                .WithMany(ppc => ppc.ChildProjectCategories)
                .HasForeignKey(pc => pc.ParentProjectCategoryId)
                .WillCascadeOnDelete(false);

            // table foreign keys to UserId
            this.HasOptional(pc => pc.User)
                .WithMany(u => u.ProjectCategories)
                .HasForeignKey(pc => pc.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
