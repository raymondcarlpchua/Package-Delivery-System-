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
    public partial class AddPackageInformation : Form
    {
        DELIVERYDBEntities2 db1;
        DELIVERYDBEntities3 db3;
        private int packid;
    
     public AddPackageInformation()
        {
            InitializeComponent();
            db1 = new DELIVERYDBEntities2();
            db3 = new DELIVERYDBEntities3();
            
        }
        public AddPackageInformation(int id)
        {
            /*InitializeComponent();
            db1 = new DELIVERYDBEntities2();
            initStatus();
            initDelivery();
            txtid.Text = id.ToString();
            packid = id;*/

            
          
        }
        private void initCourses()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int del, sta, id;
            int.TryParse(txtid.Text.ToString(), out id);
            int.TryParse(cbodelivery.SelectedValue.ToString(), out del);
            int.TryParse(cbostatus.SelectedValue.ToString(), out sta);
            db3.InsertPackageInformation(id, txtsname.Text, txtsaddress.Text, txtcontact.Text, txtrname.Text, txtraddress.Text, txtrcontact.Text, del, sta);

            MessageBox.Show("Successfull Added!", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
