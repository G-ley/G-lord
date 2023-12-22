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
    public partial class dashboard : Form
    {
        appointmentEntities db;
        public dashboard()
        {
            InitializeComponent();
            db = new appointmentEntities();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {

           dgv.DataSource = db.Dshboard.ToList();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            newcustomer nc = new newcustomer();
            nc.ShowDialog();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            lbl3.Text = DateTime.Now.Date.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
