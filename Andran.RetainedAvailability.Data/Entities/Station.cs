using Andran.RetainedAvailability.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Station : EntityBase
    {
        public string Name { get; set; }

        public string Postcode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public IEnumerable<Watch> Watches { get; set; }
    }
}
