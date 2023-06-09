using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmSbj : Form
    {
        int int_SaveState = 0;
        public frmSbj()
        {
            InitializeComponent();
        }


        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            Dg_BookSubjects.DataSource = dbCon1.dbConnection(@"SELECT     TOP 100 PERCENT SubId, Subject  FROM        Subjects ORDER BY SubId desc");
        }


        private void frmSbj_Load(object sender, EventArgs e)
        {
            dbConnection();
        }

        public void insSql()
        {
            clsAdding insTodb = new clsAdding();
            insTodb.insSql("insert into Subjects (Subject)values('" + Txt_SubjectName.Text + "')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int_SaveState = 1;
            UDF_Before(false);
            Txt_SubjectName.Text = "";
            Txt_SubjectID.Enabled = false;
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
            if (Txt_SubjectName.Text == "")
            {
                MessageBox.Show("موضوع یا بخشی از موضوع وارد نشده است");
            }
            else
            {
                clsGrideview dbCon1 = new clsGrideview();
                Dg_BookSubjects.DataSource = dbCon1.dbConnection(@"SELECT     TOP 100 PERCENT SubId, Subject  FROM        Subjects WHERE (Subject LIKE N'%" + Txt_SubjectName.Text.Trim() + "%') ORDER BY SubId");
            }
        }

        private void UDF_Before(Boolean Bln_IsDelete)
        {
            if (Bln_IsDelete != true)
            {
                G_1.Visible = false;
                Dg_BookSubjects.Enabled = false;
            }
            else
            {
                G_1.Visible = false;
                G_3.Enabled = false;
                Dg_BookSubjects.Enabled = false;
            }
        }

        private void UDF_After()
        {
            G_1.Visible = true;
            G_3.Enabled = true;
            Dg_BookSubjects.Enabled = true;
            dbConnection();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (int_SaveState == 1)
            {
                if (Txt_SubjectName.Text == "")
                {
                    MessageBox.Show("ورود عنوان موضوع الزامی می باشد");
                }
                insSql();
                dbConnection();
                Txt_SubjectName.Clear();
            }
            else if (int_SaveState == 2)
            {
                if (Txt_SubjectName.Text == "" || Txt_SubjectID.Text == "")
                {
                    MessageBox.Show("مقادیر هر دوفیلد باید وارد شوند");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    db.cmd.Parameters.Add("@SubId", SqlDbType.Int).Value = int.Parse(Txt_SubjectID.Text.Trim());
                    db.cmd.Parameters.Add("@Subject", SqlDbType.NVarChar).Value = Txt_SubjectName.Text.Trim();
                    db.exeCommand1("Update Subjects  Set Subject = @Subject	Where SubId = @SubId");
                    dbConnection();
                    Txt_SubjectName.Clear();
                    Txt_SubjectID.Clear();
                }
            }
            else if (int_SaveState == 3)
            {
                if (Txt_SubjectID.Text == "")
                {
                    MessageBox.Show("مقدار فیلد کد موضوع وارد نشده است");
                }
                else
                {
                    FirstClass db = new FirstClass();
                    db.cmd.Parameters.Add("@SubId", SqlDbType.Int).Value = int.Parse(Txt_SubjectID.Text.Trim());
                    db.exeCommand1("Delete  Subjects Where SubId = @SubId");
                    dbConnection();
                    Txt_SubjectName.Clear();
                    Txt_SubjectID.Clear();
                }
            }
            UDF_After();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            UDF_After();
        }

        private void Dg_BookSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                Txt_SubjectID.Text = Dg_BookSubjects.Rows[Dg_BookSubjects.CurrentRow.Index].Cells["SubId"].Value.ToString();
                Txt_SubjectName.Text = Dg_BookSubjects.Rows[Dg_BookSubjects.CurrentRow.Index].Cells["Subject"].Value.ToString();
            }
            catch { }
        }

        private void Dg_BookSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Dg_BookSubjects_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg(); 
        }
    }
}