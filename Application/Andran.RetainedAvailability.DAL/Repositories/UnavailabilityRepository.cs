using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class UnavailabilityRepository
    {
        private RetainedAvailabilityContext _ctx;

        public UnavailabilityRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public Unavailability GetAvailabilityForDateTime(Guid crewMemberID, DateTime period)
        {
            // Inclusive availability check
            return _ctx.Unavailability
                .FirstOrDefault(p =>
                    p.CrewMemberID == crewMemberID
                    && p.Start <= period
                    && p.End >= p.End);


        }

        public IList<Unavailability> GetUnavailabilityForADay(Guid stationId, DateTime dateToRetrieve)
        {
            var r = _ctx.Unavailability
                // Include the reason navigation property
                .Include("UnavailabilityReason")

                // Only get the crew members for the current station
                .Join(_ctx.CrewMembers,
                          uav => uav.CrewMemberID
                          , cm => cm.CrewMemberID
                          , (uav, cm) => new { CM = cm, UAV = uav })

                // Then we need to only look at the crew members for the current station
                .Join(_ctx.Stations,
                          station => station.CM.StationID
                          , station => station.StationID
                          , (uav, station) => uav)

                .Select(u => u.UAV)

                // Only retrieve unavailability for the date passed in
                .Where(uav => uav.Start.Date == dateToRetrieve.Date);

        }
    }
}
