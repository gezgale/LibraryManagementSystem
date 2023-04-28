namespace LibraryMembers
{
    partial class frmLaghveoviiat
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
            this.Dg_Members = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MemberID = new System.Windows.Forms.TextBox();
            this.btnCancelmem = new System.Windows.Forms.Button();
            this.Rbtn_Members = new System.Windows.Forms.RadioButton();
            this.Rbtn_NoState = new System.Windows.Forms.RadioButton();
            this.MemBerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExprDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_Members
            // 
            this.Dg_Members.AllowUserToAddRows = false;
            this.Dg_Members.AllowUserToDeleteRows = false;
            this.Dg_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemBerID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ExprDate,
            this.Column5,
            this.Column6});
            this.Dg_Members.Location = new System.Drawing.Point(1, 2);
            this.Dg_Members.Name = "Dg_Members";
            this.Dg_Members.Size = new System.Drawing.Size(552, 244);
            this.Dg_Members.TabIndex = 3;
            this.Dg_Members.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Members_CellClick);
            this.Dg_Members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Dg_Members.SelectionChanged += new System.EventHandler(this.Dg_Members_SelectionChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "وضعیت:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "کد عضویت:";
            // 
            // Txt_MemberID
            // 
            this.Txt_MemberID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MemberID.Enabled = false;
            this.Txt_MemberID.Location = new System.Drawing.Point(317, 255);
            this.Txt_MemberID.Name = "Txt_MemberID";
            this.Txt_MemberID.Size = new System.Drawing.Size(134, 20);
            this.Txt_MemberID.TabIndex = 19;
            // 
            // btnCancelmem
            // 
            this.btnCancelmem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelmem.Location = new System.Drawing.Point(404, 281);
            this.btnCancelmem.Name = "btnCancelmem";
            this.btnCancelmem.Size = new System.Drawing.Size(120, 23);
            this.btnCancelmem.TabIndex = 21;
            this.btnCancelmem.Text = "ثبت";
            this.btnCancelmem.UseVisualStyleBackColor = true;
            this.btnCancelmem.Click += new System.EventHandler(this.btnCancelmem_Click);
            // 
            // Rbtn_Members
            // 
            this.Rbtn_Members.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbtn_Members.AutoSize = true;
            this.Rbtn_Members.Checked = true;
            this.Rbtn_Members.Location = new System.Drawing.Point(205, 279);
            this.Rbtn_Members.Name = "Rbtn_Members";
            this.Rbtn_Members.Size = new System.Drawing.Size(113, 17);
            this.Rbtn_Members.TabIndex = 22;
            this.Rbtn_Members.TabStop = true;
            this.Rbtn_Members.Text = "نمایش اعضای فعال";
            this.Rbtn_Members.UseVisualStyleBackColor = true;
            this.Rbtn_Members.CheckedChanged += new System.EventHandler(this.Rbtn_Members_CheckedChanged);
            // 
            // Rbtn_NoState
            // 
            this.Rbtn_NoState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbtn_NoState.AutoSize = true;
            this.Rbtn_NoState.Location = new System.Drawing.Point(56, 279);
            this.Rbtn_NoState.Name = "Rbtn_NoState";
            this.Rbtn_NoState.Size = new System.Drawing.Size(132, 17);
            this.Rbtn_NoState.TabIndex = 23;
            this.Rbtn_NoState.Text = "نمایش اعضای غیر فعال";
            this.Rbtn_NoState.UseVisualStyleBackColor = true;
            this.Rbtn_NoState.CheckedChanged += new System.EventHandler(this.Rbtn_Members_CheckedChanged);
            // 
            // MemBerID
            // 
            this.MemBerID.DataPropertyName = "MemBerID";
            this.MemBerID.HeaderText = "کد عضویت";
            this.MemBerID.Name = "MemBerID";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sname";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RegDate";
            this.Column4.HeaderText = "تاریخ عضویت";
            this.Column4.Name = "Column4";
            // 
            // ExprDate
            // 
            this.ExprDate.DataPropertyName = "ExprDate";
            this.ExprDate.HeaderText = "خاتمه عضویت";
            this.ExprDate.Name = "ExprDate";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "melliCode";
            this.Column5.HeaderText = "کد ملی";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "memberState";
            this.Column6.HeaderText = "وضعیت عضویت";
            this.Column6.Name = "Column6";
            // 
            // frmLaghveoviiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 315);
            this.Controls.Add(this.Rbtn_NoState);
            this.Controls.Add(this.Rbtn_Members);
            this.Controls.Add(this.btnCancelmem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_MemberID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Dg_Members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLaghveoviiat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم لغو عضویت";
            this.Load += new System.EventHandler(this.frmLaghveoviiat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Members;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MemberID;
        private System.Windows.Forms.Button btnCancelmem;
        private System.Windows.Forms.RadioButton Rbtn_Members;
        private System.Windows.Forms.RadioButton Rbtn_NoState;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemBerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExprDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}