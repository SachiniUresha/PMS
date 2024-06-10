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

namespace PMS
{
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Login_table]([First name],[Last name],[Birthday],[NIC],[Address],[Telephone number],[Position],[Username],[Password])VALUES('" + textBox1.Text + "','" + textBox2.Text + "','"  + dateTimePicker1.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text +"','" + comboBox1.SelectedItem.ToString() + "','" + textBox6.Text + "','" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Registered... ");
            this.Hide();
            Form frm = new Login();
            frm.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Login();
            frm.ShowDialog();
        }
    }
}
