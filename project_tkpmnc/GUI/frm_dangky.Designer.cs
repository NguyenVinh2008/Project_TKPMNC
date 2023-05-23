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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_loaitaikhoan = new System.Windows.Forms.ComboBox();
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
            this.button_dangky.Location = new System.Drawing.Point(234, 186);
            this.button_dangky.Name = "button_dangky";
            this.button_dangky.Size = new System.Drawing.Size(75, 23);
            this.button_dangky.TabIndex = 6;
            this.button_dangky.Text = "Đăng ký";
            this.button_dangky.UseVisualStyleBackColor = true;
            this.button_dangky.Click += new System.EventHandler(this.button_dangky_Click);
            // 
            // textBox_sodienthoai
            // 
            this.textBox_sodienthoai.Location = new System.Drawing.Point(110, 132);
            this.textBox_sodienthoai.Name = "textBox_sodienthoai";
            this.textBox_sodienthoai.Size = new System.Drawing.Size(199, 20);
            this.textBox_sodienthoai.TabIndex = 4;
            // 
            // textBox_tennguoidung
            // 
            this.textBox_tennguoidung.Location = new System.Drawing.Point(110, 106);
            this.textBox_tennguoidung.Name = "textBox_tennguoidung";
            this.textBox_tennguoidung.Size = new System.Drawing.Size(199, 20);
            this.textBox_tennguoidung.TabIndex = 3;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(110, 80);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(199, 20);
            this.textBox_matkhau.TabIndex = 2;
            // 
            // textBox_diachiemail
            // 
            this.textBox_diachiemail.Location = new System.Drawing.Point(110, 54);
            this.textBox_diachiemail.Name = "textBox_diachiemail";
            this.textBox_diachiemail.Size = new System.Drawing.Size(199, 20);
            this.textBox_diachiemail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số điện thoại (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên người dùng (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Địa chỉ email (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Loại tài khoản  (*)";
            // 
            // comboBox_loaitaikhoan
            // 
            this.comboBox_loaitaikhoan.FormattingEnabled = true;
            this.comboBox_loaitaikhoan.Items.AddRange(new object[] {
            "Người dùng",
            "Đối tác"});
            this.comboBox_loaitaikhoan.Location = new System.Drawing.Point(110, 159);
            this.comboBox_loaitaikhoan.Name = "comboBox_loaitaikhoan";
            this.comboBox_loaitaikhoan.Size = new System.Drawing.Size(199, 21);
            this.comboBox_loaitaikhoan.TabIndex = 5;
            // 
            // frm_dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 231);
            this.Controls.Add(this.comboBox_loaitaikhoan);
            this.Controls.Add(this.label5);
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
            this.Load += new System.EventHandler(this.frm_dangky_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_loaitaikhoan;
    }
}