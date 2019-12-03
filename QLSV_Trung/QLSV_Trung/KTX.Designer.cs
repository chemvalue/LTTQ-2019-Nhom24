namespace QLSV_Trung
{
    partial class KTX
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
            this.dgvKTX = new System.Windows.Forms.DataGridView();
            this.MaKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKTX = new System.Windows.Forms.TextBox();
            this.txtTenKTX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKTX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Quản lý thông tin nội trú";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(234, 456);
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
            this.btnDel.Location = new System.Drawing.Point(434, 401);
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
            this.btnEdit.Location = new System.Drawing.Point(303, 401);
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
            this.btnSave.Location = new System.Drawing.Point(174, 401);
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
            this.btbNew.Location = new System.Drawing.Point(39, 401);
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
            this.groupBox2.Controls.Add(this.dgvKTX);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(476, 383);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvKTX
            // 
            this.dgvKTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKTX,
            this.TenKTX});
            this.dgvKTX.Location = new System.Drawing.Point(16, 26);
            this.dgvKTX.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKTX.Name = "dgvKTX";
            this.dgvKTX.Size = new System.Drawing.Size(442, 345);
            this.dgvKTX.TabIndex = 0;
            this.dgvKTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKTX_CellContentClick);
            // 
            // MaKTX
            // 
            this.MaKTX.DataPropertyName = "MaKTX";
            this.MaKTX.HeaderText = "Mã KTX";
            this.MaKTX.Name = "MaKTX";
            this.MaKTX.Width = 150;
            // 
            // TenKTX
            // 
            this.TenKTX.DataPropertyName = "TenKTX";
            this.TenKTX.HeaderText = "Tên KTX";
            this.TenKTX.Name = "TenKTX";
            this.TenKTX.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKTX);
            this.groupBox1.Controls.Add(this.txtTenKTX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(39, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(461, 251);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kí túc xá:";
            // 
            // txtMaKTX
            // 
            this.txtMaKTX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaKTX.Location = new System.Drawing.Point(201, 79);
            this.txtMaKTX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKTX.Name = "txtMaKTX";
            this.txtMaKTX.Size = new System.Drawing.Size(241, 26);
            this.txtMaKTX.TabIndex = 13;
            // 
            // txtTenKTX
            // 
            this.txtTenKTX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKTX.Location = new System.Drawing.Point(201, 158);
            this.txtTenKTX.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKTX.Name = "txtTenKTX";
            this.txtTenKTX.Size = new System.Drawing.Size(241, 26);
            this.txtTenKTX.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã kí túc xá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(44, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên kí túc xá:";
            // 
            // KTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btbNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KTX";
            this.Text = "Kí túc xá";
            this.Load += new System.EventHandler(this.KTX_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKTX)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvKTX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKTX;
        private System.Windows.Forms.TextBox txtTenKTX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKTX;
    }
}