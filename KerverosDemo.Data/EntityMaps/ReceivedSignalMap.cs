using KerverosDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerverosDemo.Data.EntityMaps
{
    public class ReceivedSignalMap : EntityTypeConfiguration<ReceivedSignal>
    {
        public ReceivedSignalMap()
        {
            HasKey(p => p.Id);

            Property(p => p.CustomerCode).HasMaxLength(16).IsRequired();
            Property(p => p.ReceivedAt).IsRequired();
            Property(p => p.EventCode).HasMaxLength(10).IsRequired();
            Property(p => p.PartitionCode).IsRequired();
            Property(p => p.UserCode).IsOptional();
            Property(p => p.ZoneCode).IsOptional();
            Property(p => p.Description).HasMaxLength(150).IsRequired();
            Property(p => p.RawData).IsRequired();
            
            Property(p=>p.CustomerCode).HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("CustomerEventIdx") { IsUnique = false, Order = 1 }));
            Property(p => p.EventCode).HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("CustomerEventIdx") { IsUnique = false, Order = 2 }));
        }
    }
}
