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
    public partial class Form8 : Form
    {
        public String id_taixe;
        public String id_khuvuc;
        public String id_donhang;
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form8()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "select makhuvuc from taixe where mataixe='" + id_taixe + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                id_khuvuc = reader["makhuvuc"].ToString();
            }

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dsdonhang '" + id_khuvuc + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cbbDSDonHang.DataSource = table;
            cbbDSDonHang.ValueMember = "makhachhang";
            cbbDSDonHang.DisplayMember = "MaDonHang";
            cbbDSDonHang.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }

        private void btnChonDonHang_Click(object sender, EventArgs e)
        {
            Form8_1 f = new Form8_1();
            DataRowView row = (DataRowView)cbbDSDonHang.SelectedItem;
            id_donhang = (String)row.Row["MaDonHang"];
            f.id_donhang = (String)row.Row["MaDonHang"];
            f.id_khachhang= (String)row.Row["makhachhang"];
            f.id_taixe = id_taixe;
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taixe_nhandon '" + id_donhang + "','" + id_taixe + "'";
            _command = new SqlCommand(sql, _connection);
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");


            f.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8_1 form10_1 = new Form8_1();

            form10_1.id_taixe = id_taixe;

            form10_1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8_2 form10_2 = new Form8_2();
            form10_2.id_taixe = id_taixe;
            form10_2.Show();
            this.Close();
        }


    }
}