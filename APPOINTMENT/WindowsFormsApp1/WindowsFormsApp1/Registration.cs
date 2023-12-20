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

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void customer_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-35LOQP5/SQLEXPRESS;Initial Catalog=register;Integrated Security=True";
            string user = first_name.Text;
            string pass = Password.Text;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "INSERT INTO UserAccount (ID,pass) VALUES ('" + user + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in form = new Log_in();
            form.Show();
            this.Hide();
        }
    }
}
