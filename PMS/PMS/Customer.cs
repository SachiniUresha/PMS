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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Add_Customer_table where Telephone=@Telephone", con);
            cmd.Parameters.AddWithValue("@Telephone", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Add_Customer_table set [First Name]=@FirstName,[Last Name]=@LastName,[Gender]=@Gender,[Birthday]=@Birthday,[Address]=@Address,[E-mail]=@Email,[Prescription]=@Prescription where [Telephone]=@Telephone", con);
            cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Birthday", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Telephone", textBox5.Text);
            cmd.Parameters.AddWithValue("@Prescription", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Add_Customer_table]([First Name],[Last Name],[Gender],[Birthday],[Address],[E-mail],[Telephone],[Prescription])VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "' , '" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved... ");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Add_Customer_table where Telephone=@Telephone", con);
            cmd.Parameters.AddWithValue("@Telephone", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted...");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Home_Page();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}