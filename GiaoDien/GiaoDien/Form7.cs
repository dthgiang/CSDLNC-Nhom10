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
using System.Xml.Linq;
using System.Xml;
using System.Data.Common;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace GiaoDien
{
    
    public partial class Form7 : Form
    {
        public string tenquan;
        public string id_doitac;
        public string id_chinhanh;
        public string tenmon;
        public String soluong;
        public String id_donhang;
        public String id_khachhang;
        public String mathucdon;
        public String tuychon;
        public string tong;
        public string phiship;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form7()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            InitializeComponent();
        }



        private void Form7_Load(object sender, EventArgs e)
        {
            btnHuy.Hide();
            label1.Hide();
            lblMieuTa.Hide();
            lblGia.Hide();
            lblTong.Hide();
            cbbThucDon.Hide();
            btnDongY.Hide();
            btnChonMonAn.Hide();
            numSoLuong.Hide();
            label2.Hide();
            textBox1.Hide();
            lblTenQuan.Text = tenquan;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT machinhanh, tenchinhanh FROM chinhanh WHERE chinhanh.madoitac ='" + id_doitac + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbChiNhanh.DataSource = table;
            cbbChiNhanh.ValueMember = "machinhanh";
            cbbChiNhanh.DisplayMember = "tenchinhanh";

            cbbChiNhanh.SelectedIndex = -1;
        }
        private void btnChonChiNhanh_Click(object sender, EventArgs e)
        {
            cbbThucDon.Show();
            btnChonMonAn.Show();
            label1.Show();
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

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql_ = "exec taodonhang '" + id_khachhang + "','" + id_doitac + "'";
            _command = new SqlCommand(sql_, _connection);
            _command.Connection = _connection;
            SqlDataReader reader_ = _command.ExecuteReader();
            if (reader_.Read())
            {
                this.id_donhang = reader_["MaDonHang"].ToString();
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            tuychon=textBox1.Text;
            lblMieuTa.Hide();
            lblGia.Hide();
            lblTong.Hide();
            btnDongY.Hide();
            numSoLuong.Hide();
            label2.Hide();
            textBox1.Hide();
            lblTong.Show();

            soluong = numSoLuong.Value.ToString();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taoctdonhang '" + mathucdon + "','"+id_donhang+"','"+soluong+"',N'"+tuychon+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");

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
            btnHuy.Show();
            btnTroVe.Hide();
            lblMieuTa.Show();
            lblGia.Show();
            lblTong.Show();
            btnDongY.Show();
            numSoLuong.Show();
            label2.Show();
            textBox1.Show();

            DataRowView row = (DataRowView)cbbThucDon.SelectedItem;
            tenmon = row.Row["tenmonan"].ToString();

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "SELECT mathucdon,mieuta,gia FROM thucdon where thucdon.madoitac='" + id_doitac + "' and thucdon.machinhanh='" + id_chinhanh + "' and thucdon.tenmonan= N'" + tenmon + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                lblGia.Text = "Gia: " + reader["Gia"].ToString();
                lblMieuTa.Text = "Mieu ta: " + reader["mieuta"].ToString();
                mathucdon = reader["mathucdon"].ToString();
            }

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec huydonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");

            Form2 form2 = new Form2();
            form2.Show();
            form2.id_khachhang = id_khachhang;
            this.Close();
        }

        private void btnDatDonHang_Click(object sender, EventArgs e)
        {
            
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec update_donhang '" + id_donhang + "','"+id_doitac+"','"+id_chinhanh+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");

            Form4 form4 = new Form4();
            form4.id_donhang = id_donhang;
            form4.id_khachhang = id_khachhang;
            form4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.id_khachhang = id_khachhang;
            this.Close();
        }


    }
}