using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class CrewMember
    {
        public Guid CrewMemberID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

        public bool IsDriver { get; set; }

        public Guid StationID { get; set; }
        public Station Station { get; set; }

        public Guid? WatchID { get; set; }
        public Watch Watch { get; set; }

        public ICollection<Skill> Skills { get; set; }
        public ICollection<Unavailability> Unavailabilitys { get; set; }
    }
}
