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
            frm_dangky dangky = new frm_dangky();
            dangky.ShowDialog();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            login_BUS login_BUS = new login_BUS();
            email = textBox_email.Text.Trim();
            password = login_BUS.GetMD5(textBox_matkhau.Text.Trim());
            if (login_BUS.CheckLogin(email, password) == 1)
            {
                if (checkBox_admin.Checked)
                {
                    if (login_BUS.CheckAdmin(email) == 1)
                    {
                        admin_DAO admin_DAO = new admin_DAO();
                        var datatable = admin_DAO.timquantrivienidbangemail(email);
                        admin_DTO.id = int.Parse(datatable.Rows[0]["quantrivien_id"].ToString());
                        admin_DTO.ten = datatable.Rows[0]["info_ten"].ToString();
                        MessageBox.Show("Đăng nhập admin thành công!");
                        this.Hide();
                        frm_admin dangnhapadmin = new frm_admin();
                        dangnhapadmin.Text = ("welcome admin name: " + admin_DTO.ten + " id: " + admin_DTO.id);
                        dangnhapadmin.ShowDialog();

                    }
                    else
                        MessageBox.Show("Đăng nhập không thành công!");
                }
                else
                {
                    if (login_BUS.CheckAdmin(email) != 1)
                    {
                        if (login_BUS.CheckStatus(email, 1) == 1)
                        {
                            MessageBox.Show("Đăng nhập đối tác thành công!");
                            frm_doitac dangnhapdoitac = new frm_doitac();
                            dangnhapdoitac.ShowDialog();
                        }
                        else
                            MessageBox.Show("Tài khoản đối tác chưa được quản trị viên duyệt!");
                    }
                    else
                        MessageBox.Show("Đăng nhập không thành công!");
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