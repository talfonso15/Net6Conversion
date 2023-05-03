namespace TravelExpenses
{
    partial class AllEstimates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEstimates));
            this.dgvAllEstimates = new System.Windows.Forms.DataGridView();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetedTravel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EstimatedTravelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelEstomatedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlOptionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEstimatePDF = new System.Windows.Forms.Button();
            this.btnApproval = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewEstimate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pEstimateDetails = new System.Windows.Forms.Panel();
            this.gbTravelDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblTravelEvent = new System.Windows.Forms.Label();
            this.txtTravelEvent = new System.Windows.Forms.TextBox();
            this.lblTravelPurpose = new System.Windows.Forms.Label();
            this.txtTravelPurpose = new System.Windows.Forms.TextBox();
            this.lblTravelBudgeted = new System.Windows.Forms.Label();
            this.lblTravelEstTotal = new System.Windows.Forms.Label();
            this.lblEstimatedTotalValue = new System.Windows.Forms.Label();
            this.dtpDepartureDateValue = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDateValue = new System.Windows.Forms.DateTimePicker();
            this.pTravelBudget = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblMealsPerDiemRate = new System.Windows.Forms.Label();
            this.txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            this.gbTravelItems = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMileageCost = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblMeals = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblLodging = new System.Windows.Forms.Label();
            this.lblCarRental = new System.Windows.Forms.Label();
            this.lblAirfare = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblOtherExpenses = new System.Windows.Forms.Label();
            this.txtMealsNotes = new System.Windows.Forms.TextBox();
            this.txtRegistrationNotes = new System.Windows.Forms.TextBox();
            this.txtLodgingNotes = new System.Windows.Forms.TextBox();
            this.txtCarRentalNotes = new System.Windows.Forms.TextBox();
            this.txtAirfareNotes = new System.Windows.Forms.TextBox();
            this.txtMileageNotes = new System.Windows.Forms.TextBox();
            this.txtOtherExpNotes = new System.Windows.Forms.TextBox();
            this.txtMealsCost = new System.Windows.Forms.TextBox();
            this.txtRegistrationCost = new System.Windows.Forms.TextBox();
            this.txtLodgingCost = new System.Windows.Forms.TextBox();
            this.txtCarRentalCost = new System.Windows.Forms.TextBox();
            this.txtAirfareCost = new System.Windows.Forms.TextBox();
            this.txtOtherExpensesCost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEstimates)).BeginInit();
            this.tlOptionButtons.SuspendLayout();
            this.pEstimateDetails.SuspendLayout();
            this.gbTravelDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pTravelBudget.SuspendLayout();
            this.gbTravelItems.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllEstimates
            // 
            this.dgvAllEstimates.AllowUserToAddRows = false;
            this.dgvAllEstimates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEstimates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.TravelEvent,
            this.TravelPurpose,
            this.BudgetedTravel,
            this.EstimatedTravelCost,
            this.TravelEstomatedID,
            this.Approved});
            this.dgvAllEstimates.Location = new System.Drawing.Point(24, 87);
            this.dgvAllEstimates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvAllEstimates.MultiSelect = false;
            this.dgvAllEstimates.Name = "dgvAllEstimates";
            this.dgvAllEstimates.RowHeadersWidth = 62;
            this.dgvAllEstimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllEstimates.Size = new System.Drawing.Size(1245, 275);
            this.dgvAllEstimates.TabIndex = 1;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure";
            this.DepartureDate.MinimumWidth = 8;
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 80;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 80;
            // 
            // TravelEvent
            // 
            this.TravelEvent.HeaderText = "Event";
            this.TravelEvent.MinimumWidth = 8;
            this.TravelEvent.Name = "TravelEvent";
            this.TravelEvent.ReadOnly = true;
            this.TravelEvent.Width = 200;
            // 
            // TravelPurpose
            // 
            this.TravelPurpose.HeaderText = "Purpose";
            this.TravelPurpose.MinimumWidth = 8;
            this.TravelPurpose.Name = "TravelPurpose";
            this.TravelPurpose.ReadOnly = true;
            this.TravelPurpose.Visible = false;
            this.TravelPurpose.Width = 170;
            // 
            // BudgetedTravel
            // 
            this.BudgetedTravel.HeaderText = "Budgeted";
            this.BudgetedTravel.MinimumWidth = 8;
            this.BudgetedTravel.Name = "BudgetedTravel";
            this.BudgetedTravel.ReadOnly = true;
            this.BudgetedTravel.Width = 60;
            // 
            // EstimatedTravelCost
            // 
            this.EstimatedTravelCost.HeaderText = "Total";
            this.EstimatedTravelCost.MinimumWidth = 8;
            this.EstimatedTravelCost.Name = "EstimatedTravelCost";
            this.EstimatedTravelCost.ReadOnly = true;
            this.EstimatedTravelCost.Width = 80;
            // 
            // TravelEstomatedID
            // 
            this.TravelEstomatedID.HeaderText = "TravelEstomatedID";
            this.TravelEstomatedID.MinimumWidth = 8;
            this.TravelEstomatedID.Name = "TravelEstomatedID";
            this.TravelEstomatedID.Visible = false;
            this.TravelEstomatedID.Width = 150;
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Approved";
            this.Approved.MinimumWidth = 8;
            this.Approved.Name = "Approved";
            this.Approved.Width = 80;
            // 
            // tlOptionButtons
            // 
            this.tlOptionButtons.ColumnCount = 9;
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.61006F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.50943F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlOptionButtons.Controls.Add(this.btnCancel, 0, 0);
            this.tlOptionButtons.Controls.Add(this.btnEstimatePDF, 2, 0);
            this.tlOptionButtons.Controls.Add(this.btnApproval, 4, 0);
            this.tlOptionButtons.Controls.Add(this.label3, 5, 0);
            this.tlOptionButtons.Controls.Add(this.label2, 3, 0);
            this.tlOptionButtons.Controls.Add(this.label1, 1, 0);
            this.tlOptionButtons.Controls.Add(this.btnViewEstimate, 8, 0);
            this.tlOptionButtons.Controls.Add(this.btnEdit, 6, 0);
            this.tlOptionButtons.Controls.Add(this.label4, 7, 0);
            this.tlOptionButtons.Location = new System.Drawing.Point(832, 2);
            this.tlOptionButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlOptionButtons.Name = "tlOptionButtons";
            this.tlOptionButtons.RowCount = 1;
            this.tlOptionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlOptionButtons.Size = new System.Drawing.Size(453, 81);
            this.tlOptionButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(6, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 69);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancel, "Close Window");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEstimatePDF
            // 
            this.btnEstimatePDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstimatePDF.FlatAppearance.BorderSize = 0;
            this.btnEstimatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstimatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstimatePDF.Image = ((System.Drawing.Image)(resources.GetObject("btnEstimatePDF.Image")));
            this.btnEstimatePDF.Location = new System.Drawing.Point(100, 6);
            this.btnEstimatePDF.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEstimatePDF.Name = "btnEstimatePDF";
            this.btnEstimatePDF.Size = new System.Drawing.Size(53, 69);
            this.btnEstimatePDF.TabIndex = 1;
            this.btnEstimatePDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEstimatePDF, "Create PDF");
            this.btnEstimatePDF.UseVisualStyleBackColor = true;
            this.btnEstimatePDF.Click += new System.EventHandler(this.btnEstimatePDF_Click);
            // 
            // btnApproval
            // 
            this.btnApproval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApproval.FlatAppearance.BorderSize = 0;
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApproval.Image = ((System.Drawing.Image)(resources.GetObject("btnApproval.Image")));
            this.btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.Location = new System.Drawing.Point(206, 6);
            this.btnApproval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(54, 69);
            this.btnApproval.TabIndex = 5;
            this.btnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnApproval, "Approve & Sign");
            this.btnApproval.UseVisualStyleBackColor = true;
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(272, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(166, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewEstimate
            // 
            this.btnViewEstimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewEstimate.FlatAppearance.BorderSize = 0;
            this.btnViewEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewEstimate.Image = ((System.Drawing.Image)(resources.GetObject("btnViewEstimate.Image")));
            this.btnViewEstimate.Location = new System.Drawing.Point(396, 6);
            this.btnViewEstimate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnViewEstimate.Name = "btnViewEstimate";
            this.btnViewEstimate.Size = new System.Drawing.Size(51, 69);
            this.btnViewEstimate.TabIndex = 0;
            this.btnViewEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnViewEstimate, "View All Details");
            this.btnViewEstimate.UseVisualStyleBackColor = true;
            this.btnViewEstimate.Click += new System.EventHandler(this.btnViewEstimate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(302, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 69);
            this.btnEdit.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit Authorization");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(365, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEstimateDetails
            // 
            this.pEstimateDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEstimateDetails.Controls.Add(this.gbTravelDetails);
            this.pEstimateDetails.Controls.Add(this.gbTravelItems);
            this.pEstimateDetails.Location = new System.Drawing.Point(35, 448);
            this.pEstimateDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pEstimateDetails.Name = "pEstimateDetails";
            this.pEstimateDetails.Size = new System.Drawing.Size(1293, 925);
            this.pEstimateDetails.TabIndex = 3;
            // 
            // gbTravelDetails
            // 
            this.gbTravelDetails.Controls.Add(this.tableLayoutPanel2);
            this.gbTravelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTravelDetails.Location = new System.Drawing.Point(44, 21);
            this.gbTravelDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTravelDetails.Name = "gbTravelDetails";
            this.gbTravelDetails.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTravelDetails.Size = new System.Drawing.Size(1204, 323);
            this.gbTravelDetails.TabIndex = 3;
            this.gbTravelDetails.TabStop = false;
            this.gbTravelDetails.Text = "Travel Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54397F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.68212F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80132F));
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblReturnDate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTravelEvent, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTravelEvent, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTravelPurpose, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTravelPurpose, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTravelBudgeted, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTravelEstTotal, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEstimatedTotalValue, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpDepartureDateValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpReturnDateValue, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pTravelBudget, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDestination, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDestination, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMealsPerDiemRate, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtMealsPerDiemRate, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 37);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 275);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureDate.Location = new System.Drawing.Point(6, 24);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(203, 20);
            this.lblDepartureDate.TabIndex = 0;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.Location = new System.Drawing.Point(533, 24);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(238, 20);
            this.lblReturnDate.TabIndex = 1;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblTravelEvent
            // 
            this.lblTravelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelEvent.AutoSize = true;
            this.lblTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelEvent.Location = new System.Drawing.Point(6, 92);
            this.lblTravelEvent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelEvent.Name = "lblTravelEvent";
            this.lblTravelEvent.Size = new System.Drawing.Size(203, 20);
            this.lblTravelEvent.TabIndex = 4;
            this.lblTravelEvent.Text = "Travel Event:";
            // 
            // txtTravelEvent
            // 
            this.txtTravelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTravelEvent.Location = new System.Drawing.Point(221, 76);
            this.txtTravelEvent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTravelEvent.Multiline = true;
            this.txtTravelEvent.Name = "txtTravelEvent";
            this.txtTravelEvent.ReadOnly = true;
            this.txtTravelEvent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTravelEvent.Size = new System.Drawing.Size(300, 52);
            this.txtTravelEvent.TabIndex = 5;
            // 
            // lblTravelPurpose
            // 
            this.lblTravelPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelPurpose.AutoSize = true;
            this.lblTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelPurpose.Location = new System.Drawing.Point(533, 92);
            this.lblTravelPurpose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelPurpose.Name = "lblTravelPurpose";
            this.lblTravelPurpose.Size = new System.Drawing.Size(238, 20);
            this.lblTravelPurpose.TabIndex = 6;
            this.lblTravelPurpose.Text = "Travel Purpose:";
            // 
            // txtTravelPurpose
            // 
            this.txtTravelPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTravelPurpose.Location = new System.Drawing.Point(783, 76);
            this.txtTravelPurpose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTravelPurpose.Multiline = true;
            this.txtTravelPurpose.Name = "txtTravelPurpose";
            this.txtTravelPurpose.ReadOnly = true;
            this.txtTravelPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTravelPurpose.Size = new System.Drawing.Size(318, 52);
            this.txtTravelPurpose.TabIndex = 7;
            // 
            // lblTravelBudgeted
            // 
            this.lblTravelBudgeted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelBudgeted.AutoSize = true;
            this.lblTravelBudgeted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelBudgeted.Location = new System.Drawing.Point(6, 160);
            this.lblTravelBudgeted.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelBudgeted.Name = "lblTravelBudgeted";
            this.lblTravelBudgeted.Size = new System.Drawing.Size(203, 20);
            this.lblTravelBudgeted.TabIndex = 8;
            this.lblTravelBudgeted.Text = "Travel Budgeted:";
            // 
            // lblTravelEstTotal
            // 
            this.lblTravelEstTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelEstTotal.AutoSize = true;
            this.lblTravelEstTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelEstTotal.Location = new System.Drawing.Point(533, 160);
            this.lblTravelEstTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelEstTotal.Name = "lblTravelEstTotal";
            this.lblTravelEstTotal.Size = new System.Drawing.Size(238, 20);
            this.lblTravelEstTotal.TabIndex = 10;
            this.lblTravelEstTotal.Text = "Estimated Total:";
            // 
            // lblEstimatedTotalValue
            // 
            this.lblEstimatedTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstimatedTotalValue.AutoSize = true;
            this.lblEstimatedTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimatedTotalValue.Location = new System.Drawing.Point(783, 160);
            this.lblEstimatedTotalValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstimatedTotalValue.Name = "lblEstimatedTotalValue";
            this.lblEstimatedTotalValue.Size = new System.Drawing.Size(318, 20);
            this.lblEstimatedTotalValue.TabIndex = 11;
            // 
            // dtpDepartureDateValue
            // 
            this.dtpDepartureDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDateValue.Enabled = false;
            this.dtpDepartureDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDateValue.Location = new System.Drawing.Point(221, 21);
            this.dtpDepartureDateValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDepartureDateValue.Name = "dtpDepartureDateValue";
            this.dtpDepartureDateValue.Size = new System.Drawing.Size(300, 26);
            this.dtpDepartureDateValue.TabIndex = 12;
            this.dtpDepartureDateValue.ValueChanged += new System.EventHandler(this.dtpDepartureDateValue_ValueChanged);
            // 
            // dtpReturnDateValue
            // 
            this.dtpReturnDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnDateValue.Enabled = false;
            this.dtpReturnDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDateValue.Location = new System.Drawing.Point(783, 21);
            this.dtpReturnDateValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpReturnDateValue.Name = "dtpReturnDateValue";
            this.dtpReturnDateValue.Size = new System.Drawing.Size(318, 26);
            this.dtpReturnDateValue.TabIndex = 13;
            this.dtpReturnDateValue.ValueChanged += new System.EventHandler(this.dtpReturnDateValue_ValueChanged);
            // 
            // pTravelBudget
            // 
            this.pTravelBudget.Controls.Add(this.rbNo);
            this.pTravelBudget.Controls.Add(this.rbYes);
            this.pTravelBudget.Enabled = false;
            this.pTravelBudget.Location = new System.Drawing.Point(221, 142);
            this.pTravelBudget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pTravelBudget.Name = "pTravelBudget";
            this.pTravelBudget.Size = new System.Drawing.Size(300, 56);
            this.pTravelBudget.TabIndex = 14;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(185, 13);
            this.rbNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(57, 24);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(66, 13);
            this.rbYes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(65, 24);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(6, 229);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(203, 20);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "City / State:";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestination.Location = new System.Drawing.Point(221, 210);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDestination.Size = new System.Drawing.Size(300, 58);
            this.txtDestination.TabIndex = 16;
            // 
            // lblMealsPerDiemRate
            // 
            this.lblMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealsPerDiemRate.AutoSize = true;
            this.lblMealsPerDiemRate.Location = new System.Drawing.Point(533, 229);
            this.lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            this.lblMealsPerDiemRate.Size = new System.Drawing.Size(238, 20);
            this.lblMealsPerDiemRate.TabIndex = 17;
            this.lblMealsPerDiemRate.Text = "Meals Per Diem Rate:";
            // 
            // txtMealsPerDiemRate
            // 
            this.txtMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsPerDiemRate.Location = new System.Drawing.Point(783, 226);
            this.txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            this.txtMealsPerDiemRate.ReadOnly = true;
            this.txtMealsPerDiemRate.Size = new System.Drawing.Size(318, 26);
            this.txtMealsPerDiemRate.TabIndex = 18;
            this.txtMealsPerDiemRate.TextChanged += new System.EventHandler(this.txtMealsPerDiemRate_TextChanged);
            this.txtMealsPerDiemRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsPerDiemRate_KeyPress);
            // 
            // gbTravelItems
            // 
            this.gbTravelItems.Controls.Add(this.tableLayoutPanel3);
            this.gbTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTravelItems.Location = new System.Drawing.Point(44, 362);
            this.gbTravelItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTravelItems.Name = "gbTravelItems";
            this.gbTravelItems.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbTravelItems.Size = new System.Drawing.Size(1153, 542);
            this.gbTravelItems.TabIndex = 2;
            this.gbTravelItems.TabStop = false;
            this.gbTravelItems.Text = "Travel Items";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19217F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.72598F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.08185F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCost, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNotes, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMeals, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblRegistration, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblLodging, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCarRental, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblAirfare, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblMileage, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblOtherExpenses, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtMealsNotes, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtRegistrationNotes, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtLodgingNotes, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCarRentalNotes, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtAirfareNotes, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtMileageNotes, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtOtherExpNotes, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtMealsCost, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtRegistrationCost, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtLodgingCost, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCarRentalCost, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtAirfareCost, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtOtherExpensesCost, 1, 7);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 40);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1107, 483);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtMileageCost);
            this.panel2.Location = new System.Drawing.Point(185, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 48);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMileageCost
            // 
            this.txtMileageCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileageCost.Location = new System.Drawing.Point(62, 6);
            this.txtMileageCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMileageCost.Name = "txtMileageCost";
            this.txtMileageCost.ReadOnly = true;
            this.txtMileageCost.Size = new System.Drawing.Size(102, 26);
            this.txtMileageCost.TabIndex = 29;
            this.txtMileageCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileageCost_KeyPress);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(185, 20);
            this.lblCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(173, 20);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(370, 20);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(731, 20);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes";
            // 
            // lblMeals
            // 
            this.lblMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeals.AutoSize = true;
            this.lblMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeals.Location = new System.Drawing.Point(6, 80);
            this.lblMeals.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMeals.Name = "lblMeals";
            this.lblMeals.Size = new System.Drawing.Size(167, 20);
            this.lblMeals.TabIndex = 3;
            this.lblMeals.Text = "Meals";
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.Location = new System.Drawing.Point(6, 140);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(167, 20);
            this.lblRegistration.TabIndex = 4;
            this.lblRegistration.Text = "Registration";
            // 
            // lblLodging
            // 
            this.lblLodging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLodging.AutoSize = true;
            this.lblLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLodging.Location = new System.Drawing.Point(6, 200);
            this.lblLodging.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLodging.Name = "lblLodging";
            this.lblLodging.Size = new System.Drawing.Size(167, 20);
            this.lblLodging.TabIndex = 5;
            this.lblLodging.Text = "Lodging";
            // 
            // lblCarRental
            // 
            this.lblCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarRental.AutoSize = true;
            this.lblCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarRental.Location = new System.Drawing.Point(6, 260);
            this.lblCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarRental.Name = "lblCarRental";
            this.lblCarRental.Size = new System.Drawing.Size(167, 20);
            this.lblCarRental.TabIndex = 6;
            this.lblCarRental.Text = "Car Rental";
            // 
            // lblAirfare
            // 
            this.lblAirfare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirfare.AutoSize = true;
            this.lblAirfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAirfare.Location = new System.Drawing.Point(6, 320);
            this.lblAirfare.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAirfare.Name = "lblAirfare";
            this.lblAirfare.Size = new System.Drawing.Size(167, 20);
            this.lblAirfare.TabIndex = 7;
            this.lblAirfare.Text = "Airfare";
            // 
            // lblMileage
            // 
            this.lblMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(6, 380);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(167, 20);
            this.lblMileage.TabIndex = 8;
            this.lblMileage.Text = "Mileage";
            // 
            // lblOtherExpenses
            // 
            this.lblOtherExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherExpenses.AutoSize = true;
            this.lblOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtherExpenses.Location = new System.Drawing.Point(6, 441);
            this.lblOtherExpenses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOtherExpenses.Name = "lblOtherExpenses";
            this.lblOtherExpenses.Size = new System.Drawing.Size(167, 20);
            this.lblOtherExpenses.TabIndex = 9;
            this.lblOtherExpenses.Text = "Other Expenses";
            // 
            // txtMealsNotes
            // 
            this.txtMealsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsNotes.Location = new System.Drawing.Point(370, 68);
            this.txtMealsNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsNotes.Multiline = true;
            this.txtMealsNotes.Name = "txtMealsNotes";
            this.txtMealsNotes.ReadOnly = true;
            this.txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMealsNotes.Size = new System.Drawing.Size(731, 44);
            this.txtMealsNotes.TabIndex = 17;
            // 
            // txtRegistrationNotes
            // 
            this.txtRegistrationNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationNotes.Location = new System.Drawing.Point(370, 128);
            this.txtRegistrationNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegistrationNotes.Multiline = true;
            this.txtRegistrationNotes.Name = "txtRegistrationNotes";
            this.txtRegistrationNotes.ReadOnly = true;
            this.txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegistrationNotes.Size = new System.Drawing.Size(731, 44);
            this.txtRegistrationNotes.TabIndex = 18;
            // 
            // txtLodgingNotes
            // 
            this.txtLodgingNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingNotes.Location = new System.Drawing.Point(370, 188);
            this.txtLodgingNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLodgingNotes.Multiline = true;
            this.txtLodgingNotes.Name = "txtLodgingNotes";
            this.txtLodgingNotes.ReadOnly = true;
            this.txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLodgingNotes.Size = new System.Drawing.Size(731, 44);
            this.txtLodgingNotes.TabIndex = 19;
            // 
            // txtCarRentalNotes
            // 
            this.txtCarRentalNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalNotes.Location = new System.Drawing.Point(370, 248);
            this.txtCarRentalNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCarRentalNotes.Multiline = true;
            this.txtCarRentalNotes.Name = "txtCarRentalNotes";
            this.txtCarRentalNotes.ReadOnly = true;
            this.txtCarRentalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCarRentalNotes.Size = new System.Drawing.Size(731, 44);
            this.txtCarRentalNotes.TabIndex = 20;
            // 
            // txtAirfareNotes
            // 
            this.txtAirfareNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirfareNotes.Location = new System.Drawing.Point(370, 308);
            this.txtAirfareNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAirfareNotes.Multiline = true;
            this.txtAirfareNotes.Name = "txtAirfareNotes";
            this.txtAirfareNotes.ReadOnly = true;
            this.txtAirfareNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAirfareNotes.Size = new System.Drawing.Size(731, 44);
            this.txtAirfareNotes.TabIndex = 21;
            // 
            // txtMileageNotes
            // 
            this.txtMileageNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileageNotes.Location = new System.Drawing.Point(370, 368);
            this.txtMileageNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMileageNotes.Multiline = true;
            this.txtMileageNotes.Name = "txtMileageNotes";
            this.txtMileageNotes.ReadOnly = true;
            this.txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMileageNotes.Size = new System.Drawing.Size(731, 44);
            this.txtMileageNotes.TabIndex = 22;
            // 
            // txtOtherExpNotes
            // 
            this.txtOtherExpNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpNotes.Location = new System.Drawing.Point(370, 426);
            this.txtOtherExpNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOtherExpNotes.Multiline = true;
            this.txtOtherExpNotes.Name = "txtOtherExpNotes";
            this.txtOtherExpNotes.ReadOnly = true;
            this.txtOtherExpNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtherExpNotes.Size = new System.Drawing.Size(731, 50);
            this.txtOtherExpNotes.TabIndex = 23;
            // 
            // txtMealsCost
            // 
            this.txtMealsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsCost.Location = new System.Drawing.Point(185, 77);
            this.txtMealsCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsCost.Name = "txtMealsCost";
            this.txtMealsCost.ReadOnly = true;
            this.txtMealsCost.Size = new System.Drawing.Size(173, 26);
            this.txtMealsCost.TabIndex = 24;
            this.txtMealsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsCost_KeyPress);
            // 
            // txtRegistrationCost
            // 
            this.txtRegistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationCost.Location = new System.Drawing.Point(185, 137);
            this.txtRegistrationCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRegistrationCost.Name = "txtRegistrationCost";
            this.txtRegistrationCost.ReadOnly = true;
            this.txtRegistrationCost.Size = new System.Drawing.Size(173, 26);
            this.txtRegistrationCost.TabIndex = 25;
            this.txtRegistrationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationCost_KeyPress);
            // 
            // txtLodgingCost
            // 
            this.txtLodgingCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingCost.Location = new System.Drawing.Point(185, 197);
            this.txtLodgingCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLodgingCost.Name = "txtLodgingCost";
            this.txtLodgingCost.ReadOnly = true;
            this.txtLodgingCost.Size = new System.Drawing.Size(173, 26);
            this.txtLodgingCost.TabIndex = 26;
            this.txtLodgingCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLodgingCost_KeyPress);
            // 
            // txtCarRentalCost
            // 
            this.txtCarRentalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalCost.Location = new System.Drawing.Point(185, 257);
            this.txtCarRentalCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCarRentalCost.Name = "txtCarRentalCost";
            this.txtCarRentalCost.ReadOnly = true;
            this.txtCarRentalCost.Size = new System.Drawing.Size(173, 26);
            this.txtCarRentalCost.TabIndex = 27;
            this.txtCarRentalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarRentalCost_KeyPress);
            // 
            // txtAirfareCost
            // 
            this.txtAirfareCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirfareCost.Location = new System.Drawing.Point(185, 317);
            this.txtAirfareCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAirfareCost.Name = "txtAirfareCost";
            this.txtAirfareCost.ReadOnly = true;
            this.txtAirfareCost.Size = new System.Drawing.Size(173, 26);
            this.txtAirfareCost.TabIndex = 28;
            this.txtAirfareCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAirfareCost_KeyPress);
            // 
            // txtOtherExpensesCost
            // 
            this.txtOtherExpensesCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpensesCost.Location = new System.Drawing.Point(185, 438);
            this.txtOtherExpensesCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOtherExpensesCost.Name = "txtOtherExpensesCost";
            this.txtOtherExpensesCost.ReadOnly = true;
            this.txtOtherExpensesCost.Size = new System.Drawing.Size(173, 26);
            this.txtOtherExpensesCost.TabIndex = 30;
            this.txtOtherExpensesCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherExpensesCost_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNotifications);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.tlOptionButtons);
            this.panel1.Controls.Add(this.dgvAllEstimates);
            this.panel1.Location = new System.Drawing.Point(35, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 369);
            this.panel1.TabIndex = 5;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotifications.Location = new System.Drawing.Point(138, 47);
            this.lblNotifications.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(261, 20);
            this.lblNotifications.TabIndex = 5;
            this.lblNotifications.Text = "Sending Notification Emails....";
            this.lblNotifications.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(20, 40);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(42, 40);
            this.btnInfo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnInfo, "Select one travel authorization and then make a click on one of the options:");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1163, 1394);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 56);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(35, 1392);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 58);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // AllEstimates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 1465);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pEstimateDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AllEstimates";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Authorizations";
            this.Load += new System.EventHandler(this.AllEstimates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEstimates)).EndInit();
            this.tlOptionButtons.ResumeLayout(false);
            this.tlOptionButtons.PerformLayout();
            this.pEstimateDetails.ResumeLayout(false);
            this.gbTravelDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pTravelBudget.ResumeLayout(false);
            this.pTravelBudget.PerformLayout();
            this.gbTravelItems.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllEstimates;
        private System.Windows.Forms.TableLayoutPanel tlOptionButtons;
        private System.Windows.Forms.Button btnViewEstimate;
        private System.Windows.Forms.Button btnEstimatePDF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pEstimateDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.TextBox txtTravelEvent;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.TextBox txtTravelPurpose;
        private System.Windows.Forms.Label lblTravelBudgeted;
        private System.Windows.Forms.GroupBox gbTravelItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblMeals;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblLodging;
        private System.Windows.Forms.Label lblCarRental;
        private System.Windows.Forms.Label lblAirfare;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblOtherExpenses;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TextBox txtRegistrationNotes;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TextBox txtCarRentalNotes;
        private System.Windows.Forms.TextBox txtAirfareNotes;
        private System.Windows.Forms.TextBox txtMileageNotes;
        private System.Windows.Forms.TextBox txtOtherExpNotes;
        private System.Windows.Forms.Label lblTravelEstTotal;
        private System.Windows.Forms.Label lblEstimatedTotalValue;
        private System.Windows.Forms.GroupBox gbTravelDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateValue;
        private System.Windows.Forms.DateTimePicker dtpReturnDateValue;
        private System.Windows.Forms.Panel pTravelBudget;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtMealsCost;
        private System.Windows.Forms.TextBox txtRegistrationCost;
        private System.Windows.Forms.TextBox txtLodgingCost;
        private System.Windows.Forms.TextBox txtCarRentalCost;
        private System.Windows.Forms.TextBox txtAirfareCost;
        private System.Windows.Forms.TextBox txtMileageCost;
        private System.Windows.Forms.TextBox txtOtherExpensesCost;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BudgetedTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTravelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEstomatedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
    }
}