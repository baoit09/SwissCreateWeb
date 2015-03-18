using SwissCreate.Core;
using SwissCreate.Services.Projects;
using System.Web.Mvc;
using SwissCreate.Core.Domain;
using System.Linq;
using SwissCreate.Core.Domain.Projects;
using System.Collections.Generic;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Extensions;

namespace SwissCreateWeb.Controllers
{
    public class ProjectController : Controller
    {
        #region Fields

        private readonly IWorkContext _workContext;
        private readonly IProjectService _projectService;

        #endregion

        #region Ctor

        public ProjectController(IWorkContext workContext, IProjectService projectService)
        {
            this._workContext = workContext;
            this._projectService = projectService;
        }

        #endregion

        #region Methods
        public ActionResult FileManager()
        {
            var currentUser = _workContext.CurrentUser;
            var projects = _projectService.GetProjectsByUser(currentUser.Id);

            var dic = FindCategoriesHasProject(projects);
            FillAllParentCategories(dic);

            ProjectCategory rootCategory = new ProjectCategory() { Id = 0, Name = currentUser.FirstName };
            FindTopCategories(dic).ForEach(c => c.ParentProjectCategoryId = 0);

            ProjectCategoryModel rootCategoryModel = ConvertToModel(rootCategory, projects, dic);

            return View(new FileManagerModel()
            {
                ProjectCategoryRoot = rootCategoryModel
            });
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

        private List<ProjectCategory> FindTopCategories(Dictionary<int, ProjectCategory> dic)
        {
            var topCategories = dic.Where(kpv => kpv.Value.ParentProjectCategoryId == null).Select(kpv => kpv.Value).ToList();
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
