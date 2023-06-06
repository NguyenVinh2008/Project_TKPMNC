using project_tkpmnc.BUS;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class nguoidung_quanlyvoucher : UserControl
    {
        public nguoidung_quanlyvoucher()
        {
            InitializeComponent();
        }
        phanthuong_BUS phanthuong_BUS = new phanthuong_BUS();
        private void load_data()
        {
            dgv_thongtinvoucher.DataSource = phanthuong_BUS.layphanthuongcuanguoidung();
        }

        private void nguoidung_quanlyvoucher_Load(object sender, EventArgs e)
        {
            comboBox_timkiem.SelectedIndex= 0;
            load_data();
            button_sudung.Enabled= false;
        }

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_timkiem.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1: //Chưa sử dụng
                    voucher_DTO.trangthai = 1;
                    dgv_thongtinvoucher.DataSource = phanthuong_BUS.layphanthuongcuanguoidungtheotrangthai();
                    break;
                case 2: //Đã sử dụng
                    voucher_DTO.trangthai = 2;
                    dgv_thongtinvoucher.DataSource = phanthuong_BUS.layphanthuongcuanguoidungtheotrangthai();
                    break; 
            }
        }
    }
}
