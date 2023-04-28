using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmTamdideozviiat : Form
    {

        public frmTamdideozviiat()
        {
            InitializeComponent();
        }

        // نمایش اطلاعات اعضا
        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            Dg_Tamdid.DataSource = dbCon1.dbConnection(@"SELECT MemBerID, Name, Sname, RegDate, ExprDate, melliCode FROM dbo.Members");
        }

        // انجام بروز رسانی
        public void updatesConnection()
        {
            if (Cmb_Years.Text == "")
            {
                MessageBox.Show("انتخاب سال الزامی می باشد . . .");
                return;
            }
            clsUpdate dbUpd = new clsUpdate();
            dbUpd.updateSql(@"update Members set ExprDate=   (SELECT  DATEADD(YEAR , " + int.Parse(Cmb_Years.Text) + ", ExprDate)  FROM [Members] WHERE MemBerID = '" + Txt_MemberID.Text.Trim() + "')  where MemBerID=" + " '" + Txt_MemberID.Text + "'  ");
            dbConnection();
        }
        

        private void frmTamdideozviiat_Load(object sender, EventArgs e)
        {
            dbConnection();
        }

        // بررسی فیلد متنی
        private void btnTamdid_Click(object sender, EventArgs e)
        {
            if (Txt_MemberID.Text == "" )
            {
                MessageBox.Show("تمامی فیلدها بایستی دارای مقدار باشند");
            }
            else
            {
                updatesConnection();
                dbConnection();
            }

        }

        private void Dg_Tamdid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                Txt_MemberID.Text = Dg_Tamdid.Rows[Dg_Tamdid.CurrentRow.Index].Cells["Column1"].Value.ToString();
            }
            catch { }
        }

        private void Dg_Tamdid_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }
    }
}