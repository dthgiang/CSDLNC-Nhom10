using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form3_1 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form3_1()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        public string tenquan;
        public string id_doitac;
        public string id_chinhanh;
        public string tenmon;
        public String soluong;
        public String id_donhang;
        public String id_khachhang;
        public String diachichinhanh; 
        //public int tongtien = 0;
        private void Form3_1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            lblMieuTa.Hide();
            lblGia.Hide();
            lblTong.Hide();
            cbbThucDon.Hide();
            btnDongY.Hide();
            btnChonMonAn.Hide();
            numSoLuong.Hide();

            lblTenQuan.Text = tenquan;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT machinhanh, dcchinnhanh FROM chinhanh WHERE chinhanh.madoitac ='" + id_doitac + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbChiNhanh.ValueMember = "machinhanh";
            cbbChiNhanh.DisplayMember = "tenchinhanh";
            cbbChiNhanh.DataSource = table;
            cbbChiNhanh.SelectedIndex = -1;


        }

        private void btnChonChiNhanh_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbChiNhanh.SelectedItem;
            id_chinhanh = (String)row.Row["machinhanh"];

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter_ = new SqlDataAdapter("SELECT tenmonan, Gia, mieuta FROM thucdon where thucdon.madoitac='" + id_doitac + "' and thucdon.machinhanh='" + id_chinhanh + "'", connection);

            DataTable tablethucdon = new DataTable();
            adapter_.Fill(tablethucdon);
            cbbThucDon.DataSource = tablethucdon;
            cbbThucDon.ValueMember = "tenmonan";
            cbbThucDon.DisplayMember = "tenmonan";
            cbbThucDon.SelectedIndex = -1;

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            lblMieuTa.Hide();
            lblGia.Hide();
            lblTong.Hide();
            btnDongY.Hide();
            numSoLuong.Hide();

            soluong = numSoLuong.Value.ToString();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taoctdonhang '" + id_donhang + "','" + id_chinhanh + "','" + id_doitac + "',N'" + tenmon + "'," + soluong;
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql_tong = "exec tinhtongdonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql_tong, _connection);
            _command.Connection = _connection;
            SqlDataReader reader_tong = _command.ExecuteReader();

            if (reader_tong.Read())
            {
                lblTong.Text = "Tổng tiền món ăn: " + reader_tong["Tong"].ToString();
            }

        }

        private void btnChonMonAn_Click(object sender, EventArgs e)
        {
            lblMieuTa.Show();
            lblGia.Show();
            lblTong.Show();
            btnDongY.Show();
            numSoLuong.Show();


            DataRowView row = (DataRowView)cbbThucDon.SelectedItem;
            tenmon = row.Row["tenmonan"].ToString();

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "SELECT mieuta,gia FROM thucdon where thucdon.madoitac='" + id_doitac + "' and thucdon.machinhanh='" + id_chinhanh + "' and thudon.tenmonan= N'" + tenmon + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                lblGia.Text = "Gia: "+reader["Gia"].ToString();
                lblMieuTa.Text = "Mieu ta: " + reader["mieuta"].ToString();
            }

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql_ = "exec taodonhang '" + id_khachhang + "','" + id_doitac + "','" + id_chinhanh + "'";
            _command = new SqlCommand(sql_, _connection);
            _command.Connection = _connection;
            SqlDataReader reader_ = _command.ExecuteReader();
            if (reader_.Read())
            {
                id_donhang = reader_["madonhang"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec huydonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form2 form2 = new Form2();
            form2.Show();
            form2.id_khachhang = id_khachhang;
            this.Close();
        }

        private void btnDatDonHang_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec update_donhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form4 form4 = new Form4();
            form4.id_donhang = id_donhang;
            form4.id_khachhang = id_khachhang;
            if (reader.Read())
            {
                form4.tongdonhang = reader["phidonhang"].ToString();
                form4.phivanchuyen = reader["phivanchuyen"].ToString();
            }
            form4.Show();
            this.Close();
        }


    }
}