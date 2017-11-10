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
        }
    }
}
