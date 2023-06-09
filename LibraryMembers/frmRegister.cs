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
    public partial class frmRegister : Form
    {
        int int_SaveState = 0;
        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            Dg_Members.DataSource = dbCon1.dbConnection(@"SELECT MemberList1.* FROM dbo.MemberList1");
        }

        public void dbConnection2()
        {
            clsForCombo cmbP2 = new clsForCombo();
            Cmb_SateMember.DataSource =  cmbP2.dbConnection2(@"SELECT StateID, MemberState FROM dbo.MemberState");
            Cmb_SateMember.ValueMember = "StateID";
            Cmb_SateMember.DisplayMember = "MemberState";
        }
        public void insSql()
        {
            FirstClass sh1 = new FirstClass();
            FirstClass sh = new FirstClass();
            sh.cmd.Parameters.Add("@Dt1", SqlDbType.DateTime).Value = sh1.ShamsiToMiladi(Txt_MemberStart.Text);
            sh1 = new FirstClass();
            sh.cmd.Parameters.Add("@Dt2", SqlDbType.DateTime).Value = sh1.ShamsiToMiladi(Txt_MemberEnd.Text);
            sh.exeCommand1("insert into Members (MemBerID, Name, Sname, RegDate, ExprDate, melliCode, memberState, Notes)values('" + Txt_MemberID.Text + "' , '" + Txt_Name.Text + "' , '" + Txt_Sname.Text + "' , @Dt1 , @Dt2 , '" + Txt_MemlliCode.Text + "' , '" + Cmb_SateMember.SelectedValue + "' , '" + Txt_Notes.Text + "')");
            dbConnection();
        }
        
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            int_SaveState = 1;
            UDF_Before(false);
            txtClear();
            Txt_MemberStart.Text = FirstClass.UDF_MiladiToShmasi(DateTime.Now);
            Txt_MemberEnd.Text = FirstClass.UDF_MiladiToShmasi(DateTime.Now.AddYears(1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection();
            dbConnection2();
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtClear()
        {
            Txt_MemberEnd.Text = "";
            Txt_MemberID.Text = "";
            Txt_MemberStart.Text = "";
            Txt_MemlliCode.Text = "";
            Txt_Name.Text = "";
            Txt_Notes.Text = "";
            Txt_Sname.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int_SaveState = 3;
            UDF_Before(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Txt_Sname.Text == "")
            {
                MessageBox.Show("نام خانوادگی و یا بخشی از نام خانوادگی وارد نشده");
            }
            else
            {
                clsGrideview dbCon1 = new clsGrideview();
                Dg_Members.DataSource = dbCon1.dbConnection(@"SELECT     TOP 100 PERCENT MemBerID, Name, Sname, RegDate, ExprDate, melliCode, MemberState FROM MemberList1 WHERE     (Sname LIKE N'%"+ Txt_Sname.Text +"%') ORDER BY MemBerID");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int_SaveState = 2;
            UDF_Before(false);
        }

        private void UDF_After()
        {
            G_1.Visible = true;
            G_3.Enabled = true;
            Dg_Members.Enabled = true;
            dbConnection();
            dbConnection2();
        }

        private void UDF_Before(Boolean Bln_IsDelete)
        {
            if (Bln_IsDelete != true)
            {
                G_1.Visible = false;
                Dg_Members.Enabled = false;
            }
            else
            {
                G_1.Visible = false;
                G_3.Enabled = false;
                Dg_Members.Enabled = false;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (int_SaveState == 1)
            {
                if (Txt_MemberID.Text == "" || Txt_Name.Text == "" || Txt_Sname.Text == "" || Txt_MemberStart.Text == "" || Txt_MemberEnd.Text == "" || Txt_MemlliCode.Text == "" || Cmb_SateMember.Text == "")
                {
                    MessageBox.Show("تمامی فیلدها بایستی دارای مقدار باشند");
                }
                else
                {
                    insSql();
                }
            }
            else if (int_SaveState == 2)
            {
                if (Txt_MemberID.Text == "" || Txt_Name.Text == "" || Txt_Sname.Text == "" || Txt_MemberStart.Text == "" || Txt_MemberEnd.Text == "" || Txt_MemlliCode.Text == "" || Cmb_SateMember.Text == "")
                {
                    MessageBox.Show("تمامی فیلدها بایستی دارای مقدار باشند");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    FirstClass Sh = new FirstClass();
                    db.cmd.Parameters.Add("@MemBerID", SqlDbType.NVarChar).Value = Txt_MemberID.Text.Trim();
                    db.cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Txt_Name.Text.Trim();
                    db.cmd.Parameters.Add("@Sname", SqlDbType.NVarChar).Value = Txt_Sname.Text.Trim();
                    db.cmd.Parameters.Add("@RegDate", SqlDbType.DateTime).Value =  Sh.ShamsiToMiladi(Txt_MemberStart.Text.Trim());
                    Sh = new FirstClass();
                    db.cmd.Parameters.Add("@ExprDate", SqlDbType.DateTime).Value = Sh.ShamsiToMiladi(Txt_MemberEnd.Text.Trim());
                    db.cmd.Parameters.Add("@melliCode", SqlDbType.NVarChar).Value = Txt_MemlliCode.Text.Trim();
                    db.cmd.Parameters.Add("@memberState", SqlDbType.Int).Value = Cmb_SateMember.SelectedValue;
                    db.cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Txt_Notes.Text.Trim();

                    db.exeCommand1(@"Update Members
	                                Set
		                               Name = @Name,
		                               Sname = @Sname,
		                               RegDate = @RegDate,
		                               ExprDate = @ExprDate,
		                               melliCode = @melliCode,
		                               memberState = @memberState,
		                               Notes = @Notes
	                                Where		
		                               MemBerID = @MemBerID");
                    dbConnection();
                    dbConnection2();
                    txtClear();
                }
            }
            else if (int_SaveState == 3)
            {
                if (Txt_MemberID.Text == "")
                {
                    MessageBox.Show("کد عضویت وارد نشده");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    db.cmd.Parameters.Add("@MemBerID", SqlDbType.NVarChar).Value = Txt_MemberID.Text.Trim();
                    db.exeCommand1("Delete Members 	Where	MemBerID = @MemBerID");
                    dbConnection();
                    dbConnection2();
                }
            }
            UDF_After();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            UDF_After();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                Txt_MemberID.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Column1"].Value.ToString();
                Txt_Name.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Column2"].Value.ToString();
                Txt_Sname.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Column3"].Value.ToString();
                Txt_MemberStart.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Dt1"].Value.ToString();
                Txt_MemberEnd.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Dt2"].Value.ToString();
                Cmb_SateMember.SelectedValue = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["memberStateID"].Value.ToString();
                Txt_Notes.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Notes"].Value.ToString();
                Txt_MemlliCode.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["Column5"].Value.ToString();
            }
            catch { }
        }

        private void Dg_Members_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Txt_MemlliCode_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}