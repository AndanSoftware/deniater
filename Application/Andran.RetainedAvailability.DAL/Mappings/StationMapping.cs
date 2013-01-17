using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class StationMapping : EntityTypeConfiguration<Station>
    {
        public StationMapping()
        {
            HasKey(s => s.StationID);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(20);

            Property(s => s.Postcode)
                .IsRequired()
                .HasMaxLength(7);

            Property(s => s.Latitude)
                .IsRequired();

            Property(s => s.Longitude)
                .IsRequired();

            Property(p => p.MinimumCrewCount)
                .IsRequired();
        }
    }
}
