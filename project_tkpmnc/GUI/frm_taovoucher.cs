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
    public partial class frm_taovoucher : Form
    {
        public frm_taovoucher()
        {
            InitializeComponent();
        }
        voucher_DAO voucher_DAO = new voucher_DAO();
        phanthuong_DAO phanthuong_DAO = new phanthuong_DAO();
        voucher_BUS voucher_BUS = new voucher_BUS();
        private void doitac_taovoucher_Load(object sender, EventArgs e)
        {
            textBox1.Text = chiendich_DTO.chiendich_id.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_taovoucher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox_soluong.Text.ToString()); i++)
            {
                voucher_DAO.taovoucher(textBox_giatri.Text.ToString(), voucher_BUS.taomagiamgia());
                voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                phanthuong_DAO.themphanthuong(voucher_DTO.id, int.Parse(textBox1.Text));
            }
            MessageBox.Show("Thêm voucher vào chiến dịch thành công!");
        }
    }
}
