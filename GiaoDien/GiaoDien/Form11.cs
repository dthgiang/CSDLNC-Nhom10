using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiaoDien
{
    public partial class Form11 : Form
    {
        public String id_doitac;
        String connectionString = "";
        public Form11()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void xemDT_btn_Click(object sender, EventArgs e)
        {
            DateTime From_Date, To_Date;
            From_Date = dateTimePicker1.Value;
            To_Date = dateTimePicker2.Value;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataRowView row = (DataRowView)CN_cbb.SelectedItem;
            String branchID = (String)row.Row["MaChiNhanh"];

            String procname = "doanhthuChiNhanh";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MaChiNhanh", SqlDbType.Char);
            command.Parameters.Add("@Tu_ngay", SqlDbType.DateTime);
            command.Parameters.Add("@Den_ngay", SqlDbType.DateTime);

            command.Parameters["@MaChiNhanh"].Value = branchID;
            command.Parameters["@Tu_ngay"].Value = From_Date;
            command.Parameters["@Den_ngay"].Value = To_Date;

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DoanhThu_Grid.DataSource = table;

            connection.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String sqlQuery = String.Format("SELECT * FROM CHINHANH WHERE MADOITAC = '{0}'", id_doitac);

            SqlDataAdapter CNadapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable CNtable = new DataTable();

            CNadapter.Fill(CNtable);

            CN_cbb.ValueMember = "MaChiNhanh";
            CN_cbb.DisplayMember = "MaChiNhanh";
            CN_cbb.DataSource = CNtable;
            CN_cbb.SelectedItem = -1;

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
