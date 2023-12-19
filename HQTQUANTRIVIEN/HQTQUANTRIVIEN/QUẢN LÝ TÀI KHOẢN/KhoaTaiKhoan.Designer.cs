namespace HQTQUANTRIVIEN
{
    partial class KhoaTaiKhoan
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
            this.ID_TK = new System.Windows.Forms.Label();
            this.idtaikhoanBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.khoaTKButton = new System.Windows.Forms.Button();
            this.labelkhoataikhoan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_TK
            // 
            this.ID_TK.AutoSize = true;
            this.ID_TK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ID_TK.Location = new System.Drawing.Point(112, 112);
            this.ID_TK.Name = "ID_TK";
            this.ID_TK.Size = new System.Drawing.Size(114, 23);
            this.ID_TK.TabIndex = 80;
            this.ID_TK.Text = "ID tài khoản";
            // 
            // idtaikhoanBox
            // 
            this.idtaikhoanBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtaikhoanBox.Location = new System.Drawing.Point(116, 153);
            this.idtaikhoanBox.Multiline = true;
            this.idtaikhoanBox.Name = "idtaikhoanBox";
            this.idtaikhoanBox.Size = new System.Drawing.Size(486, 32);
            this.idtaikhoanBox.TabIndex = 79;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(25, 267);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 78;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // khoaTKButton
            // 
            this.khoaTKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.khoaTKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.khoaTKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.khoaTKButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoaTKButton.ForeColor = System.Drawing.Color.White;
            this.khoaTKButton.Location = new System.Drawing.Point(136, 224);
            this.khoaTKButton.Name = "khoaTKButton";
            this.khoaTKButton.Size = new System.Drawing.Size(217, 102);
            this.khoaTKButton.TabIndex = 77;
            this.khoaTKButton.Text = "Khóa\r\nTài Khoản";
            this.khoaTKButton.UseVisualStyleBackColor = false;
            this.khoaTKButton.Click += new System.EventHandler(this.khoaTKButton_Click);
            // 
            // labelkhoataikhoan
            // 
            this.labelkhoataikhoan.AutoSize = true;
            this.labelkhoataikhoan.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkhoataikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labelkhoataikhoan.Location = new System.Drawing.Point(173, 9);
            this.labelkhoataikhoan.Name = "labelkhoataikhoan";
            this.labelkhoataikhoan.Size = new System.Drawing.Size(305, 90);
            this.labelkhoataikhoan.TabIndex = 76;
            this.labelkhoataikhoan.Text = "TRANG KHÓA \r\nTÀI KHOẢN";
            this.labelkhoataikhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 102);
            this.button1.TabIndex = 81;
            this.button1.Text = "Mở Khóa\r\nTài Khoản";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.mokhoaTKButton_Click);
            // 
            // KhoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_TK);
            this.Controls.Add(this.idtaikhoanBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.khoaTKButton);
            this.Controls.Add(this.labelkhoataikhoan);
            this.Name = "KhoaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoKhoaTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.khoaTK_formClosing);
            this.Shown += new System.EventHandler(this.khoaTK_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_TK;
        private System.Windows.Forms.TextBox idtaikhoanBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button khoaTKButton;
        private System.Windows.Forms.Label labelkhoataikhoan;
        private System.Windows.Forms.Button button1;
    }
}