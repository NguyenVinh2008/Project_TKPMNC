namespace project_tkpmnc
{
    partial class frm_doitac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ce_quanlychiendich = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ce_quanlyvoucher = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ce_thaydoithongtin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ce_dangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ce_thoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1104, 736);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 736);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ce_quanlychiendich});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản lý chiến dịch";
            // 
            // ce_quanlychiendich
            // 
            this.ce_quanlychiendich.Name = "ce_quanlychiendich";
            this.ce_quanlychiendich.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ce_quanlychiendich.Text = "Quản lý chiến dịch";
            this.ce_quanlychiendich.Click += new System.EventHandler(this.ce_quanlychiendich_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ce_quanlyvoucher});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Quản lý voucher";
            // 
            // ce_quanlyvoucher
            // 
            this.ce_quanlyvoucher.Name = "ce_quanlyvoucher";
            this.ce_quanlyvoucher.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ce_quanlyvoucher.Text = "Quản lý voucher";
            this.ce_quanlyvoucher.Click += new System.EventHandler(this.ce_quanlyvoucher_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ce_thaydoithongtin});
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Thay đổi thông tin";
            // 
            // ce_thaydoithongtin
            // 
            this.ce_thaydoithongtin.Name = "ce_thaydoithongtin";
            this.ce_thaydoithongtin.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ce_thaydoithongtin.Text = "Thay đổi thông tin";
            this.ce_thaydoithongtin.Click += new System.EventHandler(this.ce_thaydoithongtin_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ce_dangxuat,
            this.ce_thoat});
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Hệ thống";
            // 
            // ce_dangxuat
            // 
            this.ce_dangxuat.Name = "ce_dangxuat";
            this.ce_dangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ce_dangxuat.Text = "Đăng xuất";
            // 
            // ce_thoat
            // 
            this.ce_thoat.Name = "ce_thoat";
            this.ce_thoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ce_thoat.Text = "Thoát chương trình";
            this.ce_thoat.Click += new System.EventHandler(this.ce_thoat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1364, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frm_doitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 767);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frm_doitac";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Đối tác";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ce_quanlychiendich;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ce_quanlyvoucher;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ce_thaydoithongtin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ce_dangxuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ce_thoat;
    }
}