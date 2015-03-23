using SwissCreate.Core;
using SwissCreate.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Services.Projects
{
    public interface IProjectService
    {
        /// <summary>
        /// Get all projects
        /// </summary>
        /// <param name="staredDateFrom">Started Date from, null to ignore Started Date from</param>
        /// <param name="staredDateTo">Started Date to, null to ignore Started Date to</param>
        /// <param name="pageIndex">Page Index</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns></returns>
        IPagedList<Project> GetAllProjects(DateTime? startedDateFrom = null, DateTime? startedDateTo = null, int pageIndex = 0, int pageSize = Int32.MaxValue);

        /// <summary>
        /// Get project by project id
        /// </summary>
        /// <param name="projectId">project id</param>
        /// <returns></returns>
        Project GetProjectById(int projectId);

        /// <summary>
        /// Get projects by project ids
        /// </summary>
        /// <param name="projectIds">project ids</param>
        /// <returns></returns>
        IList<Project> GetProjectsByIds(int[] projectIds);

        /// <summary>
        /// Get project by user
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns></returns>
        IList<Project> GetProjectsByUser(int userId);


        /// <summary>
        /// Get project by category
        /// </summary>
        /// <param name="categoryId">category id</param>
        /// <returns></returns>
        IList<Project> GetProjectsByCategory(int categoryId);


        bool AddProject(Project project);

        bool DeleteProject(int projectId);

        bool ChangeProjectName(int projectId, string newName);
    }
}
