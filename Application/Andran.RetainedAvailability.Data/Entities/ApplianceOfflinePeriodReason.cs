using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class ApplianceOfflinePeriodReason
    {
        public Guid ApplianceOfflinePeriodReasonID { get; set; }
        public string Description { get; set; }

        public ICollection<ApplianceOfflinePeriod> ApplianceOfflinePeriods { get; set; }
    }
}
