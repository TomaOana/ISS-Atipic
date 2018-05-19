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
    public partial class Donare : Form
    {
        SqlDataAdapter da;
        DataSet dt;

        public Donare()
        {
            InitializeComponent();
        }

        private void Donare_Load(object sender, EventArgs e)
        {
            dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM donare", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdbl = new SqlCommandBuilder(da);
            da.Update(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pag2 ss = new Pag2();
            ss.Show();
        }
    }
}
