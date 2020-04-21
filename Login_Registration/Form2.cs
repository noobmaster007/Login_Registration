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
/*https://www.youtube.com/watch?v=hxOB5ALWQMQ&t=726s*/

namespace Login_Registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsername.Text))
            {
                MessageBox.Show("Provide your Username!");
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Provide your Password!");
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SR02AGC\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True");
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            SqlCommand cmd = new SqlCommand("select Username, Password from tblUser where Username='"+txtUsername.Text.Trim()+"' and Password='"+txtPassword.Text.Trim()+"'",conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("*** LOGIN SUCCESSFUL ***");
                MainForm mfrm = new MainForm();
                mfrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password is incorrect!");

            }
        }
    }
}
