using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace LibraryMembers
{

    class FirstClass
    {
        SqlConnection con;
        public SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;

        public FirstClass()
        {
            con = new SqlConnection(Properties.Settings.Default.LibraryMembersConnectionString.ToString());
            cmd = new SqlCommand();
            dt = new DataTable();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
        }

        public DataTable dbOut(string sql)
        {
            cmd.CommandText = sql;
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public void exeCommand(string strName)
        {
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strName;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void exeCommand1(string strName)
        {
            try
            {
                cmd.CommandText = strName;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                con.Close();
            }

        }

        public static String UDF_MiladiToShmasi(DateTime MiladiDate)
        {
            PersianCalendar calFar1 = new PersianCalendar();
            String Str_DtShamsi = calFar1.GetYear(MiladiDate).ToString() + "/" + calFar1.GetMonth(MiladiDate).ToString("00") + "/" + calFar1.GetDayOfMonth(MiladiDate).ToString("00");
            return Str_DtShamsi.Trim();
        }

        public  DateTime ShamsiToMiladi(String ShamsiDate)
        {
            DateTime MyMilDate;
            String p1, p2, p3;
            p1 = ShamsiDate.Substring(0, 4);
            p2 = ShamsiDate.Substring(5, 2);
            p3 = ShamsiDate.Substring(8, 2);
            PersianCalendar pers = new PersianCalendar();
            MyMilDate = pers.ToDateTime(int.Parse(p1), int.Parse(p2), int.Parse(p3), 0, 0, 0, 0);
            return MyMilDate;
        }
    }
}
