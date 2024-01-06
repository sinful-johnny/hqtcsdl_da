using HQTQUANTRIVIEN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HQTQUANTRIVIEN
{
    public partial class UIHome : Form
    {
        DatabaseAccess db;
        List<TAI_KHOAN> data = new List<TAI_KHOAN>();
        public string username_static;
        public string password_static;
        public UIHome()
        {
            InitializeComponent();
        }

        public void setControlState(Control Ctl, bool enabled)
        {
            //*3*
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
            //*4*
        }

        private void dangnhapButton_Click(object sender, EventArgs e)
        {
            username_static = sdtBox.Text;
            password_static = matkhauBox.Text;
            db = new DatabaseAccess(username_static, password_static);
            data = db.loginDB();
            this.Hide();
            new QuanTriVienForm(this).Show();
            MessageBox.Show("Bạn đã đăng nhập tài khoản thành công", "Đăng nhập thành công", MessageBoxButtons.OK);
        }

        private void sdtBox_Leave(object sender, EventArgs e)
        {
            if (sdtBox.Text == "")
                sdtBox.Text = "Nhập số điện thoại";
        }

        private void sdtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sdtBox.Text == "Nhập số điện thoại")
                sdtBox.Text = "";
        }

        private void matkhauBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (matkhauBox.Text == "Nhập mật khẩu")
                matkhauBox.Text = "";
        }

        private void trangdangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy_TaiKhoan kH_DangKi_form = new DangKy_TaiKhoan(this);
            kH_DangKi_form.Show();
        }

        private void matkhauBox_Enter(object sender, EventArgs e)
        {
            matkhauBox.Text = "";

            matkhauBox.ForeColor = Color.Black;

            matkhauBox.UseSystemPasswordChar = true;
        }

        private void matkhauBox_Leave(object sender, EventArgs e)
        {
            if (matkhauBox.Text == "")
            {
                matkhauBox.Text = "Nhập mật khẩu";
                matkhauBox.UseSystemPasswordChar = false;
                SelectNextControl(matkhauBox, true, true, false, true);
            }
        }

        private void qtv_formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
