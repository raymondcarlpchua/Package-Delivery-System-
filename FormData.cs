using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinalProj
{
    public partial class FormData : Form
    {
        private DELIVERYDBEntities DELIVERYDB;
        public FormData()
        {
            InitializeComponent();
            DELIVERYDB = new DELIVERYDBEntities();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //VIEW ALL PACKAGE INFORMATION
            dataGridView1.DataSource = DELIVERYDB.SearchAllPackageInformation().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
            //SEARCH PACKAGE INFO
        {
            
           
            dataGridView1.DataSource = DELIVERYDB.SearchPackageInformationByRName(txtrecieve.Text).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //UPDATE INFO
           //MessageBox.Show("ID = " + selectedID);
           //new UpdateInformationForm(selectedID).Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //SEARCH by SNAME
            dataGridView1.DataSource = DELIVERYDB.SearchPackageInformationBySName2(txtsender.Text).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // SEARCH BY ID
            
            //dataGridView1.DataSource = DELIVERYDB.SearchPackageInformationByID(txtsender.Text).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddPackageInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtpak_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
