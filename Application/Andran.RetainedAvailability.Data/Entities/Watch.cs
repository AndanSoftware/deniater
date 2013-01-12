using Andran.RetainedAvailability.Data.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Watch : EntityBase
    {
        public string Name { get; set; }
        public string Colour { get; set; }

        public Station Station { get; set; }


        public int CrewMemberCount
        {
            get
            {
                return CrewMembers.Count();
            }
        }

        public CrewMember Leader { get; set; }
        public IEnumerable<CrewMember> CrewMembers { get; set; }
    }
}
