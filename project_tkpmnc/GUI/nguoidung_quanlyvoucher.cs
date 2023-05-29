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
            load_data();
        }
    }
}
