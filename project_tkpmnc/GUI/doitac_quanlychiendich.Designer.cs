namespace project_tkpmnc.GUI
{
    partial class doitac_quanlychiendich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_themvoucher = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.button_taochiendich = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinchiendich = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinchiendich)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button_themvoucher);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_chinhsua);
            this.groupBox1.Controls.Add(this.button_taochiendich);
            this.groupBox1.Location = new System.Drawing.Point(7, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 73);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(188, 43);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(85, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Ghi lại";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toàn bộ",
            "Chưa duyệt",
            "Đã duyệt",
            "Đang diễn ra",
            "Đã kết thúc"});
            this.comboBox1.Location = new System.Drawing.Point(61, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button_themvoucher
            // 
            this.button_themvoucher.Location = new System.Drawing.Point(279, 43);
            this.button_themvoucher.Name = "button_themvoucher";
            this.button_themvoucher.Size = new System.Drawing.Size(85, 23);
            this.button_themvoucher.TabIndex = 5;
            this.button_themvoucher.Text = "Thêm voucher";
            this.button_themvoucher.UseVisualStyleBackColor = true;
            this.button_themvoucher.Click += new System.EventHandler(this.button_themvoucher_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(188, 14);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(85, 23);
            this.button_timkiem.TabIndex = 4;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.Location = new System.Drawing.Point(97, 43);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(85, 23);
            this.button_chinhsua.TabIndex = 1;
            this.button_chinhsua.Text = "Chỉnh sửa";
            this.button_chinhsua.UseVisualStyleBackColor = true;
            this.button_chinhsua.Click += new System.EventHandler(this.button_chinhsua_Click);
            // 
            // button_taochiendich
            // 
            this.button_taochiendich.Location = new System.Drawing.Point(6, 43);
            this.button_taochiendich.Name = "button_taochiendich";
            this.button_taochiendich.Size = new System.Drawing.Size(85, 23);
            this.button_taochiendich.TabIndex = 0;
            this.button_taochiendich.Text = "Tạo mới";
            this.button_taochiendich.UseVisualStyleBackColor = true;
            this.button_taochiendich.Click += new System.EventHandler(this.button_taochiendich_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_thongtinchiendich);
            this.groupBox2.Location = new System.Drawing.Point(7, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 254);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chiến dịch";
            // 
            // dgv_thongtinchiendich
            // 
            this.dgv_thongtinchiendich.AllowUserToAddRows = false;
            this.dgv_thongtinchiendich.AllowUserToDeleteRows = false;
            this.dgv_thongtinchiendich.AllowUserToOrderColumns = true;
            this.dgv_thongtinchiendich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtinchiendich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongtinchiendich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinchiendich.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtinchiendich.MultiSelect = false;
            this.dgv_thongtinchiendich.Name = "dgv_thongtinchiendich";
            this.dgv_thongtinchiendich.ReadOnly = true;
            this.dgv_thongtinchiendich.Size = new System.Drawing.Size(476, 229);
            this.dgv_thongtinchiendich.TabIndex = 0;
            this.dgv_thongtinchiendich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtinchiendich_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quản lý chiến dịch";
            // 
            // doitac_quanlychiendich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Name = "doitac_quanlychiendich";
            this.Size = new System.Drawing.Size(506, 364);
            this.Load += new System.EventHandler(this.doitac_quanlychiendich_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinchiendich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.Button button_taochiendich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtinchiendich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_themvoucher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_save;
    }
}
