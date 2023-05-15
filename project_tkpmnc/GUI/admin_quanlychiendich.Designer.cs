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
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtindoitac = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindoitac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_timkiem);
            this.groupBox1.Controls.Add(this.button_chinhsua);
            this.groupBox1.Location = new System.Drawing.Point(7, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(410, 12);
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
            this.textBox_timkiem.Size = new System.Drawing.Size(345, 20);
            this.textBox_timkiem.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.dgv_thongtindoitac);
            this.groupBox2.Location = new System.Drawing.Point(7, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chiến dịch";
            // 
            // dgv_thongtindoitac
            // 
            this.dgv_thongtindoitac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtindoitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtindoitac.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtindoitac.Name = "dgv_thongtindoitac";
            this.dgv_thongtindoitac.Size = new System.Drawing.Size(476, 230);
            this.dgv_thongtindoitac.TabIndex = 0;
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
            // admin_quanlychiendich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "admin_quanlychiendich";
            this.Size = new System.Drawing.Size(506, 364);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindoitac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtindoitac;
        private System.Windows.Forms.Label label6;
    }
}
