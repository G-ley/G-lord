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
using System.IO;

namespace Appointment
{
    public partial class newcustomer : Form
    {
        appointmentEntities db;
        public newcustomer()
        {
            InitializeComponent();
            db = new appointmentEntities();
           
        }

        private void newcustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Dshboard newDshboard = new Dshboard();
            newDshboard.ClientId = TxtId.Text;
            newDshboard.ClientName = TxtName.Text;
            newDshboard.ClientPhone = Txtphone.Text;
           
            db.Dshboard.Add(newDshboard);
            db.SaveChanges();


            TxtId.Clear();
            TxtName.Clear();
            Txtphone.Clear();
            MessageBox.Show("you have been successfully set a appointment!");

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
