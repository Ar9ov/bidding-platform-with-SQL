namespace WindowsFormsApp1
{
    partial class BrowseAucForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseAucForm));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auctionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t3DataSet11 = new WindowsFormsApp1.t3DataSet11();
            this.bidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t3DataSet3 = new WindowsFormsApp1.t3DataSet3();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bidsTableAdapter = new WindowsFormsApp1.t3DataSet3TableAdapters.BidsTableAdapter();
            this.t3DataSet9 = new WindowsFormsApp1.t3DataSet9();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new WindowsFormsApp1.t3DataSet9TableAdapters.AuctionsTableAdapter();
            this.auctionsTableAdapter1 = new WindowsFormsApp1.t3DataSet11TableAdapters.AuctionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Flat Brush", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auctionIDDataGridViewTextBoxColumn,
            this.ItemID,
            this.StartPrice,
            this.StartTime,
            this.EndTime,
            this.Status});
            this.dataGridView1.DataSource = this.auctionsBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(969, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // auctionIDDataGridViewTextBoxColumn
            // 
            this.auctionIDDataGridViewTextBoxColumn.DataPropertyName = "AuctionID";
            this.auctionIDDataGridViewTextBoxColumn.HeaderText = "AuctionID";
            this.auctionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.auctionIDDataGridViewTextBoxColumn.Name = "auctionIDDataGridViewTextBoxColumn";
            this.auctionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 8;
            this.ItemID.Name = "ItemID";
            // 
            // StartPrice
            // 
            this.StartPrice.DataPropertyName = "StartPrice";
            this.StartPrice.HeaderText = "StartPrice";
            this.StartPrice.MinimumWidth = 8;
            this.StartPrice.Name = "StartPrice";
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 8;
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 8;
            this.EndTime.Name = "EndTime";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // auctionsBindingSource1
            // 
            this.auctionsBindingSource1.DataMember = "Auctions";
            this.auctionsBindingSource1.DataSource = this.t3DataSet11;
            // 
            // t3DataSet11
            // 
            this.t3DataSet11.DataSetName = "t3DataSet11";
            this.t3DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidsBindingSource
            // 
            this.bidsBindingSource.DataMember = "Bids";
            this.bidsBindingSource.DataSource = this.t3DataSet3;
            // 
            // t3DataSet3
            // 
            this.t3DataSet3.DataSetName = "t3DataSet3";
            this.t3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Flat Brush", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(724, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "View And Bid";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select an Item to get Details and To Bid";
            // 
            // bidsTableAdapter
            // 
            this.bidsTableAdapter.ClearBeforeFill = true;
            // 
            // t3DataSet9
            // 
            this.t3DataSet9.DataSetName = "t3DataSet9";
            this.t3DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.t3DataSet9;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter1
            // 
            this.auctionsTableAdapter1.ClearBeforeFill = true;
            // 
            // BrowseAucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowseAucForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseAucForm";
            this.Load += new System.EventHandler(this.BrowseAucForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private t3DataSet3 t3DataSet3;
        private System.Windows.Forms.BindingSource bidsBindingSource;
        private t3DataSet3TableAdapters.BidsTableAdapter bidsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIDDataGridViewTextBoxColumn;
        private t3DataSet9 t3DataSet9;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private t3DataSet9TableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private t3DataSet11 t3DataSet11;
        private System.Windows.Forms.BindingSource auctionsBindingSource1;
        private t3DataSet11TableAdapters.AuctionsTableAdapter auctionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}