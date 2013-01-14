using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class ApplianceOfflinePeriodRepository
    {
        private RetainedAvailabilityContext _ctx;

        public ApplianceOfflinePeriodRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertApplianceOfflinePeriod(ApplianceOfflinePeriod applianceOfflinePeriod)
        {
            _ctx.ApplianceOfflinePeriods.Add(applianceOfflinePeriod);
        }
    }
}
