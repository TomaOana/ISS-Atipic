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
    public partial class vizAnalize : Form
    {
        public vizAnalize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT data_donarii,rezultat,grupa,Rh FROM donare WHERE id_donator = '" + textBox1.Text + "'", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

            DataSet dt1 = new DataSet();
            SqlConnection cs1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = new SqlCommand("SELECT DATEADD(day,180,MAX(data_donarii)) AS 'DataUrmatDonare' FROM donare WHERE id_donator = '" + textBox1.Text + "'", cs);
            dt1.Clear();
            da1.Fill(dt1);
            //dataGridView2.Columns[0].HeaderCell.Value = "DataUrmatoareiDonari";
            dataGridView2.DataSource = dt1.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            donatForm d = new donatForm();
            d.Show();
        }
    }
}
