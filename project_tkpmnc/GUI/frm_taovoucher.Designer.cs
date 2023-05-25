namespace project_tkpmnc.GUI
{
    partial class frm_taovoucher
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_taovoucher = new System.Windows.Forms.Button();
            this.textBox_soluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_giatri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(213, 144);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_taovoucher
            // 
            this.button_taovoucher.Location = new System.Drawing.Point(136, 144);
            this.button_taovoucher.Name = "button_taovoucher";
            this.button_taovoucher.Size = new System.Drawing.Size(75, 23);
            this.button_taovoucher.TabIndex = 10;
            this.button_taovoucher.Text = "Tạo";
            this.button_taovoucher.UseVisualStyleBackColor = true;
            this.button_taovoucher.Click += new System.EventHandler(this.button_taovoucher_Click);
            // 
            // textBox_soluong
            // 
            this.textBox_soluong.Location = new System.Drawing.Point(188, 103);
            this.textBox_soluong.Name = "textBox_soluong";
            this.textBox_soluong.Size = new System.Drawing.Size(100, 20);
            this.textBox_soluong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng";
            // 
            // textBox_giatri
            // 
            this.textBox_giatri.Location = new System.Drawing.Point(188, 77);
            this.textBox_giatri.Name = "textBox_giatri";
            this.textBox_giatri.Size = new System.Drawing.Size(100, 20);
            this.textBox_giatri.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chiến dịch ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // doitac_taovoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 244);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_taovoucher);
            this.Controls.Add(this.textBox_soluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_giatri);
            this.Controls.Add(this.label1);
            this.Name = "doitac_taovoucher";
            this.Text = "Thêm voucher vào chiến dich";
            this.Load += new System.EventHandler(this.doitac_taovoucher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_taovoucher;
        private System.Windows.Forms.TextBox textBox_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_giatri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}