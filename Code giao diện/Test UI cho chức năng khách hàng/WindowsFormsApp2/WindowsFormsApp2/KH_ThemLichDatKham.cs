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
    public partial class KH_ThemLichDatKham : Form
    {
        KH_TrangChu prev_form;
        DatabaseAccess db;
        List<TAI_KHOAN> list_NhaSiConSlot;
        List<LICH_LAM_VIEC> lICH_LAM_VIECs;

        public KH_ThemLichDatKham(KH_TrangChu prev_form, string USERNAME, string PASSWORD)
        {
            InitializeComponent();
            this.prev_form = prev_form;
            db = new DatabaseAccess(USERNAME, PASSWORD);
        }

        private void KH_ThemLichDatKham_Load(object sender, EventArgs e)
        {
            try
            {
                list_NhaSiConSlot = db.KH_HoTenNSConSlot();
                foreach (TAI_KHOAN nhaSi in list_NhaSiConSlot)
                {
                    comboBox_ChonNhaSi.Items.Add(nhaSi.HOTEN);
                }

                listView_LichLamViec.View = View.Details;
                listView_LichLamViec.Columns.Add("ID LICH LAM VIEC", 100);
                listView_LichLamViec.Columns.Add("NGAY KHAM", 100);
                listView_LichLamViec.Columns.Add("GIO KHAM", 100);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void setControlState(Control Ctl, bool enabled)
        {
            //*3*
            foreach (Control c in Ctl.Controls) setControlState(c, enabled);
            Ctl.Enabled = enabled;
            //*4*
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            setControlState(prev_form, false);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            setControlState(prev_form, true);
            this.Hide();
        }

        void update_ListView_LichLamViec()
        {
            listView_LichLamViec.Items.Clear();
            foreach (LICH_LAM_VIEC llv in lICH_LAM_VIECs)
            {
                ListViewItem newItem = new ListViewItem(llv.ID_LLV);
                newItem.SubItems.Add(llv.NGAYKHAM.ToString());
                newItem.SubItems.Add(llv.GIOKHAM.ToString());
                listView_LichLamViec.Items.Add(newItem);
                //MessageBox.Show(benhAn.Info);
            }
        }

        private void comboBox_ChonNhaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_ChonNhaSi.SelectedItem != null)
                {
                    string HOTEN_NS = comboBox_ChonNhaSi.SelectedItem.ToString();
                    TAI_KHOAN Selected_NS = list_NhaSiConSlot.Where(NS => NS.HOTEN == HOTEN_NS).ToList().FirstOrDefault();
                    lICH_LAM_VIECs = db.sp_KH_XemLLVcuaNS(Selected_NS.ID_TAIKHOAN);
                    update_ListView_LichLamViec();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button_DangKiKham_Click(object sender, EventArgs e)
        {
            try
            {
                string gioKham = $"" + numericUpDown_GioKham_Gio.Value.ToString().PadLeft(2, '0') + ":" + numericUpDown_GioKham_Phut.Value.ToString().PadLeft(2, '0') + ":00.0000000";
                //MessageBox.Show(gioKham);
                string HOTEN_NS = comboBox_ChonNhaSi.SelectedItem.ToString();
                TAI_KHOAN Selected_NS = list_NhaSiConSlot.Where(NS => NS.HOTEN == HOTEN_NS).ToList().FirstOrDefault();
                db.sp_KH_ThemLichDatKham(Selected_NS.ID_TAIKHOAN, dateTimePicker1.Value.ToShortDateString(), gioKham);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Đăng kí thành công!");
            }
            
        }

        private void listView_LichLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_LichLamViec.SelectedItems.Count > 0)
            {
                //TAI_KHOAN Selected_NS = list_NhaSiConSlot.Where(NS => NS.HOTEN == HOTEN_NS).ToList().FirstOrDefault();
                dateTimePicker1.Text = listView_LichLamViec.SelectedItems[0].SubItems[1].Text;
                DateTime giokham = DateTime.ParseExact(listView_LichLamViec.SelectedItems[0].SubItems[2].Text, "H:m:s", null);
                numericUpDown_GioKham_Gio.Value = giokham.Hour;
                numericUpDown_GioKham_Phut.Value = giokham.Minute;
            }
        }
    }
}
