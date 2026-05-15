using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuctionDetailsForm : Form
    {
        int auctionId, userId, sellerId;
        DateTime auctionEndTime;
        decimal highestBid;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Centralized connection string
        string connectionString = "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";

        public AuctionDetailsForm(int aId, int uId)
        {
            InitializeComponent();
            auctionId = aId;
            userId = uId;
        }

        private void AuctionDetailsForm_Load(object sender, EventArgs e)
        {
            LoadAuctionDetails();
            LoadHighestBid();
            auctionTimer.Interval = 1000; // 1 second
            auctionTimer.Start();
        }

        void LoadAuctionDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string q = @"SELECT I.Title, I.Description, C.CategoryName, 
                                 IC.ConditionName, U.FullName AS SellerName,
                                 A.StartPrice, A.EndTime, A.Status, I.SellerID
                                 FROM Auctions A
                                 JOIN Items I ON A.ItemID = I.ItemID
                                 JOIN Categories C ON I.CategoryID = C.CategoryID
                                 JOIN ItemConditions IC ON I.ConditionID = IC.ConditionID
                                 JOIN Users U ON I.SellerID = U.UserID
                                 WHERE A.AuctionID = @id";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@id", auctionId);
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            IblTitle.Text = dr["Title"].ToString();
                            txtDescription.Text = dr["Description"].ToString();
                            IblCategory.Text = dr["CategoryName"].ToString();
                            IblCondition.Text = dr["ConditionName"].ToString();
                            IblSeller.Text = dr["SellerName"].ToString();
                            IbsStartPrice.Text = dr["StartPrice"].ToString();
                            IblEndTime.Text = Convert.ToDateTime(dr["EndTime"]).ToString("g");
                            IblStatus.Text = dr["Status"].ToString();

                            auctionEndTime = Convert.ToDateTime(dr["EndTime"]);
                            sellerId = Convert.ToInt32(dr["SellerID"]);
                        }
                    }
                }

                // Disable bidding if current user is the seller
                if (userId == sellerId)
                {
                    btnPlaceBid.Enabled = false;
                    IblStatus.Text += " (Your Item)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }

        void LoadHighestBid()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(BidAmount), 0) FROM Bids WHERE AuctionID=@a", con);
                cmd.Parameters.AddWithValue("@a", auctionId);
                con.Open();
                highestBid = Convert.ToDecimal(cmd.ExecuteScalar());
                IblHighestBid.Text = highestBid.ToString("C2"); // Formats as Currency
            }
        }

        private void btnPlaceBid_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void IbsStartPrice_Click(object sender, EventArgs e)
        {

        }

        private void IblTitle_Click(object sender, EventArgs e)
        {

        }

        private void IblCondition_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceBid_Click_1(object sender, EventArgs e)
        {
            // Validate numeric input
            if (!decimal.TryParse(txtBidAmount.Text, out decimal bid))
            {
                MessageBox.Show("Please enter a valid numeric bid.");
                return;
            }

            if (DateTime.Now > auctionEndTime)
            {
                MessageBox.Show("Auction already ended.");
                return;
            }

            if (bid <= highestBid)
            {
                MessageBox.Show("Bid must be higher than current highest bid.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Bids(AuctionID, BidderID, BidAmount) VALUES(@a, @u, @b)", con);
                cmd.Parameters.AddWithValue("@a", auctionId);
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@b", bid);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Bid placed successfully!");
            LoadHighestBid();

        }

        private void auctionTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = auctionEndTime - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                auctionTimer.Stop();
                IblTimeLeft.Text = "Auction Ended";
                btnPlaceBid.Enabled = false;
                EndAuction();
            }
            else
            {
                IblTimeLeft.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", remaining.Hours, remaining.Minutes, remaining.Seconds);
            }
        }

        void EndAuction()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                SqlCommand closeCmd = new SqlCommand("UPDATE Auctions SET Status='Closed' WHERE AuctionID=@a AND Status <> 'Closed'", con);
                closeCmd.Parameters.AddWithValue("@a", auctionId);
                closeCmd.ExecuteNonQuery();

                // 2. Identify Winner
                int winnerId = 0;
                decimal finalPrice = 0;

                SqlCommand winCmd = new SqlCommand(@"SELECT TOP 1 BidderID, BidAmount FROM Bids WHERE AuctionID=@a ORDER BY BidAmount DESC", con);
                winCmd.Parameters.AddWithValue("@a", auctionId);

                using (SqlDataReader dr = winCmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        winnerId = Convert.ToInt32(dr["BidderID"]);
                        finalPrice = Convert.ToDecimal(dr["BidAmount"]);
                    }
                } // DataReader closes here

                // 3. Create Order if there was a winner
                if (winnerId > 0)
                {
                    SqlCommand orderCmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM Orders WHERE AuctionID=@a) " +
                                                         "INSERT INTO Orders(AuctionID, BuyerID, FinalPrice) VALUES(@a, @b, @p)", con);
                    orderCmd.Parameters.AddWithValue("@a", auctionId);
                    orderCmd.Parameters.AddWithValue("@b", winnerId);
                    orderCmd.Parameters.AddWithValue("@p", finalPrice);
                    orderCmd.ExecuteNonQuery();

                    MessageBox.Show("Auction closed. Winner ID: " + winnerId);
                }
            }
        }
    }
}