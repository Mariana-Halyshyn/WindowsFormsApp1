using System;
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
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator f1 = new Calculator();
            f1.ShowDialog();
        }

        private void myBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void акарологіяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            akarologia f1 = new akarologia();   
            f1.ShowDialog();
        }

        private void дослідженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doslidjennia f1 = new doslidjennia();
            f1.ShowDialog();
        }

        private void дослідникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doslidnuk f1 = new doslidnuk();
            f1.ShowDialog();
        }
    }
}
