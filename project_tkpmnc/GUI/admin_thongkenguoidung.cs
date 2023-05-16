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
    public partial class admin_thongkenguoidungcs : UserControl
    {
        thongkenguoidung_DAO thongke = new thongkenguoidung_DAO();
        public admin_thongkenguoidungcs()
        {
            InitializeComponent();
        }

        private void admin_thongkenguoidungcs_Load(object sender, EventArgs e)
        {
            lable_tongsotaikhoan.Text = thongke.tongsotaikhoan().ToString();
            label_songuoidung.Text = thongke.tongsonguoidung().ToString();
            label_sodoitac.Text = thongke.tongsodoitac().ToString();
            label_soquantrivien.Text = thongke.tongsoquantrivien().ToString();
            label_sotaikhoantrongthang.Text = thongke.tongsotaikhoanmoitrongthang().ToString();

        }
    }
}
