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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-35LOQP5\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

        
        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (name.Text != "G-ley")
            {

                string user = name.Text;
                string pass = password.Text;
                string conn = "Data Source=DESKTOP-35LOQP5/SQLEXPRESS;Initial Catalog=register;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From UserAccount Where ID = @firstname and pass = @pass", con);
                cmd.Parameters.AddWithValue("@firstname", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome To G-ley appointment " + name.Text);


                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");



                }
                con.Open();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
