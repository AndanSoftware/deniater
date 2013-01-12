using Andran.RetainedAvailability.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories
{
    public class CrewMemberRepository
    {
        private readonly string _connectionString;
        private SqlConnection _conn;

        public CrewMemberRepository()
        {
            _conn = new SqlConnection("Server=(local); Database=Andran.RetainedAvailability; Integrated Security=SSPI;");
        }

        public CrewMember GetCrewMember(Guid crewMemberID)
        {
            using (_conn)
            {
                using (var cmd = new SqlCommand("CrewMember_Fetch"))
                {
                    cmd.Parameters.Add(new SqlParameter("@crewMemberID",
                        crewMemberID));

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.NextResult();

                    var cm = new CrewMember()
                    {
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        IsDriver = (bool)dr["IsDriver"]
                    };
                    // How do we deal with loading say Watches here?
                    // Dont want spaghetti repos everywhere.
                    return cm ;
                }
            }
        }
    }
}
