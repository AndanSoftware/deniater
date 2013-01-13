using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class ApplianceOfflinePeriod
    {
        public Guid ApplianceOfflinePeriodID { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Guid ApplianceID { get; set; }
        public Appliance Appliance { get; set; }

        public Guid ApplianceOfflinePeriodReasonID { get; set; }
        public ApplianceOfflinePeriodReason ApplianceOfflinePeriodReason { get; set; }
    }
}
