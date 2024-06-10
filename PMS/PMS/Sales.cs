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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dr;
        SqlDataReader read;


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                int sum = 0;

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);

                }
                txttotal.Text = sum.ToString();






            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                con.Open();
                cmd = new SqlCommand("Select * from Add_Medicine_table1 where Med_ID = '" + txtmedid.Text + "'", con);

                read = cmd.ExecuteReader();

                if (read.Read())
                {

                    //string pname;
                    //string pprice;
                    MessageBox.Show("Entered ID matched with your Data Record");
                    txtmedname.Text = read["Med_Name"].ToString();
                    txtprice.Text = read["Retail Price"].ToString();


                }
                else
                {
                    MessageBox.Show("No ID found");
                }
                con.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Home_Page();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
            con.Open();
            
            
            string id = txtmedid.Text;
            string name = txtmedname.Text;
            double price = double.Parse(txtprice.Text);
            double qty = double.Parse(txtquantity.Text);
            double tot = price * qty;
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Sales_table]([Med_ID],[Med_Name],[Price],[Quantity],[Total])VALUES('" +id+ "','" +name+ "','" +price+ "' , '" +qty+ "','" +tot+ "')", con);
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.Add(id, name, price, qty, tot);
            con.Close();




            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);

            }
            txttotal.Text = sum.ToString();
            

            txtmedid.Clear();
            txtmedname.Clear();
            txtquantity.Clear();
            txtprice.Clear();


        }

        private void txtpayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpayment_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           double total = double.Parse(txttotal.Text);
            double pay = double.Parse(txtbalance.Text);
            double bal = pay - total;
            txtpayment.Text = bal.ToString();
            MessageBox.Show("Completed..");

        }
    }
}