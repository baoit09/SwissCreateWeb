using SwissCreate.Core;
using SwissCreate.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Services.Projects
{
    public interface IProjectCategoryService
    {
        /// <summary>
        /// Get all projects
        /// </summary>
        /// <param name="staredDateFrom">Started Date from, null to ignore Started Date from</param>
        /// <param name="staredDateTo">Started Date to, null to ignore Started Date to</param>
        /// <param name="pageIndex">Page Index</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns></returns>
        IPagedList<ProjectCategory> GetAllProjectCategories(int pageIndex = 0, int pageSize = Int32.MaxValue);

        /// <summary>
        /// Get project by project id
        /// </summary>
        /// <param name="projectId">project id</param>
        /// <returns></returns>
        ProjectCategory GetProjectCategoryById(int projectCategoryId);

        /// <summary>
        /// Get projects by project ids
        /// </summary>
        /// <param name="projectIds">project ids</param>
        /// <returns></returns>
        IList<ProjectCategory> GetProjectCategoriesByIds(int[] projectCategoryIds);

        /// <summary>
        /// Get project by user
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns></returns>
        IList<ProjectCategory> GetProjectCategoriesByUser(int userId);
    }
}
