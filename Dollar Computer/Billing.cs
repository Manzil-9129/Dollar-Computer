using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Dollar_Computer
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {   //Variables

            textBox1.Text = Program.cc._name;
            textBox2.Text = Program.cc._model;
            textBox3.Text = Program.cc._cost;
            
            double tx = Convert.ToDouble(textBox3.Text);
            const double taxxx = 0.05;
            double ee =(tx) * (taxxx);
            textBox5.Text = Convert.ToString((tx + ee));
            string tx4 = Convert.ToString(ee);
            textBox4.Text = tx4;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.select.Show();
            this.Hide();
        }
        

        private void Billing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
