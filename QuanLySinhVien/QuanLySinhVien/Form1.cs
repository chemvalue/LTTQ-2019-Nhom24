using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        QLHSSVEntities db = new QLHSSVEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }



        #region methobs

        void AddBinding()
        {
            txtMSV.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "MSV"));
            txtHoTen.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Name"));
            txtLop.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Class"));
            txtTenPhong.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Room"));
            txtKTX.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "From"));
        }
        void LoadData()
        {
            //using (QLHSSVEntities db = new QLHSSVEntities())
            {
                var result = from c in db.SINHVIENs where (c.TenPhong != null) select new { MSV = c.MSV, Name = c.HoTenSV, Class = c.LOP.MaLop, Room = c.NOITRU.TenPhong, From = c.NOITRU.KTX.TenKTX };
                dtgvData.DataSource = result.ToArray();
            }
        }
        void AddNoiTru()
        {
            SINHVIEN sv = db.SINHVIENs.Where(p => p.MSV == txtMSV.Text && p.HoTenSV == txtHoTen.Text && p.LOP.MaLop == txtLop.Text).SingleOrDefault();
            db.SINHVIENs.Add(sv);
            db.SaveChanges();

        }

        void DeleteNoiTru()
        {

        }

        void EditNoiTru()
        {

        }


        #endregion

        #region Events

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            LoadData();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNoiTru();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditNoiTru();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteNoiTru();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
