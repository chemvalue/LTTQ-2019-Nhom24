namespace QLSV_Trung
{
    partial class KhoaVien
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
            this.dgrdata = new System.Windows.Forms.DataGridView();
            this.MKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttkv = new System.Windows.Forms.TextBox();
            this.txtmkv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdata
            // 
            this.dgrdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MKV,
            this.TenKhoaVien});
            this.dgrdata.Location = new System.Drawing.Point(50, 217);
            this.dgrdata.Name = "dgrdata";
            this.dgrdata.Size = new System.Drawing.Size(542, 179);
            this.dgrdata.TabIndex = 31;
            this.dgrdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdata_CellContentClick);
            // 
            // MKV
            // 
            this.MKV.DataPropertyName = "MKV";
            this.MKV.HeaderText = "Mã Khoa Viện";
            this.MKV.Name = "MKV";
            this.MKV.Width = 250;
            // 
            // TenKhoaVien
            // 
            this.TenKhoaVien.DataPropertyName = "TenKhoaVien";
            this.TenKhoaVien.HeaderText = "Tên Khoa Viện";
            this.TenKhoaVien.Name = "TenKhoaVien";
            this.TenKhoaVien.Width = 250;
            // 
            // txttkv
            // 
            this.txttkv.Location = new System.Drawing.Point(230, 109);
            this.txttkv.Name = "txttkv";
            this.txttkv.Size = new System.Drawing.Size(191, 20);
            this.txttkv.TabIndex = 26;
            // 
            // txtmkv
            // 
            this.txtmkv.Location = new System.Drawing.Point(230, 79);
            this.txtmkv.Name = "txtmkv";
            this.txtmkv.Size = new System.Drawing.Size(191, 20);
            this.txtmkv.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Khoa Viện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Khoa Viện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Khoa Viện";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(454, 164);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(346, 164);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 29;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(230, 164);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 28;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(119, 164);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(99, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 160);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa viện";
            // 
            // KhoaVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 433);
            this.Controls.Add(this.dgrdata);
            this.Controls.Add(this.txttkv);
            this.Controls.Add(this.txtmkv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhoaVien";
            this.Text = "KhoaVien";
            this.Load += new System.EventHandler(this.KhoaVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaVien;
        private System.Windows.Forms.TextBox txttkv;
        private System.Windows.Forms.TextBox txtmkv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}