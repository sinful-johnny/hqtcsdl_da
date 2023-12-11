using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class KH_DangKi : Form
    {
        KH_TrangChu prev_form;
        public KH_DangKi(KH_TrangChu prev_form)
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

        private void SendRegister_Click(object sender, EventArgs e)
        {
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.HOTEN = hoTenBox.Text;
            tAI_KHOAN.SDT = SDTBox.Text;
            tAI_KHOAN.NGAYSINH = ngaySinhPicker.Value;
            tAI_KHOAN.EMAIL = emailBox.Text;
            tAI_KHOAN.MATKHAU = matKhauBox.Text;

            DatabaseAccess db_Register = new DatabaseAccess("CHUNG","");
            db_Register.register(tAI_KHOAN);

        }

        private void KH_DangKi_Shown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void KH_DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            setControlState(prev_form, true);
            this.Hide();
        }
    }
}
