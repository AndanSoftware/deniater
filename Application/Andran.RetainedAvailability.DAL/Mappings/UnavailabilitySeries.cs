using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class UnavailabilitySeriesMapping : EntityTypeConfiguration<UnavailabilitySeries>
    {
        public UnavailabilitySeriesMapping()
        {
            HasKey(a => a.UnavailabilitySeriesID);
            
            // NEEDS REASON MAPPING HERE

            Property(p => p.Description)
                .IsOptional()
                .HasMaxLength(100);

            Property(p => p.EndTime)
                .IsRequired();

            Property(p => p.Frequency)
                .IsRequired();

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(25);

            Property(p => p.SeriesEndDate)
                .IsRequired();

            Property(p => p.SeriesStartDate)
                .IsRequired();

            Property(p => p.StartTime)
                .IsRequired();

        }
    }
}
