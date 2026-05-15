using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyBidsForm : Form
    {
        int userId;
        public MyBidsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MyBidsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3DataSet5.Auctions' table. You can move, or remove it, as needed.
            this.auctionsTableAdapter.Fill(this.t3DataSet5.Auctions);
            // TODO: This line of code loads data into the 't3DataSet4.Bids' table. You can move, or remove it, as needed.
            this.bidsTableAdapter.Fill(this.t3DataSet4.Bids);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3(userId);
            f4.Show();
        }
    }
}
