namespace WindowsFormsApp2
{
    partial class KH_XemChiTietBA
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
            this.don_thuoc = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dv_sd = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // don_thuoc
            // 
            this.don_thuoc.HideSelection = false;
            this.don_thuoc.Location = new System.Drawing.Point(12, 28);
            this.don_thuoc.Name = "don_thuoc";
            this.don_thuoc.Size = new System.Drawing.Size(776, 174);
            this.don_thuoc.TabIndex = 0;
            this.don_thuoc.UseCompatibleStateImageBehavior = false;
            this.don_thuoc.SelectedIndexChanged += new System.EventHandler(this.don_thuoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dịch vụ sử dụng";
            // 
            // dv_sd
            // 
            this.dv_sd.HideSelection = false;
            this.dv_sd.Location = new System.Drawing.Point(12, 228);
            this.dv_sd.Name = "dv_sd";
            this.dv_sd.Size = new System.Drawing.Size(776, 210);
            this.dv_sd.TabIndex = 3;
            this.dv_sd.UseCompatibleStateImageBehavior = false;
            this.dv_sd.SelectedIndexChanged += new System.EventHandler(this.dv_sd_SelectedIndexChanged);
            // 
            // KH_XemChiTietBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dv_sd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.don_thuoc);
            this.Name = "KH_XemChiTietBA";
            this.Text = "Chi tiết bệnh án";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView don_thuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView dv_sd;
    }
}