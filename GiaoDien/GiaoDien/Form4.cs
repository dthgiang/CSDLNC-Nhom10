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
    public partial class Form4 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String tongdonhang;
        public String phivanchuyen;
        public string id_khachhang;
        public Form4()
        {
            InitializeComponent();
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }
        public string id_donhang;
        private void Form4_Load(object sender, EventArgs e)
        {
            
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "select PhiDonHang, PhiVanChuyen from DonHang where MaDonHang='"+id_donhang+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                tongdonhang = reader["PhiDonHang"].ToString() ;
                phivanchuyen = reader["PhiVanChuyen"].ToString();
            }
            lblTongDonHang.Text ="Tổng đơn hang: " +tongdonhang;
            lblPhiVanChuyen.Text ="Phí vận chuyển" +phivanchuyen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String diachi;
            diachi = txtDiaChi.Text;
            string selectedItems = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    selectedItems = checkedListBox1.Items[i].ToString();
            }
            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec hoantatdonhang '" + id_donhang + "',N'" + selectedItems + "',N'" + diachi + "'"; 
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
            this.Hide();
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