using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Appliance
    {
        public Guid ApplianceID { get; set; }

        public string Name { get; set; }
        public int MinimumCrewCount { get; set; }
        public int? Capacity { get; set; }

        public Guid StationID { get; set; }
        public Station Station { get; set; }

        public ICollection<Skill> SkillsRequired { get; set; }
    }
}
