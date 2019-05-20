namespace QLVDV
{
    partial class QLThanhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butIn = new System.Windows.Forms.Button();
            this.butsearch = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtNS = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTTV = new System.Windows.Forms.TextBox();
            this.txtMTV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtST = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.butIn);
            this.groupBox1.Controls.Add(this.butsearch);
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.butXoa);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(712, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 220);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butIn
            // 
            this.butIn.BackColor = System.Drawing.Color.SpringGreen;
            this.butIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIn.ForeColor = System.Drawing.Color.Red;
            this.butIn.Location = new System.Drawing.Point(140, 105);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(92, 32);
            this.butIn.TabIndex = 38;
            this.butIn.Text = "In";
            this.butIn.UseVisualStyleBackColor = false;
            // 
            // butsearch
            // 
            this.butsearch.BackColor = System.Drawing.Color.SpringGreen;
            this.butsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsearch.ForeColor = System.Drawing.Color.Red;
            this.butsearch.Location = new System.Drawing.Point(140, 40);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(92, 32);
            this.butsearch.TabIndex = 37;
            this.butsearch.Text = "Tìm Kiếm";
            this.butsearch.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.SpringGreen;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.Red;
            this.home.Location = new System.Drawing.Point(140, 157);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(92, 32);
            this.home.TabIndex = 36;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.butUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.ForeColor = System.Drawing.Color.Red;
            this.butUpdate.Location = new System.Drawing.Point(16, 157);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(92, 32);
            this.butUpdate.TabIndex = 35;
            this.butUpdate.Text = "Sửa";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.delete_Click);
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.Color.SpringGreen;
            this.butXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.ForeColor = System.Drawing.Color.Red;
            this.butXoa.Location = new System.Drawing.Point(16, 99);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(92, 32);
            this.butXoa.TabIndex = 34;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Red;
            this.btnadd.Location = new System.Drawing.Point(16, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 32);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "Cập Nhật";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.add_Click);
            // 
            // txtNS
            // 
            this.txtNS.CustomFormat = "MM/dd/yyyy";
            this.txtNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNS.Location = new System.Drawing.Point(155, 169);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(186, 20);
            this.txtNS.TabIndex = 48;
            this.txtNS.ValueChanged += new System.EventHandler(this.txtNgaysinh_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(411, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Địa chỉ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(411, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sở thích";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(69, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ngày sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(70, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên TV";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã TV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(411, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Giới tính";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTTV
            // 
            this.txtTTV.Location = new System.Drawing.Point(155, 126);
            this.txtTTV.Name = "txtTTV";
            this.txtTTV.ReadOnly = true;
            this.txtTTV.Size = new System.Drawing.Size(186, 20);
            this.txtTTV.TabIndex = 38;
            this.txtTTV.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtMTV
            // 
            this.txtMTV.Location = new System.Drawing.Point(155, 80);
            this.txtMTV.Name = "txtMTV";
            this.txtMTV.ReadOnly = true;
            this.txtMTV.Size = new System.Drawing.Size(186, 20);
            this.txtMTV.TabIndex = 37;
            this.txtMTV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1001, 534);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nguyễn Hữu Tuấn";
            // 
            // txtST
            // 
            this.txtST.Location = new System.Drawing.Point(495, 122);
            this.txtST.Name = "txtST";
            this.txtST.ReadOnly = true;
            this.txtST.Size = new System.Drawing.Size(186, 20);
            this.txtST.TabIndex = 56;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(495, 172);
            this.txtDC.Name = "txtDC";
            this.txtDC.ReadOnly = true;
            this.txtDC.Size = new System.Drawing.Size(186, 20);
            this.txtDC.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 191);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(495, 77);
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(186, 20);
            this.txtGT.TabIndex = 59;
            // 
            // QLThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 506);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTTV);
            this.Controls.Add(this.txtMTV);
            this.Controls.Add(this.button1);
            this.Name = "QLThanhVien";
            this.Text = "                                                                                 " +
    "           Chào mừng quý vị và các bạn đến với chương trình quản lý vận động viê" +
    "n của tập đoàn Nguyễn Hữu Tuấn";
            this.Load += new System.EventHandler(this.QLThanhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker txtNS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTTV;
        private System.Windows.Forms.TextBox txtMTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butIn;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGT;
    }
}