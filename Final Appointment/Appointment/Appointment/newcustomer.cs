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
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        public newcustomer()
        {
            InitializeComponent();
        }

        private void newcustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into dashboard (ClientName, UserId, UserPhone) values (@ClientName, @UserId, @UserPhone)", cn);
            cm.Parameters.AddWithValue("@ClientName", TxtName.Text);
            cm.Parameters.AddWithValue("@UserId", TxtId.Text);
            cm.Parameters.AddWithValue("@userPhone", Txtphone.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            MessageBox.Show("Record has been saved successfully");
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
