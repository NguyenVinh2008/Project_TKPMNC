namespace project_tkpmnc.GUI
{
    partial class user_OChuGame
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
            this.groupBox_cauhoi = new System.Windows.Forms.GroupBox();
            this.label_cauhoi = new System.Windows.Forms.Label();
            this.button_thamgia = new System.Windows.Forms.Button();
            this.label_thongbao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_hoanthanh = new System.Windows.Forms.Button();
            this.groupBox_cauhoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_cauhoi
            // 
            this.groupBox_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_cauhoi.Controls.Add(this.label_cauhoi);
            this.groupBox_cauhoi.Location = new System.Drawing.Point(4, 4);
            this.groupBox_cauhoi.Name = "groupBox_cauhoi";
            this.groupBox_cauhoi.Size = new System.Drawing.Size(476, 100);
            this.groupBox_cauhoi.TabIndex = 1;
            this.groupBox_cauhoi.TabStop = false;
            this.groupBox_cauhoi.Text = "Câu hỏi";
            // 
            // label_cauhoi
            // 
            this.label_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cauhoi.Location = new System.Drawing.Point(6, 16);
            this.label_cauhoi.Name = "label_cauhoi";
            this.label_cauhoi.Size = new System.Drawing.Size(464, 81);
            this.label_cauhoi.TabIndex = 0;
            this.label_cauhoi.Text = "Câu hỏi";
            this.label_cauhoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_thamgia
            // 
            this.button_thamgia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_thamgia.Location = new System.Drawing.Point(3, 296);
            this.button_thamgia.Name = "button_thamgia";
            this.button_thamgia.Size = new System.Drawing.Size(75, 23);
            this.button_thamgia.TabIndex = 2;
            this.button_thamgia.Text = "Tham gia";
            this.button_thamgia.UseVisualStyleBackColor = true;
            this.button_thamgia.Click += new System.EventHandler(this.button_thamgia_Click);
            // 
            // label_thongbao
            // 
            this.label_thongbao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongbao.ForeColor = System.Drawing.Color.Red;
            this.label_thongbao.Location = new System.Drawing.Point(3, 154);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(477, 43);
            this.label_thongbao.TabIndex = 3;
            this.label_thongbao.Text = "label2";
            this.label_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_thongbao.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_hoanthanh
            // 
            this.button_hoanthanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_hoanthanh.BackColor = System.Drawing.SystemColors.Control;
            this.button_hoanthanh.Location = new System.Drawing.Point(85, 295);
            this.button_hoanthanh.Name = "button_hoanthanh";
            this.button_hoanthanh.Size = new System.Drawing.Size(75, 23);
            this.button_hoanthanh.TabIndex = 5;
            this.button_hoanthanh.Text = "Hoàn thành";
            this.button_hoanthanh.UseVisualStyleBackColor = false;
            this.button_hoanthanh.Click += new System.EventHandler(this.button_hoanthanh_Click);
            // 
            // user_OChuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_hoanthanh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_thongbao);
            this.Controls.Add(this.button_thamgia);
            this.Controls.Add(this.groupBox_cauhoi);
            this.Name = "user_OChuGame";
            this.Size = new System.Drawing.Size(483, 322);
            this.groupBox_cauhoi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_cauhoi;
        private System.Windows.Forms.Label label_cauhoi;
        private System.Windows.Forms.Button button_thamgia;
        private System.Windows.Forms.Label label_thongbao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_hoanthanh;
    }
}
