using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<TAI_KHOAN> data = new List<TAI_KHOAN>();
        List<BENH_AN> dsBenhAn = new List<BENH_AN>();
        public Form1()
        {
            InitializeComponent();

            //UpdateDsKH();
        }

        //private void UpdateDsKH()
        //{
        //    dsKH.DataSource = data;
        //    dsKH.DisplayMember = "Info";
        //}
        private void UpdateListView()
        {
            //ListViewItem newItem = new ListViewItem("sth");
            //newItem.SubItems.Add("sth1");
            //newItem.SubItems.Add("sth2");
            //newItem.SubItems.Add("sth3");
            //ttcanhan.Items.Add(newItem);
            foreach(TAI_KHOAN tAI_KHOAN in data)
            {
                ListViewItem newItem = new ListViewItem(tAI_KHOAN.ID_TAIKHOAN);
                newItem.SubItems.Add(tAI_KHOAN.HOTEN);
                newItem.SubItems.Add(tAI_KHOAN.SDT);
                newItem.SubItems.Add(tAI_KHOAN.NGAYSINH.ToString());
                newItem.SubItems.Add(tAI_KHOAN.LOAITK);
                ttcanhan.Items.Add(newItem);
            }

        }
        private void UpdateBenhAn()
        {
            foreach (BENH_AN benhAn in dsBenhAn)
            {
                ListViewItem newItem = new ListViewItem(benhAn.ID_BA);
                newItem.SubItems.Add(benhAn.ID_KH);
                newItem.SubItems.Add(benhAn.ID_NS);
                newItem.SubItems.Add(benhAn.NGAYKHAM.ToString());
                benh_an.Items.Add(newItem);
                //MessageBox.Show(benhAn.Info);
            }

        }

        private void dsKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseAccess db = new DatabaseAccess();
            //data = db.GetTAI_KHOANs();
            data = db.loginDB(username.Text, password.Text);
            dsBenhAn = db.getBENH_ANs(username.Text, password.Text);
            //UpdateDsKH();
            UpdateListView();
            UpdateBenhAn();
            //Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", "sa", "123");
            //MessageBox.Show(helper.connectionString);
        }
        int count1 = 0;
        //private void dsKH_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if(count1 == 0)
        //    {
        //        count1 = 1;
        //    }
        //    else
        //    {
        //        MessageBox.Show(dsKH.Text.Split('\t')[0]);
        //    }
        //}
        private void Username_Leave(object sender, EventArgs e)
        {
            if(username.Text == "")
            {
                username.Text = "Username";
            }
        }

        private void Username_MouseClick(object sender, MouseEventArgs e)
        {
            if(username.Text == "Username")
            {
                username.Text = "";
            }
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            if(password.Text == "")
            {
                password.Text = "Password";
            }
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ttcanhan.View = View.Details;
            ttcanhan.Columns.Add("ID_TAIKHOAN", 100, HorizontalAlignment.Left);
            ttcanhan.Columns.Add("HOTEN", 100, HorizontalAlignment.Left);
            ttcanhan.Columns.Add("SDT", 100);
            ttcanhan.Columns.Add("NGAY SINH", 100);
            //ttcanhan.Columns.Add("MAT KHAU", 100);
            ttcanhan.Columns.Add("LOAI TAI KHOAN", 100);

            benh_an.View = View.Details;
            benh_an.Columns.Add("ID BENH AN", 100);
            benh_an.Columns.Add("ID KHACH HANG", 100);
            benh_an.Columns.Add("ID NHA SI", 100);
            benh_an.Columns.Add("NGAY KHAM", 100);
        }
    }
}
