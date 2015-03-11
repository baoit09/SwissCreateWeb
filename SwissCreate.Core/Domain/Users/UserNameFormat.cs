using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Users
{
    /// <summary>
    /// Represents the customer name fortatting enumeration
    /// </summary>
    public enum UserNameFormat
    {
        /// <summary>
        /// Show emails
        /// </summary>
        ShowEmails = 1,
        /// <summary>
        /// Show usernames
        /// </summary>
        ShowUsernames = 2,
        /// <summary>
        /// Show full names
        /// </summary>
        ShowFullNames = 3,
        /// <summary>
        /// Show first name
        /// </summary>
        ShowFirstName = 10
    }
}
