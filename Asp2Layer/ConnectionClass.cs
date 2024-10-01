using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Asp2Layer
{
   public class ConnectionClass
    {
        SqlConnection con;//public declaration of connection cls obj & SqlCommand obj
        SqlCommand cmd;
        public Connectionclass()
        {
            con = new SqlConnection(@"server=DESKTOP-JAF6I6Q\SQLEXPRESS;database=2Layer;Integrated Security=true")

        }
        public int Fn-ExeNonqry(string sqlqry)//insert,dlt,update---ExecuteNonQry--returns int value
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_Exescalar(string sqlqry)//select,aggragte fns--returns string value
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader Fn_ExeReader(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Fn ExeDataAdapter(string salary)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlqry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable Fn_ExeDataTable(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
