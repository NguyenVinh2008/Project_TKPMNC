namespace project_tkpmnc.GUI
{
    partial class admin_duyetdoitac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachchoduyet = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchoduyet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_duyet
            // 
            this.button_duyet.Location = new System.Drawing.Point(6, 20);
            this.button_duyet.Name = "button_duyet";
            this.button_duyet.Size = new System.Drawing.Size(75, 23);
            this.button_duyet.TabIndex = 1;
            this.button_duyet.Text = "Duyệt";
            this.button_duyet.UseVisualStyleBackColor = true;
            this.button_duyet.Click += new System.EventHandler(this.button_duyet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dgv_danhsachchoduyet);
            this.groupBox1.Location = new System.Drawing.Point(8, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đối tác chờ duyệt";
            // 
            // dgv_danhsachchoduyet
            // 
            this.dgv_danhsachchoduyet.AllowUserToAddRows = false;
            this.dgv_danhsachchoduyet.AllowUserToDeleteRows = false;
            this.dgv_danhsachchoduyet.AllowUserToResizeRows = false;
            this.dgv_danhsachchoduyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachchoduyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhsachchoduyet.Location = new System.Drawing.Point(6, 20);
            this.dgv_danhsachchoduyet.Name = "dgv_danhsachchoduyet";
            this.dgv_danhsachchoduyet.ReadOnly = true;
            this.dgv_danhsachchoduyet.Size = new System.Drawing.Size(483, 269);
            this.dgv_danhsachchoduyet.TabIndex = 0;
            this.dgv_danhsachchoduyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachchoduyet_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.button_duyet);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // admin_duyetdoitac
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "admin_duyetdoitac";
            this.Size = new System.Drawing.Size(506, 364);
            this.Load += new System.EventHandler(this.admin_duyetdoitac_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchoduyet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_duyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_danhsachchoduyet;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
