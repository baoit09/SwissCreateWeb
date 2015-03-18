using SwissCreateWeb.Framework.Mvc;
using System;

namespace SwissCreateWeb.Models.Project
{
    public class ProjectModel : BaseSwissCreateModel
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }
        public string Note { get; set; }
        public DateTime StartedDate { get; set; }
    }
}