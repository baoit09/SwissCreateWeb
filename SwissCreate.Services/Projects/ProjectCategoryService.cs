using SwissCreate.Core;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissCreate.Services.Projects
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        #region Constants

        ///// <summary>
        ///// Key for caching
        ///// </summary>
        ///// <remarks>
        ///// {0} : show hidden records?
        ///// </remarks>
        //private const string PROJECT_ALL_KEY = "SwissCreate.Project.all-{0}";
        ///// <summary>
        ///// Key for caching
        ///// </summary>
        ///// <remarks>
        ///// {0} : system name
        ///// </remarks>
        //private const string CUSTOMERROLES_BY_SYSTEMNAME_KEY = "Nop.customerrole.systemname-{0}";
        ///// <summary>
        ///// Key pattern to clear cache
        ///// </summary>
        //private const string CUSTOMERROLES_PATTERN_KEY = "Nop.customerrole.";

        #endregion

        #region Fields

        private readonly IDbContext _dbContext;
        private readonly IRepository<ProjectCategory> _projectCategoryRepository;

        #endregion

        #region Ctor
        public ProjectCategoryService(IDbContext dbContext, IRepository<ProjectCategory> projectCategoryRepository)
        {
            _dbContext = dbContext;
            _projectCategoryRepository = projectCategoryRepository;
        }
        #endregion

        #region Methods

        public IPagedList<ProjectCategory> GetAllProjectCategories(int pageIndex = 0, int pageSize = Int32.MaxValue)
        {
            var query = _projectCategoryRepository.Table;

            var projectCategories = new PagedList<ProjectCategory>(query, pageIndex, pageSize);
            return projectCategories;
        }

        public ProjectCategory GetProjectCategoryById(int projectCategoryId)
        {
            if (projectCategoryId == 0)
                return null;

            return _projectCategoryRepository.GetById(projectCategoryId);
        }

        public IList<ProjectCategory> GetProjectCategoriesByIds(int[] projectCategoryIds)
        {
            if (projectCategoryIds == null || projectCategoryIds.Length == 0)
                return new List<ProjectCategory>();

            var query = from p in _projectCategoryRepository.Table
                        where projectCategoryIds.Contains(p.Id)
                        select p;

            var projects = query.ToList();

            // sort by passed identifiers
            var sortedProjectCategories = new List<ProjectCategory>();
            foreach (int id in projectCategoryIds)
            {
                var projectCategory = projects.Find(x => x.Id == id);
                if (projectCategory != null)
                    sortedProjectCategories.Add(projectCategory);
            }

            return sortedProjectCategories;
        }

        public IList<ProjectCategory> GetProjectCategoriesByUser(int userId)
        {
            if (userId == 0) 
                return null;

            var query = from p in _projectCategoryRepository.Table
                        where p.UserId == userId
                        select p;
            var projectCategories = query.ToList();
            return projectCategories;
        }
        #endregion
    }
}
