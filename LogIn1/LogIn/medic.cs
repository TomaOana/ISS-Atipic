﻿using System;
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
    public partial class medic : Form
    {
        public medic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplCereri cc = new ComplCereri();
            cc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SatusCereri sc = new SatusCereri();
            sc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StocMedic sm = new StocMedic();
            sm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void medic_Load(object sender, EventArgs e)
        {

        }
    }
}
