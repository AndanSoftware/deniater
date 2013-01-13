using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class UnavailabilityMapping : EntityTypeConfiguration<Unavailability>
    {
        public UnavailabilityMapping()
        {
            HasKey(u => u.UnavailabilityID);

            HasRequired(u => u.CrewMember)
                .WithMany(c => c.Unavailabilitys)
                .HasForeignKey(u => u.CrewMemberID);

            Property(u => u.Start)
                .IsRequired();

            Property(u => u.End)
                .IsRequired();

            HasRequired(u => u.UnavailabilityReason)
                .WithMany(ur => ur.Unavailabilitys)
                .HasForeignKey(u => u.UnavailabilityReasonID);

            Property(u => u.Notes)
                .HasMaxLength(50);
        }
    }
}
