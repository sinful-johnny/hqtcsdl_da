namespace WindowsFormsApp2
{
    partial class KH_DangKi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hoTenBox = new System.Windows.Forms.TextBox();
            this.SDTBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.matKhauBox = new System.Windows.Forms.TextBox();
            this.ngaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.SendRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu";
            // 
            // hoTenBox
            // 
            this.hoTenBox.Location = new System.Drawing.Point(94, 27);
            this.hoTenBox.Name = "hoTenBox";
            this.hoTenBox.Size = new System.Drawing.Size(409, 22);
            this.hoTenBox.TabIndex = 5;
            // 
            // SDTBox
            // 
            this.SDTBox.Location = new System.Drawing.Point(94, 74);
            this.SDTBox.Name = "SDTBox";
            this.SDTBox.Size = new System.Drawing.Size(409, 22);
            this.SDTBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(94, 173);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(409, 22);
            this.emailBox.TabIndex = 7;
            // 
            // matKhauBox
            // 
            this.matKhauBox.Location = new System.Drawing.Point(94, 225);
            this.matKhauBox.Name = "matKhauBox";
            this.matKhauBox.Size = new System.Drawing.Size(409, 22);
            this.matKhauBox.TabIndex = 8;
            // 
            // ngaySinhPicker
            // 
            this.ngaySinhPicker.Location = new System.Drawing.Point(94, 120);
            this.ngaySinhPicker.Name = "ngaySinhPicker";
            this.ngaySinhPicker.Size = new System.Drawing.Size(252, 22);
            this.ngaySinhPicker.TabIndex = 9;
            // 
            // SendRegister
            // 
            this.SendRegister.Location = new System.Drawing.Point(202, 265);
            this.SendRegister.Name = "SendRegister";
            this.SendRegister.Size = new System.Drawing.Size(135, 67);
            this.SendRegister.TabIndex = 10;
            this.SendRegister.Text = "Đăng kí";
            this.SendRegister.UseVisualStyleBackColor = true;
            this.SendRegister.Click += new System.EventHandler(this.SendRegister_Click);
            // 
            // KH_DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 359);
            this.Controls.Add(this.SendRegister);
            this.Controls.Add(this.ngaySinhPicker);
            this.Controls.Add(this.matKhauBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.SDTBox);
            this.Controls.Add(this.hoTenBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KH_DangKi";
            this.Text = "Đăng kí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KH_DangKi_FormClosing);
            this.Shown += new System.EventHandler(this.KH_DangKi_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hoTenBox;
        private System.Windows.Forms.TextBox SDTBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox matKhauBox;
        private System.Windows.Forms.DateTimePicker ngaySinhPicker;
        private System.Windows.Forms.Button SendRegister;
    }
}