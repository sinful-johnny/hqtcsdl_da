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

namespace HQTQUANTRIVIEN
{
    public partial class DangKy_TaiKhoan : Form
    {
        UIHome prev_form;

        public DangKy_TaiKhoan(UIHome prev_form)
        {
            InitializeComponent();
            this.prev_form = prev_form;
        }

        public void setControlState(Control Ctl, bool enabled)
        {
            //*3*
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
            //*4*
        }

        private void dangkyButton_Click(object sender, EventArgs e)
        {
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.HOTEN = hotenBox.Text;
            tAI_KHOAN.SDT = sdtBox.Text;
            tAI_KHOAN.EMAIL = emailBox.Text;
            tAI_KHOAN.NGAYSINH = ngaysinhPicker.Value;
            tAI_KHOAN.MATKHAU = matkhauBox.Text;

            DatabaseAccess db_Register = new DatabaseAccess("CHUNG", "");
            db_Register.register(tAI_KHOAN);
            MessageBox.Show("Bạn đã đăng ký tài khoản thành công", "Đăng ký thành công", MessageBoxButtons.OK);
            new UIHome().Show();
            this.Hide();
        }

        private void DangKy_FormShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            new UIHome().Show();
            this.Hide();
        }
    }
}
