using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class SkillRepository
    {
        private RetainedAvailabilityContext _ctx;

        public SkillRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertSkill(Skill skill)
        {
            _ctx.Skills.Add(skill);
        }
    }
}
