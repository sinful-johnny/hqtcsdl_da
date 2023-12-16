namespace HQTQUANTRIVIEN
{
    partial class kiemtraListTK_Form
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
            this.backButton = new System.Windows.Forms.Button();
            this.ttcanhan = new System.Windows.Forms.ListView();
            this.labeldanhsachtaikhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(443, 585);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 77;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ttcanhan
            // 
            this.ttcanhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttcanhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ttcanhan.HideSelection = false;
            this.ttcanhan.Location = new System.Drawing.Point(34, 145);
            this.ttcanhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttcanhan.Name = "ttcanhan";
            this.ttcanhan.Size = new System.Drawing.Size(908, 411);
            this.ttcanhan.TabIndex = 76;
            this.ttcanhan.UseCompatibleStateImageBehavior = false;
            // 
            // labeldanhsachtaikhoan
            // 
            this.labeldanhsachtaikhoan.AutoSize = true;
            this.labeldanhsachtaikhoan.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldanhsachtaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labeldanhsachtaikhoan.Location = new System.Drawing.Point(313, 25);
            this.labeldanhsachtaikhoan.Name = "labeldanhsachtaikhoan";
            this.labeldanhsachtaikhoan.Size = new System.Drawing.Size(366, 90);
            this.labeldanhsachtaikhoan.TabIndex = 75;
            this.labeldanhsachtaikhoan.Text = "DANH SÁCH CÁC \r\nTÀI KHOẢN";
            this.labeldanhsachtaikhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kiemtraListTK_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 650);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ttcanhan);
            this.Controls.Add(this.labeldanhsachtaikhoan);
            this.Name = "kiemtraListTK_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kiemtraListTK_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListTK_formClosing);
            this.Load += new System.EventHandler(this.KTList_formLoading);
            this.Shown += new System.EventHandler(this.ListTK_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView ttcanhan;
        private System.Windows.Forms.Label labeldanhsachtaikhoan;
    }
}