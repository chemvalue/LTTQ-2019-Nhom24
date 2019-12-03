using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_Trung
{
    public partial class NgoaiTru : Form
    {
        MyDatabase db = new MyDatabase();
        SqlConnection conn;

        public NgoaiTru()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            dgvNgoaiTru.DataSource = db.getData("SELECT * FROM NGOAITRU");
        }


        private void NgoaiTru_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dgvNgoaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNgoaiTru.CurrentRow.Index;
            txtMNT.Text = dgvNgoaiTru.Rows[i].Cells[0].Value.ToString();
            txtTench.Text = dgvNgoaiTru.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgvNgoaiTru.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNgoaiTru.Rows[i].Cells[3].Value.ToString();
        }

        private void btbNew_Click(object sender, EventArgs e)
        {
            txtMNT.Text = "";
            txtTench.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            refreshDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMNT.Text) | string.IsNullOrWhiteSpace(txtTench.Text) | string.IsNullOrWhiteSpace(txtDiaChi.Text) | string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            if (check(txtMNT.Text) == 0)
            {
                string sql = String.Format("INSERT INTO NGOAITRU VALUES('{0}', N'{1}','{2}',N'{3}');",txtMNT.Text,txtTench.Text,txtSDT.Text,txtDiaChi.Text);
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Mã ngoại trú này đã tồn tại!", "Thông Báo!");
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMNT.Text) | string.IsNullOrWhiteSpace(txtTench.Text) | string.IsNullOrWhiteSpace(txtDiaChi.Text) | string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            if (check(txtMNT.Text) > 0)
            {
                string sql = String.Format("UPDATE NGOAITRU SET TenChuHo = N'{0}', SoDT = '{1}',DiaChi = N'{2}' WHERE MaNGT = '{3}' ;", txtTench.Text, txtSDT.Text, txtDiaChi.Text, txtMNT.Text);
                db.excute(sql); 
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Chưa có mã ngoại trú này", "Thông báo!");
            }
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMNT.Text) | string.IsNullOrWhiteSpace(txtTench.Text) | string.IsNullOrWhiteSpace(txtDiaChi.Text) | string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            else
            {

                if (check(txtMNT.Text) > 0)
                {
                    DialogResult dr = MessageBox.Show("Thao tác này sẽ xoá tất cả các sinh viên có ngoại trú này!\n Tiếp tục?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = String.Format("DELETE FROM NGOAITRU WHERE MaNGT = '{0}'",txtMNT.Text);
                        db.excute(sql);
                        txtMNT.Clear();
                        txtTench.Clear();
                        txtSDT.Clear();
                        txtDiaChi.Clear();
                        refreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có mã ngoại trú này", "Thông báo!");
                }
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int check(string st)
        {
            string sql = "select COUNT(*) from NGOAITRU where MaNGT = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }
    }
}
