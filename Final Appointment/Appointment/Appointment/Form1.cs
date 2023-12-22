using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment;

namespace Appointment
{
    public partial class Form1 : Form
    {
        appointmentEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new appointmentEntities();
        }

        private void customer_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        { 
            register reg = new register();
            reg.ShowDialog();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        { 
            string username = TxtName.Text;
            string password = TxtPass.Text;

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.UserPassword == password);
            Users newUserAccount = new Users();
            db.Users.GetType();
            if (user != null)
            {
                MessageBox.Show("Login successful!");

                switch (user.UserRole)
                {
                    case "Client":
                        Client frmclient = new Client();
                        frmclient.Show();
                        this.Hide();
                        break;
                    case "Seller":
                        Seller frmSeller = new Seller();
                        frmSeller.Show();
                        this.Hide();
                        break;
                    case "Admin":
                        Admin frmadmin   = new Admin ();   
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("User has no role!");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.");
            }
            dashboard dh = new dashboard();
            dh.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
