using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_Trung
{
    public partial class Daotao : Form
    {
        MyDatabase db = new MyDatabase();
        SqlConnection conn;

        public Daotao()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            dgvDaotao.DataSource = db.getData("SELECT * FROM LOAIHINHDT");
        }

        private void Daotao_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbNew_Click(object sender, EventArgs e)
        {
            txtLoaihinh.Text = "";
            txtMaDT.Text = "";
            refreshDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaDT.Text)|string.IsNullOrWhiteSpace(txtLoaihinh.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thong bao!");
            }
            if (check(txtMaDT.Text) == 0)
            {
                string sql = "insert into LOAIHINHDT values('" + txtMaDT.Text + "','" + txtLoaihinh.Text + "')";
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Mã đào tạo này đã tồn tại!", "Thong bao!");
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaDT.Text) | string.IsNullOrWhiteSpace(txtLoaihinh.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thong bao!");
            }
            if (check(txtMaDT.Text) > 0)
            {
                string sql = "update LOAIHINHDT set LoaiHinhDT = '" + txtLoaihinh.Text + "' where MaDT = '" + txtMaDT.Text + "'";
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Chua co ma dao tao nay!", "Thong bao!");
            }
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtMaDT.Text) | string.IsNullOrWhiteSpace(txtLoaihinh.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thong bao!");
            }
            else
            {
                
                if (check(txtMaDT.Text) > 0)
                {
                    DialogResult dr = MessageBox.Show("Thao tác này sẽ xoá tất cả các sinh viên thuộc loại hình đào tạo này!\n Tiếp tục?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dr == DialogResult.Yes)
                    {
                        string sql = "delete from LOAIHINHDT where MaDT = '" + txtMaDT.Text + "'";
                        db.excute(sql);
                        refreshDataGridView();
                    }             
                }
                else
                {
                    MessageBox.Show("Chua co ma dao tao nay!", "Thong bao!");
                }
            }      
            conn.Close();
        }
        private int check(string st)
        {
            string sql = "select COUNT(*) from LOAIHINHDT where MaDT = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }

        private void dgvDaotao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDaotao.CurrentRow.Index;
            txtMaDT.Text = dgvDaotao.Rows[i].Cells[0].Value.ToString();
            txtLoaihinh.Text = dgvDaotao.Rows[i].Cells[1].Value.ToString();
        }
    }
}
