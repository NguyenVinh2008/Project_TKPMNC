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
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        voucher_DAO voucher_DAO = new voucher_DAO();
        public int countphanthuong;
        public void load_data()
        {
            dgv_thongtintrochoi.DataSource = chiendich_DAO.laychiendichdangdienratheotrangthai(1);
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            load_data();
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
                    frm_mayman lotto = new frm_mayman();
                    lotto.Show();
                    //frm_ochu ochu = new frm_ochu();
                    //ochu.Show();
                    break;
                case 2:
                    //frm_mayman lotto = new frm_mayman();
                    //lotto.Show();
                    break;
            }
        }
    }
}
