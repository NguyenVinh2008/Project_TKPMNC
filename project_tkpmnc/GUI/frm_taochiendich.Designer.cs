namespace project_tkpmnc.GUI
{
    partial class frm_taochiendich
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
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_chiendichid = new System.Windows.Forms.TextBox();
            this.textBox_nguoitao = new System.Windows.Forms.TextBox();
            this.comboBox_trochoi = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.button_tao = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenchiendich = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(79, 38);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(68, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Chiến dịch id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo bởi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trò chơi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // textBox_chiendichid
            // 
            this.textBox_chiendichid.Location = new System.Drawing.Point(153, 35);
            this.textBox_chiendichid.Name = "textBox_chiendichid";
            this.textBox_chiendichid.ReadOnly = true;
            this.textBox_chiendichid.Size = new System.Drawing.Size(121, 20);
            this.textBox_chiendichid.TabIndex = 5;
            // 
            // textBox_nguoitao
            // 
            this.textBox_nguoitao.Location = new System.Drawing.Point(153, 61);
            this.textBox_nguoitao.Name = "textBox_nguoitao";
            this.textBox_nguoitao.ReadOnly = true;
            this.textBox_nguoitao.Size = new System.Drawing.Size(121, 20);
            this.textBox_nguoitao.TabIndex = 6;
            // 
            // comboBox_trochoi
            // 
            this.comboBox_trochoi.FormattingEnabled = true;
            this.comboBox_trochoi.Location = new System.Drawing.Point(153, 113);
            this.comboBox_trochoi.Name = "comboBox_trochoi";
            this.comboBox_trochoi.Size = new System.Drawing.Size(268, 21);
            this.comboBox_trochoi.TabIndex = 7;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(153, 140);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(268, 20);
            this.dateTimePicker_start.TabIndex = 8;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(153, 166);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(268, 20);
            this.dateTimePicker_end.TabIndex = 9;
            // 
            // button_tao
            // 
            this.button_tao.Location = new System.Drawing.Point(265, 192);
            this.button_tao.Name = "button_tao";
            this.button_tao.Size = new System.Drawing.Size(75, 23);
            this.button_tao.TabIndex = 10;
            this.button_tao.Text = "Tạo";
            this.button_tao.UseVisualStyleBackColor = true;
            this.button_tao.Click += new System.EventHandler(this.button_tao_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(346, 192);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên chiến dịch";
            // 
            // textBox_tenchiendich
            // 
            this.textBox_tenchiendich.Location = new System.Drawing.Point(153, 87);
            this.textBox_tenchiendich.Name = "textBox_tenchiendich";
            this.textBox_tenchiendich.Size = new System.Drawing.Size(268, 20);
            this.textBox_tenchiendich.TabIndex = 13;
            // 
            // frm_taochiendich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.textBox_tenchiendich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_tao);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.comboBox_trochoi);
            this.Controls.Add(this.textBox_nguoitao);
            this.Controls.Add(this.textBox_chiendichid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_id);
            this.Name = "frm_taochiendich";
            this.Text = "Tạo chiến dịch";
            this.Load += new System.EventHandler(this.frm_taochiendich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_chiendichid;
        private System.Windows.Forms.TextBox textBox_nguoitao;
        private System.Windows.Forms.ComboBox comboBox_trochoi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button button_tao;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenchiendich;
    }
}