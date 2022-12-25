﻿using System;
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
            //connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=CSDLNC2;Integrated Security=True";
            //dataGridView1.AutoGenerateColumns = false;
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select top(50) MaDoiTac,TenDoiTac, RateTB from DoiTac", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbChiNhanh.ValueMember = "MaDoiTac";
            cbbChiNhanh.DisplayMember = "TenDoiTac";
            cbbChiNhanh.DataSource = table;
            cbbChiNhanh.SelectedIndex = -1;

            dataGridView1.DataSource = table;

        }

        private void btnTimKiemCuahang_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            DataRowView row = (DataRowView)cbbChiNhanh.SelectedItem;
            f.tenquan = (String)row.Row["TenDoiTac"];
            f.id_doitac = (String)row.Row["MaDoiTac"];
            f.id_khachhang = id_khachhang;
            f.Show();
            this.Close();
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