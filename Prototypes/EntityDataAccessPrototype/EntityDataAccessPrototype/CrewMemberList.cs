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

        /// <summary>
        /// Gets a list of crew members based on the station passed in
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static CrewMemberList GetCrewMemberList(Station s)
        {
            CrewMemberList list = new CrewMemberList();

            using (SqlConnection conn = new SqlConnection("..."))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CrewMember_FetchByStationId";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@stationId", 12));

                    SqlDataReader dr = cmd.ExecuteReader();

                    // Read all the crew member rows returned from the DB
                    while (dr.Read())
                    {
                        list.Add(CrewMember.GetCrewMember(dr));
                    }
                }
            }

            return list;
        }

        #endregion
    }
}
