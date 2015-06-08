using SwissCreate.Core;
using SwissCreate.Core.Caching;
using SwissCreate.Core.Data;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Services.UserRoles
{
    public partial class UserRoleService : IUserRoleService
    {
        #region Constants
        #endregion

        #region Fields
        private readonly ICacheManager _cacheManager;
        private readonly IRepository<UserRole> _userRoleRepository;
        private readonly IEventPublisher _eventPublisher;
        #endregion

        public UserRoleService(ICacheManager cacheManager, IRepository<UserRole> userRoleRepository, IEventPublisher eventPublisher)
        {
            this._cacheManager = cacheManager;
            this._userRoleRepository = userRoleRepository;
            this._eventPublisher = eventPublisher;
        }

        public virtual IPagedList<UserRole> GetAllUserRoles(int pageIndex = 0, int pageSize = Int32.MaxValue)
        {
            var query = _userRoleRepository.Table;

            query = query.OrderBy(u => u.Id);

            var userRoles = new PagedList<UserRole>(query, pageIndex, pageSize);

            return userRoles;
        }

        public void DeleteUserRole(UserRole userRole)
        {
            if (userRole == null)
                throw new ArgumentNullException("userRole");

            UpdateUserRole(userRole);
        }

        public UserRole GetUserRoleById(int userRoleId)
        {
            if (userRoleId == 0)
                return null;

            return _userRoleRepository.GetById(userRoleId);
        }

        public IList<UserRole> GetUserRolesByIds(int[] userRoleIds)
        {
            if (userRoleIds == null || userRoleIds.Length == 0)
                return new List<UserRole>();

            var query = from c in _userRoleRepository.Table
                        where userRoleIds.Contains(c.Id)
                        select c;
            var users = query.ToList();
            //sort by passed identifiers
            var sortedUsers = new List<UserRole>();
            foreach (int id in userRoleIds)
            {
                var customer = users.Find(x => x.Id == id);
                if (customer != null)
                    sortedUsers.Add(customer);
            }
            return sortedUsers;
        }

        public void InsertUserRole(UserRole userRole)
        {
            if (userRole == null)
                throw new ArgumentNullException("userRole");

            _userRoleRepository.Insert(userRole);

            //event notification
            _eventPublisher.EntityInserted(userRole);
        }

        public void UpdateUserRole(UserRole userRole)
        {
            if (userRole == null)
                throw new ArgumentNullException("user");

            _userRoleRepository.Update(userRole);

            //event notification
            _eventPublisher.EntityUpdated(userRole);
        }
    }
}
