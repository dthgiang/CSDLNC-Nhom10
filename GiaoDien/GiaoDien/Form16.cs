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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        public String thoigianhieuluc;
        public String id_nhanvien;
        public String id_hopdong;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.id_nhanvien = this.id_nhanvien;
            form.Show();
            this.Hide();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbDoiTac.SelectedItem;
            id_hopdong = (String)row.Row["mahopdong"];

            Form15 form = new Form15();
            form.id_nhanvien = id_nhanvien;
            form.id_hopdong=id_hopdong;
            form.Show();
            this.Close();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from hopdong", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDoiTac.ValueMember = "thoigianhieuluc";
            cbbDoiTac.DisplayMember = "mahopdong";
            cbbDoiTac.DataSource = table;
            cbbDoiTac.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }
    }
}
