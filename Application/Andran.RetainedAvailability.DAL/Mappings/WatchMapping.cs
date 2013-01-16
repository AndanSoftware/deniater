using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class WatchMapping : EntityTypeConfiguration<Watch>
    {
        public WatchMapping()
        {
            HasKey(p => p.WatchID);

            HasRequired(w => w.Station)
                .WithMany(s => s.Watches)
                .HasForeignKey(w => w.StationID)
                .WillCascadeOnDelete(false);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.Colour)
                .IsRequired()
                .HasMaxLength(6);
        }
    }
}
