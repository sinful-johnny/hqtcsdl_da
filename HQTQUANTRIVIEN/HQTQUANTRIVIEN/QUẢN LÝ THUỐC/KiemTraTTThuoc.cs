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
    public partial class KiemTraTTThuoc : Form
    {
        public QuanTriVienForm prev_form;

        public KiemTraTTThuoc(QuanTriVienForm prev_form)
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
        private void kiemtraTHUOCButton_Click(object sender, EventArgs e)
        {
            string ID_THUOC = idthuocBox.Text;
            if (ID_THUOC == "")
                MessageBox.Show("Bạn chưa nhập ID tài thuốc", "Không Hợp Lệ", MessageBoxButtons.OK);
            else
            {
                this.Hide();
                thuocCheckedForm Checked = new thuocCheckedForm(this, ID_THUOC);
                Checked.Show();
            }
        }

        private void kiemtraTTThuoc_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void kiemtraTTThuoc_formClosing(object sender, FormClosingEventArgs e)
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
