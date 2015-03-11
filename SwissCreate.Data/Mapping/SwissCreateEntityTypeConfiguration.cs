using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreate.Data.Mapping
{
    public abstract class SwissCreateEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        public SwissCreateEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        public virtual void PostInitialize()
        { 
        }
    }
}
