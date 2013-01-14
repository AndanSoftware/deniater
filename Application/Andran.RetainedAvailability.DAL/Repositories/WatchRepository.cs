using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class WatchRepository
    {
        private RetainedAvailabilityContext _ctx;

        public WatchRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertWatch(Watch watch)
        {
            _ctx.Watches.Add(watch);
        }

        public IList<Watch> GetWatches(int start, int pageSize)
        {
            return _ctx.Watches
                .Skip(start)
                .Take(pageSize)
                .ToList();
        }

        public IList<Watch> GetWatchesByStationID(Guid stationID)
        {
            return _ctx.Watches
                .Where(p => p.StationID == stationID)
                .ToList();
        }
    }
}
