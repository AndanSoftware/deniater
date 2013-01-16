using Andran.RetainedAvailability.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class UnavailabilitySeries
    {
        public Guid UnavailabilitySeriesID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime SeriesStartDate { get; set; }

        public DateTime SeriesEndDate { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Frequency { get; set; }

        public Guid UnavailabilityReasonID { get; set; }
        public UnavailabilityReason UnavailabilityReason { get; set; }

        public UnavailabilitySeriesTypeEnum UnavailabilitySeriesType { get; set; }

        public ICollection<Unavailability> Unavilabilities { get; set; }
    }
}
