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
    public partial class ListaDonatori : Form
    {
        SqlDataAdapter da;
        DataSet dt;

        public ListaDonatori()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                /*DataSet dt = new DataSet();
                SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT Id,Nr_card_sanatate,Nume,Prenume,Data_nasterii,Domiciliu,Localitate,Judet,Resedinta,LocalitateR,JudetR,Email,Telefon,Data_ultimaDonare FROM Donator", cs);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];*/
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pag2 ss = new Pag2();
            ss.Show();
        }

        private void ListaDonatori_Load(object sender, EventArgs e)
        {
            dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Id,Nr_card_sanatate,Nume,Prenume,Data_nasterii,Domiciliu,Localitate,Judet,Resedinta,LocalitateR,JudetR,Email,Telefon,Data_ultimaDonare,Pers_pt_care_doneaza FROM Donator", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            //SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
            //da.Update(dt);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
