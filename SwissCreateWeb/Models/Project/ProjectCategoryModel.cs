using SwissCreateWeb.Framework.Mvc;
using System.Collections.Generic;

namespace SwissCreateWeb.Models.Project
{
    public class ProjectCategoryModel : BaseSwissCreateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<ProjectModel> Projects { get; set; }
        public IList<ProjectCategoryModel> ChildProjectCategories { get; set; }
    }
}