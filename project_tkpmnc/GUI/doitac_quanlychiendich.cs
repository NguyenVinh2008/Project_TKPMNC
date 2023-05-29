using project_tkpmnc.BUS;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class doitac_quanlychiendich : UserControl
    {
        chiendich_BUS chiendich_BUS = new chiendich_BUS();
        public doitac_quanlychiendich()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichtheodoitacid();
        }
        private void button_taochiendich_Click(object sender, EventArgs e)
        {
            frm_taochiendich taochiendich = new frm_taochiendich();
            taochiendich.ShowDialog();
            load_data();
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1:
                    chiendich_DTO.trangthai = 0;
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichcuadoitactheotrangthai();
                    break;
                case 2:
                    chiendich_DTO.trangthai = 1;
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichcuadoitactheotrangthai();
                    break;
                case 3:
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichcuadoitacdangdienra();
                    break;
                case 4:
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichcuadoitacdaketthuc();
                    break;
            }
        }
        private void dgv_thongtinchiendich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinchiendich.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.chiendich_ten = row.Cells["chiendich_ten"].Value.ToString();
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
        private void doitac_quanlychiendich_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            load_data();
        }
        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            if (chiendich_DTO.chiendich_id == 0)
            {
                MessageBox.Show("Vui lòng chọn chiến dịch bạn muốn chỉnh sửa!");
            }
            else
            {
                dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichtheoid();
                button_save.Enabled = true;
                dgv_thongtinchiendich.ReadOnly= false;
            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinchiendich.Rows[0];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.chiendich_ten = row.Cells["chiendich_ten"].Value.ToString();
            chiendich_DTO.trochoi_id = int.Parse(row.Cells["trochoi_id"].Value.ToString());
            chiendich_BUS.thaydoithongtinchiendich();
            MessageBox.Show("Thay đổi thông tin chiến dịch thành công!");
            dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichtheoid();
            button_save.Enabled = false;
        }
    }
}
