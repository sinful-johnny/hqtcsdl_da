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
    public partial class kiemtraListTHUOC_Form : Form
    {
        private QuanTriVienForm prev_form;
        public kiemtraListTHUOC_Form(QuanTriVienForm prev_form)
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

        private void kiemtraListTHUOC_Form_Load(object sender, EventArgs e)
        {
            //VIEW
            ttthuoc.View = View.Details;

            ttthuoc.Columns.Add("ID_THUOC", 100);
            ttthuoc.Columns.Add("TENTHUOC", 100);
            ttthuoc.Columns.Add("CHIDINH", 100);
            ttthuoc.Columns.Add("NGAYHETHAN", 100);
            ttthuoc.Columns.Add("GIATIEN", 100);
            ttthuoc.Columns.Add("SOLUONG", 100);


            //ITEMS

            DatabaseAccess db_listTHUOC = new DatabaseAccess(this.prev_form.prev_Form.username_static, this.prev_form.prev_Form.password_static);

            List<THUOC> data = db_listTHUOC.Xem_TTDanhSach_Thuoc();

            ttthuoc.Items.Clear(); // Clear data

            foreach (THUOC thuoc in data)
            {
                ListViewItem newItem = new ListViewItem(thuoc.ID_THUOC);
                newItem.SubItems.Add(thuoc.TENTHUOC);
                newItem.SubItems.Add(thuoc.CHIDINH);
                newItem.SubItems.Add(thuoc.NGAYHETHAN.ToString());
                newItem.SubItems.Add(thuoc.GIATIEN);
                newItem.SubItems.Add(thuoc.SOLUONG.ToString());
                ttthuoc.Items.Add(newItem);
            }
        }


        private void ListTHUOC_formShown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void ListTHUOC_formClosing(object sender, FormClosingEventArgs e)
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
