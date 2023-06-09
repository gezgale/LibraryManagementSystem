using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "" || Txt_Password.Text == "")
            {
                MessageBox.Show("مقادیر فیلدها نمی توانند خالی باشند");
            }
            else
            {
                FirstClass dbCheck = new FirstClass();
                DataTable dtChek = new DataTable();

                dtChek = dbCheck.dbOut("SELECT TOP 100 PERCENT UserName, Password FROM dbo.tblUsers WHERE  (Password = '" + Txt_Password.Text.Trim() + "' AND UserName = '" + Txt_UserName.Text.Trim() + "') ORDER BY UserName");
                if (dtChek.Rows.Count <= 0)
                {
                    MessageBox.Show("نام کاربری و کلمه عبور اشتباه وارد شده اند");
                }
                else
                {
                    frmMdiLibrary frm = new frmMdiLibrary();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}