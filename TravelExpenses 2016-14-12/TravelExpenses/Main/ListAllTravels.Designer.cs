namespace TravelExpenses
{
    partial class ListAllTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAllTravels));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnSummarizedPDF = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvAllTravels = new System.Windows.Forms.DataGridView();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTravel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSendingEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTravels)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(281, 8);
            this.btnView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(57, 71);
            this.btnView.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnView, "View Travel");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Image = ((System.Drawing.Image)(resources.GetObject("btnApprove.Image")));
            this.btnApprove.Location = new System.Drawing.Point(188, 8);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(49, 71);
            this.btnApprove.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnApprove, "Approve Travel");
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSummarizedPDF
            // 
            this.btnSummarizedPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSummarizedPDF.FlatAppearance.BorderSize = 0;
            this.btnSummarizedPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarizedPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSummarizedPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnSummarizedPDF.Image")));
            this.btnSummarizedPDF.Location = new System.Drawing.Point(97, 8);
            this.btnSummarizedPDF.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSummarizedPDF.Name = "btnSummarizedPDF";
            this.btnSummarizedPDF.Size = new System.Drawing.Size(49, 71);
            this.btnSummarizedPDF.TabIndex = 2;
            this.btnSummarizedPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSummarizedPDF, "Summarized PDF");
            this.btnSummarizedPDF.UseVisualStyleBackColor = true;
            this.btnSummarizedPDF.Click += new System.EventHandler(this.btnSummarizedPDF_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(6, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 71);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancel, "Close");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(22, 88);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 38);
            this.btnInfo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnInfo, "Select a travel and then click on the option you want to perform on it:");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dgvAllTravels
            // 
            this.dgvAllTravels.AllowUserToAddRows = false;
            this.dgvAllTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.TravelEvent,
            this.TravelPurpose,
            this.Origin,
            this.Destination,
            this.Status,
            this.Total,
            this.IDTravel,
            this.Approved});
            this.dgvAllTravels.Location = new System.Drawing.Point(28, 133);
            this.dgvAllTravels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvAllTravels.Name = "dgvAllTravels";
            this.dgvAllTravels.ReadOnly = true;
            this.dgvAllTravels.RowHeadersWidth = 62;
            this.dgvAllTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTravels.Size = new System.Drawing.Size(1610, 596);
            this.dgvAllTravels.TabIndex = 0;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure Date";
            this.DepartureDate.MinimumWidth = 8;
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 120;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 110;
            // 
            // TravelEvent
            // 
            this.TravelEvent.HeaderText = "Travel Event";
            this.TravelEvent.MinimumWidth = 8;
            this.TravelEvent.Name = "TravelEvent";
            this.TravelEvent.ReadOnly = true;
            this.TravelEvent.Width = 200;
            // 
            // TravelPurpose
            // 
            this.TravelPurpose.HeaderText = "Travel Purpose";
            this.TravelPurpose.MinimumWidth = 8;
            this.TravelPurpose.Name = "TravelPurpose";
            this.TravelPurpose.ReadOnly = true;
            this.TravelPurpose.Visible = false;
            this.TravelPurpose.Width = 120;
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // IDTravel
            // 
            this.IDTravel.HeaderText = "IDTravel";
            this.IDTravel.MinimumWidth = 8;
            this.IDTravel.Name = "IDTravel";
            this.IDTravel.ReadOnly = true;
            this.IDTravel.Visible = false;
            this.IDTravel.Width = 150;
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
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnApprove, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnView, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSummarizedPDF, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1290, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 87);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(158, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "|";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(249, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSendingEmail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dgvAllTravels);
            this.panel1.Location = new System.Drawing.Point(28, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 764);
            this.panel1.TabIndex = 3;
            // 
            // lblSendingEmail
            // 
            this.lblSendingEmail.AutoSize = true;
            this.lblSendingEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSendingEmail.Location = new System.Drawing.Point(148, 90);
            this.lblSendingEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSendingEmail.Name = "lblSendingEmail";
            this.lblSendingEmail.Size = new System.Drawing.Size(266, 20);
            this.lblSendingEmail.TabIndex = 9;
            this.lblSendingEmail.Text = "Sending Notification Emails.....";
            this.lblSendingEmail.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ListAllTravels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 808);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ListAllTravels";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All My Expenses Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListAllTravels_FormClosed);
            this.Load += new System.EventHandler(this.ListAllTravels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTravels)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvAllTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSummarizedPDF;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSendingEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
    }
}