using DevExpress.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_tkpmnc.DTO;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Security.Cryptography;
using project_tkpmnc.BUS;
using Phan_mem_quan_ly_voucher.DAO;
using project_tkpmnc.DAO;

namespace project_tkpmnc.GUI
{
    public partial class frm_dangky : Form
    {
        public frm_dangky()
        {
            InitializeComponent();
        }

        login_BUS login = new login_BUS();
        DOITAC_DAO doitac_DAO = new DOITAC_DAO();
        admin_DAO admin_DAO = new admin_DAO();
        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();

        private void button_dangky_Click(object sender, EventArgs e)
        {
            // Các giá trị cần dùng khi đăng ký tài khoản đối tác
            doitac_DTO.ten = textBox_tennguoidung.Text.Trim();
            doitac_DTO.email = textBox_diachiemail.Text.Trim();
            doitac_DTO.sodienthoai = textBox_sodienthoai.Text.Trim();
            // Mã hóa mật khẩu MD5
            doitac_DTO.password = login.GetMD5(textBox_matkhau.Text.Trim());
            if (login.CheckExistEmail(doitac_DTO.email) == 0)
            {
                doitac_DAO.themdoitac(doitac_DTO.ten, doitac_DTO.email, doitac_DTO.sodienthoai, doitac_DTO.password);
                MessageBox.Show("Dữ liệu được ghi nhận, vui lòng chờ quản trị viên duyệt!!!");
            }
            else
                MessageBox.Show("Email đã tồn tại");
        }

        private void button_dangkyadmin_Click(object sender, EventArgs e)
        {

            // Các giá trị cần dùng khi đăng ký tài khoản đối tác
            admin_DTO.ten = textBox_tennguoidung.Text.Trim();
            admin_DTO.email = textBox_diachiemail.Text.Trim();
            admin_DTO.sodienthoai = textBox_sodienthoai.Text.Trim();
            // Mã hóa mật khẩu MD5
            admin_DTO.password = login.GetMD5(textBox_matkhau.Text.Trim());

            if (login.CheckExistEmail(admin_DTO.email) == 0)
            {
                admin_DAO.themquantrivien(admin_DTO.ten, admin_DTO.email, admin_DTO.sodienthoai, admin_DTO.password);
                MessageBox.Show("Thành công!");
            }
            else
                MessageBox.Show("Email đã tồn tại");
        }

        private void button_dangkynguoidung_Click(object sender, EventArgs e)
        {
            nguoidung_DTO.ten = textBox_tennguoidung.Text.Trim();
            nguoidung_DTO.email = textBox_diachiemail.Text.Trim();
            nguoidung_DTO.sodienthoai = textBox_sodienthoai.Text.Trim();
            // Mã hóa mật khẩu MD5
            nguoidung_DTO.password = login.GetMD5(textBox_matkhau.Text.Trim());

            if (login.CheckExistEmail(nguoidung_DTO.email) == 0)
            {
                nguoidung_DAO.themnguoidung(nguoidung_DTO.ten, nguoidung_DTO.email, nguoidung_DTO.sodienthoai, nguoidung_DTO.password);
                MessageBox.Show("Thành công!");
            }
            else
                MessageBox.Show("Email đã tồn tại");
        }
    }
}
