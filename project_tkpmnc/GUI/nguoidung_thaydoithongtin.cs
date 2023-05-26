using DevExpress.XtraBars.FluentDesignSystem;
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
    public partial class nguoidung_thaydoithongtin : UserControl
    {
        public nguoidung_thaydoithongtin()
        {
            InitializeComponent();
        }
        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();
        login_BUS login_BUS = new login_BUS();
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            nguoidung_DTO.ten = textBox_tennguoidung.Text.Trim().ToString();
            nguoidung_DTO.email = textBox_diachiemail.Text.Trim().ToString();
            nguoidung_DTO.sodienthoai = textBox_sodienthoai.Text.Trim().ToString();
            var datatable = nguoidung_DAO.timnguoidungtheoemail(nguoidung_DTO.email);
            if (datatable.Rows.Count == 1)/*int.Parse(datatable.Rows[0]["doitac_id"].ToString()) == 0*/
            {
                int id = int.Parse(datatable.Rows[0]["nguoidung_id"].ToString());
                if (login_BUS.CheckExistEmail(nguoidung_DTO.email) == 0)
                {
                    nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                {
                    if (id == nguoidung_DTO.id)
                    {
                        nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                        MessageBox.Show("Thay đổi thông tin thành công");
                    }
                    else
                        MessageBox.Show("Email đã tồn tại trong hệ thống!");
                }
            }
            else
            {
                if (login_BUS.CheckExistEmail(nguoidung_DTO.email) == 0)
                {
                    nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                    MessageBox.Show("Email đã tồn tại trong hệ thống!");
            }

        }

        private void nguoidung_thaydoithongtin_Load(object sender, EventArgs e)
        {
            textBox_tendangnhap.Text = nguoidung_DTO.id.ToString();
        }
    }
}
