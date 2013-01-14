using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class StationRepository
    {
        private RetainedAvailabilityContext _ctx;

        public StationRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertStation(Station station)
        {
            _ctx.Stations.Add(station);
        }

        public Station GetStationByID(Guid id)
        {
            return _ctx.Stations
                .FirstOrDefault(p => p.StationID == id);
        }

        public IList<Station> GetStations(int start, int pageSize)
        {
            return _ctx.Stations
                .Skip(start)
                .Take(pageSize)
                .ToList();
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
