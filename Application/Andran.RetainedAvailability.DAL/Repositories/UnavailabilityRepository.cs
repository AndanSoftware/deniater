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
    }
}
