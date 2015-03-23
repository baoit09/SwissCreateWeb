using SwissCreate.Core;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissCreate.Services.Projects
{
    public class ProjectService : IProjectService
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
        private readonly IRepository<Project> _projectRepository;

        #endregion

        #region Ctor
        public ProjectService(IDbContext dbContext, IRepository<Project> projectRepository)
        {
            _dbContext = dbContext;
            _projectRepository = projectRepository;
        }
        #endregion

        #region Methods

        public IPagedList<Project> GetAllProjects(DateTime? startedDateFrom = null, DateTime? startedDateTo = null, int pageIndex = 0, int pageSize = Int32.MaxValue)
        {
            var query = _projectRepository.Table;

            if (startedDateFrom.HasValue)
                query = query.Where(p => startedDateFrom.Value <= p.StartedDate);

            if (startedDateTo.HasValue)
                query = query.Where(p => p.StartedDate <= startedDateFrom.Value);

            var projects = new PagedList<Project>(query, pageIndex, pageSize);
            return projects;
        }

        public Project GetProjectById(int projectId)
        {
            if (projectId == 0)
                return null;

            return _projectRepository.GetById(projectId);
        }

        public IList<Project> GetProjectsByIds(int[] projectIds)
        {
            if (projectIds == null || projectIds.Length == 0)
                return new List<Project>();

            var query = from p in _projectRepository.Table
                        where projectIds.Contains(p.Id)
                        select p;

            var projects = query.ToList();

            // sort by passed identifiers
            var sortedProjects = new List<Project>();
            foreach (int id in projectIds)
            {
                var project = projects.Find(x => x.Id == id);
                if (project != null)
                    sortedProjects.Add(project);
            }

            return sortedProjects;
        }

        public IList<Project> GetProjectsByUser(int userId)
        {
            if (userId == 0) 
                return null;

            var query = from p in _projectRepository.Table
                        where p.UserId == userId
                        select p;
            var projects = query.ToList();
            return projects;
        }

        public IList<Project> GetProjectsByCategory(int projectCategoryId)
        {
            if (projectCategoryId == 0)
                return null;

            var query = from p in _projectRepository.Table
                        where p.ProjectCategoryId == projectCategoryId
                        select p;

            var projects = query.ToList();
            return projects;
        }

        public bool AddProject(Project project)
        {
            if (project == null)
                return false;

            _projectRepository.Insert(project);

            return true;
        }

        public bool DeleteProject(int projectId)
        {
            if (projectId < 1)
                return false;

            var project = _projectRepository.GetById(projectId);
            if (project != null)
                _projectRepository.Delete(project);

            return true;
        }

        public bool ChangeProjectName(int projectId, string newName)
        {
            if (projectId < 1)
                return false;

            var project = _projectRepository.GetById(projectId);
            if (project != null)
            {
                if (project.Name == newName)
                    return false;

                project.Name = newName;
                _projectRepository.Update(project);
            }
                

            return true;
        }

        #endregion
    }
}
