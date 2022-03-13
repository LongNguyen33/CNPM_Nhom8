using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM
{
    public partial class Form5 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source = DESKTOP-0TDOLMP; Initial Catalog = BTLCNPM; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from notification1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        void timkiem()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from notification1 where title like N'%" + textBox1.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            label2.Visible = true;
            int i = dataGridView1.CurrentRow.Index;
            groupBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            label2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            timkiem();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
