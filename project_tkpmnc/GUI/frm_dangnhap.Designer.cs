namespace project_tkpmnc.GUI
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.linklable_dangky = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(117, 9);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(141, 21);
            this.textBox_email.TabIndex = 0;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(117, 36);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(141, 21);
            this.textBox_matkhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(102, 76);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.button_dangnhap.TabIndex = 2;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(183, 76);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // linklable_dangky
            // 
            this.linklable_dangky.AutoSize = true;
            this.linklable_dangky.Location = new System.Drawing.Point(164, 60);
            this.linklable_dangky.Name = "linklable_dangky";
            this.linklable_dangky.Size = new System.Drawing.Size(94, 13);
            this.linklable_dangky.TabIndex = 3;
            this.linklable_dangky.TabStop = true;
            this.linklable_dangky.Text = "Đăng ký tài khoản";
            this.linklable_dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklable_dangky_LinkClicked);
            // 
            // frm_dangnhap
            // 
            this.AcceptButton = this.button_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 125);
            this.Controls.Add(this.linklable_dangky);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_email);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_dangnhap.IconOptions.LargeImage")));
            this.Name = "frm_dangnhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.LinkLabel linklable_dangky;
    }
}