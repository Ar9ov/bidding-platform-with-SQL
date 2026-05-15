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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class SellItemForm : Form
    {
        int sellerID;
        public SellItemForm(int uid)
        {
            InitializeComponent();
            sellerID = uid;
        }

        private void SellItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet2.ItemConditions' table. You can move, or remove it, as needed.
            this.itemConditionsTableAdapter.Fill(this.t3DataSet2.ItemConditions);
            // TODO: This line of code loads data into the 't3DataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.t3DataSet1.Categories);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3(sellerID);
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  new SellItemForm(userId).Show();

            string connectionString =
       "Data Source=AR9OV\\SQLEXPRESS;Initial Catalog=t3;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            
            SqlCommand itemCmd = new SqlCommand(
                "INSERT INTO [Items] (Title, Description, SellerID, CategoryID, ConditionID) OUTPUT INSERTED.ItemID VALUES(@t,@d,@s,@c,@cond)",con);

            itemCmd.Parameters.AddWithValue("@t", textBox1.Text);
            itemCmd.Parameters.AddWithValue("@d", richTextBox1.Text);

            itemCmd.Parameters.AddWithValue("@s", sellerID);
            itemCmd.Parameters.AddWithValue("@c", comboBox1.SelectedValue);
            itemCmd.Parameters.AddWithValue("@cond", comboBox2.SelectedValue);

            // 1. Get the ID (Correcting the variable name to ItemId)
            int ItemId = (int)itemCmd.ExecuteScalar();

            // 2. Prepare the Auction command (Ensuring "ItemID" is spelled correctly)
            SqlCommand auctionCmd = new SqlCommand("INSERT INTO Auctions (ItemID, StartPrice, StartTime, EndTime) VALUES (@i, @p, GETDATE(), @e)", con);

            // 3. Link the parameter using the correct variable case
            auctionCmd.Parameters.AddWithValue("@i", ItemId);
            auctionCmd.Parameters.AddWithValue("@p", numericUpDown1.Value);
            auctionCmd.Parameters.AddWithValue("@e", dateTimePicker1.Value);

            auctionCmd.ExecuteNonQuery();

            MessageBox.Show("Auction Created!");
           // this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
