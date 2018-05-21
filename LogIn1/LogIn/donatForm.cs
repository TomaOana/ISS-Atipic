using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class donatForm : Form
    {
        public donatForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            donator don = new donator();
            don.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vizAnalize an = new vizAnalize();
            an.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void donatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
