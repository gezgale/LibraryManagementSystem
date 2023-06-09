using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmTedadeMojazeTahvil : Form
    {
        public frmTedadeMojazeTahvil()
        {
            InitializeComponent();
        }

        private void frmTedadeMojazeTahvil_Load(object sender, EventArgs e)
        {
            CountFetch();
        }

        private void CountFetch()
        {
            FirstClass db = new FirstClass();
            DataTable dt = new DataTable();
            dt = db.dbOut("SELECT    [TedadeMojazeAmanatdehieKetab] ,[JarimehDirkerd] ,[ModdateMojaz]  FROM tblSystemChanges WHERE     (RowID = 1)");
            Txt_AllowedQuantity.Text = dt.Rows[0][0].ToString();
            Txt_AllowdedDays.Text = dt.Rows[0][2].ToString();
            Txt_FinePerDay.Text = dt.Rows[0][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstClass db = new FirstClass();
            db.exeCommand1(String.Format("UPDATE tblSystemChanges SET TedadeMojazeAmanatdehieKetab = '{0}' , JarimehDirkerd = '{1}' , ModdateMojaz = '{2}'  WHERE RowID=1", Txt_AllowedQuantity.Text.Trim() , Txt_FinePerDay.Text.Trim() , Txt_AllowdedDays.Text.Trim()));
            
            CountFetch();
            MessageBox.Show("بروزرسانی انجام شد");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if (ascii >= 48 && ascii <= 57 || ascii == 8)
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