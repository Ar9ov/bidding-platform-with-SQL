using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text.Trim();
            string Password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            string connectionString = "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";

            
            string query = "SELECT UserId, FullName FROM [Users] WHERE Email = @Email AND PasswordHash = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;

                    connection.Open();

                    
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                           
                            int userId = dr.GetInt32(0);
                            string name = dr.GetString(1);

                            MessageBox.Show("Welcome " + name + " (User ID: " + userId + ")");

                            Form3 dash = new Form3(userId);
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanelForm ad = new AdminPanelForm();
            ad.Show();
        }
    }
        }
