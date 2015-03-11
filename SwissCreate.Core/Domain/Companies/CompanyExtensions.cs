using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissCreate.Core.Domain.Companies
{
    public static class CompanyExtensions
    {
        /// <summary>
        /// Parse comma-separated Hosts
        /// </summary>
        /// <param name="Company">Company</param>
        /// <returns>Comma-separated hosts</returns>
        public static string[] ParseHostValues(this Company Company)
        {
            if (Company == null)
                throw new ArgumentNullException("Company");

            var parsedValues = new List<string>();
            if (!String.IsNullOrEmpty(Company.Hosts))
            {
                string[] hosts = Company.Hosts.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string host in hosts)
                {
                    var tmp = host.Trim();
                    if (!String.IsNullOrEmpty(tmp))
                        parsedValues.Add(tmp);
                }
            }
            return parsedValues.ToArray();
        }

        /// <summary>
        /// Indicates whether a Company contains a specified host
        /// </summary>
        /// <param name="Company">Company</param>
        /// <param name="host">Host</param>
        /// <returns>true - contains, false - no</returns>
        public static bool ContainsHostValue(this Company Company, string host)
        {
            if (Company == null)
                throw new ArgumentNullException("Company");

            if (String.IsNullOrEmpty(host))
                return false;

            var contains = Company.ParseHostValues()
                                .FirstOrDefault(x => x.Equals(host, StringComparison.InvariantCultureIgnoreCase)) != null;
            return contains;
        }
    }
}
