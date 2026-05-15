namespace WindowsFormsApp1
{
    partial class MyBidsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBidsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auctionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t3DataSet5 = new WindowsFormsApp1.t3DataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.t3DataSet4 = new WindowsFormsApp1.t3DataSet4();
            this.bidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidsTableAdapter = new WindowsFormsApp1.t3DataSet4TableAdapters.BidsTableAdapter();
            this.auctionsTableAdapter = new WindowsFormsApp1.t3DataSet5TableAdapters.AuctionsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auctionIDDataGridViewTextBoxColumn,
            this.ItemID,
            this.StartPrice,
            this.StartTime,
            this.EndTime,
            this.Status});
            this.dataGridView1.DataSource = this.auctionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(974, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // auctionIDDataGridViewTextBoxColumn
            // 
            this.auctionIDDataGridViewTextBoxColumn.DataPropertyName = "AuctionID";
            this.auctionIDDataGridViewTextBoxColumn.HeaderText = "AuctionID";
            this.auctionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.auctionIDDataGridViewTextBoxColumn.Name = "auctionIDDataGridViewTextBoxColumn";
            this.auctionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.auctionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 8;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 150;
            // 
            // StartPrice
            // 
            this.StartPrice.DataPropertyName = "StartPrice";
            this.StartPrice.HeaderText = "StartPrice";
            this.StartPrice.MinimumWidth = 8;
            this.StartPrice.Name = "StartPrice";
            this.StartPrice.Width = 150;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 8;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 150;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 8;
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.t3DataSet5;
            // 
            // t3DataSet5
            // 
            this.t3DataSet5.DataSetName = "t3DataSet5";
            this.t3DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "All bids By Current User";
            // 
            // t3DataSet4
            // 
            this.t3DataSet4.DataSetName = "t3DataSet4";
            this.t3DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidsBindingSource
            // 
            this.bidsBindingSource.DataMember = "Bids";
            this.bidsBindingSource.DataSource = this.t3DataSet4;
            // 
            // bidsTableAdapter
            // 
            this.bidsTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.samurai_warrior_4k_hd_ghost_of_tsushima;
            this.button1.ForeColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(836, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyBidsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBidsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBidsForm";
            this.Load += new System.EventHandler(this.MyBidsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private t3DataSet4 t3DataSet4;
        private System.Windows.Forms.BindingSource bidsBindingSource;
        private t3DataSet4TableAdapters.BidsTableAdapter bidsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIDDataGridViewTextBoxColumn;
        private t3DataSet5 t3DataSet5;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private t3DataSet5TableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button1;
    }
}