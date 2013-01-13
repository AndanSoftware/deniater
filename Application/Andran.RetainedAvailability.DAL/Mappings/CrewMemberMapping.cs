using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class CrewMemberMapping : EntityTypeConfiguration<CrewMember>
    {
        public CrewMemberMapping()
        {
            HasKey(c => c.CrewMemberID);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.MobileNumber)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.IsDriver)
                .IsRequired();

            HasRequired(c => c.Watch)
                .WithMany(w => w.CrewMembers)
                .HasForeignKey(c => c.WatchID);
        }
    }
}
