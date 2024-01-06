namespace HQTQUANTRIVIEN
{
    partial class UIHome
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
            this.labeltrangchu = new System.Windows.Forms.Label();
            this.matkhauLabel = new System.Windows.Forms.Label();
            this.matkhauBox = new System.Windows.Forms.TextBox();
            this.sdtlabel = new System.Windows.Forms.Label();
            this.sdtBox = new System.Windows.Forms.TextBox();
            this.dangnhapButton = new System.Windows.Forms.Button();
            this.dangkyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // labeltrangchu
            // 
            this.labeltrangchu.AutoSize = true;
            this.labeltrangchu.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrangchu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labeltrangchu.Location = new System.Drawing.Point(30, 31);
            this.labeltrangchu.Name = "labeltrangchu";
            this.labeltrangchu.Size = new System.Drawing.Size(204, 45);
            this.labeltrangchu.TabIndex = 5;
            this.labeltrangchu.Text = "Trang Chủ";
            this.labeltrangchu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // matkhauLabel
            // 
            this.matkhauLabel.AutoSize = true;
            this.matkhauLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhauLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.matkhauLabel.Location = new System.Drawing.Point(34, 201);
            this.matkhauLabel.Name = "matkhauLabel";
            this.matkhauLabel.Size = new System.Drawing.Size(94, 23);
            this.matkhauLabel.TabIndex = 9;
            this.matkhauLabel.Text = "Mật Khẩu";
            // 
            // matkhauBox
            // 
            this.matkhauBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhauBox.Location = new System.Drawing.Point(38, 242);
            this.matkhauBox.Multiline = true;
            this.matkhauBox.Name = "matkhauBox";
            this.matkhauBox.Size = new System.Drawing.Size(302, 32);
            this.matkhauBox.TabIndex = 8;
            this.matkhauBox.Text = "Nhập mật khẩu";
            this.matkhauBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.matkhauBox_MouseClick);
            this.matkhauBox.Enter += new System.EventHandler(this.matkhauBox_Enter);
            this.matkhauBox.Leave += new System.EventHandler(this.matkhauBox_Leave);
            // 
            // sdtlabel
            // 
            this.sdtlabel.AutoSize = true;
            this.sdtlabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.sdtlabel.Location = new System.Drawing.Point(34, 106);
            this.sdtlabel.Name = "sdtlabel";
            this.sdtlabel.Size = new System.Drawing.Size(118, 23);
            this.sdtlabel.TabIndex = 7;
            this.sdtlabel.Text = "Số điện thoại";
            // 
            // sdtBox
            // 
            this.sdtBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtBox.Location = new System.Drawing.Point(38, 147);
            this.sdtBox.Multiline = true;
            this.sdtBox.Name = "sdtBox";
            this.sdtBox.Size = new System.Drawing.Size(302, 32);
            this.sdtBox.TabIndex = 6;
            this.sdtBox.Text = "Nhập số điện thoại";
            this.sdtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sdtBox_MouseClick);
            this.sdtBox.Leave += new System.EventHandler(this.sdtBox_Leave);
            // 
            // dangnhapButton
            // 
            this.dangnhapButton.BackColor = System.Drawing.Color.White;
            this.dangnhapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangnhapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.dangnhapButton.Location = new System.Drawing.Point(38, 344);
            this.dangnhapButton.Name = "dangnhapButton";
            this.dangnhapButton.Size = new System.Drawing.Size(143, 47);
            this.dangnhapButton.TabIndex = 15;
            this.dangnhapButton.Text = "Đăng Nhập";
            this.dangnhapButton.UseVisualStyleBackColor = false;
            this.dangnhapButton.Click += new System.EventHandler(this.dangnhapButton_Click);
            // 
            // dangkyButton
            // 
            this.dangkyButton.BackColor = System.Drawing.Color.White;
            this.dangkyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangkyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangkyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangkyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.dangkyButton.Location = new System.Drawing.Point(219, 344);
            this.dangkyButton.Name = "dangkyButton";
            this.dangkyButton.Size = new System.Drawing.Size(121, 47);
            this.dangkyButton.TabIndex = 16;
            this.dangkyButton.Text = "Đăng Ký";
            this.dangkyButton.UseVisualStyleBackColor = false;
            this.dangkyButton.Click += new System.EventHandler(this.trangdangky_Click);
            // 
            // UIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 438);
            this.Controls.Add(this.dangkyButton);
            this.Controls.Add(this.dangnhapButton);
            this.Controls.Add(this.matkhauLabel);
            this.Controls.Add(this.matkhauBox);
            this.Controls.Add(this.sdtlabel);
            this.Controls.Add(this.sdtBox);
            this.Controls.Add(this.labeltrangchu);
            this.Controls.Add(this.label1);
            this.Name = "UIHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qtv_formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltrangchu;
        private System.Windows.Forms.Label matkhauLabel;
        private System.Windows.Forms.TextBox matkhauBox;
        private System.Windows.Forms.Label sdtlabel;
        private System.Windows.Forms.TextBox sdtBox;
        private System.Windows.Forms.Button dangnhapButton;
        private System.Windows.Forms.Button dangkyButton;
    }
}