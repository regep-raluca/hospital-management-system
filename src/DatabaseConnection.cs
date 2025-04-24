// --------------------------------------------------------
// DatabaseConnection.cs
// Handles creation of the SQL Server connection used
// throughout the Hospital Management System.
// --------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public class DatabaseConnection
    {
        // Returns a SqlConnection object with the defined connection string
        public static SqlConnection GetConnection()
        {

            string connectionString = "Server=DESKTOP-PAOAEA2\\SQLEXPRESS;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;";
            return new SqlConnection(connectionString);
        }
    }
}
