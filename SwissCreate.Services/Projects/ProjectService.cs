using SwissCreate.Core;
using SwissCreate.Core.Caching;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Data;
using SwissCreate.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissCreate.Services.Projects
{
    public class ProjectService : IProjectService
    {
        #region Constants

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        private const string PROJECT_ALL_KEY = "SwissCreate.Project.all";
        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : system name
        /// </remarks>
        private const string PROJECT_BY_PROJECTID_KEY = "SwissCreate.Project.ProjectId-{0}";

        private const string PROJECT_BY_USERID_KEY = "SwissCreate.Project.UserId-{0}";

        private const string PROJECT_BY_CATEGORYID_KEY = "SwissCreate.Project.CategoryId-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        private const string PROJECT_PATTERN_KEY = "SwissCreate.Project.";

        #endregion

        #region Fields

        private readonly IDbContext _dbContext;
        private readonly IRepository<Project> _projectRepository;
        private readonly ICacheManager _cacheManager;
        private readonly IEventPublisher _eventPublisher;

        #endregion

        #region Ctor
        public ProjectService(IDbContext dbContext, IRepository<Project> projectRepository, ICacheManager cacheManager, IEventPublisher eventPublisher)
        {
            _dbContext = dbContext;
            _projectRepository = projectRepository;
            _cacheManager = cacheManager;
            _eventPublisher = eventPublisher;
        }
        #endregion

        #region Methods

        public IPagedList<Project> GetAllProjects(DateTime? startedDateFrom = null, DateTime? startedDateTo = null, int pageIndex = 0, int pageSize = Int32.MaxValue)
        {
            string sKey = PROJECT_ALL_KEY;
            return _cacheManager.Get(sKey, () =>
            {
                var query = _projectRepository.Table;

                if (startedDateFrom.HasValue)
                    query = query.Where(p => startedDateFrom.Value <= p.StartedDate);

                if (startedDateTo.HasValue)
                    query = query.Where(p => p.StartedDate <= startedDateFrom.Value);

                var projects = new PagedList<Project>(query, pageIndex, pageSize);
                return projects;
            });
        }

        public Project GetProjectById(int projectId)
        {
            if (projectId == 0)
                return null;

            string sKey = string.Format(PROJECT_BY_PROJECTID_KEY, projectId);
            return _cacheManager.Get(sKey, () =>
            {
                return _projectRepository.GetById(projectId);
            });
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

            string sKey = string.Format(PROJECT_BY_USERID_KEY, userId);
            return _cacheManager.Get(sKey, () =>
            {
                var query = from p in _projectRepository.Table
                            where p.UserId == userId
                            select p;
                var projects = query.ToList();
                return projects;
            });
        }

        public IList<Project> GetProjectsByCategory(int projectCategoryId)
        {
            if (projectCategoryId == 0)
                return null;

            string sKey = string.Format(PROJECT_BY_CATEGORYID_KEY, projectCategoryId);
            return _cacheManager.Get(sKey, () =>
            {
                var query = from p in _projectRepository.Table
                            where p.ProjectCategoryId == projectCategoryId
                            select p;

                var projects = query.ToList();
                return projects;
            });
        }

        public bool AddProject(Project project)
        {
            if (project == null)
                return false;

            _projectRepository.Insert(project);

            _cacheManager.RemoveByPattern(PROJECT_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityInserted(project);

            return true;
        }

        public bool DeleteProject(int projectId)
        {
            if (projectId < 1)
                return false;

            var project = _projectRepository.GetById(projectId);
            if (project != null)
                _projectRepository.Delete(project);

            _cacheManager.RemoveByPattern(PROJECT_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityDeleted(project);

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

        public bool UpdateProject(Project project)
        {
            if (project == null)
                return false;

            _projectRepository.Update(project);

            _cacheManager.RemoveByPattern(PROJECT_PATTERN_KEY);

            //event notification
            _eventPublisher.EntityUpdated(project);

            return true;
        }

        public bool LogLastViewProject(int projectId, User user)
        {
            var project = _projectRepository.GetById(projectId);
            if (project != null)
            {
                project.LastViewedDateTime = DateTime.Now;
                project.LastViewedByUserId = user.Id;
                _projectRepository.Update(project);
                return true;
            }
            return false;
        }

        public bool LogLastUpdateProject(int projectId, User user)
        {
            var project = _projectRepository.GetById(projectId);
            if (project != null)
            {
                project.LastUpdatedDateTime = DateTime.Now;
                project.LastUpdatedByUser = user;
                _projectRepository.Update(project);
                return true;
            }
            return false;
        }

        public IList<Project> GetProjectsByLastView(User user, int nTop)
        {
            if (user == null)
                return null;

            var query = from p in _projectRepository.TableNoTracking
                        where p.LastViewedByUserId == user.Id
                        orderby p.LastViewedDateTime descending
                        select p;

            var projects = query.Take(nTop).ToList();
            return projects;
        }

        #endregion
    }
}
