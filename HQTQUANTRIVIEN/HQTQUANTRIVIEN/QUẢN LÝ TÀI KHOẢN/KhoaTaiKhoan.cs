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
    public partial class KhoaTaiKhoan : Form
    {
        public QuanTriVienForm prev_form;

        public KhoaTaiKhoan(QuanTriVienForm prev_form)
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
        private void khoaTKButton_Click(object sender, EventArgs e)
        {
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.ID_TAIKHOAN = idtaikhoanBox.Text;

            DatabaseAccess db_banAccount = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_banAccount.KhoaTaiKhoan_QuanTriVien(tAI_KHOAN);
            MessageBox.Show("Bạn đã khóa tài khoản thành công", "Khóa tài khoản thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }

        private void mokhoaTKButton_Click(object sender, EventArgs e)
        {
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.ID_TAIKHOAN = idtaikhoanBox.Text;

            DatabaseAccess db_unlockAccount = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_unlockAccount.MoKhoaTaiKhoan_QuanTriVien(tAI_KHOAN);
            MessageBox.Show("Bạn đã mở khóa tài khoản thành công", "Mở khóa tài khoản thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }

        private void khoaTK_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void khoaTK_formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }
    }
}
