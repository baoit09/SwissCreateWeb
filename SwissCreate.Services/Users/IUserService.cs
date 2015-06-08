using System;
using System.Collections.Generic;
using SwissCreate.Core;
using SwissCreate.Core.Domain.Users;
using System.Threading.Tasks;

namespace SwissCreate.Services.Users
{
    public interface IUserService
    {
        /// <summary>
        /// Gets all users
        /// </summary>
        /// <param name="createdFromUtc">Created date from (UTC); null to load all records</param>
        /// <param name="createdToUtc">Created date to (UTC); null to load all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>User collection</returns>
        IPagedList<User> GetAllUsers(DateTime? createdFromUtc = null, DateTime? createdToUtc = null, int pageIndex = 0, int pageSize = Int32.MaxValue);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="customer">User</param>
        void DeleteUser(User user);

        /// <summary>
        /// Delete a users
        /// </summary>
        /// <param name="customer">Users</param>
        void DeleteUsers(IEnumerable<User> users);

        /// <summary>
        /// Gets a user
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <returns>A user</returns>
        User GetUserById(int userId);

        /// <summary>
        /// Get users by identifiers
        /// </summary>
        /// <param name="customerIds">User identifiers</param>
        /// <returns>Users</returns>
        IList<User> GetUsersByIds(int[] userIds);

        /// <summary>
        /// Get user by email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>User</returns>
        User GetUserByEmail(string email);

        /// <summary>
        /// Get customer by system role
        /// </summary>
        /// <param name="systemName">System name</param>
        /// <returns>Customer</returns>
        User GetUserBySystemName(string systemName);

        /// <summary>
        /// Get user by username
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns>User</returns>
        User GetUserByUsername(string username);

        /// <summary>
        /// Insert a user
        /// </summary>
        /// <param name="customer">User</param>
        void InsertUser(User user);

        /// <summary>
        /// Insert a users
        /// </summary>
        /// <param name="customer">Users</param>
        void InsertUsers(IEnumerable<User> users);

        /// <summary>
        /// Updates the user
        /// </summary>
        /// <param name="customer">User</param>
        void UpdateUser(User user);
    }
}
