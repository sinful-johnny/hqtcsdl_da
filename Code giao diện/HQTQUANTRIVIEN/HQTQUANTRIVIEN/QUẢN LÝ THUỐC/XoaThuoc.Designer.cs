namespace HQTQUANTRIVIEN
{
    partial class XoaThuoc
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
            this.ID_THUOC = new System.Windows.Forms.Label();
            this.idthuocBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.khoaTHUOCButton = new System.Windows.Forms.Button();
            this.labelxoathuoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_THUOC
            // 
            this.ID_THUOC.AutoSize = true;
            this.ID_THUOC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_THUOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ID_THUOC.Location = new System.Drawing.Point(16, 112);
            this.ID_THUOC.Name = "ID_THUOC";
            this.ID_THUOC.Size = new System.Drawing.Size(82, 23);
            this.ID_THUOC.TabIndex = 86;
            this.ID_THUOC.Text = "ID thuốc";
            // 
            // idthuocBox
            // 
            this.idthuocBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idthuocBox.Location = new System.Drawing.Point(20, 153);
            this.idthuocBox.Multiline = true;
            this.idthuocBox.Name = "idthuocBox";
            this.idthuocBox.Size = new System.Drawing.Size(486, 32);
            this.idthuocBox.TabIndex = 85;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(37, 233);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 84;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // khoaTHUOCButton
            // 
            this.khoaTHUOCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.khoaTHUOCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.khoaTHUOCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.khoaTHUOCButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoaTHUOCButton.ForeColor = System.Drawing.Color.White;
            this.khoaTHUOCButton.Location = new System.Drawing.Point(161, 209);
            this.khoaTHUOCButton.Name = "khoaTHUOCButton";
            this.khoaTHUOCButton.Size = new System.Drawing.Size(186, 85);
            this.khoaTHUOCButton.TabIndex = 83;
            this.khoaTHUOCButton.Text = "Xóa thuốc";
            this.khoaTHUOCButton.UseVisualStyleBackColor = false;
            this.khoaTHUOCButton.Click += new System.EventHandler(this.khoaTHUOCButton_Click);
            // 
            // labelxoathuoc
            // 
            this.labelxoathuoc.AutoSize = true;
            this.labelxoathuoc.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxoathuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labelxoathuoc.Location = new System.Drawing.Point(122, 9);
            this.labelxoathuoc.Name = "labelxoathuoc";
            this.labelxoathuoc.Size = new System.Drawing.Size(272, 90);
            this.labelxoathuoc.TabIndex = 82;
            this.labelxoathuoc.Text = "TRANG XÓA \r\nTHUỐC";
            this.labelxoathuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XoaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 327);
            this.Controls.Add(this.ID_THUOC);
            this.Controls.Add(this.idthuocBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.khoaTHUOCButton);
            this.Controls.Add(this.labelxoathuoc);
            this.Name = "XoaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaThuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.khoaTHUOC_formClosing);
            this.Shown += new System.EventHandler(this.xoaTHUOC_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID_THUOC;
        private System.Windows.Forms.TextBox idthuocBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button khoaTHUOCButton;
        private System.Windows.Forms.Label labelxoathuoc;
    }
}