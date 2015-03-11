using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Core.Domain.Configuration
{
    public partial class Setting : BaseEntity
    {
        public Setting(){} // Used for Activator.

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Description { get; set; }

        public bool? Disable { get; set; }
    }
}
