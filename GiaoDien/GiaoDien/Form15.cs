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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }
        public String id_nhanvien;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";

        public String id_hopdong;
        public String tenquan;
        public String masothue;
        public String email;
        public String sdt;
        public String diachi;
        public String tennguoidaidien;
        public String thoigianhieuluc;

        private void Form15_Load(object sender, EventArgs e)
        {

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec thongtindoitac '" + id_hopdong + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                masothue = reader["masothue"].ToString();
                email = reader["Email"].ToString();
                sdt = reader["sodienthoai"].ToString();
                diachi = reader["diachi"].ToString();
                tennguoidaidien = reader["TenNguoiDaiDien"].ToString();
                tenquan = reader["Tendoitac"].ToString();
            }
            label19.Text = tenquan;
            label21.Text = masothue;
            label22.Text = email;
            label23.Text = sdt;
            label24.Text = diachi;
            label25.Text = tennguoidaidien;

            label30.Text = id_hopdong;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.id_nhanvien = id_nhanvien;
            form.Show();
            this.Close();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            thoigianhieuluc = txtNgayHieuLuc.Text;
            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec giahanhopdong '" + id_hopdong + "','" + thoigianhieuluc + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");
        }




    }
}