namespace project_tkpmnc.GUI
{
    partial class admin_quanlynguoidung
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
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinnguoidung = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinnguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_timkiem);
            this.groupBox1.Controls.Add(this.button_thoat);
            this.groupBox1.Controls.Add(this.button_chinhsua);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(413, 12);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
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
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(59, 14);
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(348, 20);
            this.textBox_timkiem.TabIndex = 2;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(87, 41);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 23);
            this.button_thoat.TabIndex = 1;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.Location = new System.Drawing.Point(6, 41);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(75, 23);
            this.button_chinhsua.TabIndex = 0;
            this.button_chinhsua.Text = "Chỉnh sửa";
            this.button_chinhsua.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_thongtinnguoidung);
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người dùng";
            // 
            // dgv_thongtinnguoidung
            // 
            this.dgv_thongtinnguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtinnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinnguoidung.Location = new System.Drawing.Point(8, 20);
            this.dgv_thongtinnguoidung.Name = "dgv_thongtinnguoidung";
            this.dgv_thongtinnguoidung.Size = new System.Drawing.Size(484, 232);
            this.dgv_thongtinnguoidung.TabIndex = 0;
            // 
            // admin_quanlynguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "admin_quanlynguoidung";
            this.Size = new System.Drawing.Size(506, 364);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinnguoidung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtinnguoidung;
    }
}
