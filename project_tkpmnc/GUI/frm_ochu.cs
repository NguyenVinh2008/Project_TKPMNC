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
    public partial class frm_ochu : Form
    {
        public frm_ochu()
        {
            InitializeComponent();
        }
        ochu_BUS ochu_BUS = new ochu_BUS();
        //thamgia_DAO thamgia_DAO = new thamgia_DAO();
        thamgia_BUS thamgia_BUS = new thamgia_BUS();
        private void button_thamgia_Click(object sender, EventArgs e)
        {
            thamgia_BUS.taonguoidungthamgiachiendich();
            ochu_BUS.layochu();
            button_hoanthanh.Enabled = true;
            label_noidung1.Visible = true;
            label_noidung1.Text = ochu_DTO.cauhoi1;
            label_noidung2.Visible = true;
            label_noidung2.Text = ochu_DTO.cauhoi2;
            label_noidung3.Visible = true;
            label_noidung3.Text = ochu_DTO.cauhoi3;
            dapan1.ReadOnly = false;
            dapan2.ReadOnly = false;
            dapan3.ReadOnly = false;

        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            ochu_DTO.dapan1 = dapan1.Text.ToString();
            ochu_DTO.dapan2 = dapan2.Text.ToString();
            ochu_DTO.dapan3 = dapan3.Text.ToString();
            switch (ochu_BUS.kiemtradapan())
            {
                case 0:
                    label_phanthuong.Text = ochu_DTO.phanthuong0;
                    voucher_DTO.giatri = ochu_DTO.phanthuong0;
                    break;
                case 1:
                    label_phanthuong.Text = ochu_DTO.phanthuong1;
                    voucher_DTO.giatri = ochu_DTO.phanthuong1;
                    break;
                case 2:
                    label_phanthuong.Text = ochu_DTO.phanthuong2;
                    voucher_DTO.giatri = ochu_DTO.phanthuong2;
                    break;
                case 3:
                    label_phanthuong.Text = ochu_DTO.phanthuong3;
                    voucher_DTO.giatri = ochu_DTO.phanthuong3;
                    break;
            }
            label_phanthuong.Visible = true;
            button_nhanthuong.Enabled = true;
            dapan1.Enabled = false; 
            dapan2.Enabled = false;
            dapan3.Enabled = false;
            button_hoanthanh.Enabled = false;
            //button_nhanthuong.Text = voucher_DTO.giatri.ToString();
        }

        private void button_nhanthuong_Click(object sender, EventArgs e)
        {
            ochu_BUS.ganphanthuongvaotaikhoan();
            MessageBox.Show("Voucher đã thêm vào tài khoản!");
            this.Close();
        }
    }
}
