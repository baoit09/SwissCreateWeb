using SwissCreate.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Projects
{
    public class Project : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }
        public string Note { get; set; }
        public DateTime? StartedDate { get; set; }
        public int? DisplayOrder { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int? ProjectCategoryId { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
