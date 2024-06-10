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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Add_Medicine_table1]([Med_ID],[Med_Name],[Sup_ID],[Quantity],[Unit],[Expire Date],[Purchase Price],[Retail Price],[Description])VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved... ");
            
            
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Add_Medicine_table1 set  [Med_Name]=@Med_Name,[Sup_ID]=@Sup_ID,[Quantity]=@Quantity,[Unit]=@Unit,[Expire Date]=@ExpireDate,[Purchase Price]=@PurchasePrice,[Retail Price]=@RetailPrice,[Description]=@Description where [Med_ID]=@Med_ID", con);
            cmd.Parameters.AddWithValue("@Med_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Med_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Sup_ID", textBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Unit", textBox5.Text);
            cmd.Parameters.AddWithValue("@ExpireDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@PurchasePrice", textBox6.Text);
            cmd.Parameters.AddWithValue("@RetailPrice", textBox8.Text);
            cmd.Parameters.AddWithValue("@Description", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated...");
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Add_Medicine_table1 where Med_ID=@Med_ID", con);
            cmd.Parameters.AddWithValue("@Med_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted...");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Add_Medicine_table1 where Med_ID=@Med_ID", con);
            cmd.Parameters.AddWithValue("@Med_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet2.Add_Medicine_table1' table. You can move, or remove it, as needed.
            //this.add_Medicine_table1TableAdapter1.Fill(this.pMSDataSet2.Add_Medicine_table1);
            // TODO: This line of code loads data into the 'pMSDataSet.Add_Medicine_table1' table. You can move, or remove it, as needed.
            //this.add_Medicine_table1TableAdapter.Fill(this.pMSDataSet.Add_Medicine_table1);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Expire_Date_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Price_Click(object sender, EventArgs e)
        {

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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            dateTimePicker2.Text = "";
        }
    }
}