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
    public partial class Form9 : Form
    {
        public String id_doitac;
        String connectionString = "";
        public Form9()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //this.Close();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.id_doitac = id_doitac;
            form.Show();
        }

        private void quảnLíDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void quảnLíThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.id_doitac = id_doitac;
            form.Show();
        }

        private void quảnLíCNoolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.id_doitac = id_doitac;
            form.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // chay proc xem thong tin doi tac
            String procname = "thongtindoitac";
            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // truyen tham so madt vao proc
            command.Parameters.Add("@madt", SqlDbType.Char);
            command.Parameters["@madt"].Value = id_doitac;

            // chay reader
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Console.OutputEncoding = Encoding.Unicode;
                madoitac_label.Text = "Mã đối tác: " + reader["MaDoiTac"].ToString();
                tendoitac_label.Text = "Tên đối tác: " + reader["TenDoiTac"].ToString();
                masothue_label.Text = "Mã số thuế: " + reader["MaSoThue"].ToString();
                tenndd_label.Text = "Tên người đại diện: " + reader["TenNguoiDaiDien"].ToString();
                email_label.Text = "Email: " + reader["email"].ToString();
                sdt_label.Text = "Số điện thoại: " + reader["SoDienThoai"].ToString();
                diachi_label.Text = "Địa chỉ: " + reader["DiaChi"].ToString();
            }

            connection.Close();
        }
    }
}
