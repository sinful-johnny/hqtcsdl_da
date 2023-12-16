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
    public partial class CapNhatThuoc : Form
    {
        public QuanTriVienForm prev_form;

        public CapNhatThuoc(QuanTriVienForm prev_form)
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

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void capnhatTKButton_Click(object sender, EventArgs e)
        {
            THUOC thuoc = new THUOC();
            thuoc.ID_THUOC = idthuocBox.Text;
            thuoc.TENTHUOC = tenthuocBox.Text;
            thuoc.CHIDINH = chidinhBox.Text;
            thuoc.NGAYHETHAN = ngayhethanPicker.Value;
            giatienBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumbers_KeyPress);
            thuoc.GIATIEN = giatienBox.Text;
            thuoc.SOLUONG = (int)soluongnumericUpDown.Value;


            DatabaseAccess db_updateThuoc = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_updateThuoc.CapNhatThongTin_Thuoc(thuoc);
            MessageBox.Show("Bạn đã cập nhật thông tin thuốc thành công", "Cập nhật thuốc thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }


        private void capnhatTHUOC_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void capnhatTHUOC_formClosing(object sender, FormClosingEventArgs e)
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
