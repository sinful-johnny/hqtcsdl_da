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
    public partial class KH_TrangChu : Form
    {
        DatabaseAccess db;
        List<TAI_KHOAN> data = new List<TAI_KHOAN>();
        List<BENH_AN> dsBenhAn = new List<BENH_AN>();
        List<LICH_LAM_VIEC> lich_kham;
        string username_static;
        string password_static;
        public KH_TrangChu()
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
            ttcanhan.Items.Clear();
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
            benh_an.Items.Clear(); 
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

        private void UpdateLichKham()
        {
            listView_LichKham.Items.Clear();
            foreach (LICH_LAM_VIEC one in lich_kham)
            {
                ListViewItem newItem = new ListViewItem(one.ID_LLV);
                newItem.SubItems.Add(one.NGAYKHAM.ToShortDateString());
                newItem.SubItems.Add(one.GIOKHAM.ToString());
                listView_LichKham.Items.Add(newItem);
            }
        }

        private void dsKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //data = db.GetTAI_KHOANs();
            try
            {
                username_static = username.Text;
                password_static = password.Text;
                db = new DatabaseAccess(username.Text, password.Text);
                data = db.loginDB();
                dsBenhAn = db.getBENH_ANs();
                lich_kham = db.sp_KH_XemLichKham();
                //UpdateDsKH();
                UpdateListView();
                UpdateBenhAn();
                UpdateLichKham();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Helper helper = new Helper("DESKTOP-CDH2DEU\\SQLSERVER", "QL_NHAKHOA", "sa", "123");
            //MessageBox.Show(helper.connectionString);
        }
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

            listView_LichKham.View = View.Details;
            listView_LichKham.Columns.Add("ID LICH KHAM", 100);
            listView_LichKham.Columns.Add("NGAY KHAM", 100);
            listView_LichKham.Columns.Add("GIO KHAM", 100);
        }

        private void benh_an_SelectedIndexChanged(object sender, EventArgs e)
        {
            //benh_an.SelectedItems[0].Text
            if(benh_an.SelectedItems.Count > 0)
            {
                KH_XemChiTietBA KH_XemChiTietBA_form = new KH_XemChiTietBA(benh_an.SelectedItems[0].Text, this, username.Text, password.Text);
                KH_XemChiTietBA_form.Show();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            KH_DangKi kH_DangKi_form = new KH_DangKi(this);
            kH_DangKi_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KH_SuaTTCaNhan kH_SuaTTCaNhan_form = new KH_SuaTTCaNhan(this, username_static,password_static); 
            kH_SuaTTCaNhan_form.Show();
        }

        private void button_ThemLichKham_Click(object sender, EventArgs e)
        {
            KH_ThemLichDatKham kH_ThemLichDatKham = new KH_ThemLichDatKham(this, username_static,password_static);
            kH_ThemLichDatKham.Show();
        }
    }
}
