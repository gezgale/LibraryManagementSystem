namespace LibraryMembers
{
    partial class frmTahvileketab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExprDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Members = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_BookNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_DeliverDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Zemanat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Vadiee = new System.Windows.Forms.TextBox();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Deliver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.G_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ExprDate,
            this.Column5,
            this.MemberState});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 234);
            this.dataGridView1.TabIndex = 2;
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
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.MemberState.DefaultCellStyle = dataGridViewCellStyle2;
            this.MemberState.HeaderText = "مبلغ ودیعه";
            this.MemberState.Name = "MemberState";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "کد عضویت:";
            // 
            // Cmb_Members
            // 
            this.Cmb_Members.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Members.FormattingEnabled = true;
            this.Cmb_Members.Location = new System.Drawing.Point(311, 240);
            this.Cmb_Members.Name = "Cmb_Members";
            this.Cmb_Members.Size = new System.Drawing.Size(168, 21);
            this.Cmb_Members.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "نام کتاب:";
            // 
            // Cmb_BookNames
            // 
            this.Cmb_BookNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_BookNames.FormattingEnabled = true;
            this.Cmb_BookNames.Location = new System.Drawing.Point(311, 267);
            this.Cmb_BookNames.Name = "Cmb_BookNames";
            this.Cmb_BookNames.Size = new System.Drawing.Size(168, 21);
            this.Cmb_BookNames.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "تاریخ تحویل:";
            // 
            // Txt_DeliverDate
            // 
            this.Txt_DeliverDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_DeliverDate.Location = new System.Drawing.Point(311, 294);
            this.Txt_DeliverDate.MaxLength = 25;
            this.Txt_DeliverDate.Name = "Txt_DeliverDate";
            this.Txt_DeliverDate.Size = new System.Drawing.Size(168, 20);
            this.Txt_DeliverDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "نوع ضمانت:";
            // 
            // Txt_Zemanat
            // 
            this.Txt_Zemanat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Zemanat.Location = new System.Drawing.Point(12, 243);
            this.Txt_Zemanat.MaxLength = 25;
            this.Txt_Zemanat.Name = "Txt_Zemanat";
            this.Txt_Zemanat.Size = new System.Drawing.Size(192, 20);
            this.Txt_Zemanat.TabIndex = 29;
            this.Txt_Zemanat.TextChanged += new System.EventHandler(this.Txt_Zemanat_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "مبلغ ودیعه:";
            // 
            // Txt_Vadiee
            // 
            this.Txt_Vadiee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Vadiee.Location = new System.Drawing.Point(12, 269);
            this.Txt_Vadiee.MaxLength = 25;
            this.Txt_Vadiee.Name = "Txt_Vadiee";
            this.Txt_Vadiee.Size = new System.Drawing.Size(192, 20);
            this.Txt_Vadiee.TabIndex = 31;
            this.Txt_Vadiee.TextChanged += new System.EventHandler(this.Txt_Vadiee_TextChanged);
            this.Txt_Vadiee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // G_2
            // 
            this.G_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(24, 289);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(167, 35);
            this.G_2.TabIndex = 52;
            this.G_2.TabStop = false;
            this.G_2.Visible = false;
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
            // Btn_Deliver
            // 
            this.Btn_Deliver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Deliver.Location = new System.Drawing.Point(16, 298);
            this.Btn_Deliver.Name = "Btn_Deliver";
            this.Btn_Deliver.Size = new System.Drawing.Size(192, 23);
            this.Btn_Deliver.TabIndex = 33;
            this.Btn_Deliver.Text = "ثبت تحویل";
            this.Btn_Deliver.UseVisualStyleBackColor = true;
            this.Btn_Deliver.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTahvileketab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 329);
            this.Controls.Add(this.Btn_Deliver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Vadiee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Zemanat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_DeliverDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_BookNames);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cmb_Members);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.G_2);
            this.Name = "frmTahvileketab";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم تحویل کتاب";
            this.Load += new System.EventHandler(this.frmTahvileketab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.G_2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_BookNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_DeliverDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Zemanat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Vadiee;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExprDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberState;
        private System.Windows.Forms.Button Btn_Deliver;
    }
}