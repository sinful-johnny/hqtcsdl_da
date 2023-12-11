namespace WindowsFormsApp2
{
    partial class KH_SuaTTCaNhan
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
            this.ngaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.hoTenBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ngaySinhPicker
            // 
            this.ngaySinhPicker.Location = new System.Drawing.Point(103, 56);
            this.ngaySinhPicker.Name = "ngaySinhPicker";
            this.ngaySinhPicker.Size = new System.Drawing.Size(252, 22);
            this.ngaySinhPicker.TabIndex = 19;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(103, 84);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(409, 22);
            this.emailBox.TabIndex = 17;
            // 
            // hoTenBox
            // 
            this.hoTenBox.Location = new System.Drawing.Point(103, 28);
            this.hoTenBox.Name = "hoTenBox";
            this.hoTenBox.Size = new System.Drawing.Size(409, 22);
            this.hoTenBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(211, 123);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(144, 49);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // KH_SuaTTCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 195);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ngaySinhPicker);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.hoTenBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KH_SuaTTCaNhan";
            this.Text = "KH_SuaTTCaNhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KH_SuaTTCaNhan_FormClosing);
            this.Load += new System.EventHandler(this.KH_SuaTTCaNhan_Load);
            this.Shown += new System.EventHandler(this.KH_SuaTTCaNhan_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ngaySinhPicker;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox hoTenBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
    }
}