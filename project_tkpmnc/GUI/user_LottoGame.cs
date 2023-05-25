using DevExpress.Data.Utils;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Mask;
using project_tkpmnc.BUS;
using project_tkpmnc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class user_LottoGame : UserControl
    {
        public user_LottoGame()
        {
            InitializeComponent();
        }
       
        private void button_quayso_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button_quayso.Text = button_quayso.Text == "Dừng lại" ? "Bắt đầu" : "Dừng lại";
            if (button_quayso.Text == "Bắt đầu")
            {     
                label_thongbao.Visible = true;
                label_ketqua.ForeColor = Color.Red;
                button_themvaotaikhoan.Visible= true;
                button_quayso.Enabled = false;
                //MessageBox.Show("Chúc mừng bạn đã nhận được phần thưởng: " + label_ketqua.Text);
            }    
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] phanthuong = new string[] { "DISCOUNT 5%", "DISCOUNT 10%", "DISCOUNT 15%", "DISCOUNT 20%", "DISCOUNT 25%", "DISCOUNT 10k", "DISCOUNT 20k", "DISCOUNT 40k", "DISCOUNT 50k" };
            Random r = new Random();
            int num = r.Next(0, phanthuong.Length);
            label_ketqua.Text = phanthuong[num];
        }

        
    }
}
