namespace project_tkpmnc.GUI
{
    partial class admin_duyetchiendich
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
            this.button_duyet = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachchoduyet = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchoduyet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_duyet
            // 
            this.button_duyet.Location = new System.Drawing.Point(87, 20);
            this.button_duyet.Name = "button_duyet";
            this.button_duyet.Size = new System.Drawing.Size(75, 23);
            this.button_duyet.TabIndex = 1;
            this.button_duyet.Text = "Duyệt";
            this.button_duyet.UseVisualStyleBackColor = true;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(6, 20);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
            this.button_timkiem.TabIndex = 0;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_danhsachchoduyet);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 261);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chiến dịch chờ duyệt";
            // 
            // dgv_danhsachchoduyet
            // 
            this.dgv_danhsachchoduyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachchoduyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachchoduyet.Location = new System.Drawing.Point(6, 20);
            this.dgv_danhsachchoduyet.Name = "dgv_danhsachchoduyet";
            this.dgv_danhsachchoduyet.Size = new System.Drawing.Size(479, 235);
            this.dgv_danhsachchoduyet.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_exit);
            this.groupBox2.Controls.Add(this.button_duyet);
            this.groupBox2.Controls.Add(this.button_timkiem);
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(168, 20);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Duyệt chiến dịch mới";
            // 
            // admin_duyetchiendich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "admin_duyetchiendich";
            this.Size = new System.Drawing.Size(506, 364);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchoduyet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_duyet;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_danhsachchoduyet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label6;
    }
}
