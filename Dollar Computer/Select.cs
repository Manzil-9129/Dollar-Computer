using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dollar_Computer
{
    public partial class Select : Form
    {   
        
        public Select()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Select_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'laptopDataDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.laptopDataDataSet.Table);

          
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            setdata();

            Program.productinfo.Show();
           
            this.Hide();


        }

        private void setdata()
        {
            Program.cc._ID = LaptopdataGridview.CurrentRow.Cells[0].Value.ToString();
            Program.cc._name= LaptopdataGridview.CurrentRow.Cells[1].Value.ToString();
            Program.cc._model= LaptopdataGridview.CurrentRow.Cells[2].Value.ToString();
            Program.cc._cost= LaptopdataGridview.CurrentRow.Cells[3].Value.ToString();
            Program.cc._memory= LaptopdataGridview.CurrentRow.Cells[4].Value.ToString();
            Program.cc._cpubrand= LaptopdataGridview.CurrentRow.Cells[5].Value.ToString();
            Program.cc._cputype= LaptopdataGridview.CurrentRow.Cells[6].Value.ToString();
            Program.cc._cpuspeed= LaptopdataGridview.CurrentRow.Cells[7].Value.ToString();
            Program.cc._Condition= LaptopdataGridview.CurrentRow.Cells[8].Value.ToString();
        }
        private void HL_Click(object sender, EventArgs e)
        {

        }

        private void LaptopdataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductInfo product = new ProductInfo();
            var name = LaptopdataGridview.CurrentRow.Cells[1].Value;
            var model = LaptopdataGridview.CurrentRow.Cells[2].Value;
            var cost = LaptopdataGridview.CurrentRow.Cells[3].Value;


            
            
            Selectedtextbox.Text = name + "," + model +","+"priced at :" + cost;

        }     
           



                    

        
    }
}
