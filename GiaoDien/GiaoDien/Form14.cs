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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
        }
        public String id_hopdong;
        public String id_nhanvien;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        private void Form14_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select mahopdong,phihoahong, dt.tendoitac, dt.masothue, ratetb, tennguoidaidien  from hopdong hd join doitac dt on hd.madoitac=dt.madoitac and manhanvienphutrach=null", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDuyetHopDong.ValueMember = "mahopdong";
            cbbDuyetHopDong.DisplayMember = "tendoitac";
            cbbDuyetHopDong.DataSource = table;
            cbbDuyetHopDong.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbDuyetHopDong.SelectedItem;
            id_hopdong = (String)row.Row["mahopdong"];

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec duyethopdong '" + id_nhanvien + "','" + id_hopdong + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thành công!!!");
            else
                MessageBox.Show("Thất bại !!!");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.id_nhanvien = id_nhanvien;
            form.Show();
            this.Close();
        }

    }
}