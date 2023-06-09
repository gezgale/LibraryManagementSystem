using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmBazgashteketab : Form
    {
        int int_SaveState = 0;
        public frmBazgashteketab()
        {
            InitializeComponent();
        }

        public void dbConnection()
        {
            clsGrideview dbCon1 = new clsGrideview();
            Dg_DeliveredBooks.DataSource = dbCon1.dbConnection(@"SELECT     dbo.Members.MemBerID, dbo.Members.Name + N'  ' + dbo.Members.Sname AS EXPR1, dbo.Books.Title, dbo.BookH.DateDeli, dbo.Subjects.Subject, 
                      dbo.BookH.zemanat, dbo.BookH.Mablagh , BookH.BookID FROM dbo.BookH INNER JOIN dbo.Books ON dbo.BookH.BookID = dbo.Books.BookID INNER JOIN
                      dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID INNER JOIN dbo.Subjects ON dbo.Books.TopicID = dbo.Subjects.SubId WHERE  (dbo.BookH.DatBaz is null)");
        }

        public void dbConnection2()
        {
            clsForCombo cmbP2 = new clsForCombo();
            Cmb_Members.DataSource = cmbP2.dbConnection2(@"SELECT     MemBerID FROM    dbo.Members WHERE     (memberState = 1)");
            Cmb_BooksID.DataSource = cmbP2.dbConnection2(@"SELECT     BookID, Title FROM   dbo.Books WHERE     (TahYeNo = 1)");

            Cmb_Members.ValueMember = "MemBerID";
            Cmb_Members.DisplayMember = "MemBerID";

            Cmb_BooksID.ValueMember = "BookID";
            Cmb_BooksID.DisplayMember = "Title";
        }

        public void adish()
        {
            FirstClass dbEx = new FirstClass();
            dbEx.cmd.Parameters.Add("@PersonelID", SqlDbType.NVarChar).Value = Cmb_Members.SelectedValue.ToString();
            dbEx.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Cmb_BooksID.SelectedValue.ToString();
            dbEx.cmd.Parameters.Add("@DateDeli", SqlDbType.NVarChar).Value = Txt_GetDate.Text.Trim();
            dbEx.cmd.Parameters.Add("@DatBaz", SqlDbType.NVarChar).Value = Txt_ReturnDate.Text.Trim();
            dbEx.exeCommand1("Update BookH  Set	 DatBaz = @DatBaz	Where PersonelID = @PersonelID	and BookID = @BookID and DateDeli = @DateDeli");

            FirstClass dbex1 = new FirstClass();
            dbex1.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Cmb_BooksID.SelectedValue.ToString();
            dbex1.cmd.Parameters.Add("@TahYeNo", SqlDbType.Bit).Value = 0;
            dbex1.exeCommand1("Update Books Set TahYeNo = @TahYeNo 	Where	BookID = @BookID");
        }

        private void frmBazgashteketab_Load(object sender, EventArgs e)
        {
            dbConnection();
            dbConnection2();
            Txt_ReturnDate.Text = FirstClass.UDF_MiladiToShmasi(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int_SaveState = 1;
            UDF_Before(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dbConnection(String Str_BookName);
        }

        public void dbConnection(String Str_BookName)
        {
            try
            {
                clsGrideview dbCon1 = new clsGrideview();
                Dg_DeliveredBooks.DataSource = dbCon1.dbConnection(@"SELECT     dbo.Members.MemBerID, dbo.Members.Name + N'  ' + dbo.Members.Sname AS EXPR1, dbo.Books.Title, dbo.BookH.DateDeli, dbo.Subjects.Subject, 
                      dbo.BookH.zemanat, dbo.BookH.Mablagh , BookH.BookID FROM dbo.BookH INNER JOIN dbo.Books ON dbo.BookH.BookID = dbo.Books.BookID INNER JOIN
                      dbo.Members ON dbo.BookH.PersonelID = dbo.Members.MemBerID INNER JOIN dbo.Subjects ON dbo.Books.TopicID = dbo.Subjects.SubId WHERE  dbo.BookH.DatBaz is null and dbo.Books.Title like '%" + Str_BookName.Trim() + "%'");
            }
            catch { }
        }

        private void Dg_DeliveredBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Dg_DeliveredBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Dg_DeliveredBooks_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                //Lbl_AssetUnitID.Text = Dg_AssetsUnit.Rows[Dg_AssetsUnit.CurrentRow.Index].Cells["AssetUnitID"].Value.ToString();
                Txt_GetDate.Text = Dg_DeliveredBooks.Rows[Dg_DeliveredBooks.CurrentRow.Index].Cells["Column4"].Value.ToString();
                Cmb_Members.SelectedValue = Dg_DeliveredBooks.Rows[Dg_DeliveredBooks.CurrentRow.Index].Cells["Column1"].Value.ToString();
                Cmb_BooksID.SelectedValue = Dg_DeliveredBooks.Rows[Dg_DeliveredBooks.CurrentRow.Index].Cells["BookID"].Value.ToString();
                //Cbx_IsActive.Checked = Convert.ToBoolean(Dg_AssetsUnit.Rows[Dg_AssetsUnit.CurrentRow.Index].Cells["IsActive"].Value);
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbConnection(Txt_Search.Text.Trim());
        }

        private void UDF_Before(Boolean Bln_IsDelete)
        {
            if (Bln_IsDelete != true)
            {
                G_1.Visible = false;
                Dg_DeliveredBooks.Enabled = false;
            }
            else
            {
                G_1.Visible = false;
                //G_3.Enabled = false;
                Dg_DeliveredBooks.Enabled = false;
            }
        }

        private void UDF_After()
        {
            G_1.Visible = true;
            //G_3.Enabled = true;
            Dg_DeliveredBooks.Enabled = true;
            dbConnection();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (int_SaveState == 1)
            {
                if (Txt_ReturnDate.Text == "" || Txt_GetDate.Text == "" || Cmb_Members.Text == "" || Cmb_BooksID.Text == "")
                {
                    MessageBox.Show("مقادیر تمامی فیلدها بایستی وارد شوند");
                }
                else
                {
                    adish();
                    dbConnection();
                    dbConnection2();
                }
            }
            else if (int_SaveState == 2)
            {

            }
            else if (int_SaveState == 3)
            {

            }
            UDF_After();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            UDF_After();
            dbConnection();
            dbConnection2();
        }

    }
}