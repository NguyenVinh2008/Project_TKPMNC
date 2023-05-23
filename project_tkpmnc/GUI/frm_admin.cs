using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using project_tkpmnc.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_tkpmnc
{
    public partial class frm_admin : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_admin()
        {
            InitializeComponent();
        }
        admin_duyetdoitac ucDuyetdoitac;
        admin_quanlydoitac ucQuanlydoitac;
        admin_duyetchiendich ucDuyetchiendich;
        admin_quanlychiendich ucQuanlychiendich;
        admin_quanlynguoidung ucQuanlynguoidung;
        admin_quanlyvoucher ucQuanlyvoucher;
        admin_thaydoithongtin ucThaydoithongtin;
        thongke_nguoidung ucThongkenguoidung;
        user_LottoGame ucLotto;
        user_OChuGame ucOChu;
        private void ce_quanlychiendich_Click(object sender, EventArgs e)
        {
            if (ucQuanlychiendich == null)
            {
                ucQuanlychiendich = new admin_quanlychiendich();
                ucQuanlychiendich.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlychiendich);
                ucQuanlychiendich.BringToFront();
            }
            else
                ucQuanlychiendich.BringToFront();
        }

        private void ce_duyetchiendich_Click(object sender, EventArgs e)
        {
            if (ucDuyetchiendich == null)
            {
                ucDuyetchiendich = new admin_duyetchiendich();
                ucDuyetchiendich.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucDuyetchiendich);
                ucDuyetchiendich.BringToFront();
            }
            else
                ucDuyetchiendich.BringToFront();
        }

        private void ce_quanlyvoucher_Click(object sender, EventArgs e)
        {
            if (ucQuanlyvoucher == null)
            {
                ucQuanlyvoucher = new admin_quanlyvoucher();
                ucQuanlyvoucher.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlyvoucher);
                ucQuanlyvoucher.BringToFront();
            }
            else
                ucQuanlyvoucher.BringToFront();
        }

        private void ce_quanlydoitac_Click(object sender, EventArgs e)
        {
            if (ucQuanlydoitac == null)
            {
                ucQuanlydoitac = new admin_quanlydoitac();
                ucQuanlydoitac.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlydoitac);
                ucQuanlydoitac.load();
            }
            else
                ucQuanlydoitac.BringToFront();
        }

        private void ce_duyetdoitac_Click(object sender, EventArgs e)
        {
            if (ucDuyetdoitac == null)
            {
                ucDuyetdoitac = new admin_duyetdoitac();
                ucDuyetdoitac.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucDuyetdoitac);
                ucDuyetdoitac.BringToFront();
            }
            else
                ucDuyetdoitac.BringToFront();
        }

        private void ce_quanlynguoidung_Click(object sender, EventArgs e)
        {
            if (ucQuanlynguoidung == null)
            {
                ucQuanlynguoidung = new admin_quanlynguoidung();
                ucQuanlynguoidung.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucQuanlynguoidung);
                ucQuanlynguoidung.BringToFront();
            }
            else
                ucQuanlynguoidung.BringToFront();
        }

        

        private void ce_thaydoithongtin_Click(object sender, EventArgs e)
        {
            if (ucThaydoithongtin == null)
            {
                ucThaydoithongtin = new admin_thaydoithongtin();
                ucThaydoithongtin.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucThaydoithongtin);
                ucThaydoithongtin.BringToFront();
            }
            else
                ucThaydoithongtin.BringToFront();
        }

        private void ce_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void ce_thongketaikhoan_Click(object sender, EventArgs e)
        {
            if (ucThongkenguoidung == null)
            {
                ucThongkenguoidung = new thongke_nguoidung();
                ucThongkenguoidung.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucThongkenguoidung);
                ucThongkenguoidung.BringToFront();
            }
            else
                ucThongkenguoidung.BringToFront();
        }

        private void ce_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dangnhap dangnhap = new frm_dangnhap();
            dangnhap.ShowDialog();

        }

        private void ce_testform_Click(object sender, EventArgs e)
        {
            if (ucLotto == null)
            {
                ucLotto = new user_LottoGame();
                ucLotto.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucLotto);
                ucLotto.BringToFront();
            }
            else
                ucLotto.BringToFront();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (ucOChu == null)
            {
                ucOChu = new user_OChuGame();
                ucOChu.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(ucOChu);
                ucOChu.BringToFront();
            }
            else
                ucOChu.BringToFront();
        }
    }
}
