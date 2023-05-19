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
    public partial class user_OChuGame : UserControl
    {
        public user_OChuGame()
        {
            InitializeComponent();
        }

        private void button_thamgia_Click(object sender, EventArgs e)
        {
            string cauhoi = "bcsdasdadad";
            label_cauhoi.Text = cauhoi;
        }

        private void button_hoanthanh_Click(object sender, EventArgs e)
        {
            string dapan = "123456789";
            if (textBox1.Text == dapan)
            {
                label_thongbao.Visible = true;
                label_thongbao.Text = "Chúc mừng bạn đã trả lời đúng";
            }
            else
            {
                label_thongbao.Visible = true;
                label_thongbao.Text = "Không chính xác, đáp án là: " + dapan + "";
            }
        }
    }
}
