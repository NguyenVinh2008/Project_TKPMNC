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
using project_tkpmnc.BUS;
using System.Linq.Expressions;

namespace project_tkpmnc.GUI
{
    public partial class admin_quanlychiendich : UserControl
    {
        public admin_quanlychiendich()
        {
            InitializeComponent();
        }
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        chiendich_BUS chiendich_BUS = new chiendich_BUS();
        public void load_data()
        {
            dgv_thongtinchiendich.DataSource = chiendich_BUS.laythongtinchiendich();
        }

        private void admin_quanlychiendich_Load(object sender, EventArgs e)
        {
            dgv_thongtinchiendich.ReadOnly = true;
            comboBox_timkiem.SelectedIndex = 0;
            textBox_noidung.ReadOnly = true;
            load_data();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            switch (comboBox_timkiem.SelectedIndex)
            {
                case 0:
                    load_data();
                    break;
                case 1:
                    chiendich_DTO.trangthai = 0;
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 2:
                    chiendich_DTO.trangthai = 1;
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.timkiemtheotrangthai();
                    break;
                case 3:
                    application_BUS application_BUS = new application_BUS();
                    if (application_BUS.IsNumber(textBox_noidung.Text) == true)
                    {
                        doitac_DTO.id = int.Parse(textBox_noidung.Text);
                        dgv_thongtinchiendich.DataSource = chiendich_BUS.timkiemtheoiddoitac();
                    }
                    else
                        MessageBox.Show("Vui lòng nhập id đối tác là số!");
                    break;
                case 4:
                    dgv_thongtinchiendich.DataSource = chiendich_BUS.timkiemtheotengandung(textBox_noidung.Text);
                    break;
            }
        }

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_timkiem.SelectedIndex)
            {
                case 0:
                    {
                        textBox_noidung.Visible = false;
                        label_noidungtimkiem.Visible = false;
                        break;
                    }
                case 1:
                    {
                        textBox_noidung.Visible = false;
                        label_noidungtimkiem.Visible = false;
                        break;
                    }
                case 2:
                    {
                        textBox_noidung.Visible = false;
                        label_noidungtimkiem.Visible = false;
                        break;
                    }
                case 3:
                    {
                        textBox_noidung.Visible = true;
                        label_noidungtimkiem.Visible = true;
                        textBox_noidung.ReadOnly = false;
                        label_noidungtimkiem.Text = "Đối tác ID:";
                        break;
                    }
                case 4:
                    {
                        textBox_noidung.Visible = true;
                        label_noidungtimkiem.Visible = true;
                        textBox_noidung.ReadOnly = false;
                        label_noidungtimkiem.Text = "Tên chiến dịch:";
                        break;
                    }
            }
        }

        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            if (chiendich_DTO.chiendich_id == 0)
            {
                MessageBox.Show("Vui lòng chọn chiến dịch bạn muốn chỉnh sửa!");
            }
            else
            {
                dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichtheoid();
                button_save.Enabled = true;
                dgv_thongtinchiendich.ReadOnly = false;
            }
        }

        private void dgv_thongtinchiendich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinchiendich.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.chiendich_ten = row.Cells["chiendich_ten"].Value.ToString();
            chiendich_DTO.doitac_id = int.Parse(row.Cells["taoboi_doitac_id"].Value.ToString());
            chiendich_DTO.trochoi_id = int.Parse(row.Cells["trochoi_id"].Value.ToString());
            chiendich_DTO.trangthai = int.Parse(row.Cells["chiendich_trangthai"].Value.ToString());
            chiendich_DTO.chiendich_start = row.Cells["chiendich_start"].Value.ToString();
            chiendich_DTO.chiendich_end = row.Cells["chiendich_end"].Value.ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_thongtinchiendich.Rows[0];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
            chiendich_DTO.chiendich_ten = row.Cells["chiendich_ten"].Value.ToString();
            chiendich_DTO.trochoi_id = int.Parse(row.Cells["trochoi_id"].Value.ToString());
            chiendich_DAO.thaydoithongtinchiendich(chiendich_DTO.chiendich_id, chiendich_DTO.chiendich_ten);
            MessageBox.Show("Thay đổi thông tin chiến dịch thành công!");
            dgv_thongtinchiendich.DataSource = chiendich_BUS.laychiendichtheoid();
            button_save.Enabled = false;
        }
    }
}
