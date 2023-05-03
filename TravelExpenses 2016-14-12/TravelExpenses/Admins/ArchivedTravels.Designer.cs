namespace TravelExpenses
{
    partial class ArchivedTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivedTravels));
            this.dgvArchivedTravels = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pupose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedTravels)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArchivedTravels
            // 
            this.dgvArchivedTravels.AllowUserToAddRows = false;
            this.dgvArchivedTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivedTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Return,
            this.Event,
            this.Pupose,
            this.Status,
            this.Origin,
            this.Destination,
            this.Total,
            this.TravelID,
            this.UserID,
            this.User,
            this.Approved});
            this.dgvArchivedTravels.Location = new System.Drawing.Point(51, 211);
            this.dgvArchivedTravels.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArchivedTravels.MultiSelect = false;
            this.dgvArchivedTravels.Name = "dgvArchivedTravels";
            this.dgvArchivedTravels.ReadOnly = true;
            this.dgvArchivedTravels.RowHeadersWidth = 62;
            this.dgvArchivedTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchivedTravels.Size = new System.Drawing.Size(1344, 1123);
            this.dgvArchivedTravels.TabIndex = 0;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 8;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 80;
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.MinimumWidth = 8;
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.Width = 80;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.MinimumWidth = 8;
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 200;
            // 
            // Pupose
            // 
            this.Pupose.HeaderText = "Purpose";
            this.Pupose.MinimumWidth = 8;
            this.Pupose.Name = "Pupose";
            this.Pupose.ReadOnly = true;
            this.Pupose.Visible = false;
            this.Pupose.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 80;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.MinimumWidth = 8;
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Visible = false;
            this.Origin.Width = 150;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 8;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Visible = false;
            this.Destination.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Visible = false;
            this.Total.Width = 150;
            // 
            // TravelID
            // 
            this.TravelID.HeaderText = "TravelID";
            this.TravelID.MinimumWidth = 8;
            this.TravelID.Name = "TravelID";
            this.TravelID.ReadOnly = true;
            this.TravelID.Visible = false;
            this.TravelID.Width = 150;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            this.UserID.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 150;
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Approved";
            this.Approved.MinimumWidth = 8;
            this.Approved.Name = "Approved";
            this.Approved.ReadOnly = true;
            this.Approved.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.Controls.Add(this.btnPDF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSeparator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 71);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(6, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(71, 59);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeparator.Location = new System.Drawing.Point(89, 17);
            this.lblSeparator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(24, 36);
            this.lblSeparator.TabIndex = 2;
            this.lblSeparator.Text = "|";
            this.lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(125, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 59);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.cbEmployee);
            this.pnSearch.Controls.Add(this.lblSearch);
            this.pnSearch.Location = new System.Drawing.Point(51, 58);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(792, 94);
            this.pnSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(687, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 67);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(251, 32);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(369, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(24, 35);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(181, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Select Employee:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1162, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 94);
            this.panel1.TabIndex = 3;
            // 
            // ArchivedTravels
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 1396);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.dgvArchivedTravels);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchivedTravels";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archived Travels";
            this.Load += new System.EventHandler(this.ArchivedTravels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedTravels)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivedTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pupose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
    }
}