using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataAccessPrototype
{
    public partial class CrewMember
    {
        public int ID { get; set; }
        public string Name { get; set; }

        #region Constructors

        private CrewMember(SqlDataReader dr)
        {
            // FOR LOADING FROM THE DB
            this.Fill(dr);
        }

        private CrewMember()
        {
            // FOR NEW OBJECTS
        }

        #endregion

    }
}
