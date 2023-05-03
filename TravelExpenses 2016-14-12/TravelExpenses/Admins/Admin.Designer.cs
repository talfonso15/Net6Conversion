namespace TravelExpenses
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblShowBy = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.cbtravels = new System.Windows.Forms.ComboBox();
            this.pnCriteria = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvTravels = new System.Windows.Forms.DataGridView();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountingApproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnAccAprr = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnCriteria.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.33417F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmployee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblShowBy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDepartments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartments, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbtravels, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(6, 70);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(295, 22);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Select Employee:";
            this.lblEmployee.Visible = false;
            // 
            // lblShowBy
            // 
            this.lblShowBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowBy.AutoSize = true;
            this.lblShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShowBy.Location = new System.Drawing.Point(6, 14);
            this.lblShowBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowBy.Name = "lblShowBy";
            this.lblShowBy.Size = new System.Drawing.Size(295, 25);
            this.lblShowBy.TabIndex = 0;
            this.lblShowBy.Text = "Show travels by:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(313, 66);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(594, 30);
            this.cbEmployee.TabIndex = 3;
            this.cbEmployee.Visible = false;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // lblDepartments
            // 
            this.lblDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartments.Location = new System.Drawing.Point(6, 128);
            this.lblDepartments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(295, 22);
            this.lblDepartments.TabIndex = 4;
            this.lblDepartments.Text = "Select Department:";
            this.lblDepartments.Visible = false;
            // 
            // cbDepartments
            // 
            this.cbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Items.AddRange(new object[] {
            "Accounting/Purchasing 101",
            "Air/Flee/Bldg & Grounds 102",
            "Educ & Communication 103",
            "Executive 104",
            "Field Validation 105",
            "Mosquito Group 106",
            "Pilots 107",
            "Scientific Intelligence 108",
            "Hyacinth",
            "Commissioners"});
            this.cbDepartments.Location = new System.Drawing.Point(313, 122);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(6);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(594, 33);
            this.cbDepartments.TabIndex = 5;
            this.cbDepartments.Visible = false;
            // 
            // cbtravels
            // 
            this.cbtravels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtravels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbtravels.FormattingEnabled = true;
            this.cbtravels.Items.AddRange(new object[] {
            "All",
            "Department",
            "Employee",
            "Department + Date Range",
            "Employee + Date Range"});
            this.cbtravels.Location = new System.Drawing.Point(313, 11);
            this.cbtravels.Margin = new System.Windows.Forms.Padding(6);
            this.cbtravels.Name = "cbtravels";
            this.cbtravels.Size = new System.Drawing.Size(594, 30);
            this.cbtravels.TabIndex = 1;
            this.cbtravels.SelectedIndexChanged += new System.EventHandler(this.cbtravels_SelectedIndexChanged);
            // 
            // pnCriteria
            // 
            this.pnCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCriteria.Controls.Add(this.tableLayoutPanel4);
            this.pnCriteria.Controls.Add(this.tableLayoutPanel1);
            this.pnCriteria.Controls.Add(this.btnShow);
            this.pnCriteria.Location = new System.Drawing.Point(22, 15);
            this.pnCriteria.Margin = new System.Windows.Forms.Padding(6);
            this.pnCriteria.Name = "pnCriteria";
            this.pnCriteria.Size = new System.Drawing.Size(1155, 246);
            this.pnCriteria.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54321F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45679F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel4.Controls.Add(this.lblDateRange, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpStartDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTo, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpEndDate, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 183);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(913, 58);
            this.tableLayoutPanel4.TabIndex = 5;
            this.tableLayoutPanel4.Visible = false;
            // 
            // lblDateRange
            // 
            this.lblDateRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateRange.Location = new System.Drawing.Point(6, 19);
            this.lblDateRange.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(256, 20);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Date Range:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(274, 12);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(240, 33);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(526, 16);
            this.lblTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(43, 25);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(581, 12);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(326, 33);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(1086, 176);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(61, 62);
            this.btnShow.TabIndex = 2;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvTravels
            // 
            this.dgvTravels.AllowUserToAddRows = false;
            this.dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.TravelEvent,
            this.TravelPurpose,
            this.Status,
            this.Origin,
            this.Destination,
            this.Total,
            this.TravelID,
            this.UserID,
            this.Username,
            this.AccountingApproval});
            this.dgvTravels.Location = new System.Drawing.Point(26, 115);
            this.dgvTravels.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTravels.MultiSelect = false;
            this.dgvTravels.Name = "dgvTravels";
            this.dgvTravels.ReadOnly = true;
            this.dgvTravels.RowHeadersWidth = 62;
            this.dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravels.Size = new System.Drawing.Size(1564, 615);
            this.dgvTravels.TabIndex = 2;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure";
            this.DepartureDate.MinimumWidth = 8;
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 110;
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
            this.TravelEvent.Width = 250;
            // 
            // TravelPurpose
            // 
            this.TravelPurpose.HeaderText = "Purpose";
            this.TravelPurpose.MinimumWidth = 8;
            this.TravelPurpose.Name = "TravelPurpose";
            this.TravelPurpose.ReadOnly = true;
            this.TravelPurpose.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.MinimumWidth = 8;
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Width = 150;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 8;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 70;
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
            // Username
            // 
            this.Username.HeaderText = "User";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            this.Username.Width = 150;
            // 
            // AccountingApproval
            // 
            this.AccountingApproval.HeaderText = "Approved";
            this.AccountingApproval.MinimumWidth = 8;
            this.AccountingApproval.Name = "AccountingApproval";
            this.AccountingApproval.ReadOnly = true;
            this.AccountingApproval.Visible = false;
            this.AccountingApproval.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDF, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAccAprr, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnView, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDelete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFinalize, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(752, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 87);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(332, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(6, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 75);
            this.btnDelete.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Travel");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(182, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(50, 75);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPDF, "Create PDF");
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnAccAprr
            // 
            this.btnAccAprr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccAprr.FlatAppearance.BorderSize = 0;
            this.btnAccAprr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccAprr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccAprr.Image = ((System.Drawing.Image)(resources.GetObject("btnAccAprr.Image")));
            this.btnAccAprr.Location = new System.Drawing.Point(270, 6);
            this.btnAccAprr.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccAprr.Name = "btnAccAprr";
            this.btnAccAprr.Size = new System.Drawing.Size(50, 75);
            this.btnAccAprr.TabIndex = 6;
            this.btnAccAprr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAccAprr, "Accounting Approval");
            this.btnAccAprr.UseVisualStyleBackColor = true;
            this.btnAccAprr.Click += new System.EventHandler(this.btnAccAprr_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(358, 6);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(57, 75);
            this.btnView.TabIndex = 0;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnView, "View Travel Details");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDelete.Location = new System.Drawing.Point(68, 32);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(14, 22);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "|";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Visible = false;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalize.FlatAppearance.BorderSize = 0;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalize.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalize.Image")));
            this.btnFinalize.Location = new System.Drawing.Point(94, 6);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(50, 75);
            this.btnFinalize.TabIndex = 2;
            this.btnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnFinalize, "Archive travel");
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dgvTravels);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(22, 275);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1624, 769);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44509F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44509F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44509F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44231F));
            this.tableLayoutPanel3.Controls.Add(this.btnEdit, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSendEmails, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnHide, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1173, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 87);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(133, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 75);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit Travel");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "|";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(341, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 75);
            this.btnCancel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancel, "Close");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(318, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendEmails.Enabled = false;
            this.btnSendEmails.FlatAppearance.BorderSize = 0;
            this.btnSendEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmails.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmails.Image")));
            this.btnSendEmails.Location = new System.Drawing.Point(29, 6);
            this.btnSendEmails.Margin = new System.Windows.Forms.Padding(6);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(69, 75);
            this.btnSendEmails.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSendEmails, "Send Notification Email to Employee");
            this.btnSendEmails.UseVisualStyleBackColor = true;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(237, 6);
            this.btnHide.Margin = new System.Windows.Forms.Padding(6);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(69, 75);
            this.btnHide.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnHide, "Hide/Show Approved Travels");
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(214, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "|";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(112, 63);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(266, 20);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Sending Notification Emails.....";
            this.lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Admin
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1037);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCriteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnCriteria.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShowBy;
        private System.Windows.Forms.ComboBox cbtravels;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnCriteria;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccAprr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountingApproval;
    }
}