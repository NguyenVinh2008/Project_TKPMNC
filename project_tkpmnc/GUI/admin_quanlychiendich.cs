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
        public void load_data()
        {
            dgv_thongtinchiendich.DataSource = chiendich_DAO.laythongtinchiendich();
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
                    dgv_thongtinchiendich.DataSource = chiendich_DAO.laychiendichtheotrangthai(chiendich_DTO.trangthai);
                    break;
                case 2:
                    chiendich_DTO.trangthai = 1;
                    dgv_thongtinchiendich.DataSource = chiendich_DAO.laychiendichtheotrangthai(chiendich_DTO.trangthai);
                    break;
                case 3:
                    application_BUS application_BUS = new application_BUS();
                    if (application_BUS.IsNumber(textBox_noidung.Text) == true)
                    {
                        doitac_DTO.id = int.Parse(textBox_noidung.Text);
                        dgv_thongtinchiendich.DataSource = chiendich_DAO.laychiendichtheodoitacid(doitac_DTO.id);
                    }
                    else
                        MessageBox.Show("Vui lòng nhập id đối tác là số!");
                    break;
                case 4:
                    dgv_thongtinchiendich.DataSource = chiendich_DAO.laychiendichtheotengandung(textBox_noidung.Text);
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
    }
}
