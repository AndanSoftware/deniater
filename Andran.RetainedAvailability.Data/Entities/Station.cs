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
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public IEnumerable<Watch> Watches { get; set; }
    }
}
