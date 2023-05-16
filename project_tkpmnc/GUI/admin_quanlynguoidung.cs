﻿using project_tkpmnc.BUS;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class admin_quanlynguoidung : UserControl
    {
        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();
        login_BUS login_BUS = new login_BUS();
        public admin_quanlynguoidung()
        {
            InitializeComponent();
        }
        public void load()
        {
            dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidung();
        }
        private void admin_quanlynguoidung_Load(object sender, EventArgs e)
        {
            comboBox_danhmuc.SelectedIndex = 0;
            load();
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string loai = comboBox_danhmuc.SelectedItem.ToString();
            string search_str = textBox_timkiem.Text;
            switch (loai)
            {
                case "Tên":
                    dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidungtheoten(search_str);
                    break;
                case "Email":
                    dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidungtheoemail(search_str);
                    break;
                case "Số điện thoại":
                    dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidungtheosodienthoai(search_str);
                    break;
            }
        }
        private void dgv_thongtinnguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinnguoidung.Rows[e.RowIndex];
            nguoidung_DTO.id = int.Parse(row.Cells["nguoidung_id"].Value.ToString());
            nguoidung_DTO.ten = row.Cells["info_ten"].Value.ToString();
            nguoidung_DTO.email = row.Cells["info_email"].Value.ToString();
            nguoidung_DTO.sodienthoai = row.Cells["info_dienthoai"].Value.ToString();
            nguoidung_DTO.trangthai = int.Parse(row.Cells["info_trangthai"].Value.ToString());
            nguoidung_DTO.updated_at = DateTime.Now;
        }
        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidungtheoid(nguoidung_DTO.id);
            button_save.Enabled = true;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinnguoidung.Rows[0];
            nguoidung_DTO.id = int.Parse(row.Cells["nguoidung_id"].Value.ToString());
            nguoidung_DTO.ten = row.Cells["info_ten"].Value.ToString();
            nguoidung_DTO.email = row.Cells["info_email"].Value.ToString();
            nguoidung_DTO.sodienthoai = row.Cells["info_dienthoai"].Value.ToString();
            nguoidung_DTO.trangthai = int.Parse(row.Cells["info_trangthai"].Value.ToString());
            nguoidung_DAO.thaydoithongtinnguoidung(nguoidung_DTO.id, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai, nguoidung_DTO.trangthai);
            MessageBox.Show("Thay đổi thông tin thành công!");
            dgv_thongtinnguoidung.DataSource = nguoidung_DAO.timnguoidungtheoid(nguoidung_DTO.id);
            button_save.Enabled = false;
        }
        private void button_reload_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
