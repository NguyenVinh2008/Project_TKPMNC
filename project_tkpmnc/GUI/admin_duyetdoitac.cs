using System;
using System.Windows.Forms;
using project_tkpmnc.DTO;
using project_tkpmnc.BUS;

namespace project_tkpmnc.GUI
{

    public partial class admin_duyetdoitac : DevExpress.XtraEditors.XtraUserControl
    {
        doitac_BUS doitac_BUS = new doitac_BUS();
        public admin_duyetdoitac()
        {
            InitializeComponent();
        }

        private void dgv_danhsachchoduyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_danhsachchoduyet.Rows[e.RowIndex];
            doitac_DTO.id = int.Parse(row.Cells["ID"].Value.ToString());
        }

        private void button_duyet_Click(object sender, EventArgs e)
        {
            doitac_BUS.duyetdoitac();
            dgv_danhsachchoduyet.DataSource = doitac_BUS.timdoitactheotrangthai(0);
        }

        private void admin_duyetdoitac_Load(object sender, EventArgs e)
        {
            dgv_danhsachchoduyet.DataSource = doitac_BUS.timdoitactheotrangthai(0);
        }
    }
}
