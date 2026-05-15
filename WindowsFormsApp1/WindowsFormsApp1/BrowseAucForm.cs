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
    public partial class BrowseAucForm : Form
    {
        int userId;
        public BrowseAucForm(int uid)
        {
            InitializeComponent();
            userId = uid;
            LoadAuctions();
        }
        void LoadAuctions()
        {
            string connectionString = "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT AuctionID, Title, StartPrice, EndTime FROM Auctions A JOIN Items I ON A.ItemID=I.ItemID WHERE Status='Active'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading auctions: " + ex.Message);
                }
            }
        }

        private void BrowseAucForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet11.Auctions' table. You can move, or remove it, as needed.
            this.auctionsTableAdapter1.Fill(this.t3DataSet11.Auctions);
            // TODO: This line of code loads data into the 't3DataSet9.Auctions' table. You can move, or remove it, as needed.
            this.auctionsTableAdapter.Fill(this.t3DataSet9.Auctions);
            // TODO: This line of code loads data into the 't3DataSet3.Bids' table. You can move, or remove it, as needed.
            this.bidsTableAdapter.Fill(this.t3DataSet3.Bids);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3(userId);
            f4.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a valid auction from the list.");
                return;
            }

            // 2. Safely get the value and check for null
            var cellValue = dataGridView1.CurrentRow.Cells[0].Value;

            if (cellValue != null && cellValue != DBNull.Value)
            {
                int auctionId = Convert.ToInt32(cellValue);

                // 3. Open the details form
                AuctionDetailsForm details = new AuctionDetailsForm(auctionId, userId);
                details.Show();
            }
            else
            {
                MessageBox.Show("Invalid Auction ID selected.");
            }
        }
    }
}
