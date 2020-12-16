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
using System.Configuration;
using System.Data.Common;


namespace SQL_Project
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }
        private Int32 checkuser(string u, string p)
        {
            string connectionString = "Data Source=DESKTOP-A58D4M4; Initial Catalog = SQL_Project; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Login", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = u;
                cmd.Parameters.AddWithValue("@password", SqlDbType.NChar).Value = p;
                SqlParameter p1 = new SqlParameter("ret", SqlDbType.Int);
                p1.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();
                Int32 k;
                k = Convert.ToInt32(cmd.Parameters["ret"].Value);
                cmd.Dispose();
                return k;
            }
        }
        private Int32 checkrUsername(string u)
        {
            string connectionString = "Data Source=DESKTOP-A58D4M4; Initial Catalog = SQL_Project; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Register", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = u;
                SqlParameter p1 = new SqlParameter("ret", SqlDbType.Int);
                p1.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();
                Int32 k;
                k = Convert.ToInt32(cmd.Parameters["ret"].Value);
                cmd.Dispose();
                return k;
            }
        }
        private void button_login(object sender, EventArgs e)
        {
            Int32 r = checkuser(user_name.Text, user_password.Text);
            if (r == -1)
            {
                MessageBox.Show("Incorrect Username!"); 
            }
            else if (r == -2)
            {
                MessageBox.Show("Incorrect Password!");
            }
            else if (r == 1)
            {
                this.Hide();
                MainApp myNewForm = new MainApp();
                myNewForm.Show();
            }
            else
            {
                r = 0;
                MessageBox.Show("Incorrect Username or Password!");
            }
        }
        private void button_register(object sender, EventArgs e)
        {
            Int32 k = checkrUsername(user_name.Text);
            if (k == 0)
            {
                string connectionString = "Data Source=DESKTOP-A58D4M4; Initial Catalog = SQL_Project; Integrated Security = True;";
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("AddUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = user_name.Text.Trim();
                    cmd.Parameters.AddWithValue("@password", SqlDbType.NChar).Value = user_password.Text.Trim();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfully!");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("User already exists!");
            }
        }
        private void check_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpassword.Checked == true)
            {
                user_password.UseSystemPasswordChar = false;
            }
            else
            {
                user_password.UseSystemPasswordChar = true;
            }
        }
    }
}
