using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataAccessPrototype
{
    class CrewMemberList : List<CrewMember>
    {
        #region DataAccess

        public static CrewMemberList GetCrewMemberList(Station s)
        {
            CrewMemberList list = new CrewMemberList();
            using (SqlConnection conn = new SqlConnection("..."))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CrewMember_FetchByStationId";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    list.Add(CrewMember.GetCrewMember(dr));
                }
            }

            return list;
        }

        #endregion
    }
}
