namespace LibraryMembers
{
    partial class frmBedehiPardakht
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dg_State = new System.Windows.Forms.DataGridView();
            this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.G_1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Vadiee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Members = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.G_3 = new System.Windows.Forms.GroupBox();
            this.Dg_Payments = new System.Windows.Forms.DataGridView();
            this.PaymentRowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemBerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_State = new System.Windows.Forms.TextBox();
            this.Txt_DelID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_State)).BeginInit();
            this.G_1.SuspendLayout();
            this.G_2.SuspendLayout();
            this.G_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_State
            // 
            this.Dg_State.AllowUserToAddRows = false;
            this.Dg_State.AllowUserToDeleteRows = false;
            this.Dg_State.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_State.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_State.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelID,
            this.TotalTakhir,
            this.TotalBedehi,
            this.NameSname});
            this.Dg_State.Location = new System.Drawing.Point(1, 1);
            this.Dg_State.Name = "Dg_State";
            this.Dg_State.ReadOnly = true;
            this.Dg_State.Size = new System.Drawing.Size(735, 140);
            this.Dg_State.TabIndex = 0;
            this.Dg_State.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_State_CellClick);
            this.Dg_State.SelectionChanged += new System.EventHandler(this.Dg_State_SelectionChanged_1);
            // 
            // PersonelID
            // 
            this.PersonelID.DataPropertyName = "PersonelID";
            this.PersonelID.HeaderText = "کد عضویت";
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.ReadOnly = true;
            // 
            // TotalTakhir
            // 
            this.TotalTakhir.DataPropertyName = "TotalTakhir";
            dataGridViewCellStyle7.Format = "N0";
            this.TotalTakhir.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalTakhir.HeaderText = "کل تاخیر";
            this.TotalTakhir.Name = "TotalTakhir";
            this.TotalTakhir.ReadOnly = true;
            this.TotalTakhir.Width = 150;
            // 
            // TotalBedehi
            // 
            this.TotalBedehi.DataPropertyName = "TotalBedehi";
            dataGridViewCellStyle8.Format = "N0";
            this.TotalBedehi.DefaultCellStyle = dataGridViewCellStyle8;
            this.TotalBedehi.HeaderText = "کل بدهی";
            this.TotalBedehi.Name = "TotalBedehi";
            this.TotalBedehi.ReadOnly = true;
            this.TotalBedehi.Width = 150;
            // 
            // NameSname
            // 
            this.NameSname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameSname.DataPropertyName = "NameSname";
            this.NameSname.HeaderText = "نام و نام خانوادگی";
            this.NameSname.Name = "NameSname";
            this.NameSname.ReadOnly = true;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Search.Location = new System.Drawing.Point(60, 375);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(238, 20);
            this.Txt_Search.TabIndex = 53;
            // 
            // G_1
            // 
            this.G_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_1.Controls.Add(this.button2);
            this.G_1.Controls.Add(this.button1);
            this.G_1.Controls.Add(this.button4);
            this.G_1.Controls.Add(this.button3);
            this.G_1.Location = new System.Drawing.Point(310, 362);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(368, 36);
            this.G_1.TabIndex = 55;
            this.G_1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "ویرایش پرداخت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "درج پرداخت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "حذف پرداخت";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // G_2
            // 
            this.G_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(387, 363);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(167, 35);
            this.G_2.TabIndex = 54;
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
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "مبلغ پرداختی:";
            // 
            // Txt_Vadiee
            // 
            this.Txt_Vadiee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Vadiee.Location = new System.Drawing.Point(6, 18);
            this.Txt_Vadiee.MaxLength = 9;
            this.Txt_Vadiee.Name = "Txt_Vadiee";
            this.Txt_Vadiee.Size = new System.Drawing.Size(137, 20);
            this.Txt_Vadiee.TabIndex = 58;
            this.Txt_Vadiee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Vadiee_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "کد عضویت:";
            // 
            // Cmb_Members
            // 
            this.Cmb_Members.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Members.FormattingEnabled = true;
            this.Cmb_Members.Location = new System.Drawing.Point(468, 18);
            this.Cmb_Members.Name = "Cmb_Members";
            this.Cmb_Members.Size = new System.Drawing.Size(168, 21);
            this.Cmb_Members.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "تاریخ پرداخت:";
            // 
            // Txt_Date
            // 
            this.Txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Date.Location = new System.Drawing.Point(238, 19);
            this.Txt_Date.MaxLength = 25;
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(131, 20);
            this.Txt_Date.TabIndex = 60;
            // 
            // G_3
            // 
            this.G_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_3.Controls.Add(this.Txt_Date);
            this.G_3.Controls.Add(this.label1);
            this.G_3.Controls.Add(this.Cmb_Members);
            this.G_3.Controls.Add(this.label8);
            this.G_3.Controls.Add(this.label5);
            this.G_3.Controls.Add(this.Txt_Vadiee);
            this.G_3.Location = new System.Drawing.Point(11, 311);
            this.G_3.Name = "G_3";
            this.G_3.Size = new System.Drawing.Size(714, 50);
            this.G_3.TabIndex = 62;
            this.G_3.TabStop = false;
            // 
            // Dg_Payments
            // 
            this.Dg_Payments.AllowUserToAddRows = false;
            this.Dg_Payments.AllowUserToDeleteRows = false;
            this.Dg_Payments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Payments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentRowID,
            this.MemBerID,
            this.DateOfPayment,
            this.PriceOfPayment});
            this.Dg_Payments.Location = new System.Drawing.Point(1, 165);
            this.Dg_Payments.Name = "Dg_Payments";
            this.Dg_Payments.ReadOnly = true;
            this.Dg_Payments.Size = new System.Drawing.Size(735, 145);
            this.Dg_Payments.TabIndex = 63;
            this.Dg_Payments.SelectionChanged += new System.EventHandler(this.Dg_Payments_SelectionChanged);
            // 
            // PaymentRowID
            // 
            this.PaymentRowID.DataPropertyName = "PaymentRowID";
            this.PaymentRowID.HeaderText = "کد پرداخت";
            this.PaymentRowID.Name = "PaymentRowID";
            this.PaymentRowID.ReadOnly = true;
            // 
            // MemBerID
            // 
            this.MemBerID.DataPropertyName = "MemBerID";
            this.MemBerID.HeaderText = "کد عضویت";
            this.MemBerID.Name = "MemBerID";
            this.MemBerID.ReadOnly = true;
            this.MemBerID.Visible = false;
            // 
            // DateOfPayment
            // 
            this.DateOfPayment.DataPropertyName = "DateOfPayment";
            this.DateOfPayment.HeaderText = "تاریخ پرداخت";
            this.DateOfPayment.Name = "DateOfPayment";
            this.DateOfPayment.ReadOnly = true;
            this.DateOfPayment.Width = 120;
            // 
            // PriceOfPayment
            // 
            this.PriceOfPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceOfPayment.DataPropertyName = "PriceOfPayment";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.PriceOfPayment.DefaultCellStyle = dataGridViewCellStyle9;
            this.PriceOfPayment.HeaderText = "مبلغ پرداختی";
            this.PriceOfPayment.Name = "PriceOfPayment";
            this.PriceOfPayment.ReadOnly = true;
            // 
            // Txt_State
            // 
            this.Txt_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_State.Location = new System.Drawing.Point(1, 143);
            this.Txt_State.Name = "Txt_State";
            this.Txt_State.Size = new System.Drawing.Size(735, 20);
            this.Txt_State.TabIndex = 64;
            // 
            // Txt_DelID
            // 
            this.Txt_DelID.Location = new System.Drawing.Point(-46, 372);
            this.Txt_DelID.Name = "Txt_DelID";
            this.Txt_DelID.Size = new System.Drawing.Size(37, 20);
            this.Txt_DelID.TabIndex = 65;
            // 
            // frmBedehiPardakht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 403);
            this.Controls.Add(this.Txt_DelID);
            this.Controls.Add(this.Txt_State);
            this.Controls.Add(this.Dg_Payments);
            this.Controls.Add(this.G_3);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Dg_State);
            this.Controls.Add(this.G_1);
            this.Controls.Add(this.G_2);
            this.Name = "frmBedehiPardakht";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بدهی و پرداخت اعضا";
            this.Load += new System.EventHandler(this.frmBedehiPardakht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_State)).EndInit();
            this.G_1.ResumeLayout(false);
            this.G_2.ResumeLayout(false);
            this.G_3.ResumeLayout(false);
            this.G_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_State;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.GroupBox G_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Vadiee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.GroupBox G_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSname;
        private System.Windows.Forms.DataGridView Dg_Payments;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentRowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemBerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfPayment;
        private System.Windows.Forms.TextBox Txt_State;
        private System.Windows.Forms.TextBox Txt_DelID;
    }
}