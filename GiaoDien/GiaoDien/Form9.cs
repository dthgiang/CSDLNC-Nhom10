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
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //this.Close();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
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
            form.Show();
        }

        private void quảnLíCNoolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
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

            

            connection.Close();
        }
    }
}
