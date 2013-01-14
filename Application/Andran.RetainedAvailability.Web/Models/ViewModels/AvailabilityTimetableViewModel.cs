using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andran.RetainedAvailability.Web.Models.ViewModels
{
    public class AvailabilityTimetableViewModel
    {
        public Guid StationID { get; set; }

        public IEnumerable<CrewMember> CrewMembersForStation { get; set; }
        public IEnumerable<ApplianceOfflinePeriod> ApplianceOfflinePeriods { get; set; }
    }
}