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
    public partial class Cereri : Form
    {
        public Cereri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataSet dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere", cs);
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

        private void Cereri_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            DataSet dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere<>'acceptat' OR Status_cerere IS NULL) AND Grad_Urgenta = 'ridicat'", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere <> 'acceptat'  OR Status_cerere IS NULL) AND Grad_Urgenta = 'mediu'", cs);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere <> 'acceptat' OR Status_cerere IS NULL) AND Grad_Urgenta = 'scazut'", cs);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string index = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string tip_sange = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string cantitate = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                int cant = Int32.Parse(cantitate);
                string grupa = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string rh = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
                DataTable dt = new DataTable();
                SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT count(*) FROM Stoc WHERE Grupa='" + grupa + "' AND Rh='" + rh + "' AND " + tip_sange + ">=" + cantitate, cs);
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() != "0")
                {
                    //Console.WriteLine("UPDATE Stoc SET " + tip_sange + "=" + tip_sange + "-" + cantitate + " WHERE Grupa=" + grupa + " AND Rh=" + rh);
                    da.SelectCommand = new SqlCommand("UPDATE Stoc SET " + tip_sange + "=" + tip_sange + "-" + cantitate + " WHERE Grupa='" + grupa + "'" + " AND Rh='" + rh + "'", cs);
                    da.Fill(dt);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    da.SelectCommand = new SqlCommand("DELETE FROM Cerere WHERE Id='" + index + "'", cs);
                    da.Fill(dt);
                }
                else
                {
                    //Console.WriteLine("nici aici");
                    //MessageBox.Show("Stoc insuficient pentru aceasta componenta de sange.", "Stoc insuficient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Stoc insuficient. Lista posibili donatori", "Stoc insuficient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DataSet dd = new DataSet();
                    da.SelectCommand = new SqlCommand("SELECT Nr_card_sanatate, Nume, Prenume, Email, Telefon FROM Donator WHERE Nr_card_sanatate IN (SELECT id_donator FROM donare WHERE grupa='" + grupa + "'" + " AND Rh='" + rh + "') AND DATEDIFF(day,Data_ultimaDonare,SYSDATETIME()) > 180", cs);
                    da.Fill(dd);
                    dataGridView1.Hide();
                    dataGridView2.Show();
                    dataGridView2.DataSource = dd.Tables[0];

                }
            }
            else
                MessageBox.Show("Nu ati selectat nici o cerere!", "Notificari", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                MessageBox.Show("Donator notificat!", "Notificari", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView2.SelectedRows[0].DefaultCellStyle.BackColor = Color.Green;
            }
            else
                MessageBox.Show("Nu ati selectat nici un donator!", "Notificari", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dataGridView2.Hide();
            DataSet dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere<>'acceptat' OR Status_cerere IS NULL) AND Grad_Urgenta = 'ridicat'", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere <> 'acceptat'  OR Status_cerere IS NULL) AND Grad_Urgenta = 'mediu'", cs);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere WHERE (Status_cerere <> 'acceptat' OR Status_cerere IS NULL) AND Grad_Urgenta = 'scazut'", cs);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
