using Phan_mem_quan_ly_voucher.DAO;
using project_tkpmnc.BUS;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class admin_quanlydoitac : DevExpress.XtraEditors.XtraUserControl
    {
        DOITAC_DAO doitac_DAO = new DOITAC_DAO();
        login_BUS login_BUS = new login_BUS();
        public admin_quanlydoitac()
        {
            InitializeComponent();
        }
        public void load()
        {
            dgv_thongtindoitac.DataSource = doitac_DAO.timdoitac();
        }
        private void admin_quanlydoitac_Load(object sender, EventArgs e)
        {
            load();
            comboBox_danhmuc.SelectedIndex = 0;
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string loai = comboBox_danhmuc.SelectedItem.ToString();
            string search_str = textBox_timkiem.Text;
            switch (loai)
            {
                case "Tên":
                    dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheoten(search_str);
                    break;
                case "Email":
                    dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheoemail(search_str);
                    break;
                case "Số điện thoại":
                    dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheosodienthoai(search_str);
                    break;
            }
        }
        private void dgv_thongtindoitac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtindoitac.Rows[e.RowIndex];
            doitac_DTO.id = int.Parse(row.Cells["doitac_id"].Value.ToString());
            doitac_DTO.ten = row.Cells["info_ten"].Value.ToString();
            doitac_DTO.email = row.Cells["info_email"].Value.ToString();
            doitac_DTO.sodienthoai = row.Cells["info_dienthoai"].Value.ToString();
            doitac_DTO.updated_at = DateTime.Now;
        }
        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheoid(doitac_DTO.id);
            button_save.Enabled = true;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtindoitac.Rows[0];
            doitac_DTO.id = int.Parse(row.Cells["doitac_id"].Value.ToString());
            doitac_DTO.ten = row.Cells["info_ten"].Value.ToString();
            doitac_DTO.email = row.Cells["info_email"].Value.ToString();
            doitac_DTO.sodienthoai = row.Cells["info_dienthoai"].Value.ToString();
            if (login_BUS.CheckExistEmail(doitac_DTO.email) == 0)
            {
                doitac_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.ten, doitac_DTO.sodienthoai);
                MessageBox.Show("Thay đổi thông tin thành công!");
                dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheoid(doitac_DTO.id);
                button_save.Enabled = false;
            }
            else
            {
                MessageBox.Show("Email đã được đăng ký trong hệ thống!");
            }
        }
        private void button_reload_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
