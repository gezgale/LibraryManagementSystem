using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmTavizepassword : Form
    {
        public frmTavizepassword()
        {
            InitializeComponent();
        }

        public void dbConnection()
        {
            FirstClass db2 = new FirstClass();
            DataTable dt2 = new DataTable();
            dt2 = db2.dbOut("SELECT     TOP 100 PERCENT UserName  FROM    dbo.tblUsers ORDER BY UserName");
            dataGridView1.DataSource = dt2;

        }

        private void frmTavizepassword_Load(object sender, EventArgs e)
        {
            dbConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("مقادیر فیلدها نمی توانند خالی باشند");
            }
            else
            {
                FirstClass dbCheck = new FirstClass();
                DataTable dtChek = new DataTable();

                dtChek = dbCheck.dbOut("SELECT     TOP 100 PERCENT UserName, Password FROM dbo.tblUsers WHERE     (Password = '" + textBox2.Text.Trim() + "' AND UserName = '" + textBox1.Text.Trim() + "') ORDER BY UserName");
                if (dtChek.Rows.Count <= 0)
                {
                    MessageBox.Show("نام کاربری و کلمه عبور همخوانی ندارند");
                }
                else
                {
                    FirstClass dbup1 = new FirstClass();
                    dbup1.cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                    dbup1.cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBox3.Text.Trim();
                    dbup1.exeCommand1("	Update tblUsers 	Set		Password = @Password	Where		 UserName = @UserName");
                    dbConnection();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("کلمه عبور تعویض شد");
                }
            }
        }
    }
}