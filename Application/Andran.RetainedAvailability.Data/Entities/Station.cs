using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Station
    {
        public Guid StationID { get; set; }

        public string Name { get; set; }
        public string Postcode { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<Appliance> Appliances { get; set; }
        public ICollection<Watch> Watches { get; set; }
    }
}
