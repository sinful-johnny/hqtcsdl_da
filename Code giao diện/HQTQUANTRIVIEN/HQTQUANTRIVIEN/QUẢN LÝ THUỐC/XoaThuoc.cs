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
    public partial class XoaThuoc : Form
    {
        public QuanTriVienForm prev_form;

        public XoaThuoc(QuanTriVienForm prev_form)
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
        private void khoaTHUOCButton_Click(object sender, EventArgs e)
        {
            THUOC thuoc = new THUOC();
            thuoc.ID_THUOC = idthuocBox.Text;

            DatabaseAccess db_delThuoc = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_delThuoc.XoaThongTin_Thuoc(thuoc);
            MessageBox.Show("Bạn đã xóa thông tin thuốc thành công", "Xóa thuốc thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }

        private void xoaTHUOC_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void khoaTHUOC_formClosing(object sender, FormClosingEventArgs e)
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
