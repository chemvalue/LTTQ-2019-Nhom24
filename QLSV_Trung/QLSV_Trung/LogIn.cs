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
    public partial class LogIn : Form
    {
        MyDatabase mdb = new MyDatabase();
        private SqlConnection conn = null;
        public LogIn()
        {
            InitializeComponent();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string select = "Select * From USERS where TenDangNhap = '" + txtName.Text + "' and MatKhau = '" + txtPass.Text + "' and Status = 1";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MainPage frm = new MainPage();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            conn = mdb.connected();
            conn.Open();
        }


    }
}
