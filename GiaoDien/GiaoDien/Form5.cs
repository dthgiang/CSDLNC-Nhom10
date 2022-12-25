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
    public partial class Form5 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public string id_khachhang;
        public String id_donhang;
        public String trangthai;
        public Form5()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            label3.Show();
            lblTrangThai.Show();
            button2.Show();
            DataRowView row = (DataRowView)cbbMaDonHang.SelectedItem;
            id_donhang = (String)row.Row["madonhang"];

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec tinhtrangdonhang_kh '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                lblTrangThai.Text = reader["TinhTrangDonHang"].ToString();
            }
            if (lblTrangThai.Text=="Chờ nhận")
            {
                button2.Show();
            }
            else
            {
                button2.Hide();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button2.Hide();
            label3.Hide();
            lblTrangThai.Hide();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec donhang_dangduocthuchien '" + id_khachhang + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbMaDonHang.ValueMember = "madonhang";
            cbbMaDonHang.DisplayMember = "madonhang";
            cbbMaDonHang.DataSource = table;
            cbbMaDonHang.SelectedIndex = -1;

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec huydonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();
        }


    }
}