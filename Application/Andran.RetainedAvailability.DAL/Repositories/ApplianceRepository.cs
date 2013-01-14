using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class ApplianceRepository
    {
        private RetainedAvailabilityContext _ctx;

        public ApplianceRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        // Pagination
        public IEnumerable<Appliance> GetAppliancesByStationID(Guid stationID, int start, int pageSize)
        {
            return _ctx.Appliances
                .Where(a => a.StationID == stationID)
                .Skip(start)
                .Take(pageSize)
                .ToList();
        }

        public Appliance GetApplianceByID(Guid applianceID)
        {
            return _ctx.Appliances
                .FirstOrDefault(a => a.ApplianceID == applianceID);
        }

        public void InsertAppliance(Appliance appliance)
        {
            _ctx.Appliances.Add(appliance);
        }
    }
}
