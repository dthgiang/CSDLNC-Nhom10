using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form2 : Form
    {
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form2()
        {
            InitializeComponent();
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }



        private void btnTatCaCuaHang_click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.id_khachhang = id_khachhang;
            form3.Show();
            this.Hide();
        }

        private void btnLichSuDonHang_Click(object sender, EventArgs e)
        {
            Form7_2 f = new Form7_2();
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Hide();
        }

        private void btnTheoDoiDonHang_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Hide();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String monan = txtTiemKiemMonAn.Text;
            Form7_1 f = new Form7_1();
            f.monan = monan;
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Hide();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            Form2_1 f = new Form2_1();
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}

