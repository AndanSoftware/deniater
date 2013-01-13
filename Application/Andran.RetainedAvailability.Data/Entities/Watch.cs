using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Watch
    {
        public Guid WatchID { get; set; }

        public string Name { get; set; }
        public string Colour { get; set; }

        public Guid StationID { get; set; }
        public Station Station { get; set; }

        public Guid WatchLeaderID { get; set; }
        public CrewMember WatchLeader { get; set; }

        public ICollection<CrewMember> CrewMembers { get; set; }
    }
}
