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
    public partial class KhoaVien : Form
    {
        SqlConnection conn;
        MyDatabase db = new MyDatabase();
        public KhoaVien()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            dgrdata.DataSource = db.getData("select * from KHOAVIEN");
        }
        private void KhoaVien_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void xoa(Control ctr)
        {
            if (ctr is TextBox)
            {
                ctr.Text = string.Empty;
            }
            foreach (Control i in ctr.Controls)
            {
                xoa(i);
            }
        }
        private int check(string st, string str, string txt)
        {
            string sql = "select COUNT(*) from " + str + " where " + st + " = '" + txt + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }
        private Boolean checkAll()
        {
            if (txtmkv.Text.Equals("") | txttkv.Text.Equals(""))
                return true;
            return false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                MessageBox.Show("Không để trống!", "Thông báo!");
            }
            else
            {
                conn = db.connected();
                conn.Open();
                if (check("MKV", "KhoaVien", txtmkv.Text) == 0)
                {
                    string sql = "insert into KhoaVien values('" + txtmkv.Text + "','" + txttkv.Text + "')";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Khoa Viện đã tồn tại!", "Thông báo!");
                }
                conn.Close();
            }
            xoa(this);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                MessageBox.Show("Không để trống!", "Thông báo!");
            }
            else
            {
                conn = db.connected();
                conn.Open();
                if (check("MKV", "KhoaVien", txtmkv.Text) > 0)
                {
                    string sql = "update KhoaVien set TenKhoaVien='" + txttkv.Text + "' where MKV='" + txtmkv.Text + "'";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Khoa Viện chưa tồn tại!", "Thông báo!");
                }
                conn.Close();
            }
            xoa(this);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (check("MKV", "KhoaVien", txtmkv.Text) > 0)
            {
                string sql = "delete from KhoaVien where MKV = '" + txtmkv.Text + "'";
                db.excute(sql);
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản này!", "Thong bao!");
            }
            conn.Close();
            xoa(this);
        }

        private void dgrdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgrdata.CurrentRow.Index;
            txtmkv.Text = dgrdata.Rows[i].Cells[0].Value.ToString();
            txttkv.Text = dgrdata.Rows[i].Cells[1].Value.ToString();
        }


    }
}
