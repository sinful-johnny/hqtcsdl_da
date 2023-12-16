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
    public partial class kiemtraListTK_Form : Form
    {
        private QuanTriVienForm prev_form;
        public kiemtraListTK_Form(QuanTriVienForm prev_form)
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

        private void KTList_formLoading(object sender, EventArgs e)
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

            DatabaseAccess db_listAccount = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);

            List<TAI_KHOAN> data = db_listAccount.Xem_DANHSACHTK_QuanTriVien();

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


        private void ListTK_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void ListTK_formClosing(object sender, FormClosingEventArgs e)
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
