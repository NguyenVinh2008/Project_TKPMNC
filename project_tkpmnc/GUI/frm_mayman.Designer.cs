namespace project_tkpmnc.GUI
{
    partial class frm_mayman
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
            this.components = new System.ComponentModel.Container();
            this.button_quayso = new System.Windows.Forms.Button();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_thongbao = new System.Windows.Forms.Label();
            this.button_themvaotaikhoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_quayso
            // 
            this.button_quayso.BackColor = System.Drawing.Color.Transparent;
            this.button_quayso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quayso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_quayso.Location = new System.Drawing.Point(12, 12);
            this.button_quayso.Name = "button_quayso";
            this.button_quayso.Size = new System.Drawing.Size(75, 75);
            this.button_quayso.TabIndex = 8;
            this.button_quayso.Text = "Bắt đầu";
            this.button_quayso.UseVisualStyleBackColor = true;
            this.button_quayso.Click += new System.EventHandler(this.button_quayso_Click);
            // 
            // label_ketqua
            // 
            this.label_ketqua.BackColor = System.Drawing.Color.Transparent;
            this.label_ketqua.Font = new System.Drawing.Font("Bahnschrift Light", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ketqua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ketqua.Location = new System.Drawing.Point(12, 174);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(760, 101);
            this.label_ketqua.TabIndex = 7;
            this.label_ketqua.Text = "VOUCHER";
            this.label_ketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label_thongbao
            // 
            this.label_thongbao.BackColor = System.Drawing.Color.Transparent;
            this.label_thongbao.Font = new System.Drawing.Font("Bahnschrift Light", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongbao.ForeColor = System.Drawing.Color.Red;
            this.label_thongbao.Location = new System.Drawing.Point(12, 90);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(760, 84);
            this.label_thongbao.TabIndex = 10;
            this.label_thongbao.Text = "Phần quà của bạn";
            this.label_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_thongbao.Visible = false;
            // 
            // button_themvaotaikhoan
            // 
            this.button_themvaotaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.button_themvaotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_themvaotaikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_themvaotaikhoan.Location = new System.Drawing.Point(93, 12);
            this.button_themvaotaikhoan.Name = "button_themvaotaikhoan";
            this.button_themvaotaikhoan.Size = new System.Drawing.Size(93, 75);
            this.button_themvaotaikhoan.TabIndex = 9;
            this.button_themvaotaikhoan.Text = "Thêm vào tài khoản";
            this.button_themvaotaikhoan.UseVisualStyleBackColor = true;
            this.button_themvaotaikhoan.Visible = false;
            this.button_themvaotaikhoan.Click += new System.EventHandler(this.button_themvaotaikhoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // frm_mayman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_quayso);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.label_thongbao);
            this.Controls.Add(this.button_themvaotaikhoan);
            this.Name = "frm_mayman";
            this.Text = "frm_mayman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_quayso;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_thongbao;
        private System.Windows.Forms.Button button_themvaotaikhoan;
        private System.Windows.Forms.Label label1;
    }
}