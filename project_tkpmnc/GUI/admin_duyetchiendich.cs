using project_tkpmnc.BUS;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class admin_duyetchiendich : UserControl
    {
        public admin_duyetchiendich()
        {
            InitializeComponent();
        }
        chiendich_BUS chiendich_BUS = new chiendich_BUS();

        private void load_data()
        {
            dgv_danhsachchoduyet.DataSource = chiendich_BUS.laythongtinchiendich();
        }

        private void admin_duyetchiendich_Load(object sender, EventArgs e)
        {
            load_data();
            comboBox1.SelectedIndex = 0;
            button_duyet.Enabled = false;
            button_huy.Enabled = false;
        }

        private void dgv_danhsachchoduyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_danhsachchoduyet.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.trangthai = int.Parse(row.Cells["chiendich_trangthai"].Value.ToString());
            button_duyet.Enabled = true;
            button_huy.Enabled = true;
        }

        private void button_duyet_Click(object sender, EventArgs e)
        {
            chiendich_DTO.trangthai = 1;
            chiendich_BUS.thaydoitrangthaichiendich();
            dgv_danhsachchoduyet.DataSource = chiendich_BUS.laychiendichtheoid();
            MessageBox.Show("Đã duyệt chiến dịch thành công!");
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            chiendich_DTO.trangthai = 2;
            chiendich_BUS.thaydoitrangthaichiendich();
            MessageBox.Show("Đã hủy thành công!");
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
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 2:
                    chiendich_DTO.trangthai = 1;
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 3:
                    chiendich_DTO.trangthai = 2;
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1:
                    chiendich_DTO.trangthai = 0;
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 2:
                    chiendich_DTO.trangthai = 1;
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 3:
                    chiendich_DTO.trangthai = 2;
                    dgv_danhsachchoduyet.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
            }
        }
    }
}
