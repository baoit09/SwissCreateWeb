using System;
using System.Collections.Generic;

namespace SwissCreate.Core.Data
{
    public partial class DataSettings
    {
        public DataSettings()
        {
            RawDataSettings=new Dictionary<string, string>();
        }

        public string DataProvider { get; set; }

        public string DataConnectionString { get; set; }

        /// <summary>
        /// Force update DB Schema everytime app startups
        /// </summary>
        public bool ForceUpdateDBSchema { get; set; }

        public IDictionary<string, string> RawDataSettings { get; set; }

        public bool IsValid()
        {
            return !String.IsNullOrEmpty(this.DataProvider) && !String.IsNullOrEmpty(this.DataConnectionString);
        }
    }
}
