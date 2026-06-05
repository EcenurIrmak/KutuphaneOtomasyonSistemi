using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonuSistemi
{

    public class DBHelper
    {
        private static string connStr =
            "Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
