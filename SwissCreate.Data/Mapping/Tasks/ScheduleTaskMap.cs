using SwissCreate.Core.Domain.Tasks;

namespace SwissCreate.Data.Mapping.Tasks
{
    public partial class ScheduleTaskMap : SwissCreateEntityTypeConfiguration<ScheduleTask>
    {
        public ScheduleTaskMap()
        {
            this.ToTable("ScheduleTask");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Type).IsRequired();
        }
    }
}
