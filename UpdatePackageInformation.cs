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
    public partial class UpdatePackageInformation : Form
    {
        public UpdatePackageInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE 
            int course, yrLevel, id;
            int.TryParse(cboCourse.SelectedValue.ToString(), out course);

            int.TryParse(txtYearLevel.Text, out yrLevel);
            db1.UpdateStudent(txtlname.Text, txtfname.Text, course, yrLevel, txtGender.Text, selectedID);
            MessageBox.Show("Changes successfully saved!");

        }
    }
}
