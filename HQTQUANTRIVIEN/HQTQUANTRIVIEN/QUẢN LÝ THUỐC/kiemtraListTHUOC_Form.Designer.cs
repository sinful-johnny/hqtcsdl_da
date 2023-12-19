namespace HQTQUANTRIVIEN
{
    partial class kiemtraListTHUOC_Form
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
            this.ttthuoc = new System.Windows.Forms.ListView();
            this.labeldanhsachthuoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(456, 571);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 42);
            this.backButton.TabIndex = 80;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ttthuoc
            // 
            this.ttthuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttthuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ttthuoc.HideSelection = false;
            this.ttthuoc.Location = new System.Drawing.Point(24, 136);
            this.ttthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttthuoc.Name = "ttthuoc";
            this.ttthuoc.Size = new System.Drawing.Size(985, 411);
            this.ttthuoc.TabIndex = 79;
            this.ttthuoc.UseCompatibleStateImageBehavior = false;
            // 
            // labeldanhsachthuoc
            // 
            this.labeldanhsachthuoc.AutoSize = true;
            this.labeldanhsachthuoc.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldanhsachthuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labeldanhsachthuoc.Location = new System.Drawing.Point(385, 24);
            this.labeldanhsachthuoc.Name = "labeldanhsachthuoc";
            this.labeldanhsachthuoc.Size = new System.Drawing.Size(269, 90);
            this.labeldanhsachthuoc.TabIndex = 78;
            this.labeldanhsachthuoc.Text = "DANH SÁCH \r\nTHUỐC";
            this.labeldanhsachthuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kiemtraListTHUOC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 639);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ttthuoc);
            this.Controls.Add(this.labeldanhsachthuoc);
            this.Name = "kiemtraListTHUOC_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kiemtraListTHUOC_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListTHUOC_formClosing);
            this.Load += new System.EventHandler(this.kiemtraListTHUOC_Form_Load);
            this.Shown += new System.EventHandler(this.ListTHUOC_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView ttthuoc;
        private System.Windows.Forms.Label labeldanhsachthuoc;
    }
}