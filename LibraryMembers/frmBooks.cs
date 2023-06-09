using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmBooks : Form
    {
        int int_SaveState = 0;
        public frmBooks()
        {
            InitializeComponent();
        }

        public void grdFil()
        {
            clsGrideview grd = new clsGrideview();
            Dg_Books.DataSource = grd.dbConnection(@"SELECT     dbo.Books.BookID, dbo.Books.Title, dbo.Subjects.Subject, dbo.Books.CopyrightYear, dbo.Books.ISBNNumber, dbo.Books.PublisherName, 
                      dbo.Books.WriterN, dbo.Books.PurchasePrice, dbo.Books.Pages, dbo.Books.Notes, dbo.Books.TahYeNo , dbo.Books.TopicID FROM  dbo.Books INNER JOIN dbo.Subjects ON dbo.Books.TopicID = dbo.Subjects.SubId  order by dbo.Books.BookID desc");

        }

        public void cmbFil()
        {
            clsForCombo cmbP = new clsForCombo();
            Cmb_BookSubject.DataSource = cmbP.dbConnection2(@"SELECT TOP 100 PERCENT SubId, Subject FROM Subjects ORDER BY Subject");
            Cmb_BookSubject.ValueMember = "SubId";
            Cmb_BookSubject.DisplayMember = "Subject";
        }

        public void insSql()
        {

                int i = 0;
                if (!Cbx_State.Checked)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
            
                clsAdding insTodb = new clsAdding();
                SqlParameter param1 = new SqlParameter("@geimat", SqlDbType.Money);
                param1.Value = Txt_PurchasePrice.Text;
                insTodb.insSql("insert into Books (BookID, Title, TopicID, CopyrightYear, ISBNNumber, PublisherName, WriterN, PurchasePrice, Pages, Notes, TahYeNo)values('" + Txt_BookID.Text + "' , '" + Txt_BookTitle.Text + "' , '" + Cmb_BookSubject.SelectedValue + "' , '" + Txt_CopyrightYear.Text + "' , '" + Txt_Isbn.Text + "' , '" + Txt_Entesharat.Text + "' , '" + Txt_BookWrite.Text + "' , '" + Convert.ToDecimal(Txt_PurchasePrice.Text) + "' , '" + Txt_Pages.Text + "' , '" + Txt_Notes.Text + "', '" + i + "')");
                grdFil();
                cmbFil();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            grdFil();
            cmbFil();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int_SaveState = 1;
            UDF_Before(false);
            Txt_BookID.Text = "";
            Txt_BookTitle.Text = "";
            Txt_BookWrite.Text = "";
            Txt_CopyrightYear.Text = "";
            Txt_Entesharat.Text = "";
            Txt_Isbn.Text = "";
            Txt_Notes.Text = "";
            Txt_Pages.Text = "";
            Txt_PurchasePrice.Text = "";
        }

        protected void dbUpdate()
        {
            int i = 0;
            if (Cbx_State.Checked)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            FirstClass db = new FirstClass();
            db.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Txt_BookID.Text.Trim();
            db.cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Txt_BookTitle.Text.Trim();
            db.cmd.Parameters.Add("@TopicID", SqlDbType.Int).Value = Cmb_BookSubject.SelectedValue;
            db.cmd.Parameters.Add("@CopyrightYear", SqlDbType.Float).Value = float.Parse(Txt_CopyrightYear.Text.Trim());
            db.cmd.Parameters.Add("@ISBNNumber", SqlDbType.NVarChar).Value = Txt_Isbn.Text.Trim();
            db.cmd.Parameters.Add("@PublisherName", SqlDbType.NVarChar).Value = Txt_Entesharat.Text.Trim();
            db.cmd.Parameters.Add("@WriterN", SqlDbType.NVarChar).Value = Txt_BookWrite.Text.Trim();
            db.cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = decimal.Parse(Txt_PurchasePrice.Text.Trim());
            db.cmd.Parameters.Add("@Pages", SqlDbType.SmallInt).Value = int.Parse(Txt_Pages.Text.Trim());
            db.cmd.Parameters.Add("@Notes", SqlDbType.NText).Value = Txt_Notes.Text.Trim();

            db.exeCommand1("Update Books  Set	 Title = @Title, TopicID = @TopicID,	CopyrightYear = @CopyrightYear,	ISBNNumber = @ISBNNumber, PublisherName = @PublisherName,		WriterN = @WriterN,		PurchasePrice = @PurchasePrice,		Pages = @Pages,		Notes = @Notes	Where	 BookID = @BookID");
            txtClear();

        }

        protected void txtClear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {

                    ((TextBox)c).Clear();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int_SaveState = 2;
            UDF_Before(false);
        }

        protected void dbSearch()
        {
            clsGrideview grd = new clsGrideview();
            Dg_Books.DataSource = grd.dbConnection(@"SELECT     dbo.Books.BookID, dbo.Books.Title, dbo.Subjects.Subject, dbo.Books.CopyrightYear, dbo.Books.ISBNNumber, dbo.Books.PublisherName, 
                      dbo.Books.WriterN, dbo.Books.PurchasePrice, dbo.Books.Pages, dbo.Books.Notes, dbo.Books.TahYeNo FROM  dbo.Books INNER JOIN dbo.Subjects ON dbo.Books.TopicID = dbo.Subjects.SubId WHERE     (dbo.Books.Title LIKE N'%" + Txt_Search.Text.Trim() + "%')");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("کد کتاب وارد نشده است");
            }
            else
            {
                dbSearch();
                cmbFil();
                txtClear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int_SaveState = 3;
            UDF_Before(true);
        }

        private void UDF_Before(Boolean Bln_IsDelete)
        {
            if (Bln_IsDelete != true)
            {
                G_1.Visible = false;
                Dg_Books.Enabled = false;
            }
            else
            {
                G_1.Visible = false;
                G_3.Enabled = false;
                Dg_Books.Enabled = false;
            }
        }

        private void UDF_GetTextFromDg()
        {
            try
            {
                Txt_BookID.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["BookID"].Value.ToString();
                Txt_BookTitle.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["Title"].Value.ToString();
                Cmb_BookSubject.SelectedValue = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["TopicID"].Value.ToString();
                Txt_CopyrightYear.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["CopyrightYear"].Value.ToString();
                Txt_Isbn.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["ISBNNumber"].Value.ToString();
                Txt_Notes.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["Notes"].Value.ToString();
                Txt_PurchasePrice.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["PurchasePrice"].Value.ToString();
                Txt_Entesharat.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["PublisherName"].Value.ToString();
                Txt_BookWrite.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["WriterN"].Value.ToString();
                Txt_Pages.Text = Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["Pages"].Value.ToString();
                Cbx_State.Checked = Boolean.Parse(Dg_Books.Rows[Dg_Books.CurrentRow.Index].Cells["TahYeNo"].Value.ToString());
            }
            catch { }
        }

        private void UDF_After()
        {
            G_1.Visible = true;
            G_3.Enabled = true;
            Dg_Books.Enabled = true;
            grdFil();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (int_SaveState == 1)
            {
                if (Txt_BookID.Text == "" || Txt_BookTitle.Text == "" || Txt_CopyrightYear.Text == "" || Txt_Isbn.Text == "" || Txt_Notes.Text == "" || Txt_Pages.Text == "" || Txt_BookWrite.Text == "" || Txt_Entesharat.Text == "" || Txt_PurchasePrice.Text == "" || Cmb_BookSubject.Text == "")
                {
                    MessageBox.Show("مقادیر تمامی فیلدها بایستی انتخاب گردند");

                }
                else
                {
                    try
                    {
                        insSql();
                        grdFil();
                        cmbFil();
                        txtClear();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            else if (int_SaveState == 2)
            {
                try
                {
                    dbUpdate();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else if (int_SaveState == 3)
            {
                if (Txt_BookID.Text == "")
                {
                    MessageBox.Show("کد کتاب وارد نشده است");
                }
                else
                {
                    try
                    {
                        FirstClass db = new FirstClass();
                        db.cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = Txt_BookID.Text.Trim();
                        db.exeCommand1("Delete  Books Where  BookID = @BookID");
                        grdFil();
                        cmbFil();
                        txtClear();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            UDF_After();
        }

        private void Dg_Books_SelectionChanged(object sender, EventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Dg_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_GetTextFromDg();
        }

        private void Txt_PurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            UDF_After();
        }


    }
}