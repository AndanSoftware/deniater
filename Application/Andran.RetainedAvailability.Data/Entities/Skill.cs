using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Skill
    {
        public Guid SkillID { get; set; }

        public Guid SkillTypeID { get; set; }
        public SkillType SkillType { get; set; }

        public string Reference { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
