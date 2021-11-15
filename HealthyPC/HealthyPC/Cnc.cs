using System;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HealthyPC
{
    class Cnc
    {
        public static SqlDataReader dr;
        public static SqlCommand insert;
        public static SqlCommand select;
        public static String server = $"server=YASER-WPC;uid=sa;pwd=1234;database=Healthy_PC";
        public static SqlConnection conn = new SqlConnection(server);
        public static OleDbConnection cnn = new OleDbConnection();
    }
}