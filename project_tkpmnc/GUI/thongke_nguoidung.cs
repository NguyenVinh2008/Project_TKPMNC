using project_tkpmnc.DAO;
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
    public partial class thongke_nguoidung : UserControl
    {
        
        public thongke_nguoidung()
        {
            InitializeComponent();
        }
        thongkenguoidung_DAO thongke = new thongkenguoidung_DAO();
        private void thongke_nguoidung_Load(object sender, EventArgs e)
        {
            label_sotaikhoan.Text = thongke.tongsotaikhoan().Rows.Count.ToString();
            label_songuoidung.Text = thongke.tongsonguoidung().Rows.Count.ToString();
            label_sodoitac.Text = thongke.tongsodoitac().Rows.Count.ToString();
            label_soquantrivien.Text = thongke.tongsoquantrivien().Rows.Count.ToString();
            label_sotaikhoanmoi.Text = thongke.tongsotaikhoanmoitrongthang().Rows.Count.ToString();
        }

       
    }
}
