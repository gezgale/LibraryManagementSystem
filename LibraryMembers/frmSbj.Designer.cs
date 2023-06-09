namespace LibraryMembers
{
    partial class frmSbj
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
            this.Dg_BookSubjects = new System.Windows.Forms.DataGridView();
            this.SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_SubjectName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_SubjectID = new System.Windows.Forms.TextBox();
            this.G_1 = new System.Windows.Forms.GroupBox();
            this.G_2 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.G_3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BookSubjects)).BeginInit();
            this.G_1.SuspendLayout();
            this.G_2.SuspendLayout();
            this.G_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dg_BookSubjects
            // 
            this.Dg_BookSubjects.AllowUserToAddRows = false;
            this.Dg_BookSubjects.AllowUserToDeleteRows = false;
            this.Dg_BookSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_BookSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_BookSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubId,
            this.Subject});
            this.Dg_BookSubjects.Location = new System.Drawing.Point(0, 2);
            this.Dg_BookSubjects.Name = "Dg_BookSubjects";
            this.Dg_BookSubjects.ReadOnly = true;
            this.Dg_BookSubjects.Size = new System.Drawing.Size(363, 116);
            this.Dg_BookSubjects.TabIndex = 2;
            this.Dg_BookSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_BookSubjects_CellClick);
            this.Dg_BookSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_BookSubjects_CellContentClick);
            this.Dg_BookSubjects.SelectionChanged += new System.EventHandler(this.Dg_BookSubjects_SelectionChanged);
            // 
            // SubId
            // 
            this.SubId.DataPropertyName = "SubId";
            this.SubId.HeaderText = "کد موضوع";
            this.SubId.Name = "SubId";
            this.SubId.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "موضوعات کتابها";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 160;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "اضافه کردن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "موضوع جدید:";
            // 
            // Txt_SubjectName
            // 
            this.Txt_SubjectName.Location = new System.Drawing.Point(6, 14);
            this.Txt_SubjectName.Name = "Txt_SubjectName";
            this.Txt_SubjectName.Size = new System.Drawing.Size(88, 20);
            this.Txt_SubjectName.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "جستجو";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "کد موضوع:";
            // 
            // Txt_SubjectID
            // 
            this.Txt_SubjectID.Location = new System.Drawing.Point(172, 14);
            this.Txt_SubjectID.Name = "Txt_SubjectID";
            this.Txt_SubjectID.Size = new System.Drawing.Size(101, 20);
            this.Txt_SubjectID.TabIndex = 10;
            // 
            // G_1
            // 
            this.G_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_1.Controls.Add(this.button1);
            this.G_1.Controls.Add(this.button2);
            this.G_1.Controls.Add(this.button3);
            this.G_1.Controls.Add(this.button4);
            this.G_1.Location = new System.Drawing.Point(14, 167);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(333, 38);
            this.G_1.TabIndex = 12;
            this.G_1.TabStop = false;
            // 
            // G_2
            // 
            this.G_2.Controls.Add(this.Btn_OK);
            this.G_2.Controls.Add(this.Btn_Cancel);
            this.G_2.Location = new System.Drawing.Point(95, 170);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(167, 35);
            this.G_2.TabIndex = 13;
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
            // G_3
            // 
            this.G_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_3.Controls.Add(this.Txt_SubjectName);
            this.G_3.Controls.Add(this.label2);
            this.G_3.Controls.Add(this.label1);
            this.G_3.Controls.Add(this.Txt_SubjectID);
            this.G_3.Location = new System.Drawing.Point(7, 121);
            this.G_3.Name = "G_3";
            this.G_3.Size = new System.Drawing.Size(344, 40);
            this.G_3.TabIndex = 14;
            this.G_3.TabStop = false;
            // 
            // frmSbj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 214);
            this.Controls.Add(this.G_3);
            this.Controls.Add(this.Dg_BookSubjects);
            this.Controls.Add(this.G_2);
            this.Controls.Add(this.G_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSbj";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "درج موضوعات جدید";
            this.Load += new System.EventHandler(this.frmSbj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BookSubjects)).EndInit();
            this.G_1.ResumeLayout(false);
            this.G_2.ResumeLayout(false);
            this.G_3.ResumeLayout(false);
            this.G_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_BookSubjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_SubjectID;
        private System.Windows.Forms.GroupBox G_1;
        private System.Windows.Forms.GroupBox G_2;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.GroupBox G_3;
    }
}