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
using System.Xml;
using System.Xml.Linq;

namespace GiaoDien
{
    public partial class Form6 : Form
    {
        public String id_thucdon;
        public String id_khachhang;
        public String id_donhang;
        public String rate;
        public String comment;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form6()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lblComment.Hide();
            txtComment.Hide();
            lblRate.Hide();
            numRate.Hide();
            btnDongY.Hide();
            label1.Hide();
            cbbMonAn.Hide ();
            button1.Hide();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec donhang_thanhcong '" + id_khachhang + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbMaDonHang.DataSource = table;
            cbbMaDonHang.ValueMember = "madonhang";
            cbbMaDonHang.DisplayMember = "madonhang";
            cbbMaDonHang.SelectedIndex = -1;
            connection.Close();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            label1.Show();
            cbbMonAn.Show();
            button1.Show();

            DataRowView row = (DataRowView)cbbMaDonHang.SelectedItem;
            id_donhang = (String)row.Row["madonhang"];

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec monantrongdonhang '" + id_donhang + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbMonAn.DataSource = table;
            cbbMonAn.ValueMember = "tenmonan";
            cbbMonAn.DisplayMember = "mathucdon";
            cbbMonAn.SelectedIndex = -1;
            connection.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            comment = txtComment.Text;
            rate = numRate.Value.ToString();

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec danhgiadonhang '" + id_thucdon + "','" + id_khachhang + "',N'" + comment + "','" + rate + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Đánh giá thành công!!!");
            else
                MessageBox.Show("Đã đánh giá món ăn trong đơn hàng này !!!");

            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblComment.Show();
            txtComment.Show();
            lblRate.Show();
            numRate.Show();
            btnDongY.Show();


        }
    }
}