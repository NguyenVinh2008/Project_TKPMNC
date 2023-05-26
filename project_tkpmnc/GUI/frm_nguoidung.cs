using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_tkpmnc.GUI
{
    public partial class frm_nguoidung : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_nguoidung()
        {
            InitializeComponent();
        }
        nguoidung_thamgiatrochoi ucThamgiatrochoi;
        nguoidung_thaydoithongtin ucThaydoithongtin;
        private void ce_thaydoithongtin_Click(object sender, EventArgs e)
        {
            if (ucThaydoithongtin == null)
            {
                ucThaydoithongtin = new nguoidung_thaydoithongtin();
                ucThaydoithongtin.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucThaydoithongtin);
                ucThaydoithongtin.BringToFront();
            }
            else
                ucThaydoithongtin.BringToFront();
        }

        private void ce_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ce_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dangnhap dangnhap = new frm_dangnhap();
            dangnhap.ShowDialog();
        }

        private void ce_thamgiatrochoi_Click(object sender, EventArgs e)
        {
            if (ucThamgiatrochoi == null)
            {
                ucThamgiatrochoi = new nguoidung_thamgiatrochoi();
                ucThamgiatrochoi.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucThamgiatrochoi);
                ucThamgiatrochoi.BringToFront();
            }
            else
                ucThamgiatrochoi.BringToFront();
        }
    }
}
