using Andran.RetainedAvailability.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Skill : EntityBase
    {
        public string Name { get; set; }
        public string? Reference { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
