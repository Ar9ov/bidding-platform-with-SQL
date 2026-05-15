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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadAuctions();
            LoadOrders();
            LoadPayments();
            LoadReviews();
        }
        void LoadUsers()
        {
            LoadGrid(dgvUsers, "SELECT UserID, FullName, Email FROM Users");
        }
        void LoadAuctions()
        {
            LoadGrid(dgvAuctions, @"
                SELECT A.AuctionID, I.Title, A.Status, A.EndTime
                FROM Auctions A
                JOIN Items I ON A.ItemID = I.ItemID");
        }

        void LoadOrders()
        {
            LoadGrid(dgvOrders, @"
                SELECT OrderID, BuyerID, FinalPrice, PaymentStatus
                FROM Orders");
        }

        void LoadPayments()
        {
            LoadGrid(dgvPayments, @"
                SELECT PaymentID, OrderID, Amount, PaymentMethod, PaymentDate
                FROM Payments");
        }

        void LoadReviews()
        {
            LoadGrid(dgvReviews, @"
                SELECT R.ReviewID, U.FullName, R.Rating, R.Comment
                FROM Reviews R
                JOIN Users U ON R.ReviewID = U.UserID");
        }

        void LoadGrid(DataGridView dgv, string query)
        {
            using (SqlConnection con = DbHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
