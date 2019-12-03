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
            Nganh n = new Nganh();
            n.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoaVien kv = new KhoaVien();
            kv.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop lp = new Lop();
            lp.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.ShowDialog();
        }

        private void loạiHìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daotao dt = new Daotao();
            dt.Show();
        }

        private void kýTúcXáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KTX ktx = new KTX();
            ktx.Show();
        }

        private void nộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoiTru nt = new NoiTru();
            nt.Show();
        }

        private void ngoạiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgoaiTru nt = new NgoaiTru();
            nt.Show();
        }
    }
}
