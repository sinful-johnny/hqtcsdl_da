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
    public partial class KH_SuaTTCaNhan : Form
    {
        KH_TrangChu prev_form;
        string password;
        string username;
        TAI_KHOAN current_user;
        DatabaseAccess db;
        public KH_SuaTTCaNhan(KH_TrangChu prev_form,string username,string password)
        {
            InitializeComponent();
            this.prev_form = prev_form;
            this.password = password;
            this.username = username;
            db = new DatabaseAccess(username, password);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            db.SuaTTCaNhan(hoTenBox.Text,ngaySinhPicker.Value,emailBox.Text);
        }
        public void setControlState(Control Ctl, bool enabled)
        {
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
        }
        private void KH_SuaTTCaNhan_Shown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void KH_SuaTTCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            setControlState(prev_form, true);
            this.Hide();
        }

        private void KH_SuaTTCaNhan_Load(object sender, EventArgs e)
        {
            List<TAI_KHOAN> retrievedData = db.loginDB();
            current_user =retrievedData.First();
            hoTenBox.Text = current_user.HOTEN;
            ngaySinhPicker.Value = current_user.NGAYSINH;
            emailBox.Text = current_user.EMAIL;
        }
    }
}
