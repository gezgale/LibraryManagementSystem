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
    class clsForCombo
    {
        public DataTable dbConnection2(string sql)
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.LibraryMembersConnectionString.ToString();
                SqlCommand cmd = new SqlCommand();
                DataTable dtb = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Connection = con;
                cmd.CommandText = sql;
                con.Open();
                da.Fill(dtb);
                return dtb;
        }
    }
}
