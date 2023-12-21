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

namespace Appointment
{
    public partial class dashboard : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        SqlDataReader dr;
        public dashboard()
        {
            InitializeComponent();
            LoadCustomer();
        }
        void LoadCustomer()
        {
            int i = 0;
            cn.Open();
            cm = new SqlCommand("Select * from patient", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv.Rows.Add(dr["id"], i, dr["ClientName"], i, dr["UserId"], i, dr["UserPhone"], i, dr["UserAppointment"], "Edit", "Delete");

            }
            cn.Close();
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
    }
}
