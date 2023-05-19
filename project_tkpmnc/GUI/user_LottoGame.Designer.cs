namespace project_tkpmnc.GUI
{
    partial class user_LottoGame
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
            this.components = new System.ComponentModel.Container();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.button_quayso = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_themvaotaikhoan = new System.Windows.Forms.Button();
            this.label_thongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ketqua
            // 
            this.label_ketqua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ketqua.BackColor = System.Drawing.Color.Transparent;
            this.label_ketqua.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ketqua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ketqua.Location = new System.Drawing.Point(3, 123);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(318, 42);
            this.label_ketqua.TabIndex = 0;
            this.label_ketqua.Text = "VOUCHER";
            this.label_ketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_quayso
            // 
            this.button_quayso.AutoSize = true;
            this.button_quayso.BackColor = System.Drawing.Color.Transparent;
            this.button_quayso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quayso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_quayso.Location = new System.Drawing.Point(3, 3);
            this.button_quayso.Name = "button_quayso";
            this.button_quayso.Size = new System.Drawing.Size(75, 75);
            this.button_quayso.TabIndex = 3;
            this.button_quayso.Text = "Bắt đầu";
            this.button_quayso.UseVisualStyleBackColor = true;
            this.button_quayso.Click += new System.EventHandler(this.button_quayso_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_themvaotaikhoan
            // 
            this.button_themvaotaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.button_themvaotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_themvaotaikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_themvaotaikhoan.Location = new System.Drawing.Point(84, 3);
            this.button_themvaotaikhoan.Name = "button_themvaotaikhoan";
            this.button_themvaotaikhoan.Size = new System.Drawing.Size(93, 75);
            this.button_themvaotaikhoan.TabIndex = 5;
            this.button_themvaotaikhoan.Text = "Thêm vào tài khoản";
            this.button_themvaotaikhoan.UseVisualStyleBackColor = true;
            this.button_themvaotaikhoan.Visible = false;
            // 
            // label_thongbao
            // 
            this.label_thongbao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_thongbao.BackColor = System.Drawing.Color.Transparent;
            this.label_thongbao.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongbao.ForeColor = System.Drawing.Color.Red;
            this.label_thongbao.Location = new System.Drawing.Point(3, 81);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(318, 42);
            this.label_thongbao.TabIndex = 6;
            this.label_thongbao.Text = "Phần quà của bạn";
            this.label_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_thongbao.Visible = false;
            // 
            // user_LottoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label_thongbao);
            this.Controls.Add(this.button_themvaotaikhoan);
            this.Controls.Add(this.button_quayso);
            this.Controls.Add(this.label_ketqua);
            this.Name = "user_LottoGame";
            this.Size = new System.Drawing.Size(324, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.Button button_quayso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_themvaotaikhoan;
        private System.Windows.Forms.Label label_thongbao;
    }
}
