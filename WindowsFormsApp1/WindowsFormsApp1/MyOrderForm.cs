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
    public partial class MyOrderForm : Form
    {
        int userId;

        public MyOrderForm(int uid)
        {
            InitializeComponent();
            userId = uid;
        }
        private void MyOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                string q = @"
                SELECT O.OrderID, I.Title, O.FinalPrice,
                       ISNULL(P.PaymentStatus, 'Unpaid') AS Status
                FROM Orders O
                JOIN Auctions A ON O.AuctionID = A.AuctionID
                JOIN Items I ON A.ItemID = I.ItemID
                LEFT JOIN Payments P ON O.OrderID = P.OrderID
                WHERE O.BuyerID = @uid";

                SqlDataAdapter da = new SqlDataAdapter(q, con);
                da.SelectCommand.Parameters.AddWithValue("@uid", userId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrders.DataSource = dt;
            }
        }
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(dgvOrders.CurrentRow == null) return;

            string status = dgvOrders.CurrentRow.Cells["Status"].Value.ToString();

            if (status == "Paid")
            {
                MessageBox.Show("Already Paid");
                return;
            }

            int orderId = Convert.ToInt32(
                dgvOrders.CurrentRow.Cells["OrderID"].Value);

            new CheckoutForm(orderId, userId).ShowDialog();
            LoadOrders(); // refresh
        }
    }
}
