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
    public partial class Login : Form
    {

           

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-OERP5KN4\\SQLEXPRESS;Initial Catalog=PMSDatabase;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Login_table where Username=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logged in Successfully...");
                    this.Hide();
                    Form frm = new Home_Page();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch 
            {

                MessageBox.Show("Error");

            }
            finally
            {
                
            }
        }


               
        private void Reg_button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new User_Registration();
            frm.ShowDialog();
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
