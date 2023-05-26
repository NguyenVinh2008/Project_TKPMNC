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
    public partial class admin_duyetchiendich : UserControl
    {
        public admin_duyetchiendich()
        {
            InitializeComponent();
        }
        chiendich_DAO chiendich_DAO = new chiendich_DAO();

        private void load_data()
        {
            dgv_danhsachchoduyet.DataSource = chiendich_DAO.laychiendichtheotrangthai(0);
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void admin_duyetchiendich_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgv_danhsachchoduyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_danhsachchoduyet.Rows[e.RowIndex];
            chiendich_DTO.chiendich_id = int.Parse(row.Cells["chiendich_id"].Value.ToString());
        }

        private void button_duyet_Click(object sender, EventArgs e)
        {
            chiendich_DAO.duyetchiendich(chiendich_DTO.chiendich_id, admin_DTO.id);
            load_data();
        }
    }
}
