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
    public partial class doitac_taovoucher : UserControl
    {
        public doitac_taovoucher()
        {
            InitializeComponent();
        }
        voucher_DAO voucher_DAO = new voucher_DAO();
        phanthuong_DAO phanthuong_DAO = new phanthuong_DAO();
        private void button_taovoucher_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(textBox_soluong.Text);
            for (int i = 0; i < sl; i++)
            {
                voucher_DAO.taovoucher(textBox_giatri.Text);
                voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                phanthuong_DAO.themphanthuong(voucher_DTO.id, chiendich_DTO.chiendich_id);
            }
        }
    }
}
