using SwissCreate.Core;
using SwissCreate.Services.Projects;
using System.Web.Mvc;
using System.Linq;
using SwissCreate.Core.Domain.Projects;
using System.Collections.Generic;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Extensions;

namespace SwissCreateWeb.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        #region Fields

        private readonly IWorkContext _workContext;
        private readonly IProjectService _projectService;
        private readonly IProjectCategoryService _projectCategoryService;

        #endregion

        #region Ctor

        public ProjectController(IWorkContext workContext, IProjectService projectService, IProjectCategoryService projectCategoryService)
        {
            this._workContext = workContext;
            this._projectService = projectService;
            this._projectCategoryService = projectCategoryService;
        }

        #endregion

        public ActionResult Project()
        {
            return View();
        }
    }
}
