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
    public partial class Form3 : Form
    {
        int userId;
        int orderId;
        public Form3(int uid)
        {
            InitializeComponent();
            userId = uid;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CheckPendingOrders();

        }
        private void CheckPendingOrders()
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                string q = @"
                    SELECT TOP 1 O.OrderID
                    FROM Orders O
                    LEFT JOIN Payments P ON O.OrderID = P.OrderID
                    WHERE O.BuyerID = @uid
                    AND P.OrderID IS NULL";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                object result = cmd.ExecuteScalar();

               
                if (result != null)
                {
                    button4.Enabled = true;
                    orderId = Convert.ToInt32(result); 
                }
                else
                {
                    button4.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SellItemForm(userId).Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BrowseAucForm(userId).Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MyBidsForm(userId).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                string q = @"
        SELECT TOP 1 O.OrderID
        FROM Orders O
        LEFT JOIN Payments P ON O.OrderID = P.OrderID
        WHERE O.BuyerID = @uid
        AND P.OrderID IS NULL";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show(
                        "You have no pending payments.\n" +
                        "Checkout will be available only if you win an auction.",
                        "No Orders",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                int orderId = Convert.ToInt32(result);
                new CheckoutForm(orderId, userId).ShowDialog();
            }
        }
    }
}
