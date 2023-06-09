using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmTahvileketab : Form
    {
        public frmTahvileketab()
        {
            InitializeComponent();
        }

        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            dataGridView1.DataSource = dbCon1.dbConnection(@"SELECT     dbo.Members.MemBerID, dbo.Members.Name + N'  ' + dbo.Members.Sname AS EXPR1, dbo.Books.Title, dbo.BookH.DateDeli, dbo.Subjects.Subject, 
                      dbo.BookH.zemanat, dbo.BookH.Mablagh
                        FROM         dbo.BookH INNER JOIN
                      dbo.Books ON dbo.BookH.BookID = dbo.Books.BookID INNER JOIN
                      dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID INNER JOIN
                      dbo.Subjects ON dbo.Books.TopicID = dbo.Subjects.SubId
                        WHERE     (dbo.BookH.DatBaz IS NULL)");
        }

        public void dbConnection2()
        {
            clsForCombo cmbP2 = new clsForCombo();
            Cmb_Members.DataSource = cmbP2.dbConnection2(@"SELECT     MemBerID FROM    dbo.Members WHERE     (memberState = 1)");
            Cmb_BookNames.DataSource = cmbP2.dbConnection2(@"SELECT     BookID, Title FROM   dbo.Books WHERE     (TahYeNo = 0)");
            
            Cmb_Members.ValueMember = "MemBerID";
            Cmb_Members.DisplayMember = "MemBerID";

            Cmb_BookNames.ValueMember = "BookID";
            Cmb_BookNames.DisplayMember = "Title";
        }

        public void adin()
        {
            try
            {
                FirstClass dbEx = new FirstClass();
                dbEx.cmd.Parameters.Add("@PersonelID", SqlDbType.NVarChar).Value = Cmb_Members.SelectedValue.ToString();
                dbEx.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Cmb_BookNames.SelectedValue.ToString();
                dbEx.cmd.Parameters.Add("@DateDeli", SqlDbType.NVarChar).Value = Txt_DeliverDate.Text.Trim();
                dbEx.cmd.Parameters.Add("@zemanat", SqlDbType.NVarChar).Value = Txt_Zemanat.Text.Trim();
                dbEx.cmd.Parameters.Add("@Mablagh", SqlDbType.NVarChar).Value = Txt_Vadiee.Text.Trim();
                dbEx.exeCommand1(@"	Insert Into BookH
		                        (PersonelID,BookID,DateDeli,zemanat,Mablagh)
	                            Values
		                        (@PersonelID,@BookID,@DateDeli,@zemanat,@Mablagh)");

                FirstClass dbex1 = new FirstClass();
                dbex1.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Cmb_BookNames.SelectedValue.ToString();
                dbex1.cmd.Parameters.Add("@TahYeNo", SqlDbType.Bit).Value = 1;
                dbex1.exeCommand1("Update     Books Set  TahYeNo = @TahYeNo  Where BookID = @BookID");
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void frmTahvileketab_Load(object sender, EventArgs e)
        {
            dbConnection();
            dbConnection2();
            Txt_DeliverDate.Text = FirstClass.UDF_MiladiToShmasi(DateTime.Now);
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UDF_CheckBokkDeliverTimes(Cmb_Members.Text) == true)
            {
                G_2.Visible = true;
                Btn_Deliver.Visible = false;
                Txt_Vadiee.Text = "";
                Txt_Zemanat.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Cmb_Members.Text == "" || Cmb_BookNames.Text == "" || Txt_Zemanat.Text == "" || Txt_DeliverDate.Text == "" || Txt_Vadiee.Text == "")
            {
                MessageBox.Show("مقادیر تمامی فیلدها بایستی وارد شوند");
            }
            else
            {
                //if(UDF_CheckBokkDeliverTimes(
                adin();
                dbConnection();
                dbConnection2();
            }
            G_2.Visible = false;
            Btn_Deliver.Visible = true;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            G_2.Visible = false;
            Btn_Deliver.Visible = true;
        }

        /// <summary>
        /// بررسی تعداد مجاز کتابهای تحویلی
        /// </summary>
        /// <returns></returns>
        private Boolean UDF_CheckBokkDeliverTimes(String Str_MemberUserName)
        {
            FirstClass db = new FirstClass();
            db.cmd.Parameters.Add("@MemberUserName", SqlDbType.NVarChar).Value = Str_MemberUserName.Trim();
            int int_BookDelivered = int.Parse(db.dbOut("SELECT COUNT(PersonelID) AS CntBookInUse  FROM [dbo].[BookH] WHERE DatBaz IS NULL AND PersonelID = @MemberUserName").Rows[0][0].ToString());
            db = new FirstClass();
            int int_AlowdedQuantity = int.Parse(db.dbOut("SELECT [TedadeMojazeAmanatdehieKetab]  FROM [dbo].[tblSystemChanges] WHERE RowID = 1").Rows[0][0].ToString());
            if (int_AlowdedQuantity > int_BookDelivered)
            {
                return true;
            }
            else
            {
                MessageBox.Show("تعداد کتابهای تحویلی به هر کاربر حداکثر " + int_AlowdedQuantity.ToString() + " می باشد");
                return false;
            }
        }

        private void Txt_Zemanat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Vadiee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}