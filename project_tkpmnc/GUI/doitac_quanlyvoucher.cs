using project_tkpmnc.BUS;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class doitac_quanlyvoucher : UserControl
    {
        public doitac_quanlyvoucher()
        {
            InitializeComponent();
        }
        voucher_BUS voucher_BUS = new voucher_BUS();
        private void load_data()
        {
            dgv_thongtinvoucher.DataSource = voucher_BUS.layvouchertheodoitac();
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            switch (comboBox_timkiem.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1:
                    voucher_DTO.trangthai = 0;
                    break;
                case 2:
                    voucher_DTO.trangthai = 1;
                    break;
                case 3:
                    voucher_DTO.trangthai = 2;
                    break;
            }
            dgv_thongtinvoucher.DataSource = voucher_BUS.layvouchercuadoitactheotrangthai();

        }

        private void doitac_quanlyvoucher_Load(object sender, EventArgs e)
        {
            load_data();
            comboBox_timkiem.SelectedIndex = 0;
            dgv_thongtinvoucher.ReadOnly = true;
        }

        private void dgv_thongtinvoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinvoucher.Rows[e.RowIndex];
            voucher_DTO.id = int.Parse(row.Cells["voucher_id"].Value.ToString());
            voucher_DTO.giatri = row.Cells["voucher_giatri"].Value.ToString();
            voucher_DTO.magiamgia = row.Cells["voucher_magiamgia"].Value.ToString();
            voucher_DTO.trangthai = int.Parse(row.Cells["voucher_trangthai"].Value.ToString());
        }

        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            if (voucher_DTO.id == 0)
            {
                MessageBox.Show("Vui lòng chọn voucher bạn muốn chỉnh sửa!");
            }
            else
            {
                dgv_thongtinvoucher.DataSource = voucher_BUS.layvouchercuadoitactheovoucherid();
                button_save.Enabled = true;
                dgv_thongtinvoucher.ReadOnly = false;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinvoucher.Rows[0];
            voucher_DTO.id = int.Parse(row.Cells["voucher_id"].Value.ToString());
            voucher_DTO.giatri = row.Cells["voucher_giatri"].Value.ToString();
            dgv_thongtinvoucher.DataSource = voucher_BUS.updatevouchertheogiatri();
            MessageBox.Show("Thay đổi giá trị voucher thành công!");
            dgv_thongtinvoucher.DataSource = voucher_BUS.layvouchercuadoitactheovoucherid();
            button_save.Enabled = false;
        }
    }
}
