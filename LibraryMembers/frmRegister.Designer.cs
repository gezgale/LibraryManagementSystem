namespace LibraryMembers
{
    partial class frmRegister
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExprDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReg = new System.Windows.Forms.Button();
            this.Txt_MemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Sname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_MemberStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_MemberEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_MemlliCode = new System.Windows.Forms.TextBox();
            this.Cmb_SateMember = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.G_1 = new System.Windows.Forms.GroupBox();
            this.G_3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Members)).BeginInit();
            this.G_2.SuspendLayout();
            this.G_1.SuspendLayout();
            this.G_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dg_Members
            // 
            this.Dg_Members.AllowUserToAddRows = false;
            this.Dg_Members.AllowUserToDeleteRows = false;
            this.Dg_Members.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ExprDate,
            this.Column5,
            this.MemberState,
            this.memberStateID,
            this.Notes,
            this.Dt1,
            this.Dt2});
            this.Dg_Members.Location = new System.Drawing.Point(0, 2);
            this.Dg_Members.Name = "Dg_Members";
            this.Dg_Members.Size = new System.Drawing.Size(579, 202);
            this.Dg_Members.TabIndex = 1;
            this.Dg_Members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Dg_Members.SelectionChanged += new System.EventHandler(this.Dg_Members_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MemBerID";
            this.Column1.HeaderText = "کد عضویت";
            this.Column1.Name = "Column1";
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
            this.Column4.Visible = false;
            // 
            // ExprDate
            // 
            this.ExprDate.DataPropertyName = "ExprDate";
            this.ExprDate.HeaderText = "خاتمه عضویت";
            this.ExprDate.Name = "ExprDate";
            this.ExprDate.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "melliCode";
            this.Column5.HeaderText = "کد ملی";
            this.Column5.Name = "Column5";
            // 
            // MemberState
            // 
            this.MemberState.DataPropertyName = "MemberState";
            this.MemberState.HeaderText = "وضعیت عضویت";
            this.MemberState.Name = "MemberState";
            // 
            // memberStateID
            // 
            this.memberStateID.DataPropertyName = "memberStateID";
            this.memberStateID.HeaderText = "memberStateID";
            this.memberStateID.Name = "memberStateID";
            this.memberStateID.Visible = false;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "سایر توضیحات";
            this.Notes.Name = "Notes";
            // 
            // Dt1
            // 
            this.Dt1.DataPropertyName = "Dt1";
            this.Dt1.HeaderText = "تاریخ ثبت نام";
            this.Dt1.Name = "Dt1";
            // 
            // Dt2
            // 
            this.Dt2.DataPropertyName = "Dt2";
            this.Dt2.HeaderText = "تاریخ انقضاء";
            this.Dt2.Name = "Dt2";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(298, 9);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(92, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "ثبت نام";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Txt_MemberID
            // 
            this.Txt_MemberID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MemberID.Location = new System.Drawing.Point(351, 10);
            this.Txt_MemberID.MaxLength = 50;
            this.Txt_MemberID.Name = "Txt_MemberID";
            this.Txt_MemberID.Size = new System.Drawing.Size(134, 20);
            this.Txt_MemberID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد عضویت:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Name.Location = new System.Drawing.Point(351, 36);
            this.Txt_Name.MaxLength = 50;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(134, 20);
            this.Txt_Name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "نام خانوادگی:";
            // 
            // Txt_Sname
            // 
            this.Txt_Sname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Sname.Location = new System.Drawing.Point(351, 62);
            this.Txt_Sname.MaxLength = 50;
            this.Txt_Sname.Name = "Txt_Sname";
            this.Txt_Sname.Size = new System.Drawing.Size(134, 20);
            this.Txt_Sname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "عضویت:";
            // 
            // Txt_MemberStart
            // 
            this.Txt_MemberStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MemberStart.Location = new System.Drawing.Point(351, 88);
            this.Txt_MemberStart.MaxLength = 10;
            this.Txt_MemberStart.Name = "Txt_MemberStart";
            this.Txt_MemberStart.Size = new System.Drawing.Size(134, 20);
            this.Txt_MemberStart.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "خاتمه عضویت:";
            // 
            // Txt_MemberEnd
            // 
            this.Txt_MemberEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MemberEnd.Location = new System.Drawing.Point(351, 114);
            this.Txt_MemberEnd.MaxLength = 10;
            this.Txt_MemberEnd.Name = "Txt_MemberEnd";
            this.Txt_MemberEnd.Size = new System.Drawing.Size(134, 20);
            this.Txt_MemberEnd.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "کد ملی:";
            // 
            // Txt_MemlliCode
            // 
            this.Txt_MemlliCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MemlliCode.Location = new System.Drawing.Point(47, 10);
            this.Txt_MemlliCode.MaxLength = 10;
            this.Txt_MemlliCode.Name = "Txt_MemlliCode";
            this.Txt_MemlliCode.Size = new System.Drawing.Size(202, 20);
            this.Txt_MemlliCode.TabIndex = 13;
            this.Txt_MemlliCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MemlliCode_KeyPress);
            // 
            // Cmb_SateMember
            // 
            this.Cmb_SateMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_SateMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SateMember.FormattingEnabled = true;
            this.Cmb_SateMember.Location = new System.Drawing.Point(47, 36);
            this.Cmb_SateMember.Name = "Cmb_SateMember";
            this.Cmb_SateMember.Size = new System.Drawing.Size(202, 21);
            this.Cmb_SateMember.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "وضعیت:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ملاحظات:";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Notes.Location = new System.Drawing.Point(7, 63);
            this.Txt_Notes.MaxLength = 240;
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(242, 71);
            this.Txt_Notes.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "جستجو";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // G_2
            // 
            this.G_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(222, 359);
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
            this.G_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.G_1.Controls.Add(this.btnReg);
            this.G_1.Controls.Add(this.button1);
            this.G_1.Controls.Add(this.button3);
            this.G_1.Controls.Add(this.button2);
            this.G_1.Location = new System.Drawing.Point(109, 359);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(394, 35);
            this.G_1.TabIndex = 53;
            this.G_1.TabStop = false;
            // 
            // G_3
            // 
            this.G_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G_3.Controls.Add(this.label9);
            this.G_3.Controls.Add(this.Txt_Notes);
            this.G_3.Controls.Add(this.label8);
            this.G_3.Controls.Add(this.Cmb_SateMember);
            this.G_3.Controls.Add(this.label7);
            this.G_3.Controls.Add(this.Txt_MemlliCode);
            this.G_3.Controls.Add(this.label6);
            this.G_3.Controls.Add(this.Txt_MemberEnd);
            this.G_3.Controls.Add(this.label5);
            this.G_3.Controls.Add(this.Txt_MemberStart);
            this.G_3.Controls.Add(this.label4);
            this.G_3.Controls.Add(this.Txt_Sname);
            this.G_3.Controls.Add(this.label3);
            this.G_3.Controls.Add(this.Txt_Name);
            this.G_3.Controls.Add(this.label2);
            this.G_3.Controls.Add(this.Txt_MemberID);
            this.G_3.Location = new System.Drawing.Point(5, 210);
            this.G_3.Name = "G_3";
            this.G_3.Size = new System.Drawing.Size(567, 138);
            this.G_3.TabIndex = 54;
            this.G_3.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 402);
            this.Controls.Add(this.G_3);
            this.Controls.Add(this.Dg_Members);
            this.Controls.Add(this.G_1);
            this.Controls.Add(this.G_2);
            this.Name = "frmRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت نام اعضا";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Members)).EndInit();
            this.G_2.ResumeLayout(false);
            this.G_1.ResumeLayout(false);
            this.G_3.ResumeLayout(false);
            this.G_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Members;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox Txt_MemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Sname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_MemberStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_MemberEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_MemlliCode;
        private System.Windows.Forms.ComboBox Cmb_SateMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox G_1;
        private System.Windows.Forms.GroupBox G_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExprDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberState;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt2;
    }
}

