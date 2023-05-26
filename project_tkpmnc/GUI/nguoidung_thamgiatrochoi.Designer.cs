namespace project_tkpmnc.GUI
{
    partial class nguoidung_thamgiatrochoi
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_thamgia = new System.Windows.Forms.Button();
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtintrochoi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtintrochoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tham gia trò chơi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_thamgia);
            this.groupBox1.Controls.Add(this.comboBox_timkiem);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_reload);
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 73);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button_thamgia
            // 
            this.button_thamgia.Enabled = false;
            this.button_thamgia.Location = new System.Drawing.Point(97, 41);
            this.button_thamgia.Name = "button_thamgia";
            this.button_thamgia.Size = new System.Drawing.Size(85, 23);
            this.button_thamgia.TabIndex = 7;
            this.button_thamgia.Text = "Tham gia";
            this.button_thamgia.UseVisualStyleBackColor = true;
            this.button_thamgia.Click += new System.EventHandler(this.button_thamgia_Click);
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.Items.AddRange(new object[] {
            "Toàn bộ",
            "Chưa phát",
            "Đã phát",
            "Đã sử dụng"});
            this.comboBox_timkiem.Location = new System.Drawing.Point(61, 14);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timkiem.TabIndex = 6;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(188, 14);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(85, 23);
            this.button_timkiem.TabIndex = 4;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
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
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(6, 41);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(85, 23);
            this.button_reload.TabIndex = 1;
            this.button_reload.Text = "Tải lại";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_thongtintrochoi);
            this.groupBox2.Location = new System.Drawing.Point(7, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 254);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin trò chơi";
            // 
            // dgv_thongtintrochoi
            // 
            this.dgv_thongtintrochoi.AllowUserToAddRows = false;
            this.dgv_thongtintrochoi.AllowUserToDeleteRows = false;
            this.dgv_thongtintrochoi.AllowUserToOrderColumns = true;
            this.dgv_thongtintrochoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtintrochoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongtintrochoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtintrochoi.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtintrochoi.MultiSelect = false;
            this.dgv_thongtintrochoi.Name = "dgv_thongtintrochoi";
            this.dgv_thongtintrochoi.ReadOnly = true;
            this.dgv_thongtintrochoi.Size = new System.Drawing.Size(476, 229);
            this.dgv_thongtintrochoi.TabIndex = 0;
            this.dgv_thongtintrochoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtintrochoi_CellClick);
            // 
            // nguoidung_thamgiatrochoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "nguoidung_thamgiatrochoi";
            this.Size = new System.Drawing.Size(506, 364);
            this.Load += new System.EventHandler(this.nguoidung_thamgiatrochoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtintrochoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_thamgia;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtintrochoi;
    }
}
