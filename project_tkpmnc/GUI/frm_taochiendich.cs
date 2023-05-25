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
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        trochoi_DAO trochoi_DAO = new trochoi_DAO();
        private void frm_taochiendich_Load(object sender, EventArgs e)
        {
            int chiendich_id = int.Parse(chiendich_DAO.laychiendichidlonnhat().Rows[0]["chiendich_id"].ToString()) + 1;
            textBox_chiendichid.Text = chiendich_id.ToString();
            textBox_nguoitao.Text = doitac_DTO.id.ToString();
            comboBox_trochoi.DataSource = trochoi_DAO.laydanhsachtrochoi();
            comboBox_trochoi.DisplayMember = "trochoi_ten";
            comboBox_trochoi.ValueMember = "trochoi_id";
        }
        private void button_tao_Click(object sender, EventArgs e)
        {
            chiendich_DTO.doitac_id = doitac_DTO.id;
            chiendich_DTO.trochoi_id = int.Parse(comboBox_trochoi.SelectedValue.ToString());
            chiendich_DTO.chiendich_start = dateTimePicker_start.Value.ToString("yyyy/MM/dd");
            chiendich_DTO.chiendich_end = dateTimePicker_end.Value.ToString("yyyy/MM/dd");
            chiendich_DAO.taochiendich(chiendich_DTO.doitac_id, chiendich_DTO.trochoi_id, chiendich_DTO.chiendich_start, chiendich_DTO.chiendich_end);
            MessageBox.Show("Chiến dịch đã được tạo!");
            this.Close();
        }

       
    }
}
