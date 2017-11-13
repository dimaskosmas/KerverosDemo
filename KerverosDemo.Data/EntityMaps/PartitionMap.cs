using KerverosDemo.Entities;
using System.Data.Entity.ModelConfiguration;


namespace KerverosDemo.Data.EntityMaps
{
    public class PartitionMap : EntityTypeConfiguration<Partition>
    {
        public PartitionMap()
        {
            HasKey(p => p.Id);

            HasRequired(p => p.Customer)
                .WithMany(p=>p.Partitions)
                .HasForeignKey(s => s.CustomerCode);

            Property(p => p.CustomerCode).HasMaxLength(16).IsRequired();
            Property(p => p.Description).HasMaxLength(80).IsRequired();

        }
    }
}