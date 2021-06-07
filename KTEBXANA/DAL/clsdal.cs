using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace KTEBXANA.DAL
{
    class clsdal
    {
        SqlConnection con = new SqlConnection();
        public clsdal()
        {                                   //AttachDbFilename=|DataDirectory|\Database1.mdf;   AttachDbFilename=C:\Users\kimmm\Desktop\SummerTraning\KTEBXANA\KTEBXANA\KTEBXANA\DBKM.mdf
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBKM.mdf;Integrated Security=True");
        }

        // Method to open sqlcon 
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        // Method to close sqlcon 
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Fun to read data 
        public DataTable read(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;

            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        // Execute to insert , edit , delete 
        public void execute(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;

            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
