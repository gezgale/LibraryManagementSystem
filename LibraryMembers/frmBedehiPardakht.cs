using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmBedehiPardakht : Form
    {
        int int_SaveState = 0;
        public frmBedehiPardakht()
        {
            InitializeComponent();
        }

        private void frmBedehiPardakht_Load(object sender, EventArgs e)
        {
            dbConnection2();
            dbConnection();
        }

        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            Dg_State.DataSource = dbCon1.dbConnection(@"SELECT     PersonelID, SUM(takhir) AS TotalTakhir, SUM(Jarimeh) AS TotalBedehi,  Name + ' ' + Sname AS NameSname
                    FROM         (SELECT     TOP (1000) dbo.BookH.PersonelID, dbo.BookH.BookID, dbo.BookH.DateDeli, dbo.BookH.DatBaz, dbo.BookH.zemanat, dbo.BookH.Mablagh, dbo.ShamsiToMiladi(dbo.BookH.DateDeli) 
                                              AS DateDeliMiladi, dbo.ShamsiToMiladi(dbo.BookH.DatBaz) AS DatBazMiladi, DATEDIFF(DAY, dbo.ShamsiToMiladi(dbo.BookH.DateDeli), dbo.ShamsiToMiladi(dbo.BookH.DatBaz)) 
                                              AS TotalDays, CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END AS takhir, (CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END) *
                                                  (SELECT     JarimehDirkerd
                                                     FROM         dbo.tblSystemChanges
                                                     WHERE     (RowID = 1)) AS Jarimeh, dbo.Members.Name, dbo.Members.Sname
                    FROM         dbo.BookH INNER JOIN
                                              dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID) AS derivedtbl_1 GROUP BY PersonelID, Name, Sname HAVING      (SUM(Jarimeh) > 0)");

            UDF_DbConnection3(Cmb_Members.SelectedValue.ToString().Trim());

        }

        private void UDF_DbConnection3(String Str_MemberID)
        {
            FirstClass db = new FirstClass();
            db.cmd.Parameters.Add("@MemBerID", SqlDbType.NVarChar).Value = Str_MemberID;
            Dg_Payments.DataSource = db.dbOut(@"  SELECT TOP 1000 [PaymentRowID]      ,[MemBerID]      ,[DateOfPayment]      ,[PriceOfPayment]  FROM [tblPayments] WHERE MemBerID = @MemBerID");
            if (Dg_Payments.RowCount <= 0)
            {
                Txt_Date.Text = "";
                Txt_Search.Text = "";
                Txt_Vadiee.Text = "";
            }
        }

        private void Txt_Vadiee_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if (ascii >= 46 && ascii <= 57 || ascii == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void dbConnection2()
        {
            clsForCombo cmbP2 = new clsForCombo();
            Cmb_Members.DataSource = cmbP2.dbConnection2(@"SELECT     PersonelID, PersonelID + N' - ' + Name + N'  ' + Sname AS NameSname
                                                        FROM         (SELECT     TOP (1000) dbo.BookH.PersonelID, dbo.ShamsiToMiladi(dbo.BookH.DateDeli) AS DateDeliMiladi, dbo.ShamsiToMiladi(dbo.BookH.DatBaz) AS DatBazMiladi, DATEDIFF(DAY, 
                                              dbo.ShamsiToMiladi(dbo.BookH.DateDeli), dbo.ShamsiToMiladi(dbo.BookH.DatBaz)) AS TotalDays, CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END AS takhir, (CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END) *
                                                  (SELECT     JarimehDirkerd
                                                     FROM         dbo.tblSystemChanges
                                                     WHERE     (RowID = 1)) AS Jarimeh, dbo.Members.Name, dbo.Members.Sname
                        FROM         dbo.BookH INNER JOIN
                                              dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID
                        GROUP BY dbo.BookH.PersonelID, dbo.ShamsiToMiladi(dbo.BookH.DateDeli), dbo.ShamsiToMiladi(dbo.BookH.DatBaz), DATEDIFF(DAY, dbo.ShamsiToMiladi(dbo.BookH.DateDeli), 
                                              dbo.ShamsiToMiladi(dbo.BookH.DatBaz)), dbo.Members.Name, dbo.Members.Sname) AS derivedtbl_1
                            WHERE     (Jarimeh > N'0')
                            GROUP BY PersonelID, PersonelID + N' - ' + Name + N'  ' + Sname");

            Cmb_Members.ValueMember = "PersonelID";
            Cmb_Members.DisplayMember = "NameSname";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int_SaveState = 1;
            UDF_Before(false);
            Txt_Vadiee.Text = "";
            Txt_Date.Text = FirstClass.UDF_MiladiToShmasi(DateTime.Now);
        }

        private void UDF_Before(Boolean Bln_IsDelete)
        {
            if (Bln_IsDelete != true)
            {
                G_1.Visible = false;
                Dg_State.Enabled = false;
            }
            else
            {
                G_1.Visible = false;
                G_3.Enabled = false;
                Dg_State.Enabled = false;
            }
        }

        private void UDF_After()
        {
            G_1.Visible = true;
            G_3.Enabled = true;
            Dg_State.Enabled = true;
            dbConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int_SaveState = 2;
            UDF_Before(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int_SaveState = 3;
            UDF_Before(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("کد عضویت یا بخشی از کد عضویت وارد نشده است");
            }
            else
            {
                FirstClass dbCon1 = new FirstClass();
                dbCon1.cmd.Parameters.Add("@MemberID", SqlDbType.NVarChar).Value = "%" + Txt_Search.Text.Trim() + "%";
                Dg_State.DataSource = dbCon1.dbOut(@"SELECT     PersonelID, SUM(takhir) AS TotalTakhir, SUM(Jarimeh) AS TotalBedehi,  Name + ' ' + Sname AS NameSname
                    FROM         (SELECT     TOP (1000) dbo.BookH.PersonelID, dbo.BookH.BookID, dbo.BookH.DateDeli, dbo.BookH.DatBaz, dbo.BookH.zemanat, dbo.BookH.Mablagh, dbo.ShamsiToMiladi(dbo.BookH.DateDeli) 
                                              AS DateDeliMiladi, dbo.ShamsiToMiladi(dbo.BookH.DatBaz) AS DatBazMiladi, DATEDIFF(DAY, dbo.ShamsiToMiladi(dbo.BookH.DateDeli), dbo.ShamsiToMiladi(dbo.BookH.DatBaz)) 
                                              AS TotalDays, CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END AS takhir, (CASE WHEN
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1) < DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), dbo.ShamsiToMiladi(DatBaz)) THEN (DATEDIFF(DAY, dbo.ShamsiToMiladi(DateDeli), 
                                              dbo.ShamsiToMiladi(DatBaz)) -
                                                  (SELECT     [TedadeMojazeAmanatdehieKetab]
                                                     FROM         [tblSystemChanges]
                                                     WHERE     RowID = 1)) ELSE 0 END) *
                                                  (SELECT     JarimehDirkerd
                                                     FROM         dbo.tblSystemChanges
                                                     WHERE     (RowID = 1)) AS Jarimeh, dbo.Members.Name, dbo.Members.Sname
                    FROM         dbo.BookH INNER JOIN
                                              dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID) AS derivedtbl_1 GROUP BY PersonelID, Name, Sname HAVING      (SUM(Jarimeh) > 0) AND (PersonelID like @MemberID)");
                UDF_DbConnection3(Cmb_Members.SelectedValue.ToString().Trim());
            }
        }

        private void Dg_State_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                Cmb_Members.SelectedValue = Dg_Payments.Rows[Dg_Payments.CurrentRow.Index].Cells["MemBerID"].Value.ToString();
                Txt_Date.Text = Dg_Payments.Rows[Dg_Payments.CurrentRow.Index].Cells["DateOfPayment"].Value.ToString();
                Txt_Vadiee.Text = Dg_Payments.Rows[Dg_Payments.CurrentRow.Index].Cells["PriceOfPayment"].Value.ToString();
                Txt_DelID.Text = Dg_Payments.Rows[Dg_Payments.CurrentRow.Index].Cells["PaymentRowID"].Value.ToString();
            }
            catch { }
        }

        public void insSql()
        {
            clsAdding insTodb = new clsAdding();
            insTodb.insSql("INSERT INTO  [tblPayments]  ([MemBerID]  ,[DateOfPayment] ,[PriceOfPayment])  VALUES  ('" + Cmb_Members.SelectedValue.ToString().Trim() + "'   ,'" + Txt_Date.Text.Trim() + "' , " + Decimal.Parse(Txt_Vadiee.Text.Trim()) + ")");
            Txt_Date.Text = "";
            Txt_Search.Text = "";
            Txt_Vadiee.Text = "";
            dbConnection();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (int_SaveState == 1)
            {
                if (Txt_Date.Text == "" || Txt_Vadiee.Text == "")
                {
                    MessageBox.Show("ورود تاریخ پرداخت و مبلغ الزامی می باشد");
                }
                insSql();
                dbConnection();
                Txt_Date.Text = "";
                Txt_Vadiee.Text = "";
            }
            else if (int_SaveState == 2)
            {
                if (Txt_DelID.Text.Trim() == "")
                {
                    MessageBox.Show("انتخاب رکورد الزامی می باشد");
                    return;
                }
                if (Txt_Date.Text == "" || Txt_Vadiee.Text == "" )
                {
                    MessageBox.Show("مقادیر هر دوفیلد باید وارد شوند");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    db.cmd.Parameters.Add("@PaymentRowID", SqlDbType.Int).Value = int.Parse(Txt_DelID.Text.Trim());
                    //db.cmd.Parameters.Add("@Subject", SqlDbType.NVarChar).Value = Txt_SubjectName.Text.Trim();
                    db.exeCommand1("UPDATE [dbo].[tblPayments]    SET [MemBerID] = '" + Cmb_Members.SelectedValue.ToString() + "' ,[DateOfPayment] = '" + Txt_Date.Text.Trim() + "'  ,[PriceOfPayment] = " + Decimal.Parse(Txt_Vadiee.Text.Trim()) + " WHERE PaymentRowID = @PaymentRowID");
                    dbConnection();
                    Txt_Date.Text = "";
                    Txt_Vadiee.Text = "";
                }
            }
            else if (int_SaveState == 3)
            {
                if (Cmb_Members.Items.Count <= 0)
                {
                    MessageBox.Show("انتخاب فیلد الزامی می باشد . . .");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    db.cmd.Parameters.Add("@PaymentRowID", SqlDbType.Int).Value = int.Parse(Txt_DelID.Text.Trim());
                    db.exeCommand1("Delete  from [dbo].[tblPayments] Where PaymentRowID = @PaymentRowID");
                    dbConnection();
                    Txt_Date.Text = "";
                    Txt_Vadiee.Text = "";
                }
            }
            UDF_After();
        }

        private void Dg_Payments_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Dg_State_SelectionChanged_1(object sender, EventArgs e)
        {
            UDF_Get1();
        }

        private void Dg_State_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_Get1();
        }

        void UDF_Get1()
        {
            try
            {
                Cmb_Members.SelectedValue = Dg_State.Rows[Dg_State.CurrentRow.Index].Cells["PersonelID"].Value.ToString();
                UDF_DbConnection3(Cmb_Members.SelectedValue.ToString().Trim());
                UDF_CalcMemberState(Cmb_Members.SelectedValue.ToString());
            }
            catch {  }
        }

        void UDF_CalcMemberState(String Str_MemberID)
        {
            Decimal Dec_Bedehi = 0;
            Decimal Dec_Pardakhti = 0;
            Decimal Dec_State = 0;
            FirstClass db = new FirstClass();
            db.cmd.Parameters.Add("@MemberID", SqlDbType.NVarChar).Value = Str_MemberID;
            try
            {
                Dec_Bedehi = Decimal.Parse(db.dbOut("SELECT SUM(TotalBedehi) as Bed FROM dbo.XtblBedehi WHERE PersonelID = @MemberID").Rows[0][0].ToString().Trim());
            }
            catch { Dec_Bedehi = 0; }
            db = new FirstClass();
            db.cmd.Parameters.Add("@MemberID", SqlDbType.NVarChar).Value = Str_MemberID;
            try
            {
                Dec_Pardakhti = Decimal.Parse(db.dbOut("SELECT SUM([PriceOfPayment]) Par  FROM [tblPayments] WHERE MemBerID = @MemBerID").Rows[0][0].ToString().Trim());
            }
            catch { Dec_Pardakhti = 0; }
            Dec_State = Dec_Bedehi - Dec_Pardakhti;

            String Str_State = "بدهی: " + Dec_Bedehi.ToString("N0") + "      پرداختی: " + Dec_Pardakhti.ToString("N0") + "      مانده: " + Dec_State.ToString("N0");
            Txt_State.Text = Str_State;

        }
    }
}
