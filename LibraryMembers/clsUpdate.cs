using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMembers
{
    class clsUpdate
    {
        public void updateSql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.LibraryMembersConnectionString.ToString(); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
