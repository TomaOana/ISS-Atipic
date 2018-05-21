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
    public partial class donator : Form
    {
        public donator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void donator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string datanasterii = textBox3.Text;
            string domiciliu = textBox6.Text;
            string localitate = textBox7.Text;
            string judet = textBox8.Text;
            string resedinta = textBox9.Text;
            string localitate2 = textBox10.Text;
            string judet2 = textBox11.Text;
            string email = textBox12.Text;
            string telefon = textBox13.Text;
            string cardsanatate = textBox4.Text;
            string persDon = textBox5.Text;

            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            if (persDon == "")
                cmd.CommandText = "INSERT INTO Donator(Nr_card_sanatate,Nume, Prenume, Data_nasterii, Domiciliu, Localitate, Judet, Resedinta, LocalitateR, JudetR, Email, Telefon) VALUES('" + cardsanatate + "','" + nume + "', '" + prenume + "', '" + datanasterii + "', '" + domiciliu + "', '" + localitate + "', '" + judet + "', '" + resedinta + "', '" + localitate2 + "', '" + judet2 + "', '" + email + "', '" + telefon + "')";
            else
                cmd.CommandText = "INSERT INTO Donator(Nr_card_sanatate,Nume, Prenume, Data_nasterii, Domiciliu, Localitate, Judet, Resedinta, LocalitateR, JudetR, Email, Telefon,Pers_pt_care_doneaza) VALUES('" + cardsanatate + "','" + nume + "', '" + prenume + "', '" + datanasterii + "', '" + domiciliu + "', '" + localitate + "', '" + judet + "', '" + resedinta + "', '" + localitate2 + "', '" + judet2 + "', '" + email + "', '" + telefon + "','" + persDon + "')";
            cmd.Connection = cs;

            cs.Open();
            cmd.ExecuteNonQuery();
            cs.Close();

            SqlConnection cs2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2015\Projects\LogIn1\DB\login.mdf;Integrated Security=True;Connect Timeout=30");
            System.Data.SqlClient.SqlCommand cmd2 = new System.Data.SqlClient.SqlCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "INSERT INTO Users(nume, username, password, rol) VALUES('" + nume + "', '" + nume + "', '" + prenume + "', '" + "donator" + "')";
            
            cmd2.Connection = cs2;
            cs2.Open();
            cmd2.ExecuteNonQuery();
            cs2.Close();

            SqlConnection cs3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            System.Data.SqlClient.SqlCommand cmd3 = new System.Data.SqlClient.SqlCommand();
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.CommandText = "INSERT INTO donare(id_donator) VALUES('" + cardsanatate + "')";

            cmd3.Connection = cs3;
            cs3.Open();
            cmd3.ExecuteNonQuery();
            cs3.Close();


            MessageBox.Show("Cererea a fost trimisa!", "Cerere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            donatForm d = new donatForm();
            d.Show();
        }
    }
}
