using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class SkillTypeRepository
    {
        private RetainedAvailabilityContext _ctx;

        public SkillTypeRepository()
        {
            _ctx = new RetainedAvailabilityContext();
        }

        public void InsertSkillType(SkillType skillType)
        {
            _ctx.SkillTypes.Add(skillType);
        }
    }
}
