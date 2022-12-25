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
    public partial class Form12 : Form
    {
        public String id_doitac;
        String connectionString = "";
        public Form12()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void themCN_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String procname = "themChinhanh";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@madoitac", SqlDbType.Char);
            command.Parameters.Add("@diachi", SqlDbType.NVarChar);
            command.Parameters.Add("@stk", SqlDbType.Char);
            command.Parameters.Add("@tenchinhanh", SqlDbType.NVarChar);
            command.Parameters.Add("@tennh", SqlDbType.Char);


            command.Parameters["@madoitac"].Value = id_doitac;
            command.Parameters["@diachi"].Value = themDiaChiCN_txtBox.Text;
            command.Parameters["@stk"].Value = themSTKCN_txtBox.Text;
            command.Parameters["@tenchinhanh"].Value = themTenCN_txtBox.Text;
            command.Parameters["tennh"].Value = themTenNH_txtBox.Text;

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Thêm thành công!!!");
            }
            else
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Thêm thất bại!!!");
            }

            connection.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
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

        private void xoaCN_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataRowView row = (DataRowView)CN_cbb.SelectedItem;
            String branchID = (String)row.Row["MaChiNhanh"];

            String procname = "xoaChiNhanh";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            
            command.Parameters.Add("@MaChiNhanh", SqlDbType.Char);
            command.Parameters["@MaChiNhanh"].Value = branchID;

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Xóa thành công!!!");
            }

            else
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Xóa thất bại!!!");
            }

            connection.Close();
        }
    }
}
