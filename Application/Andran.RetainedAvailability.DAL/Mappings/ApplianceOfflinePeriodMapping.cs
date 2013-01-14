using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Mappings
{
    public class ApplianceOfflinePeriodMapping : EntityTypeConfiguration<ApplianceOfflinePeriod>
    {
        public ApplianceOfflinePeriodMapping()
        {
            HasKey(p => p.ApplianceOfflinePeriodID);

            Property(p => p.Start)
                .IsRequired();

            Property(p => p.End)
                .IsRequired();

            HasRequired(a => a.Appliance)
                .WithMany(ap => ap.ApplianceOfflinePeriods)
                .HasForeignKey(a => a.ApplianceID);

            Property(p => p.ApplianceOfflineReason);
        }
    }
}
