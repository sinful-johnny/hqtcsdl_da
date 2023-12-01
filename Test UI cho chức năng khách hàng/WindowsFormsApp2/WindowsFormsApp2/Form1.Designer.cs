namespace WindowsFormsApp2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttcanhan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(60, 33);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(155, 22);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Username_MouseClick);
            this.username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(60, 61);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 22);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_MouseClick);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Info";
            // 
            // ttcanhan
            // 
            this.ttcanhan.HideSelection = false;
            this.ttcanhan.Location = new System.Drawing.Point(12, 121);
            this.ttcanhan.Name = "ttcanhan";
            this.ttcanhan.Size = new System.Drawing.Size(776, 64);
            this.ttcanhan.TabIndex = 6;
            this.ttcanhan.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ttcanhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SQL Database demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ttcanhan;
    }
}

