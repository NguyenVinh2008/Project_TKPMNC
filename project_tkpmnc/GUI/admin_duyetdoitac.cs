using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_tkpmnc.GUI;
using Phan_mem_quan_ly_voucher.DAO;
using project_tkpmnc.DTO;
namespace project_tkpmnc.GUI
{
   
    public partial class admin_duyetdoitac : DevExpress.XtraEditors.XtraUserControl
    {
        DOITAC_DAO doitac_DAO = new DOITAC_DAO();
        
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
            doitac_DAO.duyetdoitac(doitac_DTO.id, admin_DTO.id);
            dgv_danhsachchoduyet.DataSource = doitac_DAO.timdoitactheotrangthai(0);

        }

        private void admin_duyetdoitac_Load(object sender, EventArgs e)
        {
            dgv_danhsachchoduyet.DataSource = doitac_DAO.timdoitactheotrangthai(0);
        }
    }
}
