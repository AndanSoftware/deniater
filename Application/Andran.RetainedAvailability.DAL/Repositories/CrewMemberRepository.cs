using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class CrewMemberRepository
    {
        private RetainedAvailabilityContext _ctx;

        public CrewMemberRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertCrewMember(CrewMember crewMember)
        {
            _ctx.CrewMembers.Add(crewMember);
        }

        public CrewMember GetCrewMemberByID(Guid crewMemberID)
        {
            return _ctx.CrewMembers
                .SingleOrDefault(c => c.CrewMemberID == crewMemberID);
        }
    }
}
