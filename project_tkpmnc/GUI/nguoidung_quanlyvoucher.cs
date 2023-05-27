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
    public partial class nguoidung_quanlyvoucher : UserControl
    {
        public nguoidung_quanlyvoucher()
        {
            InitializeComponent();
        }
        phanthuong_DAO phanthuong_DAO = new phanthuong_DAO();
        private void load_data()
        {
            dgv_thongtinvoucher.DataSource = phanthuong_DAO.layphanthuongcuanguoidung(nguoidung_DTO.id);
        }

        private void nguoidung_quanlyvoucher_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
