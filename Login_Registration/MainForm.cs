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

namespace Login_Registration
{
    public partial class MainForm : Form
    {
        string ConnectionString = @"Data Source=DESKTOP-SR02AGC\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_FeedSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UserFeed", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Feedback", txtFeed.Text.Trim());
                cmd.BeginExecuteNonQuery();

                MessageBox.Show("FEEDBACK SUBMITTED!");
                //clear();
                Form2 loginfrm = new Form2();
                loginfrm.Show();
                this.Hide();
            }

        }
        void clear()
        {
            txtFeed.Text = "";
        }
    }
}
