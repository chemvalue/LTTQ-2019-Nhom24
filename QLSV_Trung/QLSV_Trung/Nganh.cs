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
    public partial class Nganh : Form
    {
        SqlConnection conn;
        MyDatabase db = new MyDatabase();
        public Nganh()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            dgrdata.DataSource = db.getData("select * from NGANH");
        }

        private void Nganh_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dgrdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgrdata.CurrentRow.Index;
            txtmn.Text = dgrdata.Rows[i].Cells[0].Value.ToString();
            txttn.Text = dgrdata.Rows[i].Cells[1].Value.ToString();
            txtmkv.Text = dgrdata.Rows[i].Cells[2].Value.ToString();
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
            if (txtmn.Text.Equals("") | txttn.Text.Equals("") | txtmkv.Text.Equals(""))
                return true;
            return false;
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
                if (check("MaNganh", "NGANH", txtmn.Text) == 0)
                {
                    string sql = "insert into NGANH values('" + txtmn.Text + "',N'" + txttn.Text + "','" + txtmkv.Text + "')";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Ngành đã tồn tại!", "Thông báo!");

                }
                conn.Close();
                xoa(this);
            }
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
                if (check("MaNganh", "NGANH", txtmn.Text) > 0)
                {
                    string sql = "update NGANH set TenNganh =N'" + txttn.Text + "',MKV= '" + txtmkv.Text + "' where MaNganh='" + txtmn.Text + "'";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Ngành chưa tồn tại!", "Thông báo!");
                }
                conn.Close();
            }
            xoa(this);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (check("MaNganh", "NGANH", txtmn.Text) > 0)
            {
                string sql = "delete from NGANH where MaNganh = '" + txtmn.Text + "'";
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
