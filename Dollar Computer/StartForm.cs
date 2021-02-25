using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Dollar_Computer
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Heading_Click(object sender, EventArgs e)
        { 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int A = random.Next(0, 255);
            int B = random.Next(0, 255);
            int C = random.Next(0, 255);
            int D = random.Next(0, 255);

            Heading.ForeColor = Color.FromArgb(A, B, C, D);
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.productinfo.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.select.Show();
            this.Hide();
            
        }
    }
}
