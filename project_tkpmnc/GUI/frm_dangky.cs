using System;
using System.Windows.Forms;
using project_tkpmnc.DTO;
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
        application_BUS application_BUS = new application_BUS();
        DOITAC_DAO doitac_DAO = new DOITAC_DAO();
        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();
        private void button_dangky_Click(object sender, EventArgs e)
        {
            if (comboBox_loaitaikhoan.SelectedItem.ToString() == "Đối tác")
            {
                // Các giá trị cần dùng khi đăng ký tài khoản đối tác
                doitac_DTO.ten = textBox_tennguoidung.Text.Trim();
                doitac_DTO.email = textBox_diachiemail.Text.Trim();
                doitac_DTO.sodienthoai = textBox_sodienthoai.Text.Trim();
                // Mã hóa mật khẩu MD5
                doitac_DTO.password = application_BUS.GetMD5(textBox_matkhau.Text.Trim());
                if (application_BUS.CheckExistEmail(doitac_DTO.email) == 0)
                {
                    doitac_DAO.themdoitac(doitac_DTO.ten, doitac_DTO.email, doitac_DTO.sodienthoai, doitac_DTO.password);
                    MessageBox.Show("Đăng ký đối tác thành công, vui lòng chờ quản trị viên duyệt!");
                    this.Hide();
                    frm_dangnhap dangnhap = new frm_dangnhap();
                    dangnhap.ShowDialog();
                }
                else
                    MessageBox.Show("Email đã tồn tại");
            }
            if (comboBox_loaitaikhoan.SelectedItem.ToString() == "Người dùng")
            {
                nguoidung_DTO.ten = textBox_tennguoidung.Text.Trim();
                nguoidung_DTO.email = textBox_diachiemail.Text.Trim();
                nguoidung_DTO.sodienthoai = textBox_sodienthoai.Text.Trim();
                // Mã hóa mật khẩu MD5
                nguoidung_DTO.password = application_BUS.GetMD5(textBox_matkhau.Text.Trim());

                if (application_BUS.CheckExistEmail(nguoidung_DTO.email) == 0)
                {
                    nguoidung_DAO.themnguoidung(nguoidung_DTO.ten, nguoidung_DTO.email, nguoidung_DTO.sodienthoai, nguoidung_DTO.password);
                    MessageBox.Show("Đăng ký người dùng thành công!");
                    this.Hide();
                    frm_dangnhap dangnhap = new frm_dangnhap();
                    dangnhap.ShowDialog();
                }
                else
                    MessageBox.Show("Email đã tồn tại");
            }
            else
                MessageBox.Show("Vui lòng chọn loại tài khoản!");
        }
        private void frm_dangky_Load(object sender, EventArgs e)
        {
            comboBox_loaitaikhoan.SelectedIndex = 0;
        }
    }
}
