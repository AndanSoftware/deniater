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

        public void DeleteStation(Station station)
        {
            _ctx.Stations.Remove(station);
        }

        public Station GetStationByID(Guid id)
        {
            return _ctx.Stations
                .SingleOrDefault(p => p.StationID == id);
        }

        public IList<Station> GetStations(int start = 0, int pageSize = 0)
        {
            return _ctx.Stations
                .OrderBy(s => s.Name)
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
