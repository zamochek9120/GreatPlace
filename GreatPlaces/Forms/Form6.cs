﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GreatPlaces
{
    public partial class Form6 : Form
    { 
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "Select";
        }
    }
}
