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
    public partial class ProductInfo : Form
    {


        public ProductInfo()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            //Show Dialog
            var save = saveFileDialog1.ShowDialog();

            if (save != DialogResult.Cancel)
            {
                StreamWriter streamwriter = new StreamWriter(saveFileDialog1.FileName);

                streamwriter.WriteLine(Program.cc._ID);
                streamwriter.WriteLine(Program.cc._Condition);
                streamwriter.WriteLine(Program.cc._cost);
                streamwriter.WriteLine(Program.cc._name);
                streamwriter.WriteLine(Program.cc._model);
                streamwriter.WriteLine(Program.cc._memory);
                streamwriter.WriteLine(Program.cc._cpubrand);
                streamwriter.WriteLine(Program.cc._cpuspeed);
                streamwriter.WriteLine(Program.cc._cpuspeed);

                streamwriter.Flush();
                streamwriter.Close();
                MessageBox.Show("File Saved !");

            }


        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            PtextBox.Text = Program.cc._ID;
            Ctextbox.Text = Program.cc._Condition;
            Costtextbox.Text = Program.cc._cost;
            Nametextbox.Text = Program.cc._name;
            Modeltextbox.Text = Program.cc._model;
            Memorytextbox.Text = Program.cc._memory;
            Cpubrandtextbox.Text = Program.cc._cpubrand;
            Cputypetextbox.Text = Program.cc._cputype;
            Cpuspeedtextbox.Text = Program.cc._cpuspeed;




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next2_Click(object sender, EventArgs e)
        {
            Program.bill.Show();
            this.Hide();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.select.Show();
            this.Hide();


        }

        private void readdata(StreamReader streamreader)
        {
            this.PtextBox.Text = streamreader.ReadLine();
            this.Ctextbox.Text = streamreader.ReadLine();
            this.Costtextbox.Text = streamreader.ReadLine();
            this.Nametextbox.Text= streamreader.ReadLine();
            this.Modeltextbox.Text= streamreader.ReadLine();
            this.Memorytextbox.Text= streamreader.ReadLine();
            this.Cpubrandtextbox.Text= streamreader.ReadLine();
            this.Cputypetextbox.Text = streamreader.ReadLine();
            this.Cpuspeedtextbox.Text = streamreader.ReadLine();
        }
            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //Configure
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

                //Show Dialog
                var open = openFileDialog1.ShowDialog();

                if (open != DialogResult.Cancel)
                {
                    StreamReader streamreader1 = new StreamReader(openFileDialog1.OpenFile());

                    readdata(streamreader1);


                    //Clean up
                    streamreader1.Close();



                }
            }

        private void Cpuspeedtextbox_Leave(object sender, EventArgs e)
        {
            if(Cpuspeedtextbox.TextLength>2)
            {
                Next2.Enabled = true;
                Next2.Focus();

            }
        }
    }

    }


