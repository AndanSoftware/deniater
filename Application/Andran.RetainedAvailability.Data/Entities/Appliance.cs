using Andran.RetainedAvailability.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Appliance : EntityBase
    {
        public string Name { get; set; }

        public int MinimumCrewCount { get; set; }
        public int Capacity { get; set; }

        public IEnumerable<Skill> SkillsRequired { get; set; }
    }
}
