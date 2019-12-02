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
    public partial class Users : Form
    {
        SqlConnection conn;
        MyDatabase db = new MyDatabase();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        private void refreshDataGridView()
        {          
            dgvUsers.DataSource = db.getData("SELECT * FROM USERS");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbNew_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMK.Text = "";
            txtConfimMk.Text = "";
            txtSearch.Text = "";
            txtTaikhoan.Focus();
            refreshDataGridView(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if(string.IsNullOrWhiteSpace(txtTaikhoan.Text))
            {
                MessageBox.Show("Chua nhap tai khoan!", "Thong bao!");
            }
            else
            {
                if(!string.IsNullOrWhiteSpace(txtMK.Text))
                {
                    if (txtMK.Text.Equals(txtConfimMk.Text))
                    {
                        if(db.check(txtTaikhoan.Text)==0)
                        {
                            string sql = "insert into USERS values('" + txtTaikhoan.Text + "','" + txtMK.Text + "', 0)";
                            db.excute(sql);
                            refreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Tai khoan da ton tai!", "Thong bao!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong khop!", "Thong bao!");
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap mat khau!", "Thong bao!");
                }
                
            }
            
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtTaikhoan.Text))
            {
                MessageBox.Show("Chua nhap tai khoan!", "Thong bao!");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtMK.Text))
                {
                    if (txtMK.Text.Equals(txtConfimMk.Text))
                    {
                        if(db.check(txtTaikhoan.Text)!=0)
                        {
                            string sql = "update USERS set MatKhau = '"+txtMK.Text+"' where TenDangNhap = '"+txtTaikhoan.Text+"'";
                            db.excute(sql);
                            refreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Chua co tai khoan nay!", "Thong bao!");
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong khop!", "Thong bao!");
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap mat khau!", "Thong bao!");
                }

            }

            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtTaikhoan.Text))
            {
                MessageBox.Show("Chua nhap tai khoan!", "Thong bao!");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtMK.Text))
                {
                    if (txtMK.Text.Equals(txtConfimMk.Text))
                    {
                        if (db.check(txtTaikhoan.Text) != 0)
                        {
                            string sql = "delete from USERS where TenDangNhap = '" + txtTaikhoan.Text + "'";
                            db.excute(sql);
                            refreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Chua co tai khoan nay!", "Thong bao!");
                        }                   
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong khop!", "Thong bao!");
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap mat khau!", "Thong bao!");
                }

            }

            conn.Close();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = db.connected();
            conn.Open();           
            dgvUsers.DataSource = db.getData("SELECT * FROM USERS where TenDangNhap like '%"+txtSearch.Text+"%'");         
            conn.Close();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvUsers.CurrentRow.Index;
            txtTaikhoan.Text = dgvUsers.Rows[i].Cells[1].Value.ToString();
            txtMK.Text = dgvUsers.Rows[i].Cells[2].Value.ToString();
            txtConfimMk.Text = dgvUsers.Rows[i].Cells[2].Value.ToString();
        }

    }
}
