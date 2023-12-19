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
    public partial class ThemTaiKhoan : Form
    {
        public QuanTriVienForm prev_form;

        public ThemTaiKhoan(QuanTriVienForm prev_form)
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

        private void themTKButton_Click(object sender, EventArgs e)
        {
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.HOTEN = hotenBox.Text;
            tAI_KHOAN.SDT = sdtBox.Text;
            tAI_KHOAN.EMAIL = emailBox.Text;
            tAI_KHOAN.NGAYSINH = ngaysinhPicker.Value;
            tAI_KHOAN.MATKHAU = matkhauBox.Text;
            if (KHChoice.Checked)
            {
                tAI_KHOAN.LOAITK = "KH";
            }
            else if (NVChoice.Checked)
            {
                tAI_KHOAN.LOAITK = "NV";
            }
            else if (NSChoice.Checked)
            {
                tAI_KHOAN.LOAITK = "NS";
            }

            DatabaseAccess db_addAccount = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_addAccount.ThemTaiKhoan_QuanTriVien(tAI_KHOAN);
            MessageBox.Show("Bạn đã thêm tài khoản thành công", "Thêm tài khoản thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }

        private void themTK_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void themTK_formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }
    }
}
