using Phan_mem_quan_ly_voucher.DAO;
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
        application_BUS application_BUS = new application_BUS();
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            admin_DTO.ten = textBox_tennguoidung.Text.Trim().ToString();
            admin_DTO.email = textBox_diachiemail.Text.Trim().ToString();
            admin_DTO.sodienthoai = textBox_sodienthoai.Text.Trim().ToString();
            var datatable = admin_DAO.timquantrivienidbangemail(admin_DTO.email);
            if (datatable.Rows.Count == 1)
            {
                int id = int.Parse(datatable.Rows[0]["doitac_id"].ToString());
                if (application_BUS.CheckExistEmail(admin_DTO.email) == 0)
                {
                    admin_DAO.thaydoithongtinquantrivien(admin_DTO.id, admin_DTO.email, admin_DTO.ten, admin_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                {
                    if (id == admin_DTO.id)
                    {
                        admin_DAO.thaydoithongtinquantrivien(admin_DTO.id, admin_DTO.email, admin_DTO.ten, admin_DTO.sodienthoai);
                        MessageBox.Show("Thay đổi thông tin thành công");
                    }
                    else
                        MessageBox.Show("Email đã tồn tại trong hệ thống!");
                }
            }
            else
            {
                if (application_BUS.CheckExistEmail(admin_DTO.email) == 0)
                {
                    admin_DAO.thaydoithongtinquantrivien(admin_DTO.id, admin_DTO.email, admin_DTO.ten, admin_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                    MessageBox.Show("Email đã tồn tại trong hệ thống!");
            }
        }
        private void admin_thaydoithongtin_Load(object sender, EventArgs e)
        {
            textBox_tendangnhap.Text = admin_DTO.id.ToString();
        }
    }
}
