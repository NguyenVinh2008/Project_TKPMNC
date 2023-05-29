namespace project_tkpmnc.GUI
{
    partial class admin_quanlychiendich
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
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label_noidungtimkiem = new System.Windows.Forms.Label();
            this.textBox_noidung = new System.Windows.Forms.TextBox();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinchiendich = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.comboBox_timkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label_noidungtimkiem);
            this.groupBox1.Controls.Add(this.textBox_noidung);
            this.groupBox1.Controls.Add(this.button_chinhsua);
            this.groupBox1.Location = new System.Drawing.Point(7, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.Items.AddRange(new object[] {
            "Toàn bộ",
            "Chưa duyệt",
            "Đã duyệt",
            "Đối tác",
            "Tên chiến dịch"});
            this.comboBox_timkiem.Location = new System.Drawing.Point(88, 13);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timkiem.TabIndex = 6;
            this.comboBox_timkiem.SelectedIndexChanged += new System.EventHandler(this.comboBox_timkiem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(87, 43);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
            this.button_timkiem.TabIndex = 4;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // label_noidungtimkiem
            // 
            this.label_noidungtimkiem.AutoSize = true;
            this.label_noidungtimkiem.Location = new System.Drawing.Point(215, 16);
            this.label_noidungtimkiem.Name = "label_noidungtimkiem";
            this.label_noidungtimkiem.Size = new System.Drawing.Size(91, 13);
            this.label_noidungtimkiem.TabIndex = 3;
            this.label_noidungtimkiem.Text = "Nội dung tìm kiếm";
            // 
            // textBox_noidung
            // 
            this.textBox_noidung.Location = new System.Drawing.Point(312, 13);
            this.textBox_noidung.Name = "textBox_noidung";
            this.textBox_noidung.Size = new System.Drawing.Size(239, 20);
            this.textBox_noidung.TabIndex = 2;
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.Location = new System.Drawing.Point(6, 43);
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
            this.groupBox2.Controls.Add(this.dgv_thongtinchiendich);
            this.groupBox2.Location = new System.Drawing.Point(7, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chiến dịch";
            // 
            // dgv_thongtinchiendich
            // 
            this.dgv_thongtinchiendich.AllowUserToAddRows = false;
            this.dgv_thongtinchiendich.AllowUserToDeleteRows = false;
            this.dgv_thongtinchiendich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtinchiendich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinchiendich.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtinchiendich.MultiSelect = false;
            this.dgv_thongtinchiendich.Name = "dgv_thongtinchiendich";
            this.dgv_thongtinchiendich.ReadOnly = true;
            this.dgv_thongtinchiendich.Size = new System.Drawing.Size(541, 275);
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
            this.label6.TabIndex = 25;
            this.label6.Text = "Quản lý chiến dịch";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(168, 43);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Ghi lại";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // admin_quanlychiendich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "admin_quanlychiendich";
            this.Size = new System.Drawing.Size(571, 409);
            this.Load += new System.EventHandler(this.admin_quanlychiendich_Load);
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
        private System.Windows.Forms.Label label_noidungtimkiem;
        private System.Windows.Forms.TextBox textBox_noidung;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtinchiendich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
    }
}
