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
    public partial class Lop : Form
    {
        SqlConnection conn;
        MyDatabase db = new MyDatabase();
        public Lop()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            dgrdata.DataSource = db.getData("select * from LOP");
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
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
            if (txtml.Text.Equals("") | txtmn.Text.Equals(""))
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
                if (check("MaLop", "Lop", txtml.Text) == 0)
                {
                    string sql = "insert into Lop values('" + txtml.Text + "','" + txtmn.Text + "')";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Lớp đã tồn tại!", "Thông báo!");

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
                if (check("MaLop", "Lop", txtml.Text) > 0)
                {
                    string sql = "update Lop set MaNganh ='" + txtmn.Text + "' where MaLop='" + txtml.Text + "'";
                    db.excute(sql);
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Lop chưa tồn tại!", "Thông báo!");
                }
                conn.Close();
            }
            xoa(this);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (check("MaLop", "Lop", txtml.Text) > 0)
            {
                string sql = "delete from Lop where MaLop = '" + txtml.Text + "'";
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

        private void dgrdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgrdata.CurrentRow.Index;
            txtml.Text = dgrdata.Rows[i].Cells[0].Value.ToString();
            txtmn.Text = dgrdata.Rows[i].Cells[1].Value.ToString();
        }
    }
}
