using project_tkpmnc.BUS;
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
    public partial class admin_thaydoithongtin : UserControl
    {
        public admin_thaydoithongtin()
        {
            InitializeComponent();
        }
        admin_DAO admin_DAO = new admin_DAO();
        login_BUS login_BUS = new login_BUS();
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            admin_DTO.ten = textBox_tennguoidung.Text.Trim().ToString();
            admin_DTO.email = textBox_diachiemail.Text.Trim().ToString();
            admin_DTO.sodienthoai = textBox_sodienthoai.Text.Trim().ToString();
            if (login_BUS.CheckExistEmail(admin_DTO.email) == 1)
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!");
            }
            else
            {
                admin_DAO.thaydoithongtinquantrivien(admin_DTO.id, admin_DTO.ten, admin_DTO.email, admin_DTO.sodienthoai);
                MessageBox.Show("Thay đổi thông tin thành công");
            }
        }
        private void admin_thaydoithongtin_Load(object sender, EventArgs e)
        {
            textBox_tendangnhap.Text = admin_DTO.id.ToString();
        }
    }
}
