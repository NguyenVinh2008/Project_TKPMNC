using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_tkpmnc.DTO;
using project_tkpmnc.BUS;
using project_tkpmnc.DAO;
using System.Linq.Expressions;
using Phan_mem_quan_ly_voucher.DAO;

namespace project_tkpmnc.GUI
{

    public partial class frm_dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public string email;
        public string password;
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void linklable_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_dangky dangky = new frm_dangky();
            dangky.ShowDialog();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            login_BUS login_BUS = new login_BUS();
            email = textBox_email.Text.Trim().ToString();
            password = login_BUS.GetMD5(textBox_matkhau.Text.Trim().ToString());
            if (login_BUS.CheckLogin(email, password) == 1)
            {
                switch (login_BUS.checkUserType(email))
                {
                    case 0:
                        // Đăng nhập người dùng
                        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();
                        var datatable = nguoidung_DAO.timnguoidungtheoemail(email);
                        nguoidung_DTO.id = int.Parse(datatable.Rows[0]["nguoidung_id"].ToString());
                        nguoidung_DTO.ten = datatable.Rows[0]["info_ten"].ToString();
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        frm_nguoidung dangnhapnguoidung = new frm_nguoidung();
                        dangnhapnguoidung.Text = ("Xin chào: " + nguoidung_DTO.ten);
                        dangnhapnguoidung.ShowDialog();
                        break;
                    case 1:
                        // Đăng nhập quản trị viên
                        admin_DAO admin_DAO = new admin_DAO();
                        datatable = admin_DAO.timquantrivienidbangemail(email);
                        admin_DTO.id = int.Parse(datatable.Rows[0]["quantrivien_id"].ToString());
                        admin_DTO.ten = datatable.Rows[0]["info_ten"].ToString();
                        MessageBox.Show("Đăng nhập admin thành công!");
                        this.Hide();
                        frm_admin dangnhapadmin = new frm_admin();
                        dangnhapadmin.Text = ("Xin chào admin: " + admin_DTO.ten);
                        dangnhapadmin.ShowDialog();
                        break;
                    case 2:
                        // Đăng nhập đối tác
                        if (login_BUS.CheckStatus(email, 1) == 1)
                        {
                            DOITAC_DAO doitac_DAO = new DOITAC_DAO();
                            datatable = doitac_DAO.timdoitactheoemail(email);
                            doitac_DTO.id = int.Parse(datatable.Rows[0]["doitac_id"].ToString());
                            doitac_DTO.ten = datatable.Rows[0]["info_ten"].ToString();
                            MessageBox.Show("Đăng nhập đối tác thành công!");
                            this.Hide();
                            frm_doitac dangnhapdoitac = new frm_doitac();
                            dangnhapdoitac.Text = ("Xin chào đối tác: " + doitac_DTO.ten);
                            dangnhapdoitac.ShowDialog();
                        }
                        else
                            MessageBox.Show("Tài khoản đối tác chưa được quản trị viên duyệt!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sai địa chỉ email hoặc password!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}