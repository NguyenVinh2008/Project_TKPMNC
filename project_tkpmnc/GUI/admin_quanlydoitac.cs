using DevExpress.XtraPrinting.Native.LayoutAdjustment;
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
            comboBox_danhmuc.SelectedIndex = 0;
            textBox_timkiem.Text = string.Empty;
            dgv_thongtindoitac.DataSource = doitac_DAO.timdoitac();
        }
        private void admin_quanlydoitac_Load(object sender, EventArgs e)
        {
            load();
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
                    dgv_thongtindoitac.DataSource = doitac_DAO.timdoitacgandungtheoemail(search_str);
                    break;
                case "Số điện thoại":
                    dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheosodienthoai(search_str);
                    break;
                case "Trạng thái":
                    if (search_str == "0" || search_str == "1")
                        dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheotrangthai(int.Parse(search_str));
                    else
                        MessageBox.Show("Trạng thái chỉ nhập số 0 (chưa duyệt) và số 1 (đã duyệt)!");
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
            dgv_thongtindoitac.ReadOnly = false;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtindoitac.Rows[0];
            doitac_DTO.id = int.Parse(row.Cells["doitac_id"].Value.ToString());
            doitac_DTO.ten = row.Cells["info_ten"].Value.ToString();
            doitac_DTO.sodienthoai = row.Cells["info_dienthoai"].Value.ToString();
            doitac_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.ten, doitac_DTO.sodienthoai);
            MessageBox.Show("Thay đổi thông tin thành công!");
            dgv_thongtindoitac.DataSource = doitac_DAO.timdoitactheoid(doitac_DTO.id);
            button_save.Enabled = false;
        }
        private void button_reload_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
