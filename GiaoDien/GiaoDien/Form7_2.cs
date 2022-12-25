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
    public partial class Form7_2 : Form
    {
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form7_2()
        {
            InitializeComponent();
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        private void Form7_2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select top(50) MaDonHang, HinhThucThanhToan, DCGiaoHang, PhiDonHang from DonHang where makhachhang ='" + id_khachhang + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //setGridViewEditable(false);

            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();
        }
    }
}
