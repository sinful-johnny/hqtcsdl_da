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
    public partial class tkCheckedForm : Form
    {
        private kiemtraTK_Form prev_form;
        private string ID_TK;
        public tkCheckedForm(kiemtraTK_Form prev_form, string ID_TK)
        {
            InitializeComponent();
            this.prev_form = prev_form;
            this.ID_TK = ID_TK;
        }

        public void setControlState(Control Ctl, bool enabled)
        {
            //*3*
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
            //*4*
        }

        private void TKChecked_formLoading(object sender, EventArgs e)
        {
            //VIEW
            ttcanhan.View = View.Details;

            ttcanhan.Columns.Add("ID_TAIKHOAN", 100);
            ttcanhan.Columns.Add("HOTEN", 100);
            ttcanhan.Columns.Add("SDT", 100);
            ttcanhan.Columns.Add("NGAY SINH", 100);
            ttcanhan.Columns.Add("EMAIL", 100);
            ttcanhan.Columns.Add("LOAI TAI KHOAN", 100);


            //ITEMS
            TAI_KHOAN tk = new TAI_KHOAN();
            tk.ID_TAIKHOAN = ID_TK;

            DatabaseAccess db_check1Account = new DatabaseAccess(this.prev_form.prev_form.prev_Form.username_static, this.prev_form.prev_form.prev_Form.password_static);

            List<TAI_KHOAN> data = db_check1Account.Xem_1TK_QuanTriVien(tk);

            ttcanhan.Items.Clear(); // Clear data

            foreach (TAI_KHOAN tAI_KHOAN in data)
            {
                ListViewItem newItem = new ListViewItem(tAI_KHOAN.ID_TAIKHOAN);
                newItem.SubItems.Add(tAI_KHOAN.HOTEN);
                newItem.SubItems.Add(tAI_KHOAN.SDT);
                newItem.SubItems.Add(tAI_KHOAN.NGAYSINH.ToString());
                newItem.SubItems.Add(tAI_KHOAN.EMAIL);
                newItem.SubItems.Add(tAI_KHOAN.LOAITK);
                ttcanhan.Items.Add(newItem);
            }
        }


        private void TKChecked_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void TKChecked_formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new kiemtraTK_Form(this.prev_form.prev_form).Show();
            this.Hide();
        }
    }
}
