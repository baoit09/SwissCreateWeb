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
    public class ProjectManagerController : Controller
    {
        #region Fields

        private readonly IWorkContext _workContext;
        private readonly IProjectService _projectService;
        private readonly IProjectCategoryService _projectCategoryService;

        #endregion

        #region Ctor

        public ProjectManagerController(IWorkContext workContext, IProjectService projectService, IProjectCategoryService projectCategoryService)
        {
            this._workContext = workContext;
            this._projectService = projectService;
            this._projectCategoryService = projectCategoryService;
        }

        #endregion

        #region Methods
        public ActionResult FileManager()
        {
            var currentUser = _workContext.CurrentUser;
            var projectCategories = _projectCategoryService.GetProjectCategoriesByUser(currentUser.Id);

            ProjectCategory rootCategory = new ProjectCategory() { Id = 0, Name = currentUser.FirstName };
            rootCategory.ChildProjectCategories = FindTopCategories(projectCategories);

            ProjectCategoryModel rootCategoryModel = ConvertToModel(rootCategory);

            return View(new FileManagerModel()
            {
                ProjectCategoryRoot = rootCategoryModel
            });
        }

        public ActionResult GetProjectCategoryRoot()
        {
            var currentUser = _workContext.CurrentUser;
            var projectCategories = _projectCategoryService.GetProjectCategoriesByUser(currentUser.Id);

            ProjectCategory rootCategory = new ProjectCategory() { Id = 0, Name = currentUser.FirstName };
            rootCategory.ChildProjectCategories = FindTopCategories(projectCategories);

            ProjectCategoryModel rootCategoryModel = ConvertToModel(rootCategory);

            return Json(new FileManagerModel()
            {
                ProjectCategoryRoot = rootCategoryModel
            });
        }

        public ActionResult AddChildProjectCategory(int parentCategoryId, string childFolderName)
        {
            var currentUser = _workContext.CurrentUser;

            var childProjectCategory = new ProjectCategory()
            {
                ParentProjectCategoryId = parentCategoryId > 0 ? parentCategoryId : (int?)null,
                Name = childFolderName,
                Published = true,
                Deleted = false,
                UserId = currentUser.Id
            };

            bool bAdded = _projectCategoryService.AddChildProjectCategory(parentCategoryId, childProjectCategory);
            return Json(new { success = bAdded });
        }

        public ActionResult AddProject(int parentCategoryId, string childFileName)
        {
            var currentUser = _workContext.CurrentUser;

            var project = new Project()
            {
                ProjectCategoryId = parentCategoryId > 0 ? parentCategoryId : (int?)null,
                Name = childFileName,
                UserId = currentUser.Id
            };

            bool bAdded = _projectService.AddProject(project);
            return Json(new { success = bAdded });
        }

        public ActionResult DeleteProjectCategory(int projectCategoryId)
        {
            bool bSuccess = _projectCategoryService.DeleteProjectCategory(projectCategoryId);
            return Json(new { success = bSuccess });
        }

        public ActionResult DeleteProject(int projectId)
        {
            bool bSuccess = _projectService.DeleteProject(projectId);
            return Json(new { success = bSuccess });
        }

        public ActionResult ChangeProjectCategoryName(int projectCategoryId, string newName)
        {
            bool bSuccess = _projectCategoryService.ChangeProjectCategoryName(projectCategoryId, newName);
            return Json(new { success = bSuccess });
        }

        public ActionResult ChangeProjectName(int projectId, string newName)
        {
            bool bSuccess = _projectService.ChangeProjectName(projectId, newName);
            return Json(new { success = bSuccess });
        }

        private void FillAllParentCategories(Dictionary<int, ProjectCategory> dic)
        {
            List<ProjectCategory> catsToBeAdded = new List<ProjectCategory>();
            foreach (var category in dic.Values)
            {
                var parentCat = category.ParentProjectCategory;
                while (parentCat != null)
                {
                    if (!dic.ContainsKey(parentCat.Id) && !catsToBeAdded.Contains(parentCat))
                    {
                        catsToBeAdded.Add(parentCat);
                    }
                    parentCat = parentCat.ParentProjectCategory;
                }
            }

            foreach (var cat in catsToBeAdded)
            {
                dic.Add(cat.Id, cat);
            }
        }

        private Dictionary<int, ProjectCategory> FindCategoriesHasProject(IList<Project> projects)
        {
            if (projects == null || projects.Count() == 0)
                return null;

            Dictionary<int, ProjectCategory> dic = new Dictionary<int, ProjectCategory>();
            foreach (var project in projects)
            {
                var category = project.ProjectCategory;
                if (category != null)
                {
                    if (!dic.ContainsKey(category.Id))
                    {
                        dic.Add(category.Id, category);
                        continue;
                    }

                    var dicCategory = dic[category.Id];
                    dicCategory.Projects.Add(project);
                    continue;
                }
            }
            return dic;
        }

        private List<ProjectCategory> FindTopCategories(IList<ProjectCategory> projectCategories)
        {
            var topCategories = projectCategories.Where(pc => pc.ParentProjectCategoryId == null).ToList();
            return topCategories;
        }

        private List<ProjectCategory> FindTopCategories(IList<Project> projects)
        {
            if (projects == null || projects.Count() == 0)
                return null;

            List<ProjectCategory> topCategories = new List<ProjectCategory>();
            foreach (var project in projects)
            {
                if (project == null)
                    continue;

                var topCategorie = FindTopProjectCategory(project);

                if (topCategorie == null)
                    continue;

                topCategories.Add(topCategorie);
            }

            return topCategories;
        }

        private ProjectCategory FindTopProjectCategory(Project project)
        {
            if (project == null || project.ProjectCategory == null)
                return null;

            var currentTopProjectCategory = project.ProjectCategory;
            while (currentTopProjectCategory.ParentProjectCategoryId != null)
            {
                currentTopProjectCategory = currentTopProjectCategory.ParentProjectCategory;
            }

            return currentTopProjectCategory;
        }

        private ProjectCategoryModel ConvertToModel(ProjectCategory category)
        {
            if (category == null)
                return null;

            ProjectCategoryModel catModel = category.ToModel();

            // Get project models :
            catModel.Projects = new List<ProjectModel>();
            if (category.Projects != null && category.Projects.Any())
            {
                foreach (var project in category.Projects)
                {
                    if (project == null)
                        continue;

                    var projectModel = project.ToModel();
                    catModel.Projects.Add(projectModel);
                }
            }

            // Get child project categories :
            catModel.ChildProjectCategories = new List<ProjectCategoryModel>();
            if (category.ChildProjectCategories != null && category.ChildProjectCategories.Any())
            {
                foreach (var projectCategory in category.ChildProjectCategories)
                {
                    if (projectCategory == null)
                        continue;

                    var projectCategoryModel = ConvertToModel(projectCategory);
                    catModel.ChildProjectCategories.Add(projectCategoryModel);
                }
            }

            return catModel;
        }

        private ProjectCategoryModel ConvertToModel(ProjectCategory category, IList<Project> projects, Dictionary<int, ProjectCategory> dic)
        {
            if (category == null)
                return null;

            ProjectCategoryModel catModel = category.ToModel();

            // Get project models :
            catModel.Projects = new List<ProjectModel>();
            foreach (var project in projects.Where(p => p.ProjectCategoryId == category.Id).ToList())
            {
                if (project == null)
                    continue;

                var projectModel = project.ToModel();
                catModel.Projects.Add(projectModel);
            }


            // Get child project categories :
            catModel.ChildProjectCategories = new List<ProjectCategoryModel>();
            foreach (var projectCategory in dic.Values.Where(pc => pc.ParentProjectCategoryId.HasValue && pc.ParentProjectCategoryId.Value == catModel.Id))
            {
                if (projectCategory == null)
                    continue;

                var projectCategoryModel = ConvertToModel(projectCategory, projects, dic);
                catModel.ChildProjectCategories.Add(projectCategoryModel);
            }


            return catModel;
        }
        #endregion
    }
}
