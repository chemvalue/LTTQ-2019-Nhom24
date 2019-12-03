namespace QLSV_Trung
{
    partial class Nganh
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgrdata = new System.Windows.Forms.DataGridView();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmkv = new System.Windows.Forms.TextBox();
            this.txttn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(492, 173);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 36;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(384, 173);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 35;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(268, 173);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 34;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(157, 173);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgrdata
            // 
            this.dgrdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh,
            this.MKV});
            this.dgrdata.Location = new System.Drawing.Point(66, 229);
            this.dgrdata.Name = "dgrdata";
            this.dgrdata.Size = new System.Drawing.Size(579, 157);
            this.dgrdata.TabIndex = 37;
            this.dgrdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdata_CellContentClick);
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Width = 180;
            // 
            // TenNganh
            // 
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Tên Ngành";
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.Width = 180;
            // 
            // MKV
            // 
            this.MKV.DataPropertyName = "MKV";
            this.MKV.HeaderText = "Mã Khoa Viện";
            this.MKV.Name = "MKV";
            this.MKV.Width = 180;
            // 
            // txtmkv
            // 
            this.txtmkv.Location = new System.Drawing.Point(268, 133);
            this.txtmkv.Name = "txtmkv";
            this.txtmkv.Size = new System.Drawing.Size(191, 20);
            this.txtmkv.TabIndex = 32;
            // 
            // txttn
            // 
            this.txttn.Location = new System.Drawing.Point(268, 96);
            this.txttn.Name = "txttn";
            this.txttn.Size = new System.Drawing.Size(191, 20);
            this.txttn.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã Khoa Viện:";
            // 
            // txtmn
            // 
            this.txtmn.Location = new System.Drawing.Point(268, 55);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(191, 20);
            this.txtmn.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Ngành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ngành";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(135, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 188);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngành";
            // 
            // Nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgrdata);
            this.Controls.Add(this.txtmkv);
            this.Controls.Add(this.txttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nganh";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Nganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgrdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKV;
        private System.Windows.Forms.TextBox txtmkv;
        private System.Windows.Forms.TextBox txttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}