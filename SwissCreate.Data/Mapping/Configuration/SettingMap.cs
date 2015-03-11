using SwissCreate.Core.Domain.Configuration;

namespace SwissCreate.Data.Mapping.Configuration
{
    class SettingMap : SwissCreateEntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            this.ToTable("Setting");
            this.HasKey(s => s.Id);
            this.Property(s => s.Name).IsRequired().HasMaxLength(200);
            this.Property(s => s.Value).IsRequired().HasMaxLength(2000);
            this.Property(s => s.Description);
        }
    }
}
