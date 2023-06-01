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
    public partial class frm_taochiendich : Form
    {
        public frm_taochiendich()
        {
            InitializeComponent();
        }
        chiendich_BUS chiendich_BUS = new chiendich_BUS();
        trochoi_BUS trochoi_BUS = new trochoi_BUS();
        private void frm_taochiendich_Load(object sender, EventArgs e)
        {
            chiendich_DTO.chiendich_id = int.Parse(chiendich_BUS.laychiendichidlonnhat().Rows[0]["chiendich_id"].ToString());
            textBox_chiendichid.Text = chiendich_DTO.chiendich_id.ToString();
            textBox_nguoitao.Text = doitac_DTO.id.ToString();
            comboBox_trochoi.DataSource = trochoi_BUS.laydanhsachtrochoi();
            comboBox_trochoi.DisplayMember = "trochoi_ten";
            comboBox_trochoi.ValueMember = "trochoi_id";
        }
        private void button_tao_Click(object sender, EventArgs e)
        {
            switch (comboBox_trochoi.SelectedIndex)
            {
                case 0:
                    chiendich_DTO.chiendich_ten = textBox_tenchiendich.Text;
                    trochoi_DTO.id = int.Parse(comboBox_trochoi.SelectedValue.ToString());
                    chiendich_DTO.chiendich_start = dateTimePicker_start.Value.ToString("yyyy/MM/dd");
                    chiendich_DTO.chiendich_end = dateTimePicker_end.Value.ToString("yyyy/MM/dd");
                    chiendich_BUS.taochiendich();
                    MessageBox.Show("Tạo chiến dịch mới thành công!");
                    frm_tao_cau_hoi taocauhoi = new frm_tao_cau_hoi();
                    taocauhoi.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    chiendich_DTO.chiendich_ten = textBox_tenchiendich.Text;
                    trochoi_DTO.id = int.Parse(comboBox_trochoi.SelectedValue.ToString());
                    chiendich_DTO.chiendich_start = dateTimePicker_start.Value.ToString("yyyy/MM/dd");
                    chiendich_DTO.chiendich_end = dateTimePicker_end.Value.ToString("yyyy/MM/dd");
                    chiendich_BUS.taochiendich();
                    MessageBox.Show("Tạo chiến dịch mới thành công!");
                    frm_taovoucher taovoucher = new frm_taovoucher();
                    taovoucher.ShowDialog();
                    this.Close();
                    break;
            }
        }
    }
}
