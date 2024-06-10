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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet.Add_Supplier_table' table. You can move, or remove it, as needed.
            //this.add_Supplier_tableTableAdapter1.Fill(this.pMSDataSet.Add_Supplier_table);
            // TODO: This line of code loads data into the 'pMSDataSet1.Add_Supplier_table' table. You can move, or remove it, as needed.
            //this.add_Supplier_tableTableAdapter.Fill(this.pMSDataSet1.Add_Supplier_table);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Add_Supplier_table set  [Sup_Name]=@Sup_Name,[Sup_ID]=@Sup_ID,[Telephone]=@Telephone,[E-mail]=@Email,[Address]=@Address,[Other]=@Other where [Sup_ID]=@Sup_ID", con);
            cmd.Parameters.AddWithValue("@Sup_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sup_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Telephone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Other", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated...");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Add_Supplier_table where Sup_ID=@Sup_ID", con);
            cmd.Parameters.AddWithValue("@Sup_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Add_Supplier_table]([Sup_ID],[Sup_Name],[Telephone],[E-mail],[Address],[Other]) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved... ");
            con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Add_Supplier_table where Sup_ID=@Sup_ID", con);
            cmd.Parameters.AddWithValue("@Sup_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted...");

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Home_Page();
            frm.ShowDialog();
            
            
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}