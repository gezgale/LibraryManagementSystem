namespace LibraryMembers
{
    partial class frmTamdideozviiat
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
            this.Dg_Tamdid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExprDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTamdid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MemberID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Years = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Tamdid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_Tamdid
            // 
            this.Dg_Tamdid.AllowUserToAddRows = false;
            this.Dg_Tamdid.AllowUserToDeleteRows = false;
            this.Dg_Tamdid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Tamdid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ExprDate,
            this.Column5});
            this.Dg_Tamdid.Location = new System.Drawing.Point(-1, 1);
            this.Dg_Tamdid.Name = "Dg_Tamdid";
            this.Dg_Tamdid.Size = new System.Drawing.Size(556, 216);
            this.Dg_Tamdid.TabIndex = 2;
            this.Dg_Tamdid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Tamdid_CellContentClick);
            this.Dg_Tamdid.SelectionChanged += new System.EventHandler(this.Dg_Tamdid_SelectionChanged);
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
            // btnTamdid
            // 
            this.btnTamdid.Location = new System.Drawing.Point(192, 263);
            this.btnTamdid.Name = "btnTamdid";
            this.btnTamdid.Size = new System.Drawing.Size(152, 23);
            this.btnTamdid.TabIndex = 3;
            this.btnTamdid.Text = "تمدید عضویت";
            this.btnTamdid.UseVisualStyleBackColor = true;
            this.btnTamdid.Click += new System.EventHandler(this.btnTamdid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "کد عضویت:";
            // 
            // Txt_MemberID
            // 
            this.Txt_MemberID.Location = new System.Drawing.Point(328, 234);
            this.Txt_MemberID.Name = "Txt_MemberID";
            this.Txt_MemberID.Size = new System.Drawing.Size(134, 20);
            this.Txt_MemberID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "میزان تمدید (سال):";
            // 
            // Cmb_Years
            // 
            this.Cmb_Years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Years.FormattingEnabled = true;
            this.Cmb_Years.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Cmb_Years.Location = new System.Drawing.Point(65, 233);
            this.Cmb_Years.Name = "Cmb_Years";
            this.Cmb_Years.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Years.TabIndex = 15;
            // 
            // frmTamdideozviiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 292);
            this.Controls.Add(this.Cmb_Years);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_MemberID);
            this.Controls.Add(this.btnTamdid);
            this.Controls.Add(this.Dg_Tamdid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTamdideozviiat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تمدید عضویت اعضا";
            this.Load += new System.EventHandler(this.frmTamdideozviiat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Tamdid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Tamdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExprDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnTamdid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MemberID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Years;
    }
}