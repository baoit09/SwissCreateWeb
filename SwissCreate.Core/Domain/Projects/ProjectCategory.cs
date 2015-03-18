using SwissCreate.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Projects
{
    public class ProjectCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Published { get; set; }
        public bool Deleted { get; set; }

        public int? ParentProjectCategoryId { get; set; }
        public virtual ProjectCategory ParentProjectCategory { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectCategory> ChildProjectCategories { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
