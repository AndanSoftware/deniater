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
        public static CrewMember GetCrewMember(int crewMemberId)
        {
            using (SqlConnection conn = new SqlConnection("..."))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CrewMember_Fetch";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    return new CrewMember(dr);
                }
            }
        }

        public static CrewMember GetCrewMember(SqlDataReader dr)
        {
            return new CrewMember(dr);
        }

        public static CrewMember NewCrewMember()
        {
            return new CrewMember();
        }

        #region Loading

        private void Fill(SqlDataReader dr)
        {
            this.Name = dr.GetString(0);
        }

        #endregion
    }
}
