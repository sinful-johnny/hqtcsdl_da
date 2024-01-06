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
    public partial class ThemThuoc : Form
    {
        public QuanTriVienForm prev_form;

        public ThemThuoc(QuanTriVienForm prev_form)
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

        //Handling convert string into number 
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

        private void themTHUOCButton_Click(object sender, EventArgs e)
        {
            THUOC thuoc = new THUOC();
            thuoc.TENTHUOC = tenthuocBox.Text;
            thuoc.CHIDINH = chidinhBox.Text;
            thuoc.NGAYHETHAN = ngayhethanPicker.Value;
            giatienBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumbers_KeyPress);
            thuoc.GIATIEN = giatienBox.Text;
            thuoc.SOLUONG = (int)soluongnumericUpDown.Value;


            DatabaseAccess db_addThuoc = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);
            db_addThuoc.ThemThongTin_Thuoc(thuoc);
            MessageBox.Show("Bạn đã thêm thuốc thành công", "Thêm thuốc thành công", MessageBoxButtons.OK);
            new QuanTriVienForm(this.prev_form.prev_Form).Show();
            this.Hide();
        }

        private void themTHUOC_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void themTHUOC_formClosing(object sender, FormClosingEventArgs e)
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
