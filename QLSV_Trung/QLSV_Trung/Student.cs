using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_Trung
{
    public partial class Student : Form
    {
        SqlConnection conn;
        MyDatabase db = new MyDatabase();
        string ktx;
        string ngt;
        public Student()
        {
            InitializeComponent();
        }

        private void btbNew_Click(object sender, EventArgs e)
        {
            xoatext(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            
            cboLop.DisplayMember = "MaLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = db.getData("select * from LOP");

            cboDT.DisplayMember = "LoaiHinhDT";
            cboDT.ValueMember = "MaDT";
            cboDT.DataSource = db.getData("select * from LOAIHINHDT");

            

            

        }
        private void refreshDataGridView()
        {
            dgvStudents.DataSource = db.getData("SELECT * FROM SINHVIEN");
        }
        public void xoatext(Control ctr)
        {
            if(ctr is TextBox)
            {
                ctr.Text = string.Empty;
            }
            foreach(Control i in ctr.Controls)
            {
                xoatext(i);
            }
        }
        private int check(string st, string str, string txt)
        {
            string sql = "select COUNT(*) from "+str+" where "+ st +" = '" + txt + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }
        private Boolean checkAll()
        {
            if (txtMSV.Text.Equals("")|txtHoten.Text.Equals("")|txtNgaysinh.Text.Equals("")|txtGioitinh.Text.Equals(""))
                return true;
            if (txtCMND.Text.Equals("") | txtSDT.Text.Equals("") | txtDantoc.Text.Equals("") | txtNoisinh.Text.Equals("") | txtQuequan.Text.Equals(""))
                return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkAll())
            {
                MessageBox.Show("Không được để trống!", "Thông báo");
            }
            else
            {
                conn = db.connected();
                conn.Open();
                if (check("MSV","SINHVIEN",txtMSV.Text) == 0)
                {
                    string sql = "insert into SINHVIEN values('" + txtMSV.Text + "','" + txtHoten.Text + "','" + txtNgaysinh.Text +
                        "','" + txtGioitinh.Text + "','" + txtCMND.Text + "','" + txtSDT.Text + "','" + txtDantoc.Text +
                        "','" + txtNoisinh.Text + "','" + txtQuequan.Text + "','" + cboLop.SelectedValue.ToString() + "','" + ktx + 
                        "','" + ngt +"','" + cboDT.SelectedValue.ToString() + "')";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Tai khoan da ton tai!", "Thong bao!");
                }
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                MessageBox.Show("Không được để trống!", "Thông báo");
            }
            else
            {
                conn = db.connected();
                conn.Open();
                if (check("MSV", "SINHVIEN", txtMSV.Text) > 0)
                {
                    string sql = "update SINHVIEN set HoTenSV = '" + txtHoten.Text + "', NgaySinh = '" + txtNgaysinh.Text + "', GioiTinh = '" + txtGioitinh.Text +
                        "', CMND = '" + txtCMND.Text + "', SDT = '" + txtSDT.Text + "', DanToc = '" + txtDantoc.Text + "', NoiSinh ='" + txtNoisinh.Text +
                        "', QueQuan = '" + txtQuequan.Text + "', MaLop = '" + cboLop.SelectedValue.ToString() + "', TenPhong = '" + ktx + 
                        "', MaNGT = '" + ngt + "', MaDT = '" + cboDT.SelectedValue.ToString() + "' where MSV = '"+txtMSV.Text+"'";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Chua co tai khoan nay!", "Thong bao!");
                }
                conn.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
                conn = db.connected();
                conn.Open();
                if (check("MSV", "SINHVIEN", txtMSV.Text) > 0)
                {
                    string sql = "delete from SINHVIEN where MSV = '"+txtMSV.Text+"'";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Chưa có tài khoản này!", "Thong bao!");
                }
                conn.Close();
            
        }

        private void cboTamtru_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboTamtru.SelectedItem.ToString().Equals("Nội trú"))
            {
                cboKTX.DisplayMember = "TenPhong";
                cboKTX.ValueMember = "TenPhong";
                cboKTX.DataSource = db.getData("select * from NOITRU");
                cboNT.DataSource = null;
                cboNT.Enabled = false;
                cboKTX.Enabled = true;
                ktx = cboKTX.SelectedValue.ToString();
                ngt = " ";
            }
            else
            {
                cboNT.DisplayMember = "TenChuHo";
                cboNT.ValueMember = "MaNGT";
                cboNT.DataSource = db.getData("select * from NGOAITRU");
                cboKTX.DataSource = null;
                cboKTX.Enabled = false;
                cboNT.Enabled = true;
                ktx = " ";
                ngt = cboNT.SelectedValue.ToString();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvStudents.CurrentRow.Index;
            txtMSV.Text = dgvStudents.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dgvStudents.Rows[i].Cells[1].Value.ToString();
            txtNgaysinh.Text = dgvStudents.Rows[i].Cells[2].Value.ToString();
            txtGioitinh.Text = dgvStudents.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = dgvStudents.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dgvStudents.Rows[i].Cells[5].Value.ToString();
            txtDantoc.Text = dgvStudents.Rows[i].Cells[6].Value.ToString();
            txtNoisinh.Text = dgvStudents.Rows[i].Cells[7].Value.ToString();
            txtQuequan.Text = dgvStudents.Rows[i].Cells[8].Value.ToString();
            cboLop.Text = dgvStudents.Rows[i].Cells[9].Value.ToString();
            cboKTX.Text = dgvStudents.Rows[i].Cells[10].Value.ToString();
            cboNT.Text = dgvStudents.Rows[i].Cells[11].Value.ToString();
            cboDT.Text = dgvStudents.Rows[i].Cells[12].Value.ToString();
        }



    }
}
