namespace QLSV
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkv = new System.Windows.Forms.TextBox();
            this.txttkv = new System.Windows.Forms.TextBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.grvdata = new System.Windows.Forms.DataGridView();
            this.MKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa viện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa viện:";
            // 
            // txtmkv
            // 
            this.txtmkv.Location = new System.Drawing.Point(139, 63);
            this.txtmkv.Name = "txtmkv";
            this.txtmkv.Size = new System.Drawing.Size(100, 20);
            this.txtmkv.TabIndex = 1;
            // 
            // txttkv
            // 
            this.txttkv.Location = new System.Drawing.Point(139, 107);
            this.txttkv.Name = "txttkv";
            this.txttkv.Size = new System.Drawing.Size(169, 20);
            this.txttkv.TabIndex = 1;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(139, 215);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 23);
            this.btnnhap.TabIndex = 2;
            this.btnnhap.Text = "Nhập ";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(219, 215);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(300, 215);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // grvdata
            // 
            this.grvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MKV,
            this.TenKhoaVien});
            this.grvdata.Location = new System.Drawing.Point(-1, 244);
            this.grvdata.Name = "grvdata";
            this.grvdata.Size = new System.Drawing.Size(551, 210);
            this.grvdata.TabIndex = 3;
            // 
            // MKV
            // 
            this.MKV.DataPropertyName = "MKV";
            this.MKV.HeaderText = "Mã khoa viện";
            this.MKV.Name = "MKV";
            // 
            // TenKhoaVien
            // 
            this.TenKhoaVien.DataPropertyName = "TenKhoaVien";
            this.TenKhoaVien.HeaderText = "Tên khoa viện";
            this.TenKhoaVien.Name = "TenKhoaVien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa Viện";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grvdata);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.txttkv);
            this.Controls.Add(this.txtmkv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmkv;
        private System.Windows.Forms.TextBox txttkv;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView grvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaVien;
        private System.Windows.Forms.Label label3;

    }
}

