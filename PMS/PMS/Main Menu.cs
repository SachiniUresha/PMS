using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMS
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

       

        private void Sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Sales();
            frm.ShowDialog();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Customer();
            frm.ShowDialog();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Supplier();
            frm.ShowDialog();

        }

        private void Medicine_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Medicine();
            frm.ShowDialog();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ss = new Welcome();
            ss.Show();
        }

        private void medicine_pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
