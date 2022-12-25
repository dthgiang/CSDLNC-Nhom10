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
    public partial class Form13 : Form
    {
        public String id_doitac;
        String connectionString = "";
        public Form13()
        {
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e )
        {

        }

        private void Form13_Load(object sender, EventArgs e)
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

        private void XemThucDon_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataRowView row = (DataRowView)CN_cbb.SelectedItem;
            String branchID = (String)row.Row["MaChiNhanh"];

            String procname = "xemThucDon";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@iddt", SqlDbType.Char);
            command.Parameters.Add("@idcn", SqlDbType.Char);

            command.Parameters["@iddt"].Value = id_doitac;
            command.Parameters["@idcn"].Value = branchID;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DSTD_Grid.DataSource = table;
        }
    }
}
