using Andran.RetainedAvailability.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class CrewMember : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDriver { get; set; }

        public Watch Watch { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
