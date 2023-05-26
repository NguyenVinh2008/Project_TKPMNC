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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_tkpmnc.GUI
{
    public partial class doitac_thaydoithongtin : UserControl
    {
        public doitac_thaydoithongtin()
        {
            InitializeComponent();
        }
        login_BUS login_BUS = new login_BUS();
        DOITAC_DAO DOITAC_DAO = new DOITAC_DAO();
        private void button_capnhat_Click(object sender, EventArgs e)
        {
            doitac_DTO.ten = textBox_tennguoidung.Text.Trim().ToString();
            doitac_DTO.email = textBox_diachiemail.Text.Trim().ToString();
            doitac_DTO.sodienthoai = textBox_sodienthoai.Text.Trim().ToString();
            var datatable = DOITAC_DAO.timdoitactheoemail(doitac_DTO.email);
            if (datatable.Rows.Count == 1)/*int.Parse(datatable.Rows[0]["doitac_id"].ToString()) == 0*/
            {
                int id = int.Parse(datatable.Rows[0]["doitac_id"].ToString());
                if (login_BUS.CheckExistEmail(doitac_DTO.email) == 0)
                {
                    DOITAC_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.email, doitac_DTO.ten, doitac_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                {
                    if (id == doitac_DTO.id)
                    {
                        DOITAC_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.email, doitac_DTO.ten, doitac_DTO.sodienthoai);
                        MessageBox.Show("Thay đổi thông tin thành công");
                    }
                    else
                        MessageBox.Show("Email đã tồn tại trong hệ thống!");
                }
            }
            else
            {
                if (login_BUS.CheckExistEmail(doitac_DTO.email) == 0)
                {
                    DOITAC_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.email, doitac_DTO.ten, doitac_DTO.sodienthoai);
                    MessageBox.Show("Thay đổi thông tin thành công");
                }
                else
                    MessageBox.Show("Email đã tồn tại trong hệ thống!");
            }
        }
        private void doitac_thaydoithongtin_Load(object sender, EventArgs e)
        {
            textBox_tendangnhap.Text = doitac_DTO.id.ToString();
        }
    }
}
