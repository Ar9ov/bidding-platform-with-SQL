namespace WindowsFormsApp1
{
    partial class AuctionDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionDetailsForm));
            this.IblTitle = new System.Windows.Forms.Label();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IblCategory = new System.Windows.Forms.Label();
            this.IblCondition = new System.Windows.Forms.Label();
            this.IblSeller = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.IbsStartPrice = new System.Windows.Forms.Label();
            this.IblHighestBid = new System.Windows.Forms.Label();
            this.IblEndTime = new System.Windows.Forms.Label();
            this.IblStatus = new System.Windows.Forms.Label();
            this.IblTimeLeft = new System.Windows.Forms.Label();
            this.auctionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IblTitle
            // 
            this.IblTitle.AutoSize = true;
            this.IblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.IblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.IblTitle.Location = new System.Drawing.Point(271, 35);
            this.IblTitle.Name = "IblTitle";
            this.IblTitle.Size = new System.Drawing.Size(123, 29);
            this.IblTitle.TabIndex = 0;
            this.IblTitle.Text = "Item Title";
            this.IblTitle.Click += new System.EventHandler(this.IblTitle_Click);
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBidAmount.Location = new System.Drawing.Point(253, 257);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(211, 35);
            this.txtBidAmount.TabIndex = 2;
            this.txtBidAmount.TextChanged += new System.EventHandler(this.txtBidAmount_TextChanged);
            // 
            // btnPlaceBid
            // 
            this.btnPlaceBid.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlaceBid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlaceBid.Font = new System.Drawing.Font("Flat Brush", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBid.ForeColor = System.Drawing.Color.Black;
            this.btnPlaceBid.Location = new System.Drawing.Point(163, 322);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(231, 81);
            this.btnPlaceBid.TabIndex = 4;
            this.btnPlaceBid.Text = "Place Bid";
            this.btnPlaceBid.UseVisualStyleBackColor = false;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Flat Brush", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(38, 464);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // IblCategory
            // 
            this.IblCategory.AutoSize = true;
            this.IblCategory.BackColor = System.Drawing.Color.Lime;
            this.IblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCategory.ForeColor = System.Drawing.Color.Firebrick;
            this.IblCategory.Location = new System.Drawing.Point(271, 83);
            this.IblCategory.Name = "IblCategory";
            this.IblCategory.Size = new System.Drawing.Size(100, 26);
            this.IblCategory.TabIndex = 7;
            this.IblCategory.Text = "Category";
            // 
            // IblCondition
            // 
            this.IblCondition.AutoSize = true;
            this.IblCondition.BackColor = System.Drawing.Color.Lime;
            this.IblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCondition.ForeColor = System.Drawing.Color.Firebrick;
            this.IblCondition.Location = new System.Drawing.Point(271, 134);
            this.IblCondition.Name = "IblCondition";
            this.IblCondition.Size = new System.Drawing.Size(104, 26);
            this.IblCondition.TabIndex = 8;
            this.IblCondition.Text = "Condition";
            this.IblCondition.Click += new System.EventHandler(this.IblCondition_Click);
            // 
            // IblSeller
            // 
            this.IblSeller.AutoSize = true;
            this.IblSeller.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblSeller.Location = new System.Drawing.Point(749, 245);
            this.IblSeller.Name = "IblSeller";
            this.IblSeller.Size = new System.Drawing.Size(81, 31);
            this.IblSeller.TabIndex = 9;
            this.IblSeller.Text = "Seller";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(580, 67);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(351, 154);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "";
            // 
            // IbsStartPrice
            // 
            this.IbsStartPrice.AutoSize = true;
            this.IbsStartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbsStartPrice.Location = new System.Drawing.Point(749, 296);
            this.IbsStartPrice.Name = "IbsStartPrice";
            this.IbsStartPrice.Size = new System.Drawing.Size(114, 26);
            this.IbsStartPrice.TabIndex = 11;
            this.IbsStartPrice.Text = "Start Price";
            this.IbsStartPrice.Click += new System.EventHandler(this.IbsStartPrice_Click);
            // 
            // IblHighestBid
            // 
            this.IblHighestBid.AutoSize = true;
            this.IblHighestBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.IblHighestBid.ForeColor = System.Drawing.Color.Green;
            this.IblHighestBid.Location = new System.Drawing.Point(749, 348);
            this.IblHighestBid.Name = "IblHighestBid";
            this.IblHighestBid.Size = new System.Drawing.Size(24, 25);
            this.IblHighestBid.TabIndex = 12;
            this.IblHighestBid.Text = "0";
            // 
            // IblEndTime
            // 
            this.IblEndTime.AutoSize = true;
            this.IblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblEndTime.Location = new System.Drawing.Point(749, 401);
            this.IblEndTime.Name = "IblEndTime";
            this.IblEndTime.Size = new System.Drawing.Size(105, 26);
            this.IblEndTime.TabIndex = 13;
            this.IblEndTime.Text = "End Time";
            // 
            // IblStatus
            // 
            this.IblStatus.AutoSize = true;
            this.IblStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.IblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblStatus.Location = new System.Drawing.Point(749, 447);
            this.IblStatus.Name = "IblStatus";
            this.IblStatus.Size = new System.Drawing.Size(95, 32);
            this.IblStatus.TabIndex = 14;
            this.IblStatus.Text = "Status";
            // 
            // IblTimeLeft
            // 
            this.IblTimeLeft.AutoSize = true;
            this.IblTimeLeft.Font = new System.Drawing.Font("RUPERTA", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTimeLeft.ForeColor = System.Drawing.Color.Red;
            this.IblTimeLeft.Location = new System.Drawing.Point(271, 186);
            this.IblTimeLeft.Name = "IblTimeLeft";
            this.IblTimeLeft.Size = new System.Drawing.Size(162, 32);
            this.IblTimeLeft.TabIndex = 15;
            this.IblTimeLeft.Text = "00:00:00";
            // 
            // auctionTimer
            // 
            this.auctionTimer.Interval = 1000;
            this.auctionTimer.Tick += new System.EventHandler(this.auctionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Condition";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lavender;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bid Ending in";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lavender;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 35);
            this.label10.TabIndex = 16;
            this.label10.Text = "Place Your Bid";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Lavender;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(575, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 35);
            this.label11.TabIndex = 16;
            this.label11.Text = "Item Description";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(575, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 35);
            this.label12.TabIndex = 16;
            this.label12.Text = "Seller";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Lavender;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(574, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 35);
            this.label13.TabIndex = 16;
            this.label13.Text = "Start Price";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Lavender;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(574, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 35);
            this.label14.TabIndex = 16;
            this.label14.Text = "Highest Bid";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Lavender;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(574, 396);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 35);
            this.label15.TabIndex = 16;
            this.label15.Text = "End Time";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Lavender;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(574, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 35);
            this.label16.TabIndex = 16;
            this.label16.Text = "Status";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // AuctionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IblTimeLeft);
            this.Controls.Add(this.IblStatus);
            this.Controls.Add(this.IblEndTime);
            this.Controls.Add(this.IblHighestBid);
            this.Controls.Add(this.IbsStartPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.IblSeller);
            this.Controls.Add(this.IblCondition);
            this.Controls.Add(this.IblCategory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlaceBid);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.IblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuctionDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auction Details";
            this.Load += new System.EventHandler(this.AuctionDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblTitle;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IblCategory;
        private System.Windows.Forms.Label IblCondition;
        private System.Windows.Forms.Label IblSeller;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label IbsStartPrice;
        private System.Windows.Forms.Label IblHighestBid;
        private System.Windows.Forms.Label IblEndTime;
        private System.Windows.Forms.Label IblStatus;
        private System.Windows.Forms.Label IblTimeLeft;
        private System.Windows.Forms.Timer auctionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}