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
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source = DESKTOP-0TDOLMP; Initial Catalog = BTLCNPM; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from medicalinformation1";
            adapter.SelectCommand = command;
            SqlDataReader da = command.ExecuteReader();
                while (da.Read())
            {
                textBox1.Text= da.GetValue(1).ToString();
                textBox2.Text = da.GetValue(0).ToString();
                textBox3.Text = da.GetValue(2).ToString();
                textBox4.Text = da.GetValue(9).ToString();
                textBox5.Text = da.GetValue(7).ToString();
                textBox6.Text = da.GetValue(6).ToString();
                if(da.GetValue(4).ToString() == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }             
                textBox8.Text = da.GetValue(5).ToString();
                textBox9.Text = da.GetValue(10).ToString();
                textBox10.Text = da.GetValue(3).ToString();
                textBox11.Text = da.GetValue(8).ToString();
                textBox12.Text = da.GetValue(11).ToString();
            }
        }
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
