using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class UnavailabilityReasonRepository
    {
        private RetainedAvailabilityContext _ctx;

        public UnavailabilityReasonRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertUnavailabilityReason(UnavailabilityReason unavailabilityReason)
        {
            _ctx.UnavailabilityReasons.Add(unavailabilityReason);
        }

        public IEnumerable<UnavailabilityReason> GetUnavailabilityReasons(int start = 0, int pageSize = 0)
        {
            return _ctx.UnavailabilityReasons
                    .OrderBy(uavr => uavr.Symbol)
                    .Skip(start)
                    .Take(pageSize);
        }
    }
}
