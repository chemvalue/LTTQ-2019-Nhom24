using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_Trung
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ngànhHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.ShowDialog();
        }

        private void tạmTruToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiHìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daotao dt = new Daotao();
            dt.Show();
        }
    }
}
