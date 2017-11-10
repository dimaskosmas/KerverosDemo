using KerverosDemo.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace KerverosDemo.Data.EntityMaps
{
    public class EventTypeMap : EntityTypeConfiguration<EventType>
    {
        public EventTypeMap()
        {
            HasKey(p => p.Id);
            Property(p => p.EventCode).HasMaxLength(10).IsRequired();
            Property(p => p.Description).HasMaxLength(80).IsRequired();
            Property(p => p.ReffersTo).IsRequired();

            Property(p => p.EventCode).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("EventCodeIdx") { IsUnique = true }));
        }
    }
}
