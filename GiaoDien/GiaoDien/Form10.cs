﻿using System;
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
        public Form10()
        {
            InitializeComponent();
        }

        public Form10(String madoitac)
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();



            connection.Close();
        }
    }
}
