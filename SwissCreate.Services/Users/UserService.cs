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

namespace SwissCreate.Services.Users
{
    public partial class UserService : IUserService
    {
        #region Constants
        #endregion

        #region Fields
        private readonly ICacheManager _cacheManager;
        private readonly IRepository<User> _userRepository;
        private readonly IEventPublisher _eventPublisher;
        #endregion

        public UserService(ICacheManager cacheManager, IRepository<User> userRepository, IEventPublisher eventPublisher)
        {
            this._cacheManager = cacheManager;
            this._userRepository = userRepository;
            this._eventPublisher = eventPublisher;
        }

        public virtual IPagedList<User> GetAllUsers(DateTime? createdFromUtc = null, DateTime? createdToUtc = null, int pageIndex = 0, int pageSize = Int32.MaxValue)
        {
            var query = _userRepository.Table;

            if (createdFromUtc.HasValue)
                query = query.Where(u => createdFromUtc.Value <= u.CreatedOnUtc);

            if (createdToUtc.HasValue)
                query = query.Where(u => createdToUtc.Value >= u.CreatedOnUtc);

            query = query.Where(u => !u.Deleted);
            query = query.OrderBy(u => u.Id);

            var users = new PagedList<User>(query, pageIndex, pageSize);
            return users;
        }

        public void DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            _userRepository.Delete(user);            
        }

        public void DeleteUsers(IEnumerable<User> users)
        {
            if (users == null && !users.Any())
                throw new ArgumentNullException("users");

            foreach (var user in users)
            {
                user.Deleted = true;
            }

            UpdateUser(users.FirstOrDefault());
        }

        public User GetUserById(int userId)
        {
            if (userId == 0)
                return null;

            return _userRepository.GetById(userId);
        }

        public IList<User> GetUsersByIds(int[] userIds)
        {
            if (userIds == null || userIds.Length == 0)
                return new List<User>();

            var query = from c in _userRepository.Table
                        where userIds.Contains(c.Id)
                        select c;
            var users = query.ToList();
            //sort by passed identifiers
            var sortedUsers = new List<User>();
            foreach (int id in userIds)
            {
                var customer = users.Find(x => x.Id == id);
                if (customer != null)
                    sortedUsers.Add(customer);
            }
            return sortedUsers;
        }

        public User GetUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            var query = from c in _userRepository.Table
                        orderby c.Id
                        where c.Email == email
                        select c;
            var user = query.FirstOrDefault();
            return user;
        }

        /// <summary>
        /// Get customer by system name
        /// </summary>
        /// <param name="systemName">System name</param>
        /// <returns>Customer</returns>
        public virtual User GetUserBySystemName(string systemName)
        {
            if (string.IsNullOrWhiteSpace(systemName))
                return null;

            var query = from c in _userRepository.Table
                        orderby c.Id
                        where c.SystemName == systemName
                        select c;
            var user = query.FirstOrDefault();
            return user;
        }

        public User GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            var query = from c in _userRepository.Table
                        orderby c.Id
                        where c.Username == username
                        select c;
            var user = query.FirstOrDefault();
            return user;
        }

        public void InsertUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            _userRepository.Insert(user);

            //event notification
            _eventPublisher.EntityInserted(user);
        }

        public void InsertUsers(IEnumerable<User> users)
        {
            if (users == null)
                throw new ArgumentNullException("user");

            _userRepository.Insert(users);

            //event notification
            _eventPublisher.EntityInserted(users.FirstOrDefault());
        }

        public void UpdateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            _userRepository.Update(user);

            //event notification
            _eventPublisher.EntityUpdated(user);
        }
    }
}
