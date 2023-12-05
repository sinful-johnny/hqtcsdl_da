using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 prev_form;
        public string ID_BA { get; set; }

        DatabaseAccess db;    

        List<DON_THUOC> dON_THUOCs = new List<DON_THUOC>();

        List<DICHVU_SD> dICHVU_SDs = new List<DICHVU_SD>();

        public Form2(string id_ba, Form1 prev_form, string username, string password)
        {
            InitializeComponent();
            ID_BA = id_ba;
            this.prev_form = prev_form;
            db = new DatabaseAccess(username, password);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            don_thuoc.View = View.Details;
            don_thuoc.Columns.Add("ID DON THUOC", 100);
            don_thuoc.Columns.Add("THANH TIEN", 100);
            don_thuoc.Columns.Add("HOA DON", 100);

            dv_sd.View = View.Details;
            dv_sd.Columns.Add("ID DICH VU", 100);
            dv_sd.Columns.Add("THANH TIEN", 100);
            dv_sd.Columns.Add("HOA DON", 100);

            dON_THUOCs = db.GetDON_THUOCs(ID_BA);
            dICHVU_SDs = db.GetDICHVU_SDs(ID_BA);  
            update_ListView_HOADON();
            update_ListView_DVSD();
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

        private void update_ListView_HOADON()
        {
            foreach(DON_THUOC dON_THUOC in dON_THUOCs)
            {
                ListViewItem newItem = new ListViewItem(dON_THUOC.ID_DONTHUOC);
                newItem.SubItems.Add(dON_THUOC.THANHTIEN.ToString());
                newItem.SubItems.Add(dON_THUOC.ID_HOADON);
                don_thuoc.Items.Add(newItem);
            }
        }
        private void update_ListView_DVSD()
        {
            foreach (DICHVU_SD dICHVU_SD in dICHVU_SDs)
            {
                ListViewItem newItem = new ListViewItem(dICHVU_SD.ID_LOAIDV);
                newItem.SubItems.Add(dICHVU_SD.THANHTIEN.ToString());
                newItem.SubItems.Add(dICHVU_SD.ID_HOADON);
                dv_sd.Items.Add(newItem);
            }
        }

        private void dv_sd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //while(dv_sd.SelectedItems.Count == 0) { }
            if(dv_sd.SelectedItems.Count > 0) {
                List<LOAI_DV> DICHVUs = db.GetLOAI_DVs(dv_sd.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show(dv_sd.SelectedItems[0].SubItems[0].Text);
                _ = MessageBox.Show(DICHVUs.FirstOrDefault().Info);
            }

        }

        //private void don_thuoc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<THUOC> tHUOCs = new List<THUOC>();
        //    tHUOCs = db.GetTHUOCs(don_thuoc.SelectedItems[0].Text);
        //    MessageBox.Show(tHUOCs[0].Info);
        //}

    }
}
