﻿using SwissCreate.Core.Domain.Logging;

namespace SwissCreate.Data.Mapping.Logging
{
    public partial class ActivityLogTypeMap : SwissCreateEntityTypeConfiguration<ActivityLogType>
    {
        public ActivityLogTypeMap()
        {
            this.ToTable("ActivityLogType");
            this.HasKey(alt => alt.Id);

            this.Property(alt => alt.SystemKeyword).IsRequired().HasMaxLength(100);
            this.Property(alt => alt.Name).IsRequired().HasMaxLength(200);
        }
    }
}
