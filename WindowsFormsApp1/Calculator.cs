﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcul_Load(object sender, EventArgs e)
        {
            cmbAct.Items.Add("+");
            cmbAct.Items.Add("-");
            cmbAct.Items.Add("*");  
            cmbAct.Items.Add("/");

            cmbAct.Text = "+";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double ch1, ch2;
            if (txtCh1.Text == "") ch1 = 0; ch1 = double.Parse(txtCh1.Text);
            if (txtCh2.Text == "") ch2 = 0; else ch2 = Convert.ToDouble(txtCh2.Text);

            if(cmbAct.SelectedIndex ==0)
                txtRez.Text = (ch1+ch2).ToString();
            else if(cmbAct.SelectedIndex ==1) 
                txtRez.Text = (ch1-ch2).ToString();
            else if (cmbAct.SelectedIndex ==2)
                txtRez.Text = (ch1*ch2).ToString();
            else if (cmbAct.SelectedIndex ==3)
                txtRez.Text = (ch1/ch2).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
