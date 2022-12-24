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
    public partial class Form1 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form1()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            String tendangnhap = this.txtTenDangNhap.Text;
            String matkhau = this.txtMatKhau.Text;
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec sp_login '" + tendangnhap + "','" + matkhau + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                string loaitaikhoan = reader["loaitaikhoan"].ToString();
                if (loaitaikhoan == "Khach hang")
                {
                    //lay id_khachhang
                    String id_khachhang = reader["makhachhang"].ToString();
                    //vao form trang chu cua khach hang
                    Form2 form2 = new Form2();
                    form2.id_khachhang = id_khachhang;
                    //form2.id_f2 = id;
                    form2.Show();
                    this.Hide();
                }
                
            }
            else
                MessageBox.Show("Not found !!!");
            reader.Close();
            //Bước 5: Đóng kết nối
            _connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form1_1 form1_1 = new Form1_1();
            form1_1.ShowDialog();
            this.Close();
        }
    }
}
