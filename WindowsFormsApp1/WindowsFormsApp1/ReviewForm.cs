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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class ReviewForm : Form
    {
        int orderId;
        int userId;
        public ReviewForm(int oid, int uid)
        {
            InitializeComponent();
            orderId = oid;
            userId = uid;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet14.Reviews' table. You can move, or remove it, as needed.
            this.reviewsTableAdapter.Fill(this.t3DataSet14.Reviews);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Reviews (OrderID, ReviewID, Rating, Comment)
                    VALUES (@o, @u, @r, @c)", con);

                cmd.Parameters.AddWithValue("@o", orderId);
                cmd.Parameters.AddWithValue("@u", userId);
                //cmd.Parameters.AddWithValue("@r", comboBox1.Value);
                cmd.Parameters.AddWithValue("@c", textBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Review submitted");
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

