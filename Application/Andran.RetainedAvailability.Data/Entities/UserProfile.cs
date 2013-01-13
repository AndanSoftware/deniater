using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class UserProfile
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserProfileID { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public Guid CrewMemberID { get; set; }
    }
}
