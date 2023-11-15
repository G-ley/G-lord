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

namespace Login
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-35LOQP5\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Enter the username");
            }
            else if (txt2.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-35LOQP5\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("SELECT * FROM log_in WHERE username =@username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", txt1.Text);
                    cmd.Parameters.AddWithValue("@password", txt2.Text);
                    SqlDataAdapter da = SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("login successfull");
                    }
                    else
                    {
                        MessageBox.Show("username or password is invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {
           
        }

        private SqlDataAdapter SqlDataAdapter(SqlCommand cmd)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt1.Clear(); // Clear the username textbox
            txt2.Clear(); // Clear the password textbox
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("path_to_your_transparent_image.png");
        }
    }
}
