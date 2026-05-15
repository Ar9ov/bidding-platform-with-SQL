using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet.UserRoles' table. You can move, or remove it, as needed.
            this.userRolesTableAdapter.Fill(this.t3DataSet.UserRoles);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =
       "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";

            string FullName = textBox1.Text.Trim();
            string Email = textBox2.Text.Trim();
            string Phone = textBox3.Text.Trim();
            string PasswordHash = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(PasswordHash))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!long.TryParse(Phone, out _))
            {
                MessageBox.Show("Phone must be numeric.");
                return;
            }

            string query =
                "INSERT INTO [Users] (FullName, Email, Phone, PasswordHash) " +
                "VALUES (@FullName, @Email, @Phone, @PasswordHash)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FullName", System.Data.SqlDbType.VarChar).Value = FullName;
                    command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@Phone", System.Data.SqlDbType.VarChar).Value = Phone;
                    command.Parameters.Add("@PasswordHash", System.Data.SqlDbType.VarChar).Value = PasswordHash;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile created successfully!");
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        MessageBox.Show("Insert failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}