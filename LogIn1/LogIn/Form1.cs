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
namespace LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2015\Projects\LogIn1\DB\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select rol from Users Where username='" + textBox1.Text + "' and password = '" + textBox2.Text + "'", conn);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "medic")
            {
                this.Hide();
                medic med = new medic();
                med.Show();
                //MessageBox.Show("Your are logged in," + textBox1.Text+ "!");

            }
            else if (dt.Rows[0][0].ToString() == "personal")
            {
                this.Hide();
                Pag2 pers = new Pag2();
                pers.Show();
                //MessageBox.Show("Your are logged in," + textBox1.Text + "!");

            }
            else if (dt.Rows[0][0].ToString() == "donator")
            {
                this.Hide();
                //donator don = new donator();
                donatForm don = new donatForm();
                don.Show();
                //MessageBox.Show("Your are logged in," + textBox1.Text + "!");


            }
            else
                MessageBox.Show("Please enter correct username and password", "ErrorLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
