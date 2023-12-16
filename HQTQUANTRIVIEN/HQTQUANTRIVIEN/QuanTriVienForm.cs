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
    public partial class QuanTriVienForm: Form
    {
        public UIHome prev_Form;
        public QuanTriVienForm(UIHome prev_Form)
        {
            InitializeComponent();
            this.prev_Form = prev_Form;
        }
        public void setControlState(Control Ctl, bool enabled)
        {
            //*3*
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
            //*4*
        }

        //QUAN LY TAI KHOAN
        private void AddTKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemTaiKhoan themTK_form = new ThemTaiKhoan(this);
            themTK_form.Show();
        }

        private void UpdateTKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapNhatTaiKhoan capnhatTK_form = new CapNhatTaiKhoan(this);
            capnhatTK_form.Show();
        }

        private void BanTKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoaTaiKhoan khoaTK_form = new KhoaTaiKhoan(this);
            khoaTK_form.Show();
        }

        private void ViewTKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kiemtraTK_Form kiemtraTK_form = new kiemtraTK_Form(this);
            kiemtraTK_form.Show();
        }

        private void ViewListTKButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kiemtraListTK_Form kiemtraListTK_form = new kiemtraListTK_Form(this);
            kiemtraListTK_form.Show();
        }

        //QUAN LY THUOC

        private void AddTHUOCButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemThuoc themTHUOC_form = new ThemThuoc(this);
            themTHUOC_form.Show();
        }

        private void UpdateTHUOCButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapNhatThuoc capnhatTHUOC_form = new CapNhatThuoc(this);
            capnhatTHUOC_form.Show();
        }

        private void DeleteTHUOCButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            XoaThuoc xoaTHUOC_form = new XoaThuoc(this);
            xoaTHUOC_form.Show();
        }

        private void ViewTHUOCButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KiemTraTTThuoc kiemtraTTTHUOC_form = new KiemTraTTThuoc(this);
            kiemtraTTTHUOC_form.Show();
        }

        private void ViewListTHUOCButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kiemtraListTHUOC_Form listTHUOC_form = new kiemtraListTHUOC_Form(this);
            listTHUOC_form.Show();
        }

        private void quantrivien_formShown(object sender, EventArgs e)
        {
            setControlState(prev_Form, false);
        }

        private void quantrivien_formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UIHome Home_form = new UIHome();
            Home_form.Show();
            MessageBox.Show("Bạn đã đăng xuất khỏi tài khoản thành công", "Đăng xuất thành công", MessageBoxButtons.OK);
        }
    }
}
