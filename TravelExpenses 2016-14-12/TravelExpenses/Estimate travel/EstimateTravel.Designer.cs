namespace TravelExpenses
{
    partial class EstimateTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateTravel));
            this.gbTravelDetails = new System.Windows.Forms.GroupBox();
            this.btnMealsPerHelp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPerDiemInfo = new System.Windows.Forms.Label();
            this.txtMealsPerDiem = new System.Windows.Forms.TextBox();
            this.lblPerDiem = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoBudgetedTravel = new System.Windows.Forms.RadioButton();
            this.rbYesBudgetedTravel = new System.Windows.Forms.RadioButton();
            this.lblBudgetedTravel = new System.Windows.Forms.Label();
            this.lblOtherPurpose = new System.Windows.Forms.Label();
            this.txtOtherPurpose = new System.Windows.Forms.TextBox();
            this.txtOtherEvent = new System.Windows.Forms.TextBox();
            this.lblOtherEvent = new System.Windows.Forms.Label();
            this.cbTravelPurpose = new System.Windows.Forms.ComboBox();
            this.lblTravelPurpose = new System.Windows.Forms.Label();
            this.cbTravelEvent = new System.Windows.Forms.ComboBox();
            this.lblTravelEvent = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.gbTravelItems = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chxMeals = new System.Windows.Forms.CheckBox();
            this.chxRegistration = new System.Windows.Forms.CheckBox();
            this.chxLodgings = new System.Windows.Forms.CheckBox();
            this.chxCarRental = new System.Windows.Forms.CheckBox();
            this.chxAirFare = new System.Windows.Forms.CheckBox();
            this.chxMileage = new System.Windows.Forms.CheckBox();
            this.chxOtherExpenses = new System.Windows.Forms.CheckBox();
            this.txtMealsCost = new System.Windows.Forms.TextBox();
            this.txtMealsNotes = new System.Windows.Forms.TextBox();
            this.txtRegistrationCost = new System.Windows.Forms.TextBox();
            this.txtRegistrationNotes = new System.Windows.Forms.TextBox();
            this.txtLodgingsCost = new System.Windows.Forms.TextBox();
            this.txtLodgingNotes = new System.Windows.Forms.TextBox();
            this.txtCarRentalCost = new System.Windows.Forms.TextBox();
            this.txtCarRentalNotes = new System.Windows.Forms.TextBox();
            this.txtAirFareCost = new System.Windows.Forms.TextBox();
            this.txtAirFareNotes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMileageCost = new System.Windows.Forms.TextBox();
            this.btnMileageCalculator = new System.Windows.Forms.Button();
            this.txtMileageNotes = new System.Windows.Forms.TextBox();
            this.txtOtherExpensesCost = new System.Windows.Forms.TextBox();
            this.txtOtherExpensesNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveEstimatedTravel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbTravelDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTravelItems.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTravelDetails
            // 
            this.gbTravelDetails.Controls.Add(this.btnMealsPerHelp);
            this.gbTravelDetails.Controls.Add(this.linkLabel1);
            this.gbTravelDetails.Controls.Add(this.lblPerDiemInfo);
            this.gbTravelDetails.Controls.Add(this.txtMealsPerDiem);
            this.gbTravelDetails.Controls.Add(this.lblPerDiem);
            this.gbTravelDetails.Controls.Add(this.txtDestination);
            this.gbTravelDetails.Controls.Add(this.lblDestination);
            this.gbTravelDetails.Controls.Add(this.panel2);
            this.gbTravelDetails.Controls.Add(this.lblOtherPurpose);
            this.gbTravelDetails.Controls.Add(this.txtOtherPurpose);
            this.gbTravelDetails.Controls.Add(this.txtOtherEvent);
            this.gbTravelDetails.Controls.Add(this.lblOtherEvent);
            this.gbTravelDetails.Controls.Add(this.cbTravelPurpose);
            this.gbTravelDetails.Controls.Add(this.lblTravelPurpose);
            this.gbTravelDetails.Controls.Add(this.cbTravelEvent);
            this.gbTravelDetails.Controls.Add(this.lblTravelEvent);
            this.gbTravelDetails.Controls.Add(this.dtpReturnDate);
            this.gbTravelDetails.Controls.Add(this.lblReturnDate);
            this.gbTravelDetails.Controls.Add(this.dtpDepartureDate);
            this.gbTravelDetails.Controls.Add(this.lblDepartureDate);
            this.gbTravelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTravelDetails.Location = new System.Drawing.Point(42, 79);
            this.gbTravelDetails.Margin = new System.Windows.Forms.Padding(6);
            this.gbTravelDetails.Name = "gbTravelDetails";
            this.gbTravelDetails.Padding = new System.Windows.Forms.Padding(6);
            this.gbTravelDetails.Size = new System.Drawing.Size(1122, 479);
            this.gbTravelDetails.TabIndex = 0;
            this.gbTravelDetails.TabStop = false;
            this.gbTravelDetails.Text = "Travel Details";
            // 
            // btnMealsPerHelp
            // 
            this.btnMealsPerHelp.FlatAppearance.BorderSize = 0;
            this.btnMealsPerHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealsPerHelp.Image = global::TravelExpenses.Properties.Resources.Help2;
            this.btnMealsPerHelp.Location = new System.Drawing.Point(962, 365);
            this.btnMealsPerHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnMealsPerHelp.Name = "btnMealsPerHelp";
            this.btnMealsPerHelp.Size = new System.Drawing.Size(66, 52);
            this.btnMealsPerHelp.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnMealsPerHelp, "Click here to see what you have to look for on the GSA page");
            this.btnMealsPerHelp.UseVisualStyleBackColor = true;
            this.btnMealsPerHelp.Click += new System.EventHandler(this.btnMealsPerHelp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(422, 419);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(447, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPerDiemInfo
            // 
            this.lblPerDiemInfo.AutoSize = true;
            this.lblPerDiemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPerDiemInfo.Location = new System.Drawing.Point(422, 379);
            this.lblPerDiemInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerDiemInfo.Name = "lblPerDiemInfo";
            this.lblPerDiemInfo.Size = new System.Drawing.Size(432, 22);
            this.lblPerDiemInfo.TabIndex = 17;
            this.lblPerDiemInfo.Text = "Check the Meals Per Diem Rate on the following link:";
            // 
            // txtMealsPerDiem
            // 
            this.txtMealsPerDiem.Location = new System.Drawing.Point(238, 406);
            this.txtMealsPerDiem.Margin = new System.Windows.Forms.Padding(6);
            this.txtMealsPerDiem.Name = "txtMealsPerDiem";
            this.txtMealsPerDiem.Size = new System.Drawing.Size(152, 26);
            this.txtMealsPerDiem.TabIndex = 16;
            this.txtMealsPerDiem.TextChanged += new System.EventHandler(this.txtMealsPerDiem_TextChanged);
            this.txtMealsPerDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsPerDiem_KeyPress);
            // 
            // lblPerDiem
            // 
            this.lblPerDiem.AutoSize = true;
            this.lblPerDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPerDiem.Location = new System.Drawing.Point(26, 412);
            this.lblPerDiem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerDiem.Name = "lblPerDiem";
            this.lblPerDiem.Size = new System.Drawing.Size(175, 20);
            this.lblPerDiem.TabIndex = 15;
            this.lblPerDiem.Text = "Meals Per Diem Rate:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(755, 304);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(6);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(332, 26);
            this.txtDestination.TabIndex = 14;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.Location = new System.Drawing.Point(566, 310);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(97, 20);
            this.lblDestination.TabIndex = 13;
            this.lblDestination.Text = "City / State:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNoBudgetedTravel);
            this.panel2.Controls.Add(this.rbYesBudgetedTravel);
            this.panel2.Controls.Add(this.lblBudgetedTravel);
            this.panel2.Location = new System.Drawing.Point(11, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 65);
            this.panel2.TabIndex = 12;
            // 
            // rbNoBudgetedTravel
            // 
            this.rbNoBudgetedTravel.AutoSize = true;
            this.rbNoBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoBudgetedTravel.Location = new System.Drawing.Point(418, 13);
            this.rbNoBudgetedTravel.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoBudgetedTravel.Name = "rbNoBudgetedTravel";
            this.rbNoBudgetedTravel.Size = new System.Drawing.Size(55, 24);
            this.rbNoBudgetedTravel.TabIndex = 2;
            this.rbNoBudgetedTravel.TabStop = true;
            this.rbNoBudgetedTravel.Text = "No";
            this.rbNoBudgetedTravel.UseVisualStyleBackColor = true;
            // 
            // rbYesBudgetedTravel
            // 
            this.rbYesBudgetedTravel.AutoSize = true;
            this.rbYesBudgetedTravel.Checked = true;
            this.rbYesBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbYesBudgetedTravel.Location = new System.Drawing.Point(330, 13);
            this.rbYesBudgetedTravel.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesBudgetedTravel.Name = "rbYesBudgetedTravel";
            this.rbYesBudgetedTravel.Size = new System.Drawing.Size(62, 24);
            this.rbYesBudgetedTravel.TabIndex = 1;
            this.rbYesBudgetedTravel.TabStop = true;
            this.rbYesBudgetedTravel.Text = "Yes";
            this.rbYesBudgetedTravel.UseVisualStyleBackColor = true;
            // 
            // lblBudgetedTravel
            // 
            this.lblBudgetedTravel.AutoSize = true;
            this.lblBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBudgetedTravel.Location = new System.Drawing.Point(15, 21);
            this.lblBudgetedTravel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBudgetedTravel.Name = "lblBudgetedTravel";
            this.lblBudgetedTravel.Size = new System.Drawing.Size(249, 20);
            this.lblBudgetedTravel.TabIndex = 0;
            this.lblBudgetedTravel.Text = "Was the travel event budgeted ?";
            // 
            // lblOtherPurpose
            // 
            this.lblOtherPurpose.AutoSize = true;
            this.lblOtherPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtherPurpose.Location = new System.Drawing.Point(566, 235);
            this.lblOtherPurpose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOtherPurpose.Name = "lblOtherPurpose";
            this.lblOtherPurpose.Size = new System.Drawing.Size(123, 20);
            this.lblOtherPurpose.TabIndex = 11;
            this.lblOtherPurpose.Text = "Other Purpose:";
            // 
            // txtOtherPurpose
            // 
            this.txtOtherPurpose.Enabled = false;
            this.txtOtherPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOtherPurpose.Location = new System.Drawing.Point(755, 221);
            this.txtOtherPurpose.Margin = new System.Windows.Forms.Padding(6);
            this.txtOtherPurpose.Multiline = true;
            this.txtOtherPurpose.Name = "txtOtherPurpose";
            this.txtOtherPurpose.Size = new System.Drawing.Size(332, 35);
            this.txtOtherPurpose.TabIndex = 10;
            // 
            // txtOtherEvent
            // 
            this.txtOtherEvent.Enabled = false;
            this.txtOtherEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOtherEvent.Location = new System.Drawing.Point(189, 221);
            this.txtOtherEvent.Margin = new System.Windows.Forms.Padding(6);
            this.txtOtherEvent.Multiline = true;
            this.txtOtherEvent.Name = "txtOtherEvent";
            this.txtOtherEvent.Size = new System.Drawing.Size(332, 35);
            this.txtOtherEvent.TabIndex = 9;
            // 
            // lblOtherEvent
            // 
            this.lblOtherEvent.AutoSize = true;
            this.lblOtherEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtherEvent.Location = new System.Drawing.Point(26, 235);
            this.lblOtherEvent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOtherEvent.Name = "lblOtherEvent";
            this.lblOtherEvent.Size = new System.Drawing.Size(103, 20);
            this.lblOtherEvent.TabIndex = 8;
            this.lblOtherEvent.Text = "Other Event:";
            // 
            // cbTravelPurpose
            // 
            this.cbTravelPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTravelPurpose.FormattingEnabled = true;
            this.cbTravelPurpose.Items.AddRange(new object[] {
            "Training",
            "Professional",
            "Industry-related",
            "Work outside district",
            "Seminar",
            "Workshops",
            "Other"});
            this.cbTravelPurpose.Location = new System.Drawing.Point(755, 135);
            this.cbTravelPurpose.Margin = new System.Windows.Forms.Padding(6);
            this.cbTravelPurpose.Name = "cbTravelPurpose";
            this.cbTravelPurpose.Size = new System.Drawing.Size(332, 28);
            this.cbTravelPurpose.TabIndex = 7;
            this.cbTravelPurpose.SelectedIndexChanged += new System.EventHandler(this.cbTravelPurpose_SelectedIndexChanged);
            // 
            // lblTravelPurpose
            // 
            this.lblTravelPurpose.AutoSize = true;
            this.lblTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTravelPurpose.Location = new System.Drawing.Point(566, 150);
            this.lblTravelPurpose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelPurpose.Name = "lblTravelPurpose";
            this.lblTravelPurpose.Size = new System.Drawing.Size(127, 20);
            this.lblTravelPurpose.TabIndex = 6;
            this.lblTravelPurpose.Text = "Travel Purpose:";
            // 
            // cbTravelEvent
            // 
            this.cbTravelEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTravelEvent.FormattingEnabled = true;
            this.cbTravelEvent.Items.AddRange(new object[] {
            "FMCA Aerial Fly In",
            "AMCA Annual Meeting",
            "FMCA Annual Meeting",
            "FASD Annual Meeting",
            "Chemical Response Training",
            "FMCA Legislative",
            "AMCA Legislative",
            "FGFOA Accounting",
            "FMCA Dodd Short Course",
            "FASD Legislative",
            "FRS Training",
            "Aquatic Weed Shortcourse",
            "FAPMS",
            "APMS",
            "SFAPMS",
            "FLMS",
            "CHNEP",
            "Other"});
            this.cbTravelEvent.Location = new System.Drawing.Point(189, 135);
            this.cbTravelEvent.Margin = new System.Windows.Forms.Padding(6);
            this.cbTravelEvent.Name = "cbTravelEvent";
            this.cbTravelEvent.Size = new System.Drawing.Size(332, 28);
            this.cbTravelEvent.TabIndex = 5;
            this.cbTravelEvent.SelectedIndexChanged += new System.EventHandler(this.cbTravelEvent_SelectedIndexChanged);
            // 
            // lblTravelEvent
            // 
            this.lblTravelEvent.AutoSize = true;
            this.lblTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTravelEvent.Location = new System.Drawing.Point(26, 150);
            this.lblTravelEvent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTravelEvent.Name = "lblTravelEvent";
            this.lblTravelEvent.Size = new System.Drawing.Size(107, 20);
            this.lblTravelEvent.TabIndex = 4;
            this.lblTravelEvent.Text = "Travel Event:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(755, 58);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(224, 26);
            this.dtpReturnDate.TabIndex = 3;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.Location = new System.Drawing.Point(566, 69);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(105, 20);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(189, 58);
            this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(211, 26);
            this.dtpDepartureDate.TabIndex = 1;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureDate.Location = new System.Drawing.Point(26, 69);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(130, 20);
            this.lblDepartureDate.TabIndex = 0;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // gbTravelItems
            // 
            this.gbTravelItems.Controls.Add(this.tableLayoutPanel1);
            this.gbTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTravelItems.Location = new System.Drawing.Point(42, 602);
            this.gbTravelItems.Margin = new System.Windows.Forms.Padding(6);
            this.gbTravelItems.Name = "gbTravelItems";
            this.gbTravelItems.Padding = new System.Windows.Forms.Padding(6);
            this.gbTravelItems.Size = new System.Drawing.Size(1122, 602);
            this.gbTravelItems.TabIndex = 1;
            this.gbTravelItems.TabStop = false;
            this.gbTravelItems.Text = "Travel Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 656F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNotes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxMeals, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chxRegistration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chxLodgings, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chxCarRental, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chxAirFare, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chxMileage, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.chxOtherExpenses, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsNotes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationCost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationNotes, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLodgingsCost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLodgingNotes, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCarRentalCost, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCarRentalNotes, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAirFareCost, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAirFareNotes, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMileageNotes, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherExpensesCost, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherExpensesNotes, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(182, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(200, 23);
            this.lblCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(197, 20);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(409, 23);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(645, 20);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chxMeals
            // 
            this.chxMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMeals.AutoSize = true;
            this.chxMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxMeals.Location = new System.Drawing.Point(6, 87);
            this.chxMeals.Margin = new System.Windows.Forms.Padding(6);
            this.chxMeals.Name = "chxMeals";
            this.chxMeals.Size = new System.Drawing.Size(182, 24);
            this.chxMeals.TabIndex = 3;
            this.chxMeals.Text = "Meals";
            this.chxMeals.UseVisualStyleBackColor = true;
            this.chxMeals.CheckedChanged += new System.EventHandler(this.chxMeals_CheckedChanged);
            // 
            // chxRegistration
            // 
            this.chxRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxRegistration.AutoSize = true;
            this.chxRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxRegistration.Location = new System.Drawing.Point(6, 153);
            this.chxRegistration.Margin = new System.Windows.Forms.Padding(6);
            this.chxRegistration.Name = "chxRegistration";
            this.chxRegistration.Size = new System.Drawing.Size(182, 24);
            this.chxRegistration.TabIndex = 4;
            this.chxRegistration.Text = "Registration";
            this.chxRegistration.UseVisualStyleBackColor = true;
            this.chxRegistration.CheckedChanged += new System.EventHandler(this.chxRegistration_CheckedChanged);
            // 
            // chxLodgings
            // 
            this.chxLodgings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxLodgings.AutoSize = true;
            this.chxLodgings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxLodgings.Location = new System.Drawing.Point(6, 219);
            this.chxLodgings.Margin = new System.Windows.Forms.Padding(6);
            this.chxLodgings.Name = "chxLodgings";
            this.chxLodgings.Size = new System.Drawing.Size(182, 24);
            this.chxLodgings.TabIndex = 5;
            this.chxLodgings.Text = "Lodging";
            this.chxLodgings.UseVisualStyleBackColor = true;
            this.chxLodgings.CheckedChanged += new System.EventHandler(this.chxLodgings_CheckedChanged);
            // 
            // chxCarRental
            // 
            this.chxCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxCarRental.AutoSize = true;
            this.chxCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxCarRental.Location = new System.Drawing.Point(6, 285);
            this.chxCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.chxCarRental.Name = "chxCarRental";
            this.chxCarRental.Size = new System.Drawing.Size(182, 24);
            this.chxCarRental.TabIndex = 6;
            this.chxCarRental.Text = "Car Rental";
            this.chxCarRental.UseVisualStyleBackColor = true;
            this.chxCarRental.CheckedChanged += new System.EventHandler(this.chxCarRental_CheckedChanged);
            // 
            // chxAirFare
            // 
            this.chxAirFare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxAirFare.AutoSize = true;
            this.chxAirFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxAirFare.Location = new System.Drawing.Point(6, 351);
            this.chxAirFare.Margin = new System.Windows.Forms.Padding(6);
            this.chxAirFare.Name = "chxAirFare";
            this.chxAirFare.Size = new System.Drawing.Size(182, 24);
            this.chxAirFare.TabIndex = 7;
            this.chxAirFare.Text = "Airfare";
            this.chxAirFare.UseVisualStyleBackColor = true;
            this.chxAirFare.CheckedChanged += new System.EventHandler(this.chxAirFare_CheckedChanged);
            // 
            // chxMileage
            // 
            this.chxMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMileage.AutoSize = true;
            this.chxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxMileage.Location = new System.Drawing.Point(6, 417);
            this.chxMileage.Margin = new System.Windows.Forms.Padding(6);
            this.chxMileage.Name = "chxMileage";
            this.chxMileage.Size = new System.Drawing.Size(182, 24);
            this.chxMileage.TabIndex = 8;
            this.chxMileage.Text = "Mileage";
            this.chxMileage.UseVisualStyleBackColor = true;
            this.chxMileage.CheckedChanged += new System.EventHandler(this.chxMileage_CheckedChanged);
            // 
            // chxOtherExpenses
            // 
            this.chxOtherExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxOtherExpenses.AutoSize = true;
            this.chxOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxOtherExpenses.Location = new System.Drawing.Point(6, 485);
            this.chxOtherExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.chxOtherExpenses.Name = "chxOtherExpenses";
            this.chxOtherExpenses.Size = new System.Drawing.Size(182, 24);
            this.chxOtherExpenses.TabIndex = 9;
            this.chxOtherExpenses.Text = "Other Expenses";
            this.chxOtherExpenses.UseVisualStyleBackColor = true;
            this.chxOtherExpenses.CheckedChanged += new System.EventHandler(this.chxOtherExpenses_CheckedChanged);
            // 
            // txtMealsCost
            // 
            this.txtMealsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsCost.Enabled = false;
            this.txtMealsCost.Location = new System.Drawing.Point(200, 86);
            this.txtMealsCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtMealsCost.Name = "txtMealsCost";
            this.txtMealsCost.Size = new System.Drawing.Size(197, 26);
            this.txtMealsCost.TabIndex = 10;
            this.txtMealsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsCost_KeyPress);
            // 
            // txtMealsNotes
            // 
            this.txtMealsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsNotes.Enabled = false;
            this.txtMealsNotes.Location = new System.Drawing.Point(409, 74);
            this.txtMealsNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtMealsNotes.Multiline = true;
            this.txtMealsNotes.Name = "txtMealsNotes";
            this.txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMealsNotes.Size = new System.Drawing.Size(645, 50);
            this.txtMealsNotes.TabIndex = 11;
            // 
            // txtRegistrationCost
            // 
            this.txtRegistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationCost.Enabled = false;
            this.txtRegistrationCost.Location = new System.Drawing.Point(200, 152);
            this.txtRegistrationCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtRegistrationCost.Name = "txtRegistrationCost";
            this.txtRegistrationCost.Size = new System.Drawing.Size(197, 26);
            this.txtRegistrationCost.TabIndex = 12;
            this.txtRegistrationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationCost_KeyPress);
            // 
            // txtRegistrationNotes
            // 
            this.txtRegistrationNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationNotes.Enabled = false;
            this.txtRegistrationNotes.Location = new System.Drawing.Point(409, 140);
            this.txtRegistrationNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtRegistrationNotes.Multiline = true;
            this.txtRegistrationNotes.Name = "txtRegistrationNotes";
            this.txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegistrationNotes.Size = new System.Drawing.Size(645, 50);
            this.txtRegistrationNotes.TabIndex = 13;
            // 
            // txtLodgingsCost
            // 
            this.txtLodgingsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingsCost.Enabled = false;
            this.txtLodgingsCost.Location = new System.Drawing.Point(200, 218);
            this.txtLodgingsCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtLodgingsCost.Name = "txtLodgingsCost";
            this.txtLodgingsCost.Size = new System.Drawing.Size(197, 26);
            this.txtLodgingsCost.TabIndex = 14;
            this.txtLodgingsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLodgingsCost_KeyPress);
            // 
            // txtLodgingNotes
            // 
            this.txtLodgingNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingNotes.Enabled = false;
            this.txtLodgingNotes.Location = new System.Drawing.Point(409, 206);
            this.txtLodgingNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtLodgingNotes.Multiline = true;
            this.txtLodgingNotes.Name = "txtLodgingNotes";
            this.txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLodgingNotes.Size = new System.Drawing.Size(645, 50);
            this.txtLodgingNotes.TabIndex = 15;
            // 
            // txtCarRentalCost
            // 
            this.txtCarRentalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalCost.Enabled = false;
            this.txtCarRentalCost.Location = new System.Drawing.Point(200, 284);
            this.txtCarRentalCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtCarRentalCost.Name = "txtCarRentalCost";
            this.txtCarRentalCost.Size = new System.Drawing.Size(197, 26);
            this.txtCarRentalCost.TabIndex = 16;
            this.txtCarRentalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarRentalCost_KeyPress);
            // 
            // txtCarRentalNotes
            // 
            this.txtCarRentalNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalNotes.Enabled = false;
            this.txtCarRentalNotes.Location = new System.Drawing.Point(409, 272);
            this.txtCarRentalNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtCarRentalNotes.Multiline = true;
            this.txtCarRentalNotes.Name = "txtCarRentalNotes";
            this.txtCarRentalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarRentalNotes.Size = new System.Drawing.Size(645, 50);
            this.txtCarRentalNotes.TabIndex = 17;
            // 
            // txtAirFareCost
            // 
            this.txtAirFareCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirFareCost.Enabled = false;
            this.txtAirFareCost.Location = new System.Drawing.Point(200, 350);
            this.txtAirFareCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtAirFareCost.Name = "txtAirFareCost";
            this.txtAirFareCost.Size = new System.Drawing.Size(197, 26);
            this.txtAirFareCost.TabIndex = 18;
            this.txtAirFareCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAirFareCost_KeyPress);
            // 
            // txtAirFareNotes
            // 
            this.txtAirFareNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirFareNotes.Enabled = false;
            this.txtAirFareNotes.Location = new System.Drawing.Point(409, 338);
            this.txtAirFareNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtAirFareNotes.Multiline = true;
            this.txtAirFareNotes.Name = "txtAirFareNotes";
            this.txtAirFareNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAirFareNotes.Size = new System.Drawing.Size(645, 50);
            this.txtAirFareNotes.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtMileageCost);
            this.panel1.Controls.Add(this.btnMileageCalculator);
            this.panel1.Location = new System.Drawing.Point(194, 396);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 66);
            this.panel1.TabIndex = 21;
            // 
            // txtMileageCost
            // 
            this.txtMileageCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMileageCost.Enabled = false;
            this.txtMileageCost.Location = new System.Drawing.Point(67, 17);
            this.txtMileageCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtMileageCost.Name = "txtMileageCost";
            this.txtMileageCost.ReadOnly = true;
            this.txtMileageCost.Size = new System.Drawing.Size(133, 26);
            this.txtMileageCost.TabIndex = 21;
            // 
            // btnMileageCalculator
            // 
            this.btnMileageCalculator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMileageCalculator.Enabled = false;
            this.btnMileageCalculator.Location = new System.Drawing.Point(6, 7);
            this.btnMileageCalculator.Margin = new System.Windows.Forms.Padding(0);
            this.btnMileageCalculator.Name = "btnMileageCalculator";
            this.btnMileageCalculator.Size = new System.Drawing.Size(55, 48);
            this.btnMileageCalculator.TabIndex = 20;
            this.btnMileageCalculator.Text = "+";
            this.btnMileageCalculator.UseVisualStyleBackColor = true;
            this.btnMileageCalculator.Click += new System.EventHandler(this.btnMileageCalculator_Click);
            // 
            // txtMileageNotes
            // 
            this.txtMileageNotes.Enabled = false;
            this.txtMileageNotes.Location = new System.Drawing.Point(409, 402);
            this.txtMileageNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtMileageNotes.Multiline = true;
            this.txtMileageNotes.Name = "txtMileageNotes";
            this.txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMileageNotes.Size = new System.Drawing.Size(616, 50);
            this.txtMileageNotes.TabIndex = 22;
            // 
            // txtOtherExpensesCost
            // 
            this.txtOtherExpensesCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpensesCost.Enabled = false;
            this.txtOtherExpensesCost.Location = new System.Drawing.Point(200, 484);
            this.txtOtherExpensesCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtOtherExpensesCost.Name = "txtOtherExpensesCost";
            this.txtOtherExpensesCost.Size = new System.Drawing.Size(197, 26);
            this.txtOtherExpensesCost.TabIndex = 23;
            this.txtOtherExpensesCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherExpensesCost_KeyPress);
            // 
            // txtOtherExpensesNotes
            // 
            this.txtOtherExpensesNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpensesNotes.Enabled = false;
            this.txtOtherExpensesNotes.Location = new System.Drawing.Point(409, 472);
            this.txtOtherExpensesNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtOtherExpensesNotes.Multiline = true;
            this.txtOtherExpensesNotes.Name = "txtOtherExpensesNotes";
            this.txtOtherExpensesNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOtherExpensesNotes.Size = new System.Drawing.Size(645, 50);
            this.txtOtherExpensesNotes.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveEstimatedTravel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1001, 1223);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 98);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSaveEstimatedTravel
            // 
            this.btnSaveEstimatedTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveEstimatedTravel.FlatAppearance.BorderSize = 0;
            this.btnSaveEstimatedTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEstimatedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveEstimatedTravel.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEstimatedTravel.Image")));
            this.btnSaveEstimatedTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEstimatedTravel.Location = new System.Drawing.Point(31, 13);
            this.btnSaveEstimatedTravel.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveEstimatedTravel.Name = "btnSaveEstimatedTravel";
            this.btnSaveEstimatedTravel.Size = new System.Drawing.Size(106, 71);
            this.btnSaveEstimatedTravel.TabIndex = 0;
            this.btnSaveEstimatedTravel.Text = "Save";
            this.btnSaveEstimatedTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveEstimatedTravel.UseVisualStyleBackColor = true;
            this.btnSaveEstimatedTravel.Click += new System.EventHandler(this.btnSaveEstimatedTravel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(42, 1240);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 71);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EstimateTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 1342);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbTravelItems);
            this.Controls.Add(this.gbTravelDetails);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EstimateTravel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Authorization";
            this.Load += new System.EventHandler(this.EstimateTravel_Load);
            this.gbTravelDetails.ResumeLayout(false);
            this.gbTravelDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTravelItems.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTravelDetails;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.ComboBox cbTravelEvent;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.ComboBox cbTravelPurpose;
        private System.Windows.Forms.Label lblOtherEvent;
        private System.Windows.Forms.TextBox txtOtherEvent;
        private System.Windows.Forms.TextBox txtOtherPurpose;
        private System.Windows.Forms.Label lblOtherPurpose;
        private System.Windows.Forms.GroupBox gbTravelItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox chxMeals;
        private System.Windows.Forms.CheckBox chxRegistration;
        private System.Windows.Forms.CheckBox chxLodgings;
        private System.Windows.Forms.CheckBox chxCarRental;
        private System.Windows.Forms.CheckBox chxAirFare;
        private System.Windows.Forms.CheckBox chxMileage;
        private System.Windows.Forms.CheckBox chxOtherExpenses;
        private System.Windows.Forms.TextBox txtMealsCost;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TextBox txtRegistrationCost;
        private System.Windows.Forms.TextBox txtRegistrationNotes;
        private System.Windows.Forms.TextBox txtLodgingsCost;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TextBox txtCarRentalCost;
        private System.Windows.Forms.TextBox txtCarRentalNotes;
        private System.Windows.Forms.TextBox txtAirFareCost;
        private System.Windows.Forms.TextBox txtAirFareNotes;
        private System.Windows.Forms.Button btnMileageCalculator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMileageCost;
        private System.Windows.Forms.TextBox txtMileageNotes;
        private System.Windows.Forms.TextBox txtOtherExpensesCost;
        private System.Windows.Forms.TextBox txtOtherExpensesNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSaveEstimatedTravel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoBudgetedTravel;
        private System.Windows.Forms.RadioButton rbYesBudgetedTravel;
        private System.Windows.Forms.Label lblBudgetedTravel;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPerDiemInfo;
        private System.Windows.Forms.TextBox txtMealsPerDiem;
        private System.Windows.Forms.Label lblPerDiem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMealsPerHelp;
    }
}