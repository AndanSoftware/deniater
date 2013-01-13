using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class UnavailabilityReason
    {
        public Guid UnavailabilityReasonID { get; set; }

        public char Symbol { get; set; }
        public string ColourHex { get; set; }
        public string Description { get; set; }

        public ICollection<Unavailability> Unavailabilitys { get; set; }
    }
}
