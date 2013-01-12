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
        /// <summary>
        /// Gets a crew member based on their ID from teh DB
        /// </summary>
        /// <param name="crewMemberId"></param>
        /// <returns></returns>
        public static CrewMember GetCrewMember(int crewMemberId)
        {
            using (SqlConnection conn = new SqlConnection("..."))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CrewMember_Fetch";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    // Pass the data reader to a private constructor that accepts a data reader
                    return new CrewMember(dr);
                }
            }
        }

        /// <summary>
        /// Populate a crew member through a supplied data reader
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static CrewMember GetCrewMember(SqlDataReader dr)
        {
            return new CrewMember(dr);
        }

        /// <summary>
        /// Create a new crew member instance
        /// </summary>
        /// <returns></returns>
        public static CrewMember NewCrewMember()
        {
            return new CrewMember();
        }

        #region Loading

        /// <summary>
        /// Fill the current instance based on a data reader
        /// </summary>
        /// <param name="dr"></param>
        private void Fill(SqlDataReader dr)
        {
            this.Name = dr.GetString(0);
        }

        #endregion
    }
}
