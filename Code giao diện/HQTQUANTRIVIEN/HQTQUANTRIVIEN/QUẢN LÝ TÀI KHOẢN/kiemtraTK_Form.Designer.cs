namespace HQTQUANTRIVIEN
{
    partial class kiemtraTK_Form
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
            this.kiemtraTKButton = new System.Windows.Forms.Button();
            this.labelkiemtrataikhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_TK
            // 
            this.ID_TK.AutoSize = true;
            this.ID_TK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ID_TK.Location = new System.Drawing.Point(23, 130);
            this.ID_TK.Name = "ID_TK";
            this.ID_TK.Size = new System.Drawing.Size(114, 23);
            this.ID_TK.TabIndex = 75;
            this.ID_TK.Text = "ID tài khoản";
            // 
            // idtaikhoanBox
            // 
            this.idtaikhoanBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtaikhoanBox.Location = new System.Drawing.Point(27, 171);
            this.idtaikhoanBox.Multiline = true;
            this.idtaikhoanBox.Name = "idtaikhoanBox";
            this.idtaikhoanBox.Size = new System.Drawing.Size(435, 32);
            this.idtaikhoanBox.TabIndex = 74;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(27, 257);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 73;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // kiemtraTKButton
            // 
            this.kiemtraTKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.kiemtraTKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kiemtraTKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kiemtraTKButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiemtraTKButton.ForeColor = System.Drawing.Color.White;
            this.kiemtraTKButton.Location = new System.Drawing.Point(142, 224);
            this.kiemtraTKButton.Name = "kiemtraTKButton";
            this.kiemtraTKButton.Size = new System.Drawing.Size(217, 102);
            this.kiemtraTKButton.TabIndex = 72;
            this.kiemtraTKButton.Text = "Kiểm Tra\r\nTài Khoản";
            this.kiemtraTKButton.UseVisualStyleBackColor = false;
            this.kiemtraTKButton.Click += new System.EventHandler(this.kiemtraTKButton_Click);
            // 
            // labelkiemtrataikhoan
            // 
            this.labelkiemtrataikhoan.AutoSize = true;
            this.labelkiemtrataikhoan.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkiemtrataikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labelkiemtrataikhoan.Location = new System.Drawing.Point(55, 18);
            this.labelkiemtrataikhoan.Name = "labelkiemtrataikhoan";
            this.labelkiemtrataikhoan.Size = new System.Drawing.Size(389, 90);
            this.labelkiemtrataikhoan.TabIndex = 71;
            this.labelkiemtrataikhoan.Text = "TRANG KIỂM TRA \r\nTÀI KHOẢN";
            this.labelkiemtrataikhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kiemtraTK_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 344);
            this.Controls.Add(this.ID_TK);
            this.Controls.Add(this.idtaikhoanBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kiemtraTKButton);
            this.Controls.Add(this.labelkiemtrataikhoan);
            this.Name = "kiemtraTK_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kiemtraTK_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kiemtraTK_formClosing);
            this.Shown += new System.EventHandler(this.kiemtraTK_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_TK;
        private System.Windows.Forms.TextBox idtaikhoanBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button kiemtraTKButton;
        private System.Windows.Forms.Label labelkiemtrataikhoan;
    }
}