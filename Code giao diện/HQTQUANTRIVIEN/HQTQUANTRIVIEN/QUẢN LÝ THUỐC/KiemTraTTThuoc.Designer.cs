namespace HQTQUANTRIVIEN
{
    partial class KiemTraTTThuoc
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
            this.kiemtraTHUOCButton = new System.Windows.Forms.Button();
            this.labelkiemthuoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_THUOC
            // 
            this.ID_THUOC.AutoSize = true;
            this.ID_THUOC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_THUOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.ID_THUOC.Location = new System.Drawing.Point(23, 130);
            this.ID_THUOC.Name = "ID_THUOC";
            this.ID_THUOC.Size = new System.Drawing.Size(82, 23);
            this.ID_THUOC.TabIndex = 80;
            this.ID_THUOC.Text = "ID thuốc";
            // 
            // idthuocBox
            // 
            this.idthuocBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idthuocBox.Location = new System.Drawing.Point(27, 171);
            this.idthuocBox.Multiline = true;
            this.idthuocBox.Name = "idthuocBox";
            this.idthuocBox.Size = new System.Drawing.Size(435, 32);
            this.idthuocBox.TabIndex = 79;
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
            this.backButton.TabIndex = 78;
            this.backButton.Text = "Trở về";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // kiemtraTHUOCButton
            // 
            this.kiemtraTHUOCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.kiemtraTHUOCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kiemtraTHUOCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kiemtraTHUOCButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiemtraTHUOCButton.ForeColor = System.Drawing.Color.White;
            this.kiemtraTHUOCButton.Location = new System.Drawing.Point(142, 224);
            this.kiemtraTHUOCButton.Name = "kiemtraTHUOCButton";
            this.kiemtraTHUOCButton.Size = new System.Drawing.Size(217, 102);
            this.kiemtraTHUOCButton.TabIndex = 77;
            this.kiemtraTHUOCButton.Text = "Kiểm Tra\r\nThuốc";
            this.kiemtraTHUOCButton.UseVisualStyleBackColor = false;
            this.kiemtraTHUOCButton.Click += new System.EventHandler(this.kiemtraTHUOCButton_Click);
            // 
            // labelkiemthuoc
            // 
            this.labelkiemthuoc.AutoSize = true;
            this.labelkiemthuoc.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkiemthuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.labelkiemthuoc.Location = new System.Drawing.Point(55, 18);
            this.labelkiemthuoc.Name = "labelkiemthuoc";
            this.labelkiemthuoc.Size = new System.Drawing.Size(389, 90);
            this.labelkiemthuoc.TabIndex = 76;
            this.labelkiemthuoc.Text = "TRANG KIỂM TRA \r\nTHUỐC";
            this.labelkiemthuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KiemTraTTThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 344);
            this.Controls.Add(this.ID_THUOC);
            this.Controls.Add(this.idthuocBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kiemtraTHUOCButton);
            this.Controls.Add(this.labelkiemthuoc);
            this.Name = "KiemTraTTThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiemTraTTThuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kiemtraTTThuoc_formClosing);
            this.Shown += new System.EventHandler(this.kiemtraTTThuoc_formShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_THUOC;
        private System.Windows.Forms.TextBox idthuocBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button kiemtraTHUOCButton;
        private System.Windows.Forms.Label labelkiemthuoc;
    }
}