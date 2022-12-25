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
    public partial class Form7_1 : Form
    {
        public String monan;
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form7_1()
        {
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            InitializeComponent();
        }


        private void Form7_1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select distinct TenmonAn, TenDoiTac, MaDoiTac from ThucDon where ThucDon.LoaiAmThuc = N'" + monan + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbTimKiem.ValueMember = "MaDoiTac";
            cbbTimKiem.DisplayMember = "TenDoiTac";
            cbbTimKiem.DataSource = table;
            cbbTimKiem.SelectedIndex = -1;


            //setGridViewEditable(false);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            DataRowView row = (DataRowView)cbbTimKiem.SelectedItem;
            f.tenquan = (String)row.Row["TenDoiTac"];
            f.id_doitac = (String)row.Row["MaDoiTac"];
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Close();
        }
    }
}
    
