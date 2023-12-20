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
    public partial class AddCustomer : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Form f = new Form1();

        public AddCustomer(Customer f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into Customer (Customer_name,Customer_id,Customer_phone) values(@Customer_name,@Customer_id,@Customer_phone)", cn);
            cm.Parameters.AddWithValue("@Customer_name", TxtName.Text);
            cm.Parameters.AddWithValue("@Customer_id", Txtid.Text);
            cm.Parameters.AddWithValue("@Customer_phonne", TxtPhone);
            cm.ExecuteNonQuery();
            cn.Close();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            //f.LoadCustomer();

            MessageBox.Show("Record has been saved successfully");
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {

        }
    }
}
