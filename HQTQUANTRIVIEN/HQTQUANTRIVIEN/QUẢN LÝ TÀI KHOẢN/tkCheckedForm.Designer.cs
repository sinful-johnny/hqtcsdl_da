namespace HQTQUANTRIVIEN
{
    partial class tkCheckedForm
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
            this.labelkiemtrataikhoan = new System.Windows.Forms.Label();
            this.ttcanhan = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelkiemtrataikhoan
            // 
            this.labelkiemtrataikhoan.AutoSize = true;
            this.labelkiemtrataikhoan.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkiemtrataikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labelkiemtrataikhoan.Location = new System.Drawing.Point(174, 9);
            this.labelkiemtrataikhoan.Name = "labelkiemtrataikhoan";
            this.labelkiemtrataikhoan.Size = new System.Drawing.Size(466, 45);
            this.labelkiemtrataikhoan.TabIndex = 72;
            this.labelkiemtrataikhoan.Text = "KIỂM TRA TÀI KHOẢN";
            this.labelkiemtrataikhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ttcanhan
            // 
            this.ttcanhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttcanhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ttcanhan.HideSelection = false;
            this.ttcanhan.Location = new System.Drawing.Point(25, 85);
            this.ttcanhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttcanhan.Name = "ttcanhan";
            this.ttcanhan.Size = new System.Drawing.Size(772, 101);
            this.ttcanhan.TabIndex = 73;
            this.ttcanhan.UseCompatibleStateImageBehavior = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(350, 193);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tkCheckedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 253);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ttcanhan);
            this.Controls.Add(this.labelkiemtrataikhoan);
            this.Name = "tkCheckedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tkCheckedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TKChecked_formClosing);
            this.Load += new System.EventHandler(this.TKChecked_formLoading);
            this.Shown += new System.EventHandler(this.TKChecked_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkiemtrataikhoan;
        private System.Windows.Forms.ListView ttcanhan;
        private System.Windows.Forms.Button backButton;
    }
}