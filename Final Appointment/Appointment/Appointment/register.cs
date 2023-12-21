using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment
{
    public partial class register : Form
    {
        appointmentEntities db ;
        
        public register()
        {
            InitializeComponent();
            db = new appointmentEntities();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Users newUsers = new Users();
            newUsers. firstName = txtName.Text;
            newUsers. lastName = txtLname.Text;
            newUsers. UserAddress = txtAddress.Text;
            newUsers. UserPassword= txtpass.Text;
            newUsers. UserRole = cmbrole.SelectedItem.ToString();


            db.Users.Add(newUsers);
            db.SaveChanges();

            txtName.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtpass.Clear();
            MessageBox.Show("Registered!");

        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
