namespace LibraryMembers
{
    partial class frmTedadeMojazeTahvil
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_AllowedQuantity = new System.Windows.Forms.TextBox();
            this.Txt_AllowdedDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_FinePerDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "تعداد مجاز کتابهای قابل تحویل:";
            // 
            // Txt_AllowedQuantity
            // 
            this.Txt_AllowedQuantity.Location = new System.Drawing.Point(6, 7);
            this.Txt_AllowedQuantity.MaxLength = 5;
            this.Txt_AllowedQuantity.Name = "Txt_AllowedQuantity";
            this.Txt_AllowedQuantity.Size = new System.Drawing.Size(121, 21);
            this.Txt_AllowedQuantity.TabIndex = 2;
            this.Txt_AllowedQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_AllowedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Txt_AllowdedDays
            // 
            this.Txt_AllowdedDays.Location = new System.Drawing.Point(6, 34);
            this.Txt_AllowdedDays.MaxLength = 5;
            this.Txt_AllowdedDays.Name = "Txt_AllowdedDays";
            this.Txt_AllowdedDays.Size = new System.Drawing.Size(121, 21);
            this.Txt_AllowdedDays.TabIndex = 4;
            this.Txt_AllowdedDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_AllowdedDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "تعداد روزهای مجاز نگهداری کناب:";
            // 
            // Txt_FinePerDay
            // 
            this.Txt_FinePerDay.Location = new System.Drawing.Point(6, 59);
            this.Txt_FinePerDay.MaxLength = 5;
            this.Txt_FinePerDay.Name = "Txt_FinePerDay";
            this.Txt_FinePerDay.Size = new System.Drawing.Size(121, 21);
            this.Txt_FinePerDay.TabIndex = 6;
            this.Txt_FinePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_FinePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "جریمه هر روز دیر کرد:";
            // 
            // frmTedadeMojazeTahvil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 123);
            this.Controls.Add(this.Txt_FinePerDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_AllowdedDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_AllowedQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmTedadeMojazeTahvil";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ویرایش تعداد مجاز تحویل کتاب";
            this.Load += new System.EventHandler(this.frmTedadeMojazeTahvil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_AllowedQuantity;
        private System.Windows.Forms.TextBox Txt_AllowdedDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_FinePerDay;
        private System.Windows.Forms.Label label3;
    }
}