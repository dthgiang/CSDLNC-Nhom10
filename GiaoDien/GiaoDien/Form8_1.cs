using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form8_1 : Form
    {
        public String id_khachhang;
        public String id_donhang;
        public String diachicuahang;
        public String diachinguoinhan;
        public String tenquan;

        public String sdtnguoinhan;
        public String id_taixe;
        public String trangthaidonhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form8_1()
        {
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            InitializeComponent();
        }

        private void Form8_1_Load(object sender, EventArgs e)
        {
            label1.Text = id_donhang;
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec thongtinkhachhang '" + id_khachhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                lcltennguoinhan.Text = reader["hovaten"].ToString();
                lblsdtnguoinhan.Text = reader["SoDienThoai"].ToString();
            }


            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql__ = "exec tinhtrangdonhang_kh'" + id_donhang + "'";
            _command = new SqlCommand(sql__, _connection);
            _command.Connection = _connection;
            SqlDataReader reader__ = _command.ExecuteReader();
            if (reader__.Read())
            {
                trangthaidonhang = reader__["TinhTrangDonHang"].ToString();
                lbltt.Text = trangthaidonhang;
            }


            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql___ = "select PhiVanChuyen, PhiDonHang, HinhThucThanhToan, DCNhanHang, DCGiaoHang from DonHang where MaDonHang='" + id_donhang + "'";
            _command = new SqlCommand(sql___, _connection);
            _command.Connection = _connection;
            SqlDataReader reader___ = _command.ExecuteReader();
            if (reader__.Read())
            {
                lbltienship.Text = reader__["phivanchuyen"].ToString();
                lbltong.Text = reader__["PhiDonHang"].ToString();
                lblhttt.Text = reader__["HinhThucThanhToan"].ToString();
                lbldccuahang.Text = reader__["DCNhanHang"].ToString();
                lbldiachinguoinhan.Text = reader___["DCGiaoHang"].ToString();
            }
            if (trangthaidonhang != "Hoàn tất")
            {
                button1.Hide();
            }
            else
            {
                button1.Show();
            }

        }



        private void btnChuyenDonHang_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taixe_chuyentrangthai '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");


            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql__ = "exec tinhtrangdonhang_kh'" + id_donhang + "'";
            _command = new SqlCommand(sql__, _connection);
            _command.Connection = _connection;
            SqlDataReader reader__ = _command.ExecuteReader();
            if (reader__.Read())
            {
                trangthaidonhang = reader__["TinhTrangDonHang"].ToString();
                lbltt.Text = trangthaidonhang;
            }
            if (trangthaidonhang != "Hoàn tất")
            {
                button1.Hide();
            }
            else
            {
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.id_taixe = id_taixe;
            f.id_donhang = id_donhang;
            f.Show();
            this.Close();
        }


    }
}