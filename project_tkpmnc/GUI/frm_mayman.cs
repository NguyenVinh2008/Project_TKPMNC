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
    public partial class frm_mayman : Form
    {
        public frm_mayman()
        {
            InitializeComponent();
        }
        voucher_DAO voucher_DAO = new voucher_DAO();
        phanthuong_DAO phanthuong_DAO = new phanthuong_DAO();
        int count;
        
        private void button_quayso_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button_quayso.Text = button_quayso.Text == "Dừng lại" ? "Bắt đầu" : "Dừng lại";
            if (button_quayso.Text == "Bắt đầu")
            {
                label_thongbao.Visible = true;
                label_ketqua.ForeColor = Color.Red;
                button_themvaotaikhoan.Visible = true;
                button_quayso.Enabled = false;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var phanthuong = voucher_DAO.layphanthuongcuachiendichbangtrangthai(chiendich_DTO.chiendich_id, 0);
            count = phanthuong.Rows.Count;
            string[] dsphanthuong = new string[count];
            for(int i = 0; i < count; i++)
            {
                dsphanthuong[i] = phanthuong.Rows[i]["voucher_giatri"].ToString();
            }
            Random r = new Random();
            int num = r.Next(0, dsphanthuong.Length);
            label1.Text = phanthuong.Rows[num]["voucher_magiamgia"].ToString();
            label_ketqua.Text = dsphanthuong[num];
        }
        private void button_themvaotaikhoan_Click(object sender, EventArgs e)
        {
            DataTable dataTable = voucher_DAO.layvoucheridbangmagiamgia(label1.Text.Trim());
            voucher_DTO.id = int.Parse(dataTable.Rows[0]["voucher_id"].ToString());
            dataTable = phanthuong_DAO.layphanthuongbangvoucherid(voucher_DTO.id);
            phanthuong_DTO.id = int.Parse(dataTable.Rows[0]["phanthuong_id"].ToString());
            phanthuong_DAO.themphanthuongvaotaikhoannguoidung(nguoidung_DTO.id, phanthuong_DTO.id);
            MessageBox.Show("Thêm phần thưởng vào tài khoản thành công!");
        }
    }
}
