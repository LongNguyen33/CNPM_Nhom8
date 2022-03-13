using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgr f = new backgr();
            AddForm(f);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            backgr f = new backgr();
            AddForm(f);
        }

        private void thôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            AddForm(f);
        }

        private void thôngTinYTếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            AddForm(f);
        }

        private void khaiBáoYTếToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            AddForm(f);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
