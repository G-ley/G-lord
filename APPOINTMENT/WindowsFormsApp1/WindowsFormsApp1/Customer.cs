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

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        SqlDataReader dr;
        Form1 f = new Form1();
        public Customer(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from Customer", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(dr["id"], i, dr["Customer_name"], dr["Custome_id"], dr["Customer_phone"], "Edit", "Delete");

            }
            cn.Close();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void customer_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_phoneLabel_Click(object sender, EventArgs e)
        {

        }


        private void btn2_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer(this);
            f.ShowDialog();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
