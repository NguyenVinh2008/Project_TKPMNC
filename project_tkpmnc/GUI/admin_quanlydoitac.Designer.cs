namespace project_tkpmnc.GUI
{
    partial class admin_quanlydoitac
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
            this.comboBox_danhmuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtindoitac = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindoitac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_reload);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.comboBox_danhmuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_timkiem);
            this.groupBox1.Controls.Add(this.button_chinhsua);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // comboBox_danhmuc
            // 
            this.comboBox_danhmuc.FormattingEnabled = true;
            this.comboBox_danhmuc.Items.AddRange(new object[] {
            "Tên",
            "Email",
            "Số điện thoại"});
            this.comboBox_danhmuc.Location = new System.Drawing.Point(60, 14);
            this.comboBox_danhmuc.Name = "comboBox_danhmuc";
            this.comboBox_danhmuc.Size = new System.Drawing.Size(134, 21);
            this.comboBox_danhmuc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm theo";
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(411, 12);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
            this.button_timkiem.TabIndex = 4;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(253, 14);
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(152, 21);
            this.textBox_timkiem.TabIndex = 2;
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.Location = new System.Drawing.Point(87, 41);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(75, 23);
            this.button_chinhsua.TabIndex = 0;
            this.button_chinhsua.Text = "Chỉnh sửa";
            this.button_chinhsua.UseVisualStyleBackColor = true;
            this.button_chinhsua.Click += new System.EventHandler(this.button_chinhsua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_thongtindoitac);
            this.groupBox2.Location = new System.Drawing.Point(4, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đối tác";
            // 
            // dgv_thongtindoitac
            // 
            this.dgv_thongtindoitac.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_thongtindoitac.AllowUserToAddRows = false;
            this.dgv_thongtindoitac.AllowUserToDeleteRows = false;
            this.dgv_thongtindoitac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtindoitac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongtindoitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtindoitac.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtindoitac.Name = "dgv_thongtindoitac";
            this.dgv_thongtindoitac.Size = new System.Drawing.Size(476, 230);
            this.dgv_thongtindoitac.TabIndex = 0;
            this.dgv_thongtindoitac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtindoitac_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quản lý đối tác";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(168, 41);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Ghi lại";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(6, 41);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(75, 23);
            this.button_reload.TabIndex = 8;
            this.button_reload.Text = "Tải lại";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // admin_quanlydoitac
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "admin_quanlydoitac";
            this.Size = new System.Drawing.Size(506, 364);
            this.Load += new System.EventHandler(this.admin_quanlydoitac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindoitac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.DataGridView dgv_thongtindoitac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_danhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_reload;
    }
}
