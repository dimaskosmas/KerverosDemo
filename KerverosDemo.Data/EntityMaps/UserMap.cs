using KerverosDemo.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KerverosDemo.Data.EntityMaps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(p => p.Id);

            HasRequired(p => p.Customer)
                .WithMany(p=>p.Users)
                .HasForeignKey(s => s.CustomerCode);

            Property(p => p.UserCode).IsRequired();
            Property(p => p.CustomerCode).HasMaxLength(16).IsRequired();
            Property(p => p.Name).HasMaxLength(60).IsRequired();
            Property(p => p.Phone).HasMaxLength(20).IsRequired();
            Property(p => p.Email).HasMaxLength(30).IsRequired();
            Property(p => p.MobilePhone).HasMaxLength(20).IsRequired();
            Property(p => p.MobileEmail).HasMaxLength(30).IsRequired();
        }
    }
}
