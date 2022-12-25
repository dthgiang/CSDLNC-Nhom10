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
    public partial class Form10 : Form
    {
        String connectionString = "";
        public String id_doitac;
        public Form10()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        public Form10(String madoitac)
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String procname = "xemTK_DoiTac";

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MaDoiTac", SqlDbType.Char);
            command.Parameters["@MaDoiTac"].Value = id_doitac;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                hoten_txtBox.Text = reader["HoVaTen"].ToString();
                email_txtBox.Text = reader["Email"].ToString();
                diachi_txtBox.Text = reader["DiaChi"].ToString();
                sdt_txtBox.Text = reader["SoDienThoai"].ToString();
            }

            connection.Close();
        }

        private void acp_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String procname = "update_doitac";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MaDoiTac", SqlDbType.Char);
            command.Parameters.Add("@HoVaTen", SqlDbType.NVarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            command.Parameters.Add("@SoDienThoai", SqlDbType.Char);

            command.Parameters["@MaDoiTac"].Value = id_doitac;
            command.Parameters["@HoVaTen"].Value = hoten_txtBox;
            command.Parameters["@email"].Value = email_txtBox;
            command.Parameters["@DiaChi"].Value = diachi_txtBox;
            command.Parameters["@SoDienThoai"].Value = sdt_txtBox;

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Cập nhật thành công!!!");
            }

            else
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Cập nhật thất bại!!!");
            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
