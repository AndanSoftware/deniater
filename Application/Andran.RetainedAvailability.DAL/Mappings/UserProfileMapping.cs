using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class UserProfileMapping : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMapping()
        {
            HasKey(p => p.UserProfileID);

            Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Email)
                .HasMaxLength(25);

            Property(p => p.CrewMemberID)
                .IsOptional();
        }
    }
}
