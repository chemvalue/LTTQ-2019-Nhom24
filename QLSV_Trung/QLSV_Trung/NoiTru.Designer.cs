namespace QLSV_Trung
{
    partial class NoiTru
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btbNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNoiTru = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtMaKTX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiTru)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(390, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Quản lý thông tin nội trú ";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(228, 476);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(428, 421);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(83, 30);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(297, 421);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 30);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(168, 421);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btbNew
            // 
            this.btbNew.AutoSize = true;
            this.btbNew.Location = new System.Drawing.Point(33, 421);
            this.btbNew.Margin = new System.Windows.Forms.Padding(4);
            this.btbNew.Name = "btbNew";
            this.btbNew.Size = new System.Drawing.Size(83, 30);
            this.btbNew.TabIndex = 46;
            this.btbNew.Text = "New";
            this.btbNew.UseVisualStyleBackColor = true;
            this.btbNew.Click += new System.EventHandler(this.btbNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNoiTru);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(549, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(492, 410);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvNoiTru
            // 
            this.dgvNoiTru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoiTru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.SoLuong,
            this.MaKTX,
            this.Status});
            this.dgvNoiTru.Location = new System.Drawing.Point(16, 26);
            this.dgvNoiTru.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNoiTru.Name = "dgvNoiTru";
            this.dgvNoiTru.Size = new System.Drawing.Size(459, 377);
            this.dgvNoiTru.TabIndex = 0;
            this.dgvNoiTru.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgoaiTru_CellContentClick);
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 110;
            // 
            // MaKTX
            // 
            this.MaKTX.DataPropertyName = "MaKTX";
            this.MaKTX.HeaderText = "Mã KTX";
            this.MaKTX.Name = "MaKTX";
            this.MaKTX.Width = 110;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình Trạng";
            this.Status.Name = "Status";
            this.Status.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtMaKTX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(495, 287);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng kí túc:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(309, 230);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 23);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chưa đầy";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(221, 230);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 23);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Đầy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtMaKTX
            // 
            this.txtMaKTX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaKTX.Location = new System.Drawing.Point(201, 164);
            this.txtMaKTX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKTX.Name = "txtMaKTX";
            this.txtMaKTX.Size = new System.Drawing.Size(241, 26);
            this.txtMaKTX.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình trạng phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenPhong.Location = new System.Drawing.Point(201, 46);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(241, 26);
            this.txtTenPhong.TabIndex = 13;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoLuong.Location = new System.Drawing.Point(201, 103);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(241, 26);
            this.txtSoLuong.TabIndex = 13;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã kí túc xá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng:";
            // 
            // NoiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btbNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NoiTru";
            this.Text = "Phòng kí túc ";
            this.Load += new System.EventHandler(this.NoiTru_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiTru)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btbNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNoiTru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKTX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}