namespace project_tkpmnc.GUI
{
    partial class frm_dangky
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
            this.label6 = new System.Windows.Forms.Label();
            this.button_dangky = new System.Windows.Forms.Button();
            this.textBox_sodienthoai = new System.Windows.Forms.TextBox();
            this.textBox_tennguoidung = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.textBox_diachiemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dangkyadmin = new System.Windows.Forms.Button();
            this.button_dangkynguoidung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Đăng ký tài khoản";
            // 
            // button_dangky
            // 
            this.button_dangky.Location = new System.Drawing.Point(234, 158);
            this.button_dangky.Name = "button_dangky";
            this.button_dangky.Size = new System.Drawing.Size(75, 23);
            this.button_dangky.TabIndex = 35;
            this.button_dangky.Text = "Đối tác";
            this.button_dangky.UseVisualStyleBackColor = true;
            this.button_dangky.Click += new System.EventHandler(this.button_dangky_Click);
            // 
            // textBox_sodienthoai
            // 
            this.textBox_sodienthoai.Location = new System.Drawing.Point(101, 132);
            this.textBox_sodienthoai.Name = "textBox_sodienthoai";
            this.textBox_sodienthoai.Size = new System.Drawing.Size(208, 20);
            this.textBox_sodienthoai.TabIndex = 33;
            // 
            // textBox_tennguoidung
            // 
            this.textBox_tennguoidung.Location = new System.Drawing.Point(101, 106);
            this.textBox_tennguoidung.Name = "textBox_tennguoidung";
            this.textBox_tennguoidung.Size = new System.Drawing.Size(208, 20);
            this.textBox_tennguoidung.TabIndex = 32;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(101, 80);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(208, 20);
            this.textBox_matkhau.TabIndex = 31;
            // 
            // textBox_diachiemail
            // 
            this.textBox_diachiemail.Location = new System.Drawing.Point(101, 54);
            this.textBox_diachiemail.Name = "textBox_diachiemail";
            this.textBox_diachiemail.Size = new System.Drawing.Size(208, 20);
            this.textBox_diachiemail.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Địa chỉ email";
            // 
            // button_dangkyadmin
            // 
            this.button_dangkyadmin.Location = new System.Drawing.Point(153, 158);
            this.button_dangkyadmin.Name = "button_dangkyadmin";
            this.button_dangkyadmin.Size = new System.Drawing.Size(75, 23);
            this.button_dangkyadmin.TabIndex = 37;
            this.button_dangkyadmin.Text = "Admin";
            this.button_dangkyadmin.UseVisualStyleBackColor = true;
            this.button_dangkyadmin.Click += new System.EventHandler(this.button_dangkyadmin_Click);
            // 
            // button_dangkynguoidung
            // 
            this.button_dangkynguoidung.Location = new System.Drawing.Point(72, 158);
            this.button_dangkynguoidung.Name = "button_dangkynguoidung";
            this.button_dangkynguoidung.Size = new System.Drawing.Size(75, 23);
            this.button_dangkynguoidung.TabIndex = 38;
            this.button_dangkynguoidung.Text = "Người dùng";
            this.button_dangkynguoidung.UseVisualStyleBackColor = true;
            this.button_dangkynguoidung.Click += new System.EventHandler(this.button_dangkynguoidung_Click);
            // 
            // frm_dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 186);
            this.Controls.Add(this.button_dangkynguoidung);
            this.Controls.Add(this.button_dangkyadmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_dangky);
            this.Controls.Add(this.textBox_sodienthoai);
            this.Controls.Add(this.textBox_tennguoidung);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_diachiemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_dangky";
            this.Text = "Đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_dangky;
        private System.Windows.Forms.TextBox textBox_sodienthoai;
        private System.Windows.Forms.TextBox textBox_tennguoidung;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.TextBox textBox_diachiemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dangkyadmin;
        private System.Windows.Forms.Button button_dangkynguoidung;
    }
}