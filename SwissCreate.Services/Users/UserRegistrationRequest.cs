using SwissCreate.Core.Domain.Users;

namespace SwissCreate.Services.Users
{
    public class UserRegistrationRequest
    {
        public User User { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public PasswordFormat PasswordFormat { get; set; }
        public bool IsApproved { get; set; }

        public UserRegistrationRequest(User user, string email, string username,
            string password,
            PasswordFormat passwordFormat,
            bool isApproved = true)
        {
            this.User = user;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.PasswordFormat = passwordFormat;
            this.IsApproved = isApproved;
        }

        //public bool IsValid  
        //{
        //    get 
        //    {
        //        return (!CommonHelper.AreNullOrEmpty(
        //                    this.Email,
        //                    this.Password
        //                    ));
        //    }
        //}
    }
}
