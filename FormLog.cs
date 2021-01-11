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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
           
            string username1 = "client";
            string password1 = "client";
            

            if ((txtusername.Text == username) && (txtpassword.Text == password))
           
            {

                this.Hide();
                FormData ss = new FormData();

                ss.Show();

            }

            else if ((txtusername.Text == username1) && (txtpassword.Text == password1))
            
            {

                this.Hide();
                FormData ss = new FormData();

                ss.Show();
            }
            else

                MessageBox.Show("Please Select Valid user type, Username or Password ");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();

            ss.Show();
        }
    }
}
