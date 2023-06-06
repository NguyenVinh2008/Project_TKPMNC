using project_tkpmnc.BUS;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class nguoidung_thamgiatrochoi : UserControl
    {
        public nguoidung_thamgiatrochoi()
        {
            InitializeComponent();
        }
        thamgia_BUS thamgia_BUS = new thamgia_BUS();
        chiendich_BUS chiendich_BUS = new chiendich_BUS();
        public int countphanthuong;
        public void load_data()
        {
            comboBox_timkiem.SelectedIndex = 0;
            button_thamgia.Visible = false;
            chiendich_DTO.trangthai = 1;
            dgv_thongtintrochoi.DataSource = chiendich_BUS.laychiendichdangdienratheotrangthai();
        }

        private void nguoidung_thamgiatrochoi_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgv_thongtintrochoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtintrochoi.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.chiendich_ten = row.Cells["chiendich_ten"].Value.ToString();
            chiendich_DTO.doitac_id = int.Parse(row.Cells["taoboi_doitac_id"].Value.ToString());
            trochoi_DTO.id = int.Parse(row.Cells["trochoi_id"].Value.ToString());
            chiendich_DTO.trangthai = int.Parse(row.Cells["chiendich_trangthai"].Value.ToString()); ;
            chiendich_DTO.chiendich_start = row.Cells["chiendich_start"].Value.ToString();
            chiendich_DTO.chiendich_end = row.Cells["chiendich_end"].Value.ToString();
            button_thamgia.Enabled = true;
        }

        private void button_thamgia_Click(object sender, EventArgs e)
        {
            switch (trochoi_DTO.id)
            {
                case 1 :
                    frm_ochu ochu = new frm_ochu();
                    ochu.ShowDialog();
                    load_data();
                    break;
                case 2:
                    frm_mayman lotto = new frm_mayman();
                    lotto.ShowDialog();
                    load_data();
                    break;
            }
        }

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_timkiem.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1:
                    button_thamgia.Visible = true;
                    dgv_thongtintrochoi.DataSource = thamgia_BUS.laydanhsachchiendichchuathamgia();
                    break;
                case 2:
                    button_thamgia.Visible = false;
                    dgv_thongtintrochoi.DataSource = thamgia_BUS.laydanhsachchiendichdathamgia();
                    break;
            }
        }
    }
}
