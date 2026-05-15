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
    public partial class CheckoutForm : Form
    {
        int orderId;
        int userId;
        decimal finalPrice;

        public CheckoutForm(int oid, int uid)
        {
            InitializeComponent();
            orderId = oid;
            userId = uid;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet13.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter1.Fill(this.t3DataSet13.Payments);
            // TODO: This line of code loads data into the 't3DataSet12.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.t3DataSet12.Payments);
            LoadOrder();
        }
        private void LoadOrder()
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                string q = @"
        SELECT O.FinalPrice, I.Title
        FROM Orders O
        JOIN Auctions A ON O.AuctionID = A.AuctionID
        JOIN Items I ON A.ItemID = I.ItemID
        WHERE O.OrderID=@oid AND O.BuyerID=@uid";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@oid", orderId);
                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    label2.Text = dr["Title"].ToString();
                    finalPrice = Convert.ToDecimal(dr["FinalPrice"]);
                    label4.Text = finalPrice.ToString("0.00");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select payment method");
                return;
            }

            using (SqlConnection con = DbHelper.GetConnection())
            {
                con.Open();

                // Insert Payment
                SqlCommand payCmd = new SqlCommand(@"
            INSERT INTO Payments (OrderID, PaymentMethod, Amount)
            VALUES (@oid, @method, @amount)", con);

                payCmd.Parameters.AddWithValue("@oid", orderId);
                payCmd.Parameters.AddWithValue("@method", comboBox1.Text);
                payCmd.Parameters.AddWithValue("@amount", finalPrice);
                payCmd.ExecuteNonQuery();

                // ✅ UPDATE ORDER STATUS
                SqlCommand orderCmd = new SqlCommand(@"
            UPDATE Orders
            SET PaymentStatus='Paid'
            WHERE OrderID=@oid", con);

                orderCmd.Parameters.AddWithValue("@oid", orderId);
                orderCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Payment Successful");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

