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
    public partial class kiemtraTK_Form : Form
    {
        public QuanTriVienForm prev_form;

        public kiemtraTK_Form(QuanTriVienForm prev_form)
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
        private void kiemtraTKButton_Click(object sender, EventArgs e)
        {
            string ID_TK = idtaikhoanBox.Text;
            if (ID_TK == "")
                MessageBox.Show("Bạn chưa nhập ID tài khoản", "Không Hợp Lệ", MessageBoxButtons.OK);
            else
            {
                this.Hide();
                tkCheckedForm Checked = new tkCheckedForm(this, ID_TK);
                Checked.Show();
            }
        }

        private void kiemtraTK_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void kiemtraTK_formClosing(object sender, FormClosingEventArgs e)
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
