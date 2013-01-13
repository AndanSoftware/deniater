using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class SkillType
    {
        public Guid SkillTypeID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
