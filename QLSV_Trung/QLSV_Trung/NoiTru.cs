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
    public partial class NoiTru : Form
    {
        MyDatabase db = new MyDatabase();
        SqlConnection conn;
        string stt = "";

        public NoiTru()
        {
            InitializeComponent();
        }

        private void refreshDataGridView()
        {
            dgvNoiTru.DataSource = db.getData("SELECT * FROM NOITRU");
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void NoiTru_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dgvNgoaiTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNoiTru.CurrentRow.Index;
            txtTenPhong.Text = dgvNoiTru.Rows[i].Cells[0].Value.ToString();
            txtSoLuong.Text = dgvNoiTru.Rows[i].Cells[1].Value.ToString();
            txtMaKTX.Text = dgvNoiTru.Rows[i].Cells[3].Value.ToString();
        }

        private void btbNew_Click(object sender, EventArgs e)
        {
            txtTenPhong.Text = "";
            txtSoLuong.Text = "";
            txtMaKTX.Text = "";
            refreshDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            conn = db.connected();
            conn.Open(); 
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) | string.IsNullOrWhiteSpace(txtSoLuong.Text) | string.IsNullOrWhiteSpace(txtMaKTX.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            else
            {
                if (check(txtTenPhong.Text) == 0)
                {
                    string sql = String.Format("INSERT INTO NOITRU VALUES('{0}','{1}',{2},'{3}');", txtTenPhong.Text, txtSoLuong.Text, stt, txtMaKTX.Text);
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông Báo!");
                }
            }     
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) | string.IsNullOrWhiteSpace(txtSoLuong.Text) | string.IsNullOrWhiteSpace(txtMaKTX.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            else
            {
                if (check(txtTenPhong.Text) > 0)
                {
                    string sql = String.Format("UPDATE NOITRU SET SoLuong = '{0}', Status = '{1}' WHERE TenPhong = '{2}' and MaKTX = '{3}';", txtSoLuong.Text, stt, txtTenPhong.Text, txtMaKTX.Text);
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Phòng không tồn tại", "Thông báo!");
                }
            }           
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) | string.IsNullOrWhiteSpace(txtSoLuong.Text) | string.IsNullOrWhiteSpace(txtMaKTX.Text))
            {
                MessageBox.Show("Không được để trống trường!", "Thông báo!");
            }
            else
            {
                if (check(txtTenPhong.Text) > 0)
                {
                    DialogResult dr = MessageBox.Show("Thao tác này sẽ xoá tất cả các sinh viên có nội trú này!\n Tiếp tục?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = String.Format("DELETE FROM NOITRU WHERE TenPhong = '{0}'", txtTenPhong.Text);
                        db.excute(sql);
                        refreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Phòng không tồn tại", "Thông báo!");
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
            string sql = "select COUNT(*) from NOITRU where TenPhong = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }

        private void checkstt()
        {
            if(!txtSoLuong.Text.Equals(""))
            {
                if (Convert.ToInt32(txtSoLuong.Text.ToString()) < 6)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    stt = "0";
                }
                else
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    stt = "1";
                }
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            checkstt();
        }
    }
}
