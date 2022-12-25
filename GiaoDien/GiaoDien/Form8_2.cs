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
    public partial class Form8_2 : Form
    {
        public String id_taixe;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form8_2()
        {
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            InitializeComponent();
        }


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.id_taixe = id_taixe;
            f.Show();
            this.Close();
        }

        private void Form8_2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dsdonhangdanhan '" + id_taixe + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}