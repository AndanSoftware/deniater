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
                if (_crewMembers == null)
                    _crewMembers = CrewMemberList.GetCrewMemberList(this);
                return _crewMembers;
            }
        }
    }
}
