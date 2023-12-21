namespace WindowsFormsApp2
{
    partial class KH_ThemLichDatKham
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
            this.comboBox_ChonNhaSi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_LichLamViec = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_GioKham_Gio = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_GioKham_Phut = new System.Windows.Forms.NumericUpDown();
            this.button_DangKiKham = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GioKham_Gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GioKham_Phut)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ChonNhaSi
            // 
            this.comboBox_ChonNhaSi.FormattingEnabled = true;
            this.comboBox_ChonNhaSi.Location = new System.Drawing.Point(12, 61);
            this.comboBox_ChonNhaSi.Name = "comboBox_ChonNhaSi";
            this.comboBox_ChonNhaSi.Size = new System.Drawing.Size(252, 24);
            this.comboBox_ChonNhaSi.TabIndex = 0;
            this.comboBox_ChonNhaSi.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChonNhaSi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn một lịch làm việc phù hợp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn nha sĩ";
            // 
            // listView_LichLamViec
            // 
            this.listView_LichLamViec.HideSelection = false;
            this.listView_LichLamViec.Location = new System.Drawing.Point(305, 61);
            this.listView_LichLamViec.Name = "listView_LichLamViec";
            this.listView_LichLamViec.Size = new System.Drawing.Size(360, 377);
            this.listView_LichLamViec.TabIndex = 6;
            this.listView_LichLamViec.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // numericUpDown_GioKham_Gio
            // 
            this.numericUpDown_GioKham_Gio.Location = new System.Drawing.Point(15, 175);
            this.numericUpDown_GioKham_Gio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_GioKham_Gio.Name = "numericUpDown_GioKham_Gio";
            this.numericUpDown_GioKham_Gio.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown_GioKham_Gio.TabIndex = 8;
            // 
            // numericUpDown_GioKham_Phut
            // 
            this.numericUpDown_GioKham_Phut.Location = new System.Drawing.Point(108, 175);
            this.numericUpDown_GioKham_Phut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_GioKham_Phut.Name = "numericUpDown_GioKham_Phut";
            this.numericUpDown_GioKham_Phut.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown_GioKham_Phut.TabIndex = 9;
            // 
            // button_DangKiKham
            // 
            this.button_DangKiKham.Location = new System.Drawing.Point(83, 229);
            this.button_DangKiKham.Name = "button_DangKiKham";
            this.button_DangKiKham.Size = new System.Drawing.Size(99, 50);
            this.button_DangKiKham.TabIndex = 10;
            this.button_DangKiKham.Text = "Đăng kí khám";
            this.button_DangKiKham.UseVisualStyleBackColor = true;
            this.button_DangKiKham.Click += new System.EventHandler(this.button_DangKiKham_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn ngày khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giờ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phút";
            // 
            // KH_ThemLichDatKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_DangKiKham);
            this.Controls.Add(this.numericUpDown_GioKham_Phut);
            this.Controls.Add(this.numericUpDown_GioKham_Gio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView_LichLamViec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ChonNhaSi);
            this.Name = "KH_ThemLichDatKham";
            this.Text = "KH_ThemLichDatKham";
            this.Load += new System.EventHandler(this.KH_ThemLichDatKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GioKham_Gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GioKham_Phut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ChonNhaSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_LichLamViec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown_GioKham_Gio;
        private System.Windows.Forms.NumericUpDown numericUpDown_GioKham_Phut;
        private System.Windows.Forms.Button button_DangKiKham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}