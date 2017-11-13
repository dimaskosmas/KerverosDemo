using KerverosDemo.Entities;
using System.Data.Entity.ModelConfiguration;


namespace KerverosDemo.Data.EntityMaps
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(s => s.CustomerCode);

            Property(p => p.CustomerCode).HasMaxLength(16).IsRequired();
            Property(p => p.Name).HasMaxLength(60).IsRequired();
            Property(p => p.Address).HasMaxLength(60).IsRequired();

            HasMany(p => p.Partitions)
                .WithRequired(s => s.Customer)
                .HasForeignKey(s => s.CustomerCode)
                .WillCascadeOnDelete(true);

            HasMany(p => p.Zones)
                .WithRequired(s => s.Customer)
                .HasForeignKey(s => s.CustomerCode)
                .WillCascadeOnDelete(true);

            HasMany(p => p.Users)
                .WithRequired(s => s.Customer)
                .HasForeignKey(s => s.CustomerCode)
                .WillCascadeOnDelete(true);
        }
    }
}
