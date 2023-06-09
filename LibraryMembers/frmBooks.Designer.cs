namespace LibraryMembers
{
    partial class frmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dg_Books = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyrightYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriterN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahYeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_BookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_BookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CopyrightYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Isbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Pages = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_BookWrite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Entesharat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cbx_State = new System.Windows.Forms.CheckBox();
            this.Cmb_BookSubject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.G_1 = new System.Windows.Forms.GroupBox();
            this.G_3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Books)).BeginInit();
            this.G_2.SuspendLayout();
            this.G_1.SuspendLayout();
            this.G_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dg_Books
            // 
            this.Dg_Books.AllowUserToAddRows = false;
            this.Dg_Books.AllowUserToDeleteRows = false;
            this.Dg_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Subject,
            this.CopyrightYear,
            this.ISBNNumber,
            this.PublisherName,
            this.WriterN,
            this.PurchasePrice,
            this.Pages,
            this.Notes,
            this.TahYeNo,
            this.TopicID});
            this.Dg_Books.Location = new System.Drawing.Point(1, 1);
            this.Dg_Books.Name = "Dg_Books";
            this.Dg_Books.Size = new System.Drawing.Size(622, 190);
            this.Dg_Books.TabIndex = 4;
            this.Dg_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Books_CellClick);
            
            this.Dg_Books.SelectionChanged += new System.EventHandler(this.Dg_Books_SelectionChanged);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "کد کتاب";
            this.BookID.Name = "BookID";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "نام کتاب";
            this.Title.Name = "Title";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "موضوع کتاب";
            this.Subject.Name = "Subject";
            // 
            // CopyrightYear
            // 
            this.CopyrightYear.DataPropertyName = "CopyrightYear";
            dataGridViewCellStyle1.Format = "0000/00/00";
            dataGridViewCellStyle1.NullValue = "0000/00/00";
            this.CopyrightYear.DefaultCellStyle = dataGridViewCellStyle1;
            this.CopyrightYear.HeaderText = "تاریخ حق نشر";
            this.CopyrightYear.Name = "CopyrightYear";
            // 
            // ISBNNumber
            // 
            this.ISBNNumber.DataPropertyName = "ISBNNumber";
            this.ISBNNumber.HeaderText = "کد شابک";
            this.ISBNNumber.Name = "ISBNNumber";
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "منتشر کننده";
            this.PublisherName.Name = "PublisherName";
            // 
            // WriterN
            // 
            this.WriterN.DataPropertyName = "WriterN";
            this.WriterN.HeaderText = "نام نویسنده";
            this.WriterN.Name = "WriterN";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasePrice.HeaderText = "قیمت خرید";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // Pages
            // 
            this.Pages.DataPropertyName = "Pages";
            this.Pages.HeaderText = "تعداد صفحات";
            this.Pages.Name = "Pages";
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "ملاحظات";
            this.Notes.Name = "Notes";
            // 
            // TahYeNo
            // 
            this.TahYeNo.DataPropertyName = "TahYeNo";
            this.TahYeNo.HeaderText = "وضعیت تحویل";
            this.TahYeNo.Name = "TahYeNo";
            // 
            // TopicID
            // 
            this.TopicID.DataPropertyName = "TopicID";
            this.TopicID.HeaderText = "TopicID";
            this.TopicID.Name = "TopicID";
            this.TopicID.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "کد کتاب:";
            // 
            // Txt_BookID
            // 
            this.Txt_BookID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BookID.Location = new System.Drawing.Point(333, 19);
            this.Txt_BookID.MaxLength = 7;
            this.Txt_BookID.Name = "Txt_BookID";
            this.Txt_BookID.Size = new System.Drawing.Size(194, 20);
            this.Txt_BookID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "نام کتاب:";
            // 
            // Txt_BookTitle
            // 
            this.Txt_BookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BookTitle.Location = new System.Drawing.Point(333, 45);
            this.Txt_BookTitle.MaxLength = 25;
            this.Txt_BookTitle.Name = "Txt_BookTitle";
            this.Txt_BookTitle.Size = new System.Drawing.Size(194, 20);
            this.Txt_BookTitle.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "موضوع کتاب:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CopyRight:";
            // 
            // Txt_CopyrightYear
            // 
            this.Txt_CopyrightYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CopyrightYear.Location = new System.Drawing.Point(333, 97);
            this.Txt_CopyrightYear.MaxLength = 8;
            this.Txt_CopyrightYear.Name = "Txt_CopyrightYear";
            this.Txt_CopyrightYear.Size = new System.Drawing.Size(194, 20);
            this.Txt_CopyrightYear.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "کد ISBN:";
            // 
            // Txt_Isbn
            // 
            this.Txt_Isbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Isbn.Location = new System.Drawing.Point(333, 123);
            this.Txt_Isbn.Name = "Txt_Isbn";
            this.Txt_Isbn.Size = new System.Drawing.Size(194, 20);
            this.Txt_Isbn.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "تعداد صفحات:";
            // 
            // Txt_Pages
            // 
            this.Txt_Pages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Pages.Location = new System.Drawing.Point(17, 97);
            this.Txt_Pages.Name = "Txt_Pages";
            this.Txt_Pages.Size = new System.Drawing.Size(189, 20);
            this.Txt_Pages.TabIndex = 37;
            this.Txt_Pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PurchasePrice_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "نویسنده:";
            // 
            // Txt_BookWrite
            // 
            this.Txt_BookWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BookWrite.Location = new System.Drawing.Point(17, 71);
            this.Txt_BookWrite.Name = "Txt_BookWrite";
            this.Txt_BookWrite.Size = new System.Drawing.Size(189, 20);
            this.Txt_BookWrite.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "نام انتشاراتی:";
            // 
            // Txt_Entesharat
            // 
            this.Txt_Entesharat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Entesharat.Location = new System.Drawing.Point(17, 45);
            this.Txt_Entesharat.Name = "Txt_Entesharat";
            this.Txt_Entesharat.Size = new System.Drawing.Size(189, 20);
            this.Txt_Entesharat.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "قیمت خرید:";
            // 
            // Txt_PurchasePrice
            // 
            this.Txt_PurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_PurchasePrice.Location = new System.Drawing.Point(17, 19);
            this.Txt_PurchasePrice.Name = "Txt_PurchasePrice";
            this.Txt_PurchasePrice.Size = new System.Drawing.Size(189, 20);
            this.Txt_PurchasePrice.TabIndex = 31;
            this.Txt_PurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PurchasePrice_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "ملاحظات:";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Notes.Location = new System.Drawing.Point(14, 147);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(515, 43);
            this.Txt_Notes.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "درج کتاب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbx_State
            // 
            this.Cbx_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_State.AutoSize = true;
            this.Cbx_State.Location = new System.Drawing.Point(191, 123);
            this.Cbx_State.Name = "Cbx_State";
            this.Cbx_State.Size = new System.Drawing.Size(15, 14);
            this.Cbx_State.TabIndex = 44;
            this.Cbx_State.UseVisualStyleBackColor = true;
            // 
            // Cmb_BookSubject
            // 
            this.Cmb_BookSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_BookSubject.FormattingEnabled = true;
            this.Cmb_BookSubject.Location = new System.Drawing.Point(333, 71);
            this.Cmb_BookSubject.Name = "Cmb_BookSubject";
            this.Cmb_BookSubject.Size = new System.Drawing.Size(194, 21);
            this.Cmb_BookSubject.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "دسترسی:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "ویرایش کتاب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "حذف کتاب";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "جستجو";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Search.Location = new System.Drawing.Point(18, 407);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(153, 20);
            this.Txt_Search.TabIndex = 50;
            // 
            // G_2
            // 
            this.G_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(260, 395);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(167, 35);
            this.G_2.TabIndex = 51;
            this.G_2.TabStop = false;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(86, 9);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 8;
            this.Btn_OK.Text = "تائید";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(5, 9);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // G_1
            // 
            this.G_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_1.Controls.Add(this.button2);
            this.G_1.Controls.Add(this.button1);
            this.G_1.Controls.Add(this.button4);
            this.G_1.Controls.Add(this.button3);
            this.G_1.Location = new System.Drawing.Point(183, 396);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(368, 36);
            this.G_1.TabIndex = 52;
            this.G_1.TabStop = false;
            // 
            // G_3
            // 
            this.G_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_3.Controls.Add(this.Cmb_BookSubject);
            this.G_3.Controls.Add(this.Cbx_State);
            this.G_3.Controls.Add(this.Txt_Notes);
            this.G_3.Controls.Add(this.label11);
            this.G_3.Controls.Add(this.label3);
            this.G_3.Controls.Add(this.label6);
            this.G_3.Controls.Add(this.label7);
            this.G_3.Controls.Add(this.Txt_Pages);
            this.G_3.Controls.Add(this.label8);
            this.G_3.Controls.Add(this.Txt_BookWrite);
            this.G_3.Controls.Add(this.label9);
            this.G_3.Controls.Add(this.Txt_Entesharat);
            this.G_3.Controls.Add(this.label10);
            this.G_3.Controls.Add(this.Txt_PurchasePrice);
            this.G_3.Controls.Add(this.label5);
            this.G_3.Controls.Add(this.Txt_Isbn);
            this.G_3.Controls.Add(this.label4);
            this.G_3.Controls.Add(this.Txt_CopyrightYear);
            this.G_3.Controls.Add(this.label1);
            this.G_3.Controls.Add(this.Txt_BookTitle);
            this.G_3.Controls.Add(this.label2);
            this.G_3.Controls.Add(this.Txt_BookID);
            this.G_3.Location = new System.Drawing.Point(4, 197);
            this.G_3.Name = "G_3";
            this.G_3.Size = new System.Drawing.Size(612, 196);
            this.G_3.TabIndex = 53;
            this.G_3.TabStop = false;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 436);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Dg_Books);
            this.Controls.Add(this.G_3);
            this.Controls.Add(this.G_1);
            this.Controls.Add(this.G_2);
            this.Name = "frmBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اطلاعات کتب جدید";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Books)).EndInit();
            this.G_2.ResumeLayout(false);
            this.G_1.ResumeLayout(false);
            this.G_3.ResumeLayout(false);
            this.G_3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Books;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_BookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_BookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CopyrightYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Isbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Pages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_BookWrite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Entesharat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_PurchasePrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Cbx_State;
        private System.Windows.Forms.ComboBox Cmb_BookSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox G_1;
        private System.Windows.Forms.GroupBox G_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyrightYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriterN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahYeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicID;

    }
}