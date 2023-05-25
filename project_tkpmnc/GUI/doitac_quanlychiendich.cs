using DevExpress.XtraBars.FluentDesignSystem;
using Phan_mem_quan_ly_voucher.DAO;
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
    public partial class doitac_quanlychiendich : UserControl
    {
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        public doitac_quanlychiendich()
        {
            InitializeComponent();
        }
        private void button_taochiendich_Click(object sender, EventArgs e)
        {

            frm_taochiendich taochiendich = new frm_taochiendich();
            taochiendich.Show();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dgv_thongtinchiendich.DataSource = chiendich_DAO.laychiendichtheodoitacid(doitac_DTO.id);
            
        }
        private void dgv_thongtinchiendich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinchiendich.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.doitac_id = int.Parse(row.Cells["taoboi_doitac_id"].Value.ToString());
            chiendich_DTO.trochoi_id = int.Parse(row.Cells["trochoi_id"].Value.ToString());
            chiendich_DTO.trangthai = int.Parse(row.Cells["chiendich_trangthai"].Value.ToString()); ;
            chiendich_DTO.chiendich_start = row.Cells["chiendich_start"].Value.ToString();
            chiendich_DTO.chiendich_end = row.Cells["chiendich_end"].Value.ToString();
        }
        private void button_themvoucher_Click(object sender, EventArgs e)
        {
            if (chiendich_DTO.chiendich_id == 0)
            {
                MessageBox.Show("Vui lòng chọn chiến dịch bạn muốn thêm voucher vào");
            }
            else
            {
                frm_taovoucher taovoucher = new frm_taovoucher();
                taovoucher.Show();
            }
            
        }
    }
}
