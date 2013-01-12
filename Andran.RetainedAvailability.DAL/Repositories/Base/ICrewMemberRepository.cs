using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories.Base
{
    public interface ICrewMemberRepository
    {
        IEnumerable<Skill> GetSkills(Guid crewMemberId);
    }
}
