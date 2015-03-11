using SwissCreate.Core.Domain.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core
{
    public interface ICompanyContext
    {
        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        Company CurrentCompany { get; }
    }
}
