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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source = DESKTOP-0TDOLMP; Initial Catalog = BTLCNPM; Integrated Security = True");
            con.Open();
            string tk = textBox1.Text;
            string mk = textBox2.Text;
            string sql = "select * from User1 where username = '" + tk + "' and password = '" + mk + "'";

            SqlCommand comm = new SqlCommand(sql, con);
            SqlDataReader dta = comm.ExecuteReader();
            if (dta.Read() == true)
            {
                Form2 ch = new Form2();
                ch.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
