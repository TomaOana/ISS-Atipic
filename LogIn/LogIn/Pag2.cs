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
    public partial class Pag2 : Form
    {
        public Pag2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stoc ss = new Stoc();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDonatori list = new ListaDonatori();
            list.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cereri list = new Cereri();
            list.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donare list = new Donare();
            list.Show();
        }
    }
}
