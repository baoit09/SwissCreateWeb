using System;
using System.Collections.Generic;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Users;
using System.Threading.Tasks;

namespace SwissCreate.Services.UserRoles
{
    public interface IUserRoleService
    {
        /// <summary>
        /// Gets all users
        /// </summary>
        /// <param name="createdFromUtc">Created date from (UTC); null to load all records</param>
        /// <param name="createdToUtc">Created date to (UTC); null to load all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>User collection</returns>
        IPagedList<UserRole> GetAllUserRoles(int pageIndex = 0, int pageSize = Int32.MaxValue);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="customer">User</param>
        void DeleteUserRole(UserRole userRole);

        /// <summary>
        /// Gets a user
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <returns>A user</returns>
        UserRole GetUserRoleById(int userRoleId);

        /// <summary>
        /// Get userroles by identifiers
        /// </summary>
        /// <param name="customerIds">User role identifiers</param>
        /// <returns>UserRoles</returns>
        IList<UserRole> GetUserRolesByIds(int[] userRoleIds);

        /// <summary>
        /// Insert a user
        /// </summary>
        /// <param name="customer">User</param>
        void InsertUserRole(UserRole userRole);

        /// <summary>
        /// Updates the user role
        /// </summary>
        /// <param name="customer">User Role</param>
        void UpdateUserRole(UserRole userRole);
    }
}
