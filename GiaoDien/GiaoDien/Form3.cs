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
    public partial class Form3 : Form
    {
        public String id_khachhang;
        public String id_doitac;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form3()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select top(50) madoitac,tendoitac, ratetb from doitac", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbChiNhanh.ValueMember = "madoitac";
            cbbChiNhanh.DisplayMember = "tendoitac";
            cbbChiNhanh.DataSource = table;
            cbbChiNhanh.SelectedIndex = -1;

        }

        private void btnTimKiemCuahang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_1 form3_1 = new Form3_1();
            DataRowView row = (DataRowView)cbbChiNhanh.SelectedItem;
            form3_1.tenquan = (String)row.Row["tendoitac"];
            form3_1.id_doitac = (String)row.Row["madoitac"];
            form3_1.id_khachhang = id_khachhang;
            form3_1.Show();

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