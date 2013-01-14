using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class ApplianceOfflinePeriodReasonRepository
    {
        private RetainedAvailabilityContext _ctx;

        public ApplianceOfflinePeriodReasonRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertApplianceOfflinePeriodReason(ApplianceOfflinePeriodReason applianceOfflinePeriodReason)
        {
            _ctx.ApplianceOfflinePeriodReasons.Add(applianceOfflinePeriodReason);
        }
    }
}
