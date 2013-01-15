using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.Data.Entities
{
    public class Rank
    {
        public Guid RankID { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }
    }
}
