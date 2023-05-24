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
    public partial class doitac_quanlychiendich : UserControl
    {
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        public doitac_quanlychiendich()
        {
            InitializeComponent();
        }
        public int chiendich_id;
        private void button_taochiendich_Click(object sender, EventArgs e)
        {
            if (chiendich_DAO.laychiendichidlonnhat().Rows[0]["chiendich_id"] is null)
            {
                chiendich_DTO.chiendich_id = int.Parse(chiendich_DAO.laychiendichidlonnhat().Rows[0]["chiendich_id"].ToString()) + 1;
            }
            else
                chiendich_DTO.chiendich_id = 1;
            chiendich_DTO.doitac_id = doitac_DTO.id;
            chiendich_DTO.trochoi_id = 1;
            chiendich_DTO.chiendich_start = DateTime.Parse(DateTime.Now.ToString());
            chiendich_DTO.chiendich_end = DateTime.Parse(DateTime.Now.ToString());
            chiendich_DAO.taochiendich(chiendich_DTO.doitac_id, chiendich_DTO.trochoi_id, chiendich_DTO.chiendich_start, chiendich_DTO.chiendich_end);

        }
    }
}
