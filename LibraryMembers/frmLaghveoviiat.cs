using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmLaghveoviiat : Form
    {
        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            if (Rbtn_Members.Checked)
            {
                Dg_Members.DataSource = dbCon1.dbConnection(@"SELECT     dbo.Members.MemBerID, dbo.Members.Name, dbo.Members.Sname, dbo.Members.RegDate, dbo.Members.ExprDate, dbo.Members.melliCode, dbo.MemberState.MemberState, 
                      dbo.Members.memberState AS memberStateID, dbo.Members.Notes, dbo.MakeCompleteShmsiDate(dbo.Members.RegDate, '/') AS Dt1, dbo.MakeCompleteShmsiDate(dbo.Members.ExprDate, '/') 
                      AS Dt2 FROM         dbo.Members INNER JOIN   dbo.MemberState ON dbo.Members.memberState = dbo.MemberState.StateID WHERE     (dbo.MemberState.StateID = 1)");
            }
            else
            {
                Dg_Members.DataSource = dbCon1.dbConnection(@"SELECT     dbo.Members.MemBerID, dbo.Members.Name, dbo.Members.Sname, dbo.Members.RegDate, dbo.Members.ExprDate, dbo.Members.melliCode, dbo.MemberState.MemberState, 
                      dbo.Members.memberState AS memberStateID, dbo.Members.Notes, dbo.MakeCompleteShmsiDate(dbo.Members.RegDate, '/') AS Dt1, dbo.MakeCompleteShmsiDate(dbo.Members.ExprDate, '/') 
                      AS Dt2 FROM         dbo.Members INNER JOIN   dbo.MemberState ON dbo.Members.memberState = dbo.MemberState.StateID WHERE     (dbo.MemberState.StateID = 2)");
            }
        }

        public void dbConnection2()
        {
            clsForCombo cmbP = new clsForCombo();
            comboBox1.DataSource = cmbP.dbConnection2(@"SELECT StateID, MemberState FROM dbo.MemberState");
            comboBox1.ValueMember = "StateID";
            comboBox1.DisplayMember = "MemberState";
        }

        public void uPdatesConnection()
        {
            clsUpdate dbUpdate = new clsUpdate();
            dbUpdate.updateSql(@"update Members set memberState=" + " '" + comboBox1.SelectedValue + "' " + "where MemBerID=" + " '" + Txt_MemberID.Text + "'  ");
            dbConnection();
        }

        public frmLaghveoviiat()
        {
            InitializeComponent();
        }

        private void frmLaghveoviiat_Load(object sender, EventArgs e)
        {
            dbConnection();
            dbConnection2();
        }

        private void btnCancelmem_Click(object sender, EventArgs e)
        {
            if (Txt_MemberID.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("تمامی فیلدها بایستی دارای مقدار باشند");
            }
            else
            {
                uPdatesConnection();
                dbConnection();
                dbConnection2();

            }

        }

        private void Rbtn_Members_CheckedChanged(object sender, EventArgs e)
        {
            dbConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txt_MemberID.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["MemBerID"].Value.ToString();
            }
            catch { }
        }

        private void Dg_Members_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_MemberID.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["MemBerID"].Value.ToString();
            }
            catch { }
        }

        private void Dg_Members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txt_MemberID.Text = Dg_Members.Rows[Dg_Members.CurrentRow.Index].Cells["MemBerID"].Value.ToString();
            }
            catch { }
        }
    }
}