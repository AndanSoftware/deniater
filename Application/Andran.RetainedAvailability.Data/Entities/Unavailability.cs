using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Unavailability
    {
        public Guid UnavailabilityID { get; set; }

        public Guid CrewMemberID { get; set; }
        public CrewMember CrewMember { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Guid UnavailabilityReasonID { get; set; }
        public UnavailabilityReason UnavailabilityReason { get; set; }

        public string Notes { get; set; }
    }
}
