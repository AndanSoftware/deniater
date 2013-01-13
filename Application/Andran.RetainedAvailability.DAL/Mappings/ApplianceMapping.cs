using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class ApplianceMapping : EntityTypeConfiguration<Appliance>
    {
        public ApplianceMapping()
        {
            HasKey(a => a.ApplianceID);

            HasRequired(ap => ap.Station)
                .WithMany(station => station.Appliances)
                .HasForeignKey(ap => ap.StationID);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.MinimumCrewCount)
                .IsRequired();
        }
    }
}
