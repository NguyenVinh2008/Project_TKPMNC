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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_tkpmnc.GUI
{
    public partial class frm_tao_cau_hoi : Form
    {
        public frm_tao_cau_hoi()
        {
            InitializeComponent();
        }
        ochu_BUS ochu_BUS = new ochu_BUS();
        voucher_BUS voucher_BUS = new voucher_BUS();
        phanthuong_BUS phanthuong_BUS = new phanthuong_BUS();
        voucher_DAO voucher_DAO = new voucher_DAO();
        chiendich_BUS chiendich_BUS = new chiendich_BUS();
        private void button_tao_Click(object sender, EventArgs e)
        {
            if(textBox_cauhoi1.Text.Trim().Length == 0 || textBox_cauhoi2.Text.Trim().Length == 0 || textBox_cauhoi3.Text.Trim().Length == 0 ||
               textBox_dapan1.Text.Trim().Length == 0 || textBox_dapan2.Text.Trim().Length == 0 || textBox_dapan3.Text.Trim().Length == 0 ||
               textBox_phanthuong0.Text.Trim().Length == 0 || textBox_phanthuong1.Text.Trim().Length == 0 || textBox_phanthuong2.Text.Trim().Length == 0 || textBox_phanthuong3.Text.Trim().Length == 0 ||
               textBox_sl0.Text.Trim().Length == 0 || textBox_sl1.Text.Trim().Length == 0|| textBox_sl2.Text.Trim().Length == 0|| textBox_sl3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ câu hỏi, đáp án, phần thưởng và số lượng!");
            }
            else
            {
                ochu_DTO.cauhoi1 = textBox_cauhoi1.Text.Trim();
                ochu_DTO.cauhoi2 = textBox_cauhoi2.Text.Trim();
                ochu_DTO.cauhoi3 = textBox_cauhoi3.Text.Trim();
                ochu_DTO.dapan1 = textBox_dapan1.Text.Trim();
                ochu_DTO.dapan2 = textBox_dapan2.Text.Trim();
                ochu_DTO.dapan3 = textBox_dapan3.Text.Trim();
                ochu_DTO.phanthuong0 = textBox_phanthuong0.Text.Trim();
                ochu_DTO.phanthuong1 = textBox_phanthuong1.Text.Trim();
                ochu_DTO.phanthuong2 = textBox_phanthuong2.Text.Trim();
                ochu_DTO.phanthuong3 = textBox_phanthuong3.Text.Trim();
                ochu_BUS.taoochu();

                for (int i = 0; i < int.Parse(textBox_sl0.Text.ToString()); i++)
                {
                    voucher_DAO.taovoucher(ochu_DTO.phanthuong0, voucher_BUS.taomagiamgia());
                    voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                    phanthuong_BUS.themphanthuong();
                }
                for (int i = 0; i < int.Parse(textBox_sl1.Text.ToString()); i++)
                {
                    voucher_DAO.taovoucher(ochu_DTO.phanthuong1, voucher_BUS.taomagiamgia());
                    voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                    phanthuong_BUS.themphanthuong();
                }
                for (int i = 0; i < int.Parse(textBox_sl2.Text.ToString()); i++)
                {
                    voucher_DAO.taovoucher(ochu_DTO.phanthuong2, voucher_BUS.taomagiamgia());
                    voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                    phanthuong_BUS.themphanthuong();
                }
                for (int i = 0; i < int.Parse(textBox_sl3.Text.ToString()); i++)
                {
                    voucher_DAO.taovoucher(ochu_DTO.phanthuong3, voucher_BUS.taomagiamgia());
                    voucher_DTO.id = int.Parse(voucher_DAO.layvoucheridlonnhat().Rows[0]["voucher_id"].ToString());
                    phanthuong_BUS.themphanthuong();
                }
            }
            MessageBox.Show("Thêm ô chữ thành công!");
            this.Close();
        }

        private void frm_tao_cau_hoi_Load(object sender, EventArgs e)
        {
            ochu_DTO.ochu_id = int.Parse(ochu_BUS.layochuidtieptheo().Rows[0]["ochu_id"].ToString());
            chiendich_DTO.chiendich_id = int.Parse(chiendich_BUS.laychiendichidlonnhat().Rows[0]["chiendich_id"].ToString());
        }
    }
}
