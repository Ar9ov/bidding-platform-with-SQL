using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{ 

public static class DbHelper
    {
        public static string connectionString =
            "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}

