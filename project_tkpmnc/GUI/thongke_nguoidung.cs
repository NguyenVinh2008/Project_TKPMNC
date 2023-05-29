using project_tkpmnc.BUS;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class thongke_nguoidung : UserControl
    {
        public thongke_nguoidung()
        {
            InitializeComponent();
        }
        nguoidung_BUS nguoidung_BUS = new nguoidung_BUS();
        private void thongke_nguoidung_Load(object sender, EventArgs e)
        {
            label_sotaikhoan.Text = nguoidung_BUS.tongsotaikhoan().Rows.Count.ToString();
            label_songuoidung.Text = nguoidung_BUS.tongsonguoidung().Rows.Count.ToString();
            label_sodoitac.Text = nguoidung_BUS.tongsodoitac().Rows.Count.ToString();
            label_soquantrivien.Text = nguoidung_BUS.tongsoquantrivien().Rows.Count.ToString();
            label_sotaikhoanmoi.Text = nguoidung_BUS.tongsotaikhoanmoitrongthang().Rows.Count.ToString();
        }       
    }
}
