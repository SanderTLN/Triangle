﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form2 : Form
    {
        private bool byHeight;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            if (txtH.TextLength > 0)
            {
                txtB.Enabled = false;
                txtC.Enabled = false;
                heightCheckbox.Enabled = true;
            }
            else
            {
                txtB.Enabled = true;
                txtC.Enabled = true;
                heightCheckbox.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHtext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}