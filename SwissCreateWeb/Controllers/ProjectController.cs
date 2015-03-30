using SwissCreate.Core;
using SwissCreate.Services.Projects;
using System.Web.Mvc;
using System.Linq;
using SwissCreate.Core.Domain.Projects;
using System.Collections.Generic;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Extensions;
using SwissCreateWeb.Framework.Helpers;
using ViCode_LeVi.Data;

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

        public ActionResult ProjectEdit(int ProjectId)
        {
            ProjectEditModel model  = LocalGetProjectEditModel(ProjectId);
            return View(model);
        }

        public ActionResult GetProjectEditModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return Json(model);
        }

        private ProjectEditModel LocalGetProjectEditModel(int projectId)
        {
            ProjectEditModel model = new ProjectEditModel();

            var project = _projectService.GetProjectById(projectId);
            if (project != null)
            {
                model.Project = project.ToModel();

                if (!string.IsNullOrWhiteSpace(project.ProjectData))
                {
                    var bytes = System.Text.Encoding.UTF8.GetBytes(project.ProjectData);
                    var projectData = XMLData<ProjectData>.GetEntity(bytes);

                    model.ProjectData = projectData;
                }
            }
            return model;
        }

        public ActionResult QuestionAnswerStep(int projectId, int stepIndex)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            Step_QuestionAnwserStep QuestionAnwserStep = model.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep;
            return View(QuestionAnwserStep);
        }

        #region Tabs
        public ActionResult BusinessModel(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return View(model);
        }

        public ActionResult SwotAnalysis(int projectId)
        {
            ProjectEditModel model = LocalGetProjectEditModel(projectId);
            return PartialView(model);
        }
        #endregion
    }
}
