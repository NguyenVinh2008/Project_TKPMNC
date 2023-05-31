namespace project_tkpmnc.GUI
{
    partial class frm_ochu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ochu));
            this.label_noidung1 = new System.Windows.Forms.Label();
            this.dapan1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_thamgia = new System.Windows.Forms.Button();
            this.label_phanthuong = new System.Windows.Forms.Label();
            this.button_hoanthanh = new System.Windows.Forms.Button();
            this.button_nhanthuong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dapan2 = new System.Windows.Forms.TextBox();
            this.label_noidung2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dapan3 = new System.Windows.Forms.TextBox();
            this.label_noidung3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_noidung1
            // 
            this.label_noidung1.AllowDrop = true;
            this.label_noidung1.Location = new System.Drawing.Point(12, 101);
            this.label_noidung1.Name = "label_noidung1";
            this.label_noidung1.Size = new System.Drawing.Size(413, 44);
            this.label_noidung1.TabIndex = 1;
            this.label_noidung1.Text = "Nội dung câu hỏi 1";
            this.label_noidung1.Visible = false;
            // 
            // dapan1
            // 
            this.dapan1.Location = new System.Drawing.Point(431, 101);
            this.dapan1.Multiline = true;
            this.dapan1.Name = "dapan1";
            this.dapan1.ReadOnly = true;
            this.dapan1.Size = new System.Drawing.Size(445, 44);
            this.dapan1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Câu hỏi 1:";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(864, 76);
            this.label7.TabIndex = 9;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // button_thamgia
            // 
            this.button_thamgia.Location = new System.Drawing.Point(12, 321);
            this.button_thamgia.Name = "button_thamgia";
            this.button_thamgia.Size = new System.Drawing.Size(80, 80);
            this.button_thamgia.TabIndex = 1;
            this.button_thamgia.Text = "Tham gia";
            this.button_thamgia.UseVisualStyleBackColor = true;
            this.button_thamgia.Click += new System.EventHandler(this.button_thamgia_Click);
            // 
            // label_phanthuong
            // 
            this.label_phanthuong.AllowDrop = true;
            this.label_phanthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phanthuong.ForeColor = System.Drawing.Color.Red;
            this.label_phanthuong.Location = new System.Drawing.Point(12, 274);
            this.label_phanthuong.Name = "label_phanthuong";
            this.label_phanthuong.Size = new System.Drawing.Size(864, 44);
            this.label_phanthuong.TabIndex = 13;
            this.label_phanthuong.Text = "label phần thưởng";
            this.label_phanthuong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_phanthuong.Visible = false;
            // 
            // button_hoanthanh
            // 
            this.button_hoanthanh.Enabled = false;
            this.button_hoanthanh.Location = new System.Drawing.Point(98, 321);
            this.button_hoanthanh.Name = "button_hoanthanh";
            this.button_hoanthanh.Size = new System.Drawing.Size(80, 80);
            this.button_hoanthanh.TabIndex = 5;
            this.button_hoanthanh.Text = "Hoàn thành";
            this.button_hoanthanh.UseVisualStyleBackColor = true;
            this.button_hoanthanh.Click += new System.EventHandler(this.button_hoanthanh_Click);
            // 
            // button_nhanthuong
            // 
            this.button_nhanthuong.Enabled = false;
            this.button_nhanthuong.Location = new System.Drawing.Point(184, 321);
            this.button_nhanthuong.Name = "button_nhanthuong";
            this.button_nhanthuong.Size = new System.Drawing.Size(80, 80);
            this.button_nhanthuong.TabIndex = 6;
            this.button_nhanthuong.Text = "Nhận thưởng";
            this.button_nhanthuong.UseVisualStyleBackColor = true;
            this.button_nhanthuong.Click += new System.EventHandler(this.button_nhanthuong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đáp án 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đáp án 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Câu hỏi 2:";
            // 
            // dapan2
            // 
            this.dapan2.Location = new System.Drawing.Point(431, 164);
            this.dapan2.Multiline = true;
            this.dapan2.Name = "dapan2";
            this.dapan2.ReadOnly = true;
            this.dapan2.Size = new System.Drawing.Size(445, 44);
            this.dapan2.TabIndex = 16;
            // 
            // label_noidung2
            // 
            this.label_noidung2.AllowDrop = true;
            this.label_noidung2.Location = new System.Drawing.Point(12, 164);
            this.label_noidung2.Name = "label_noidung2";
            this.label_noidung2.Size = new System.Drawing.Size(413, 44);
            this.label_noidung2.TabIndex = 15;
            this.label_noidung2.Text = "Nội dung câu hỏi 2";
            this.label_noidung2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Đáp án 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Câu hỏi 3:";
            // 
            // dapan3
            // 
            this.dapan3.Location = new System.Drawing.Point(431, 227);
            this.dapan3.Multiline = true;
            this.dapan3.Name = "dapan3";
            this.dapan3.ReadOnly = true;
            this.dapan3.Size = new System.Drawing.Size(445, 44);
            this.dapan3.TabIndex = 20;
            // 
            // label_noidung3
            // 
            this.label_noidung3.AllowDrop = true;
            this.label_noidung3.Location = new System.Drawing.Point(12, 227);
            this.label_noidung3.Name = "label_noidung3";
            this.label_noidung3.Size = new System.Drawing.Size(413, 44);
            this.label_noidung3.TabIndex = 19;
            this.label_noidung3.Text = "Nội dung câu hỏi 3";
            this.label_noidung3.Visible = false;
            // 
            // frm_ochu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 584);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dapan3);
            this.Controls.Add(this.label_noidung3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dapan2);
            this.Controls.Add(this.label_noidung2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_nhanthuong);
            this.Controls.Add(this.button_hoanthanh);
            this.Controls.Add(this.label_phanthuong);
            this.Controls.Add(this.button_thamgia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dapan1);
            this.Controls.Add(this.label_noidung1);
            this.Name = "frm_ochu";
            this.Text = "Trò chơi ô chữ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_noidung1;
        private System.Windows.Forms.TextBox dapan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_thamgia;
        private System.Windows.Forms.Label label_phanthuong;
        private System.Windows.Forms.Button button_hoanthanh;
        private System.Windows.Forms.Button button_nhanthuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dapan2;
        private System.Windows.Forms.Label label_noidung2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dapan3;
        private System.Windows.Forms.Label label_noidung3;
    }
}