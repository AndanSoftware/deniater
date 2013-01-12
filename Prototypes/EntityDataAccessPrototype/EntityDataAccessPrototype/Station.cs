using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataAccessPrototype
{
    class Station
    {
        private IEnumerable<CrewMember> _crewMembers;

        public IEnumerable<CrewMember> CrewMembers
        {
            get
            {
                // If it's null we know we haven't loaded it yet

                if (_crewMembers == null)

                    // So we can load it

                    _crewMembers = CrewMemberList.GetCrewMemberList(this);

                // And now it's ready to return to the caller

                return _crewMembers;
            }
        }
    }
}
