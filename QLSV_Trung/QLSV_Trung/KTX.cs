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
    public partial class KTX : Form
    {
        MyDatabase db = new MyDatabase();
        SqlConnection conn;
        public KTX()
        {
            InitializeComponent();
        }

        private void refreshDataGridView()
        {
            dgvKTX.DataSource = db.getData("SELECT * FROM KTX");
        }
        private void KTX_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        

        private void btbNew_Click(object sender, EventArgs e)
        {
            txtMaKTX.Text = "";
            txtTenKTX.Text = "";
            refreshDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaKTX.Text) | string.IsNullOrWhiteSpace(txtTenKTX.Text) )
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            if (check(txtMaKTX.Text) == 0)
            {
                string sql = String.Format("INSERT INTO KTX VALUES('{0}', N'{1}');", txtMaKTX.Text, txtTenKTX.Text);
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Mã KTX này đã tồn tại!", "Thông Báo!");
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaKTX.Text) | string.IsNullOrWhiteSpace(txtTenKTX.Text) )
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            if (check(txtMaKTX.Text) > 0)
            {
                string sql = String.Format("UPDATE KTX SET TenKTX = N'{0}' WHERE MaKTX = '{1}' ;",  txtTenKTX.Text, txtMaKTX.Text);
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Chưa có mã KTX này", "Thông báo!");
            }
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaKTX.Text) | string.IsNullOrWhiteSpace(txtTenKTX.Text) )
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            else
            {

                if (check(txtMaKTX.Text) > 0)
                {
                    DialogResult dr = MessageBox.Show("Thao tác này sẽ xoá tất cả các sinh viên ở trong KTX này!\n Tiếp tục?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = String.Format("DELETE FROM KTX WHERE MaKTX = '{0}'", txtMaKTX.Text);
                        db.excute(sql);
                        txtMaKTX.Clear();
                        txtTenKTX.Clear();
                        refreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có mã KTX này", "Thông báo!");
                }
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKTX.CurrentRow.Index;
            txtMaKTX.Text = dgvKTX.Rows[i].Cells[0].Value.ToString();
            txtTenKTX.Text = dgvKTX.Rows[i].Cells[1].Value.ToString();
        }
        private int check(string st)
        {
            string sql = "select COUNT(*) from KTX where MaKTX = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }
    }
}
