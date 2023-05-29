using project_tkpmnc.BUS;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class nguoidung_thaydoithongtin : UserControl
    {
        public nguoidung_thaydoithongtin()
        {
            InitializeComponent();
        }
        nguoidung_BUS nguoidung_BUS = new nguoidung_BUS();
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            nguoidung_DTO.ten = textBox_tennguoidung.Text.Trim().ToString();
            nguoidung_DTO.email = textBox_diachiemail.Text.Trim().ToString();
            nguoidung_DTO.sodienthoai = textBox_sodienthoai.Text.Trim().ToString();
            switch (nguoidung_BUS.thaydoithongtinnguoidungemail())
            {
                case 0:
                    MessageBox.Show("Email đã tồn tại trong hệ thống!");
                    break;
                case 1:
                    MessageBox.Show("Thay đổi thông tin thành công");
                    break;
            }
           
        }

        private void nguoidung_thaydoithongtin_Load(object sender, EventArgs e)
        {
            textBox_tendangnhap.Text = nguoidung_DTO.id.ToString();
        }
    }
}
