namespace LibraryMembers
{
    partial class frmBazgashteketab
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
            this.Dg_DeliveredBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_GetDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_BooksID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Members = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ReturnDate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExprDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.G_1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_DeliveredBooks)).BeginInit();
            this.G_2.SuspendLayout();
            this.G_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dg_DeliveredBooks
            // 
            this.Dg_DeliveredBooks.AllowUserToAddRows = false;
            this.Dg_DeliveredBooks.AllowUserToDeleteRows = false;
            this.Dg_DeliveredBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_DeliveredBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_DeliveredBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ExprDate,
            this.Column5,
            this.MemberState,
            this.BookID});
            this.Dg_DeliveredBooks.Location = new System.Drawing.Point(-1, 2);
            this.Dg_DeliveredBooks.Name = "Dg_DeliveredBooks";
            this.Dg_DeliveredBooks.Size = new System.Drawing.Size(576, 204);
            this.Dg_DeliveredBooks.TabIndex = 3;
            this.Dg_DeliveredBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_DeliveredBooks_CellClick);
            this.Dg_DeliveredBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_DeliveredBooks_CellContentClick);
            this.Dg_DeliveredBooks.SelectionChanged += new System.EventHandler(this.Dg_DeliveredBooks_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "تاریخ تحویل:";
            // 
            // Txt_GetDate
            // 
            this.Txt_GetDate.Location = new System.Drawing.Point(12, 212);
            this.Txt_GetDate.MaxLength = 25;
            this.Txt_GetDate.Name = "Txt_GetDate";
            this.Txt_GetDate.Size = new System.Drawing.Size(159, 20);
            this.Txt_GetDate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "نام کتاب:";
            // 
            // Cmb_BooksID
            // 
            this.Cmb_BooksID.FormattingEnabled = true;
            this.Cmb_BooksID.Location = new System.Drawing.Point(312, 243);
            this.Cmb_BooksID.Name = "Cmb_BooksID";
            this.Cmb_BooksID.Size = new System.Drawing.Size(159, 21);
            this.Cmb_BooksID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "کد عضویت:";
            // 
            // Cmb_Members
            // 
            this.Cmb_Members.FormattingEnabled = true;
            this.Cmb_Members.Location = new System.Drawing.Point(312, 216);
            this.Cmb_Members.Name = "Cmb_Members";
            this.Cmb_Members.Size = new System.Drawing.Size(159, 21);
            this.Cmb_Members.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "ثبت بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "تاریخ بازگشت:";
            // 
            // Txt_ReturnDate
            // 
            this.Txt_ReturnDate.Location = new System.Drawing.Point(12, 239);
            this.Txt_ReturnDate.MaxLength = 25;
            this.Txt_ReturnDate.Name = "Txt_ReturnDate";
            this.Txt_ReturnDate.Size = new System.Drawing.Size(159, 20);
            this.Txt_ReturnDate.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "جستجو";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Search.Location = new System.Drawing.Point(12, 270);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(120, 20);
            this.Txt_Search.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MemBerID";
            this.Column1.HeaderText = "کد عضویت";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EXPR1";
            this.Column2.HeaderText = "نام و نام خانوادگی";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Title";
            this.Column3.HeaderText = "نام کتاب";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateDeli";
            this.Column4.HeaderText = "تاریخ تحویل کتاب";
            this.Column4.Name = "Column4";
            // 
            // ExprDate
            // 
            this.ExprDate.DataPropertyName = "Subject";
            this.ExprDate.HeaderText = "موضوع کتاب";
            this.ExprDate.Name = "ExprDate";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "zemanat";
            this.Column5.HeaderText = "نوع ضمانت";
            this.Column5.Name = "Column5";
            // 
            // MemberState
            // 
            this.MemberState.DataPropertyName = "Mablagh";
            this.MemberState.HeaderText = "مبلغ ودیعه";
            this.MemberState.Name = "MemberState";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // G_2
            // 
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(259, 262);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(167, 35);
            this.G_2.TabIndex = 52;
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
            this.G_1.Controls.Add(this.button4);
            this.G_1.Controls.Add(this.button1);
            this.G_1.Location = new System.Drawing.Point(145, 260);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(421, 36);
            this.G_1.TabIndex = 53;
            this.G_1.TabStop = false;
            // 
            // frmBazgashteketab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 342);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_ReturnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_GetDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_BooksID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cmb_Members);
            this.Controls.Add(this.Dg_DeliveredBooks);
            this.Controls.Add(this.G_1);
            this.Controls.Add(this.G_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBazgashteketab";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت بازگشت کتابها";
            this.Load += new System.EventHandler(this.frmBazgashteketab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_DeliveredBooks)).EndInit();
            this.G_2.ResumeLayout(false);
            this.G_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_DeliveredBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_GetDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_BooksID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Members;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ReturnDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExprDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberState;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox G_1;

    }
}