using KerverosDemo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KerverosDemo.Data.EntityMaps
{
    public class ZoneMap : EntityTypeConfiguration<Zone>
    {
        public ZoneMap()
        {
            HasKey(p => new { p.CustomerCode, p.ZoneCode });

            HasRequired(p => p.Customer)
                .WithMany(p=>p.Zones)
                .HasForeignKey(s => s.CustomerCode);

            Property(p => p.CustomerCode).HasMaxLength(16).IsRequired();
            Property(p => p.Description).HasMaxLength(80).IsRequired();
            
        }
    }
}
