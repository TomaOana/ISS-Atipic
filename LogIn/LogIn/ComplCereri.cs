using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogIn
{
    public partial class ComplCereri : Form
    {
        public ComplCereri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string card = textBox3.Text;
            string tip_sange = textBox4.Text;
            string cantitate = textBox5.Text;
            string grupa = textBox6.Text;
            string id_medic = textBox7.Text;
            string grad_urgenta = textBox8.Text;
            string rh = textBox9.Text;
            string locatie = textBox10.Text;

            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30"); 
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Cerere(Tip_Sange, Cantitate, Grupa, RH, Nume_Pacient, Prenume_Pacient, Nr_Card_sanatate, id_medic, Grad_Urgenta, LocatiaSpital) VALUES('" + tip_sange + "', '" + Int32.Parse(cantitate) + "', '" + grupa + "', '" + rh + "', '" + nume + "', '" + prenume + "', '" + card + "', '" + Int32.Parse(id_medic) + "', '" + grad_urgenta + "', '" + locatie + "')";
            cmd.Connection = cs;

            cs.Open();
            cmd.ExecuteNonQuery();
            cs.Close();

            MessageBox.Show("Cererea a fost trimisa!", "Cerere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            medic m = new medic();
            m.Show();
        }
    }
}
