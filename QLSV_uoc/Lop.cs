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

namespace QLSV
{
    public partial class Lop : Form
    {
        private SqlConnection con;
        private DataTable dt = new DataTable("tblKhoavien");
        private SqlDataAdapter da = new SqlDataAdapter();

        private void connect()
        {
            String cn = @"Data Source=ADMIN/SQLEXPRESS;Initial Catalog=QLHSSV;Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Kết nối tới CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        public Lop()
        {
            InitializeComponent();
        }

       
        private void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"select * from LOP";
            da.SelectCommand = command;
            da.Fill(dt);
            grvdatalop.DataSource = dt;
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }
    }
}
