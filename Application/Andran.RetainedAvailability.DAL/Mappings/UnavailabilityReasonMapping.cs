using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class UnavailabilityReasonMapping : EntityTypeConfiguration<UnavailabilityReason>
    {
        public UnavailabilityReasonMapping()
        {
            HasKey(ur => ur.UnavailabilityReasonID);

            Property(p => p.ColourHex)
                .IsRequired()
                .HasMaxLength(6);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Symbol)
                .HasMaxLength(1)
                .IsRequired();
        }
    }
}
