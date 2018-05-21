﻿using System;
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
    public partial class SatusCereri : Form
    {
        public SatusCereri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SatusCereri_Load(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Cerere", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            medic m = new medic();
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
