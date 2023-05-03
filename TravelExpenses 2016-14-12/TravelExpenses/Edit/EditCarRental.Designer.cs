namespace TravelExpenses
{
    partial class EditCarRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCarRental));
            this.dgvEditCar = new System.Windows.Forms.DataGridView();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarCostperDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDWInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplementalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraInsurance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExtraInsuranceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalIssues = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalIssuesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarRentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlEditButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelEditCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.pCarData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pPersonalIssuesAmount = new System.Windows.Forms.Panel();
            this.txtPersonalUseAmount = new System.Windows.Forms.TextBox();
            this.lblPersonalIssuesAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoPersonalIssues = new System.Windows.Forms.RadioButton();
            this.rbYesPeronalIssues = new System.Windows.Forms.RadioButton();
            this.lblPesonalIssues = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            this.lblDistrictPay = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblDropOffDate = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblRentalCompany = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblCarCost = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDropOffDate = new System.Windows.Forms.DateTimePicker();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.cbRentalCompany = new System.Windows.Forms.ComboBox();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.txtCarCost = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalCar = new System.Windows.Forms.TextBox();
            this.lblTaxesAndFees = new System.Windows.Forms.Label();
            this.txtExtraInsuranceAmount = new System.Windows.Forms.TextBox();
            this.lblExtraInsuranceAmount = new System.Windows.Forms.Label();
            this.chxExtraInsurance = new System.Windows.Forms.CheckBox();
            this.lblExtraInsurance = new System.Windows.Forms.Label();
            this.txtTaxesAndFees = new System.Windows.Forms.TextBox();
            this.txtSupplementalInsurance = new System.Windows.Forms.TextBox();
            this.lblSupplementalInsurance = new System.Windows.Forms.Label();
            this.lblLDWInsurance = new System.Windows.Forms.Label();
            this.txtLDWInsurance = new System.Windows.Forms.TextBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCar)).BeginInit();
            this.tlEditButtons.SuspendLayout();
            this.pCarData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pPersonalIssuesAmount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditCar
            // 
            this.dgvEditCar.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PickUpDate,
            this.DropOffDate,
            this.CarCostperDay,
            this.DistrictPay,
            this.Total,
            this.CarType,
            this.RentalCompany,
            this.Days,
            this.TaxesAndFees,
            this.LDWInsurance,
            this.SupplementalInsurance,
            this.ExtraInsurance,
            this.ExtraInsuranceAmount,
            this.PersonalIssues,
            this.PersonalIssuesAmount,
            this.CarRentalID,
            this.Notes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditCar.Location = new System.Drawing.Point(32, 86);
            this.dgvEditCar.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEditCar.Name = "dgvEditCar";
            this.dgvEditCar.ReadOnly = true;
            this.dgvEditCar.RowHeadersWidth = 62;
            this.dgvEditCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditCar.Size = new System.Drawing.Size(1126, 224);
            this.dgvEditCar.TabIndex = 0;
            this.dgvEditCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditCar_CellContentClick);
            // 
            // PickUpDate
            // 
            this.PickUpDate.HeaderText = "Pick Up Date";
            this.PickUpDate.MinimumWidth = 8;
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.ReadOnly = true;
            this.PickUpDate.Width = 110;
            // 
            // DropOffDate
            // 
            this.DropOffDate.HeaderText = "Drop Off Date";
            this.DropOffDate.MinimumWidth = 8;
            this.DropOffDate.Name = "DropOffDate";
            this.DropOffDate.ReadOnly = true;
            this.DropOffDate.Width = 110;
            // 
            // CarCostperDay
            // 
            this.CarCostperDay.HeaderText = "Car Cost per Day";
            this.CarCostperDay.MinimumWidth = 8;
            this.CarCostperDay.Name = "CarCostperDay";
            this.CarCostperDay.ReadOnly = true;
            this.CarCostperDay.Width = 150;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "District Pay";
            this.DistrictPay.MinimumWidth = 8;
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
            this.DistrictPay.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.MinimumWidth = 8;
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            this.CarType.Visible = false;
            this.CarType.Width = 150;
            // 
            // RentalCompany
            // 
            this.RentalCompany.HeaderText = "Rental Company";
            this.RentalCompany.MinimumWidth = 8;
            this.RentalCompany.Name = "RentalCompany";
            this.RentalCompany.ReadOnly = true;
            this.RentalCompany.Visible = false;
            this.RentalCompany.Width = 150;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 8;
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Visible = false;
            this.Days.Width = 150;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Taxes And Fees";
            this.TaxesAndFees.MinimumWidth = 8;
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            this.TaxesAndFees.Width = 150;
            // 
            // LDWInsurance
            // 
            this.LDWInsurance.HeaderText = "LDW Insurance";
            this.LDWInsurance.MinimumWidth = 8;
            this.LDWInsurance.Name = "LDWInsurance";
            this.LDWInsurance.ReadOnly = true;
            this.LDWInsurance.Visible = false;
            this.LDWInsurance.Width = 150;
            // 
            // SupplementalInsurance
            // 
            this.SupplementalInsurance.HeaderText = "Supplemental Insurance";
            this.SupplementalInsurance.MinimumWidth = 8;
            this.SupplementalInsurance.Name = "SupplementalInsurance";
            this.SupplementalInsurance.ReadOnly = true;
            this.SupplementalInsurance.Visible = false;
            this.SupplementalInsurance.Width = 150;
            // 
            // ExtraInsurance
            // 
            this.ExtraInsurance.HeaderText = "Extra Insurance";
            this.ExtraInsurance.MinimumWidth = 8;
            this.ExtraInsurance.Name = "ExtraInsurance";
            this.ExtraInsurance.ReadOnly = true;
            this.ExtraInsurance.Visible = false;
            this.ExtraInsurance.Width = 150;
            // 
            // ExtraInsuranceAmount
            // 
            this.ExtraInsuranceAmount.HeaderText = "Extra Insurance Amount";
            this.ExtraInsuranceAmount.MinimumWidth = 8;
            this.ExtraInsuranceAmount.Name = "ExtraInsuranceAmount";
            this.ExtraInsuranceAmount.ReadOnly = true;
            this.ExtraInsuranceAmount.Visible = false;
            this.ExtraInsuranceAmount.Width = 150;
            // 
            // PersonalIssues
            // 
            this.PersonalIssues.HeaderText = "Personal Issues";
            this.PersonalIssues.MinimumWidth = 8;
            this.PersonalIssues.Name = "PersonalIssues";
            this.PersonalIssues.ReadOnly = true;
            this.PersonalIssues.Visible = false;
            this.PersonalIssues.Width = 150;
            // 
            // PersonalIssuesAmount
            // 
            this.PersonalIssuesAmount.HeaderText = "Personal Issues Amount";
            this.PersonalIssuesAmount.MinimumWidth = 8;
            this.PersonalIssuesAmount.Name = "PersonalIssuesAmount";
            this.PersonalIssuesAmount.ReadOnly = true;
            this.PersonalIssuesAmount.Visible = false;
            this.PersonalIssuesAmount.Width = 150;
            // 
            // CarRentalID
            // 
            this.CarRentalID.HeaderText = "CarRentalID";
            this.CarRentalID.MinimumWidth = 8;
            this.CarRentalID.Name = "CarRentalID";
            this.CarRentalID.ReadOnly = true;
            this.CarRentalID.Visible = false;
            this.CarRentalID.Width = 150;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            this.Notes.Width = 150;
            // 
            // tlEditButtons
            // 
            this.tlEditButtons.ColumnCount = 7;
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.32609F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15217F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlEditButtons.Controls.Add(this.btnAddCar, 4, 0);
            this.tlEditButtons.Controls.Add(this.btnDeleteCar, 2, 0);
            this.tlEditButtons.Controls.Add(this.label1, 1, 0);
            this.tlEditButtons.Controls.Add(this.label2, 3, 0);
            this.tlEditButtons.Controls.Add(this.label3, 5, 0);
            this.tlEditButtons.Controls.Add(this.btnCancelEditCar, 0, 0);
            this.tlEditButtons.Controls.Add(this.btnEditCar, 6, 0);
            this.tlEditButtons.Location = new System.Drawing.Point(820, 8);
            this.tlEditButtons.Margin = new System.Windows.Forms.Padding(6);
            this.tlEditButtons.Name = "tlEditButtons";
            this.tlEditButtons.RowCount = 1;
            this.tlEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEditButtons.Size = new System.Drawing.Size(350, 66);
            this.tlEditButtons.TabIndex = 2;
            this.tlEditButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tlEditButtons_Paint);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.Location = new System.Drawing.Point(190, 6);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(56, 54);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCar.FlatAppearance.BorderSize = 0;
            this.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCar.Image")));
            this.btnDeleteCar.Location = new System.Drawing.Point(99, 6);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(49, 54);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(258, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelEditCar
            // 
            this.btnCancelEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelEditCar.FlatAppearance.BorderSize = 0;
            this.btnCancelEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelEditCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEditCar.Image")));
            this.btnCancelEditCar.Location = new System.Drawing.Point(6, 6);
            this.btnCancelEditCar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelEditCar.Name = "btnCancelEditCar";
            this.btnCancelEditCar.Size = new System.Drawing.Size(53, 54);
            this.btnCancelEditCar.TabIndex = 3;
            this.btnCancelEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEditCar.UseVisualStyleBackColor = true;
            this.btnCancelEditCar.Click += new System.EventHandler(this.btnCancelEditCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCar.FlatAppearance.BorderSize = 0;
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditCar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCar.Image")));
            this.btnEditCar.Location = new System.Drawing.Point(289, 6);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(55, 54);
            this.btnEditCar.TabIndex = 0;
            this.btnEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // pCarData
            // 
            this.pCarData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCarData.Controls.Add(this.tableLayoutPanel3);
            this.pCarData.Controls.Add(this.pPersonalIssuesAmount);
            this.pCarData.Controls.Add(this.panel2);
            this.pCarData.Controls.Add(this.panel1);
            this.pCarData.Controls.Add(this.tableLayoutPanel2);
            this.pCarData.Controls.Add(this.lblTaxesAndFees);
            this.pCarData.Controls.Add(this.txtExtraInsuranceAmount);
            this.pCarData.Controls.Add(this.lblExtraInsuranceAmount);
            this.pCarData.Controls.Add(this.chxExtraInsurance);
            this.pCarData.Controls.Add(this.lblExtraInsurance);
            this.pCarData.Controls.Add(this.txtTaxesAndFees);
            this.pCarData.Controls.Add(this.txtSupplementalInsurance);
            this.pCarData.Controls.Add(this.lblSupplementalInsurance);
            this.pCarData.Controls.Add(this.lblLDWInsurance);
            this.pCarData.Controls.Add(this.txtLDWInsurance);
            this.pCarData.Location = new System.Drawing.Point(32, 356);
            this.pCarData.Margin = new System.Windows.Forms.Padding(6);
            this.pCarData.Name = "pCarData";
            this.pCarData.Size = new System.Drawing.Size(1124, 875);
            this.pCarData.TabIndex = 3;
            this.pCarData.Paint += new System.Windows.Forms.PaintEventHandler(this.pCarData_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32076F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67924F));
            this.tableLayoutPanel3.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 737);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(874, 75);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.Location = new System.Drawing.Point(7, 27);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(86, 20);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(106, 9);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(761, 56);
            this.txtNotes.TabIndex = 1;
            // 
            // pPersonalIssuesAmount
            // 
            this.pPersonalIssuesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPersonalIssuesAmount.Controls.Add(this.txtPersonalUseAmount);
            this.pPersonalIssuesAmount.Controls.Add(this.lblPersonalIssuesAmount);
            this.pPersonalIssuesAmount.Enabled = false;
            this.pPersonalIssuesAmount.Location = new System.Drawing.Point(126, 677);
            this.pPersonalIssuesAmount.Margin = new System.Windows.Forms.Padding(6);
            this.pPersonalIssuesAmount.Name = "pPersonalIssuesAmount";
            this.pPersonalIssuesAmount.Size = new System.Drawing.Size(873, 52);
            this.pPersonalIssuesAmount.TabIndex = 3;
            // 
            // txtPersonalUseAmount
            // 
            this.txtPersonalUseAmount.Location = new System.Drawing.Point(689, 6);
            this.txtPersonalUseAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtPersonalUseAmount.Name = "txtPersonalUseAmount";
            this.txtPersonalUseAmount.Size = new System.Drawing.Size(158, 33);
            this.txtPersonalUseAmount.TabIndex = 1;
            this.txtPersonalUseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalUseAmount_KeyPress);
            // 
            // lblPersonalIssuesAmount
            // 
            this.lblPersonalIssuesAmount.AutoSize = true;
            this.lblPersonalIssuesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalIssuesAmount.Location = new System.Drawing.Point(11, 13);
            this.lblPersonalIssuesAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonalIssuesAmount.Name = "lblPersonalIssuesAmount";
            this.lblPersonalIssuesAmount.Size = new System.Drawing.Size(525, 20);
            this.lblPersonalIssuesAmount.TabIndex = 0;
            this.lblPersonalIssuesAmount.Text = "Please provide the amount that you used for personal issues:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbNoPersonalIssues);
            this.panel2.Controls.Add(this.rbYesPeronalIssues);
            this.panel2.Controls.Add(this.lblPesonalIssues);
            this.panel2.Location = new System.Drawing.Point(126, 613);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 50);
            this.panel2.TabIndex = 2;
            // 
            // rbNoPersonalIssues
            // 
            this.rbNoPersonalIssues.AutoSize = true;
            this.rbNoPersonalIssues.Location = new System.Drawing.Point(786, 8);
            this.rbNoPersonalIssues.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoPersonalIssues.Name = "rbNoPersonalIssues";
            this.rbNoPersonalIssues.Size = new System.Drawing.Size(62, 29);
            this.rbNoPersonalIssues.TabIndex = 2;
            this.rbNoPersonalIssues.TabStop = true;
            this.rbNoPersonalIssues.Text = "No";
            this.rbNoPersonalIssues.UseVisualStyleBackColor = true;
            this.rbNoPersonalIssues.CheckedChanged += new System.EventHandler(this.rbNoPersonalIssues_CheckedChanged);
            // 
            // rbYesPeronalIssues
            // 
            this.rbYesPeronalIssues.AutoSize = true;
            this.rbYesPeronalIssues.Location = new System.Drawing.Point(689, 8);
            this.rbYesPeronalIssues.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesPeronalIssues.Name = "rbYesPeronalIssues";
            this.rbYesPeronalIssues.Size = new System.Drawing.Size(64, 29);
            this.rbYesPeronalIssues.TabIndex = 1;
            this.rbYesPeronalIssues.TabStop = true;
            this.rbYesPeronalIssues.Text = "Yes";
            this.rbYesPeronalIssues.UseVisualStyleBackColor = true;
            this.rbYesPeronalIssues.CheckedChanged += new System.EventHandler(this.rbYesPeronalIssues_CheckedChanged);
            // 
            // lblPesonalIssues
            // 
            this.lblPesonalIssues.AutoSize = true;
            this.lblPesonalIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesonalIssues.Location = new System.Drawing.Point(11, 13);
            this.lblPesonalIssues.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPesonalIssues.Name = "lblPesonalIssues";
            this.lblPesonalIssues.Size = new System.Drawing.Size(463, 20);
            this.lblPesonalIssues.TabIndex = 0;
            this.lblPesonalIssues.Text = "Did you use any of the car rental for personal issues?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictPay);
            this.panel1.Controls.Add(this.rbYesDistrictPay);
            this.panel1.Controls.Add(this.lblDistrictPay);
            this.panel1.Location = new System.Drawing.Point(126, 552);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 48);
            this.panel1.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            this.rbNoDistrictPay.AutoSize = true;
            this.rbNoDistrictPay.Location = new System.Drawing.Point(786, 8);
            this.rbNoDistrictPay.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoDistrictPay.Name = "rbNoDistrictPay";
            this.rbNoDistrictPay.Size = new System.Drawing.Size(62, 29);
            this.rbNoDistrictPay.TabIndex = 2;
            this.rbNoDistrictPay.TabStop = true;
            this.rbNoDistrictPay.Text = "No";
            this.rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPay
            // 
            this.rbYesDistrictPay.AutoSize = true;
            this.rbYesDistrictPay.Location = new System.Drawing.Point(689, 6);
            this.rbYesDistrictPay.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesDistrictPay.Name = "rbYesDistrictPay";
            this.rbYesDistrictPay.Size = new System.Drawing.Size(64, 29);
            this.rbYesDistrictPay.TabIndex = 1;
            this.rbYesDistrictPay.TabStop = true;
            this.rbYesDistrictPay.Text = "Yes";
            this.rbYesDistrictPay.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPay
            // 
            this.lblDistrictPay.AutoSize = true;
            this.lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistrictPay.Location = new System.Drawing.Point(11, 12);
            this.lblDistrictPay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrictPay.Name = "lblDistrictPay";
            this.lblDistrictPay.Size = new System.Drawing.Size(338, 20);
            this.lblDistrictPay.TabIndex = 0;
            this.lblDistrictPay.Text = "Did the district pay for your car rental?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34837F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65163F));
            this.tableLayoutPanel2.Controls.Add(this.lblPickUpDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDropOffDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCarType, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRentalCompany, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDays, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblCarCost, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.dtpPickUpDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDropOffDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbCarType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbRentalCompany, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.nudDays, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtCarCost, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalCar, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(205, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 460);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPickUpDate.Location = new System.Drawing.Point(7, 23);
            this.lblPickUpDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(274, 20);
            this.lblPickUpDate.TabIndex = 0;
            this.lblPickUpDate.Text = "Pick Up Date:";
            // 
            // lblDropOffDate
            // 
            this.lblDropOffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDropOffDate.AutoSize = true;
            this.lblDropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDropOffDate.Location = new System.Drawing.Point(7, 88);
            this.lblDropOffDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDropOffDate.Name = "lblDropOffDate";
            this.lblDropOffDate.Size = new System.Drawing.Size(274, 20);
            this.lblDropOffDate.TabIndex = 1;
            this.lblDropOffDate.Text = "Drop Off Date:";
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarType.Location = new System.Drawing.Point(7, 153);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(274, 20);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car Type:";
            // 
            // lblRentalCompany
            // 
            this.lblRentalCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRentalCompany.AutoSize = true;
            this.lblRentalCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentalCompany.Location = new System.Drawing.Point(7, 218);
            this.lblRentalCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRentalCompany.Name = "lblRentalCompany";
            this.lblRentalCompany.Size = new System.Drawing.Size(274, 20);
            this.lblRentalCompany.TabIndex = 3;
            this.lblRentalCompany.Text = "Rental Company:";
            // 
            // lblDays
            // 
            this.lblDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDays.Location = new System.Drawing.Point(7, 283);
            this.lblDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(274, 20);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Days:";
            // 
            // lblCarCost
            // 
            this.lblCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarCost.AutoSize = true;
            this.lblCarCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarCost.Location = new System.Drawing.Point(7, 348);
            this.lblCarCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarCost.Name = "lblCarCost";
            this.lblCarCost.Size = new System.Drawing.Size(274, 20);
            this.lblCarCost.TabIndex = 5;
            this.lblCarCost.Text = "Car Cost:";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickUpDate.Location = new System.Drawing.Point(294, 16);
            this.dtpPickUpDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(431, 33);
            this.dtpPickUpDate.TabIndex = 12;
            this.dtpPickUpDate.ValueChanged += new System.EventHandler(this.dtpPickUpDate_ValueChanged);
            // 
            // dtpDropOffDate
            // 
            this.dtpDropOffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDropOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDropOffDate.Location = new System.Drawing.Point(294, 81);
            this.dtpDropOffDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDropOffDate.Name = "dtpDropOffDate";
            this.dtpDropOffDate.Size = new System.Drawing.Size(431, 33);
            this.dtpDropOffDate.TabIndex = 13;
            this.dtpDropOffDate.ValueChanged += new System.EventHandler(this.dtpDropOffDate_ValueChanged);
            // 
            // cbCarType
            // 
            this.cbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Items.AddRange(new object[] {
            "compact",
            "mid-size"});
            this.cbCarType.Location = new System.Drawing.Point(294, 146);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(6);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(431, 33);
            this.cbCarType.TabIndex = 14;
            // 
            // cbRentalCompany
            // 
            this.cbRentalCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRentalCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentalCompany.FormattingEnabled = true;
            this.cbRentalCompany.Items.AddRange(new object[] {
            "Enterprise",
            "National",
            "Other"});
            this.cbRentalCompany.Location = new System.Drawing.Point(294, 211);
            this.cbRentalCompany.Margin = new System.Windows.Forms.Padding(6);
            this.cbRentalCompany.Name = "cbRentalCompany";
            this.cbRentalCompany.Size = new System.Drawing.Size(431, 33);
            this.cbRentalCompany.TabIndex = 15;
            // 
            // nudDays
            // 
            this.nudDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDays.Location = new System.Drawing.Point(294, 276);
            this.nudDays.Margin = new System.Windows.Forms.Padding(6);
            this.nudDays.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.ReadOnly = true;
            this.nudDays.Size = new System.Drawing.Size(431, 33);
            this.nudDays.TabIndex = 16;
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            this.nudDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudDays_KeyUp);
            // 
            // txtCarCost
            // 
            this.txtCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarCost.Location = new System.Drawing.Point(294, 341);
            this.txtCarCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtCarCost.Name = "txtCarCost";
            this.txtCarCost.Size = new System.Drawing.Size(431, 33);
            this.txtCarCost.TabIndex = 17;
            this.txtCarCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarCost_KeyPress);
            this.txtCarCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCarCost_KeyUp);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(7, 415);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(274, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotalCar
            // 
            this.txtTotalCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCar.Location = new System.Drawing.Point(294, 408);
            this.txtTotalCar.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalCar.Name = "txtTotalCar";
            this.txtTotalCar.Size = new System.Drawing.Size(431, 33);
            this.txtTotalCar.TabIndex = 23;
            this.txtTotalCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCar_KeyPress);
            // 
            // lblTaxesAndFees
            // 
            this.lblTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFees.AutoSize = true;
            this.lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxesAndFees.Location = new System.Drawing.Point(9, 15);
            this.lblTaxesAndFees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTaxesAndFees.Name = "lblTaxesAndFees";
            this.lblTaxesAndFees.Size = new System.Drawing.Size(148, 20);
            this.lblTaxesAndFees.TabIndex = 6;
            this.lblTaxesAndFees.Text = "Taxes and Fees:";
            this.lblTaxesAndFees.Visible = false;
            // 
            // txtExtraInsuranceAmount
            // 
            this.txtExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraInsuranceAmount.Enabled = false;
            this.txtExtraInsuranceAmount.Location = new System.Drawing.Point(370, 823);
            this.txtExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtExtraInsuranceAmount.Name = "txtExtraInsuranceAmount";
            this.txtExtraInsuranceAmount.Size = new System.Drawing.Size(59, 33);
            this.txtExtraInsuranceAmount.TabIndex = 22;
            this.txtExtraInsuranceAmount.Visible = false;
            this.txtExtraInsuranceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraInsuranceAmount_KeyPress);
            this.txtExtraInsuranceAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExtraInsuranceAmount_KeyUp);
            // 
            // lblExtraInsuranceAmount
            // 
            this.lblExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsuranceAmount.AutoSize = true;
            this.lblExtraInsuranceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtraInsuranceAmount.Location = new System.Drawing.Point(99, 829);
            this.lblExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtraInsuranceAmount.Name = "lblExtraInsuranceAmount";
            this.lblExtraInsuranceAmount.Size = new System.Drawing.Size(216, 20);
            this.lblExtraInsuranceAmount.TabIndex = 10;
            this.lblExtraInsuranceAmount.Text = "Extra Insurance Amount:";
            this.lblExtraInsuranceAmount.Visible = false;
            // 
            // chxExtraInsurance
            // 
            this.chxExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxExtraInsurance.AutoSize = true;
            this.chxExtraInsurance.Location = new System.Drawing.Point(964, 17);
            this.chxExtraInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.chxExtraInsurance.Name = "chxExtraInsurance";
            this.chxExtraInsurance.Size = new System.Drawing.Size(22, 21);
            this.chxExtraInsurance.TabIndex = 21;
            this.chxExtraInsurance.UseVisualStyleBackColor = true;
            this.chxExtraInsurance.Visible = false;
            this.chxExtraInsurance.CheckedChanged += new System.EventHandler(this.chxExtraInsurance_CheckedChanged);
            // 
            // lblExtraInsurance
            // 
            this.lblExtraInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsurance.AutoSize = true;
            this.lblExtraInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtraInsurance.Location = new System.Drawing.Point(776, 15);
            this.lblExtraInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtraInsurance.Name = "lblExtraInsurance";
            this.lblExtraInsurance.Size = new System.Drawing.Size(147, 20);
            this.lblExtraInsurance.TabIndex = 9;
            this.lblExtraInsurance.Text = "Extra Insurance:";
            this.lblExtraInsurance.Visible = false;
            // 
            // txtTaxesAndFees
            // 
            this.txtTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxesAndFees.Location = new System.Drawing.Point(194, 10);
            this.txtTaxesAndFees.Margin = new System.Windows.Forms.Padding(6);
            this.txtTaxesAndFees.Name = "txtTaxesAndFees";
            this.txtTaxesAndFees.Size = new System.Drawing.Size(26, 33);
            this.txtTaxesAndFees.TabIndex = 18;
            this.txtTaxesAndFees.Text = "0";
            this.txtTaxesAndFees.Visible = false;
            this.txtTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxesAndFees_KeyPress);
            this.txtTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxesAndFees_KeyUp);
            // 
            // txtSupplementalInsurance
            // 
            this.txtSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplementalInsurance.Location = new System.Drawing.Point(733, 12);
            this.txtSupplementalInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.txtSupplementalInsurance.Name = "txtSupplementalInsurance";
            this.txtSupplementalInsurance.Size = new System.Drawing.Size(28, 33);
            this.txtSupplementalInsurance.TabIndex = 20;
            this.txtSupplementalInsurance.Text = "0";
            this.txtSupplementalInsurance.Visible = false;
            this.txtSupplementalInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplementalInsurance_KeyPress);
            this.txtSupplementalInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplementalInsurance_KeyUp);
            // 
            // lblSupplementalInsurance
            // 
            this.lblSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplementalInsurance.AutoSize = true;
            this.lblSupplementalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupplementalInsurance.Location = new System.Drawing.Point(460, 15);
            this.lblSupplementalInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSupplementalInsurance.Name = "lblSupplementalInsurance";
            this.lblSupplementalInsurance.Size = new System.Drawing.Size(216, 20);
            this.lblSupplementalInsurance.TabIndex = 8;
            this.lblSupplementalInsurance.Text = "Supplemental Insurance:";
            this.lblSupplementalInsurance.Visible = false;
            // 
            // lblLDWInsurance
            // 
            this.lblLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLDWInsurance.AutoSize = true;
            this.lblLDWInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLDWInsurance.Location = new System.Drawing.Point(235, 15);
            this.lblLDWInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLDWInsurance.Name = "lblLDWInsurance";
            this.lblLDWInsurance.Size = new System.Drawing.Size(145, 20);
            this.lblLDWInsurance.TabIndex = 7;
            this.lblLDWInsurance.Text = "LDW Insurance:";
            this.lblLDWInsurance.Visible = false;
            // 
            // txtLDWInsurance
            // 
            this.txtLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLDWInsurance.Location = new System.Drawing.Point(420, 12);
            this.txtLDWInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.txtLDWInsurance.Name = "txtLDWInsurance";
            this.txtLDWInsurance.Size = new System.Drawing.Size(26, 33);
            this.txtLDWInsurance.TabIndex = 19;
            this.txtLDWInsurance.Text = "0";
            this.txtLDWInsurance.Visible = false;
            this.txtLDWInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLDWInsurance_KeyPress);
            this.txtLDWInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLDWInsurance_KeyUp);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveCar.FlatAppearance.BorderSize = 0;
            this.btnSaveCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCar.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCar.Image")));
            this.btnSaveCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCar.Location = new System.Drawing.Point(1072, 1276);
            this.btnSaveCar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(111, 62);
            this.btnSaveCar.TabIndex = 0;
            this.btnSaveCar.Text = "Save";
            this.btnSaveCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCar.UseVisualStyleBackColor = true;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(5, 1282);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 58);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.button1.Location = new System.Drawing.Point(28, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "Select a car rental from the list and then click on the option button you want to" +
        " perform");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditCarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1336);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pCarData);
            this.Controls.Add(this.tlEditButtons);
            this.Controls.Add(this.dgvEditCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditCarRental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Car Rental";
            this.Load += new System.EventHandler(this.EditCarRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCar)).EndInit();
            this.tlEditButtons.ResumeLayout(false);
            this.tlEditButtons.PerformLayout();
            this.pCarData.ResumeLayout(false);
            this.pCarData.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pPersonalIssuesAmount.ResumeLayout(false);
            this.pPersonalIssuesAmount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditCar;
        private System.Windows.Forms.TableLayoutPanel tlEditButtons;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnCancelEditCar;
        private System.Windows.Forms.Panel pCarData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblDropOffDate;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblRentalCompany;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblCarCost;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.Label lblLDWInsurance;
        private System.Windows.Forms.Label lblSupplementalInsurance;
        private System.Windows.Forms.Label lblExtraInsurance;
        private System.Windows.Forms.Label lblExtraInsuranceAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.DateTimePicker dtpDropOffDate;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.ComboBox cbRentalCompany;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.TextBox txtCarCost;
        private System.Windows.Forms.TextBox txtTaxesAndFees;
        private System.Windows.Forms.TextBox txtLDWInsurance;
        private System.Windows.Forms.TextBox txtSupplementalInsurance;
        private System.Windows.Forms.CheckBox chxExtraInsurance;
        private System.Windows.Forms.TextBox txtExtraInsuranceAmount;
        private System.Windows.Forms.TextBox txtTotalCar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoPersonalIssues;
        private System.Windows.Forms.RadioButton rbYesPeronalIssues;
        private System.Windows.Forms.Label lblPesonalIssues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistrictPay;
        private System.Windows.Forms.Label lblDistrictPay;
        private System.Windows.Forms.Panel pPersonalIssuesAmount;
        private System.Windows.Forms.TextBox txtPersonalUseAmount;
        private System.Windows.Forms.Label lblPersonalIssuesAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCostperDay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDWInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplementalInsurance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExtraInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraInsuranceAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalIssuesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarRentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}