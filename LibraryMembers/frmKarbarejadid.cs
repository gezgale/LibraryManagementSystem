using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmKarbarejadid : Form
    {
        public frmKarbarejadid()
        {
            InitializeComponent();
        }

        public void dbConnection()
        {
            FirstClass db2 = new FirstClass();
            DataTable dt2 = new DataTable();
            dt2 = db2.dbOut("SELECT     TOP 100 PERCENT UserName  FROM    tblUsers ORDER BY UserName");
            dataGridView1.DataSource = dt2;
         }

        public void insSql()
        {
            try
            {
                FirstClass dbIns = new FirstClass();
                dbIns.cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                dbIns.cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBox2.Text.Trim();
                dbIns.exeCommand1("Insert Into tblUsers	 (UserName,Password)	Values (@UserName,@Password)");
            }
            catch (Exception EE) { MessageBox.Show(EE.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("مقادیر فیلدها نمی توانند خالی باشند");
            }
            else
            {
                insSql();
                dbConnection();
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void frmKarbarejadid_Load(object sender, EventArgs e)
        {
            dbConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
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
                    FirstClass dbDel = new FirstClass();
                    dbDel.cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                    dbDel.exeCommand1("Delete tblUsers	Where		UserName = @UserName");
                    dbConnection();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("نام کاربری و یا بخشی از نام کاربری وارد نشده");
            }
            else
            {
                FirstClass db2 = new FirstClass();
                DataTable dt2 = new DataTable();
                dt2 = db2.dbOut("SELECT     TOP 100 PERCENT UserName  FROM    tblUsers Where (UserName LIKE N'%" + textBox1.Text + "%') ORDER BY UserName");
                dataGridView1.DataSource = dt2;
            }
        }
    }
}