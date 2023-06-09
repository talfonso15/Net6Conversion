﻿namespace TravelExpenses
{
    partial class CarRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRental));
            this.lblCarRentalHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.dtpPickUpDateCarRental = new System.Windows.Forms.DateTimePicker();
            this.lblDropOffDateCarRental = new System.Windows.Forms.Label();
            this.dtpDropOffDateCarRental = new System.Windows.Forms.DateTimePicker();
            this.lblCarType = new System.Windows.Forms.Label();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbRentalCompany = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblCarCost = new System.Windows.Forms.Label();
            this.txtCarCost = new System.Windows.Forms.TextBox();
            this.lblTotalCarRental = new System.Windows.Forms.Label();
            this.txtTotalCarRental = new System.Windows.Forms.TextBox();
            this.tblCarRentalNotes = new System.Windows.Forms.TableLayoutPanel();
            this.lblCarRentalNotes = new System.Windows.Forms.Label();
            this.txtNotesCarRental = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPayCarRental = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPayCarRental = new System.Windows.Forms.RadioButton();
            this.lblDistrictPayCarRental = new System.Windows.Forms.Label();
            this.pPersonalAmount = new System.Windows.Forms.Panel();
            this.txtPersonalAmountCarRental = new System.Windows.Forms.TextBox();
            this.lblPersonalAmountCarRental = new System.Windows.Forms.Label();
            this.pUsePersonalCarRental = new System.Windows.Forms.Panel();
            this.rbNoPersonalUseCarRental = new System.Windows.Forms.RadioButton();
            this.rbYesPersonalUseCarRental = new System.Windows.Forms.RadioButton();
            this.lblPersonalUseCarRental = new System.Windows.Forms.Label();
            this.lblTaxesAndFeesCarRental = new System.Windows.Forms.Label();
            this.txtCarTaxesAndFees = new System.Windows.Forms.TextBox();
            this.txtExtraInsuranceAmount = new System.Windows.Forms.TextBox();
            this.txtSupplementalInsurance = new System.Windows.Forms.TextBox();
            this.lblExtraInsuranceAmount = new System.Windows.Forms.Label();
            this.lblSupplementalInsurance = new System.Windows.Forms.Label();
            this.lblExtraInsurance = new System.Windows.Forms.Label();
            this.chxExtraInsurance = new System.Windows.Forms.CheckBox();
            this.lblLDWInsurance = new System.Windows.Forms.Label();
            this.txtLDWInsurance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCarRental = new System.Windows.Forms.Button();
            this.dgvCarRental = new System.Windows.Forms.DataGridView();
            this.tlpCarRentalNavigationButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextCarRental = new System.Windows.Forms.Button();
            this.btnBackCarRental = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarList = new System.Windows.Forms.Label();
            this.btnCancelCarRental = new System.Windows.Forms.Button();
            this.PickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistricPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDWInsuranse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplementalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraInsura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExtraInsuranceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.tblCarRentalNotes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pPersonalAmount.SuspendLayout();
            this.pUsePersonalCarRental.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRental)).BeginInit();
            this.tlpCarRentalNavigationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarRentalHeader
            // 
            this.lblCarRentalHeader.AutoSize = true;
            this.lblCarRentalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCarRentalHeader.Location = new System.Drawing.Point(37, 17);
            this.lblCarRentalHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarRentalHeader.Name = "lblCarRentalHeader";
            this.lblCarRentalHeader.Size = new System.Drawing.Size(293, 29);
            this.lblCarRentalHeader.TabIndex = 0;
            this.lblCarRentalHeader.Text = "Enter Car Rental Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tblCarRentalNotes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pPersonalAmount);
            this.panel1.Controls.Add(this.pUsePersonalCarRental);
            this.panel1.Controls.Add(this.lblTaxesAndFeesCarRental);
            this.panel1.Controls.Add(this.txtCarTaxesAndFees);
            this.panel1.Controls.Add(this.txtExtraInsuranceAmount);
            this.panel1.Controls.Add(this.txtSupplementalInsurance);
            this.panel1.Controls.Add(this.lblExtraInsuranceAmount);
            this.panel1.Controls.Add(this.lblSupplementalInsurance);
            this.panel1.Controls.Add(this.lblExtraInsurance);
            this.panel1.Controls.Add(this.chxExtraInsurance);
            this.panel1.Controls.Add(this.lblLDWInsurance);
            this.panel1.Controls.Add(this.txtLDWInsurance);
            this.panel1.Location = new System.Drawing.Point(37, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 717);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.15476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.84524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.tableLayoutPanel1.Controls.Add(this.lblPickUpDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpPickUpDateCarRental, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDropOffDateCarRental, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDropOffDateCarRental, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCarType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCompany, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbRentalCompany, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDays, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudDays, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCarCost, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCarCost, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCarRental, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalCarRental, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1203, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Location = new System.Drawing.Point(7, 25);
            this.lblPickUpDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(213, 25);
            this.lblPickUpDate.TabIndex = 0;
            this.lblPickUpDate.Text = "Pick Up Date:";
            // 
            // dtpPickUpDateCarRental
            // 
            this.dtpPickUpDateCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPickUpDateCarRental.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickUpDateCarRental.Location = new System.Drawing.Point(233, 21);
            this.dtpPickUpDateCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.dtpPickUpDateCarRental.Name = "dtpPickUpDateCarRental";
            this.dtpPickUpDateCarRental.Size = new System.Drawing.Size(285, 33);
            this.dtpPickUpDateCarRental.TabIndex = 2;
            this.dtpPickUpDateCarRental.ValueChanged += new System.EventHandler(this.dtpPickUpDateCarRental_ValueChanged);
            // 
            // lblDropOffDateCarRental
            // 
            this.lblDropOffDateCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDropOffDateCarRental.AutoSize = true;
            this.lblDropOffDateCarRental.Location = new System.Drawing.Point(531, 25);
            this.lblDropOffDateCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDropOffDateCarRental.Name = "lblDropOffDateCarRental";
            this.lblDropOffDateCarRental.Size = new System.Drawing.Size(265, 25);
            this.lblDropOffDateCarRental.TabIndex = 1;
            this.lblDropOffDateCarRental.Text = "Drop Off Date:";
            // 
            // dtpDropOffDateCarRental
            // 
            this.dtpDropOffDateCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDropOffDateCarRental.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDropOffDateCarRental.Location = new System.Drawing.Point(809, 21);
            this.dtpDropOffDateCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDropOffDateCarRental.Name = "dtpDropOffDateCarRental";
            this.dtpDropOffDateCarRental.Size = new System.Drawing.Size(387, 33);
            this.dtpDropOffDateCarRental.TabIndex = 3;
            this.dtpDropOffDateCarRental.ValueChanged += new System.EventHandler(this.dtpDropOffDateCarRental_ValueChanged);
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(7, 95);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(213, 25);
            this.lblCarType.TabIndex = 4;
            this.lblCarType.Text = "Car Type:";
            // 
            // cbCarType
            // 
            this.cbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Items.AddRange(new object[] {
            "compact",
            "mid-size"});
            this.cbCarType.Location = new System.Drawing.Point(233, 91);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(6);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(285, 33);
            this.cbCarType.TabIndex = 5;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(531, 95);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(265, 25);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "Rental Company:";
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
            this.cbRentalCompany.Location = new System.Drawing.Point(809, 91);
            this.cbRentalCompany.Margin = new System.Windows.Forms.Padding(6);
            this.cbRentalCompany.Name = "cbRentalCompany";
            this.cbRentalCompany.Size = new System.Drawing.Size(387, 33);
            this.cbRentalCompany.TabIndex = 7;
            // 
            // lblDays
            // 
            this.lblDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(7, 155);
            this.lblDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(213, 25);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Days:";
            // 
            // nudDays
            // 
            this.nudDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDays.Location = new System.Drawing.Point(233, 151);
            this.nudDays.Margin = new System.Windows.Forms.Padding(6);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(285, 33);
            this.nudDays.TabIndex = 9;
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            this.nudDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudDays_KeyUp);
            // 
            // lblCarCost
            // 
            this.lblCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarCost.AutoSize = true;
            this.lblCarCost.Location = new System.Drawing.Point(531, 155);
            this.lblCarCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarCost.Name = "lblCarCost";
            this.lblCarCost.Size = new System.Drawing.Size(265, 25);
            this.lblCarCost.TabIndex = 10;
            this.lblCarCost.Text = "Cost Per Day:";
            this.lblCarCost.Click += new System.EventHandler(this.lblCarCost_Click);
            // 
            // txtCarCost
            // 
            this.txtCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarCost.Location = new System.Drawing.Point(809, 151);
            this.txtCarCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtCarCost.Name = "txtCarCost";
            this.txtCarCost.Size = new System.Drawing.Size(387, 33);
            this.txtCarCost.TabIndex = 11;
            this.txtCarCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarCost_KeyPress);
            this.txtCarCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCarCost_KeyUp);
            // 
            // lblTotalCarRental
            // 
            this.lblTotalCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCarRental.AutoSize = true;
            this.lblTotalCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCarRental.Location = new System.Drawing.Point(7, 213);
            this.lblTotalCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalCarRental.Name = "lblTotalCarRental";
            this.lblTotalCarRental.Size = new System.Drawing.Size(213, 20);
            this.lblTotalCarRental.TabIndex = 14;
            this.lblTotalCarRental.Text = "Total:";
            // 
            // txtTotalCarRental
            // 
            this.txtTotalCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCarRental.Location = new System.Drawing.Point(233, 207);
            this.txtTotalCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalCarRental.Name = "txtTotalCarRental";
            this.txtTotalCarRental.Size = new System.Drawing.Size(285, 33);
            this.txtTotalCarRental.TabIndex = 15;
            this.txtTotalCarRental.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalCarRental_KeyUp);
            // 
            // tblCarRentalNotes
            // 
            this.tblCarRentalNotes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCarRentalNotes.ColumnCount = 2;
            this.tblCarRentalNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.890744F));
            this.tblCarRentalNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.10925F));
            this.tblCarRentalNotes.Controls.Add(this.lblCarRentalNotes, 0, 0);
            this.tblCarRentalNotes.Controls.Add(this.txtNotesCarRental, 1, 0);
            this.tblCarRentalNotes.Location = new System.Drawing.Point(42, 569);
            this.tblCarRentalNotes.Margin = new System.Windows.Forms.Padding(6);
            this.tblCarRentalNotes.Name = "tblCarRentalNotes";
            this.tblCarRentalNotes.RowCount = 1;
            this.tblCarRentalNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCarRentalNotes.Size = new System.Drawing.Size(1210, 88);
            this.tblCarRentalNotes.TabIndex = 7;
            // 
            // lblCarRentalNotes
            // 
            this.lblCarRentalNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarRentalNotes.AutoSize = true;
            this.lblCarRentalNotes.Location = new System.Drawing.Point(7, 31);
            this.lblCarRentalNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarRentalNotes.Name = "lblCarRentalNotes";
            this.lblCarRentalNotes.Size = new System.Drawing.Size(83, 25);
            this.lblCarRentalNotes.TabIndex = 0;
            this.lblCarRentalNotes.Text = "Notes:";
            // 
            // txtNotesCarRental
            // 
            this.txtNotesCarRental.Location = new System.Drawing.Point(103, 7);
            this.txtNotesCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.txtNotesCarRental.Multiline = true;
            this.txtNotesCarRental.Name = "txtNotesCarRental";
            this.txtNotesCarRental.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotesCarRental.Size = new System.Drawing.Size(1097, 67);
            this.txtNotesCarRental.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbNoDistrictPayCarRental);
            this.panel2.Controls.Add(this.rbYesDistrictPayCarRental);
            this.panel2.Controls.Add(this.lblDistrictPayCarRental);
            this.panel2.Location = new System.Drawing.Point(42, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 62);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rbNoDistrictPayCarRental
            // 
            this.rbNoDistrictPayCarRental.AutoSize = true;
            this.rbNoDistrictPayCarRental.Location = new System.Drawing.Point(1094, 13);
            this.rbNoDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoDistrictPayCarRental.Name = "rbNoDistrictPayCarRental";
            this.rbNoDistrictPayCarRental.Size = new System.Drawing.Size(62, 29);
            this.rbNoDistrictPayCarRental.TabIndex = 1;
            this.rbNoDistrictPayCarRental.TabStop = true;
            this.rbNoDistrictPayCarRental.Text = "No";
            this.rbNoDistrictPayCarRental.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPayCarRental
            // 
            this.rbYesDistrictPayCarRental.AutoSize = true;
            this.rbYesDistrictPayCarRental.Checked = true;
            this.rbYesDistrictPayCarRental.Location = new System.Drawing.Point(959, 13);
            this.rbYesDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesDistrictPayCarRental.Name = "rbYesDistrictPayCarRental";
            this.rbYesDistrictPayCarRental.Size = new System.Drawing.Size(64, 29);
            this.rbYesDistrictPayCarRental.TabIndex = 0;
            this.rbYesDistrictPayCarRental.TabStop = true;
            this.rbYesDistrictPayCarRental.Text = "Yes";
            this.rbYesDistrictPayCarRental.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayCarRental
            // 
            this.lblDistrictPayCarRental.AutoSize = true;
            this.lblDistrictPayCarRental.Location = new System.Drawing.Point(37, 21);
            this.lblDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrictPayCarRental.Name = "lblDistrictPayCarRental";
            this.lblDistrictPayCarRental.Size = new System.Drawing.Size(336, 25);
            this.lblDistrictPayCarRental.TabIndex = 0;
            this.lblDistrictPayCarRental.Text = "Did the district pay for your car rental?";
            // 
            // pPersonalAmount
            // 
            this.pPersonalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPersonalAmount.Controls.Add(this.txtPersonalAmountCarRental);
            this.pPersonalAmount.Controls.Add(this.lblPersonalAmountCarRental);
            this.pPersonalAmount.Enabled = false;
            this.pPersonalAmount.Location = new System.Drawing.Point(42, 492);
            this.pPersonalAmount.Margin = new System.Windows.Forms.Padding(6);
            this.pPersonalAmount.Name = "pPersonalAmount";
            this.pPersonalAmount.Size = new System.Drawing.Size(1208, 62);
            this.pPersonalAmount.TabIndex = 6;
            // 
            // txtPersonalAmountCarRental
            // 
            this.txtPersonalAmountCarRental.Location = new System.Drawing.Point(959, 13);
            this.txtPersonalAmountCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.txtPersonalAmountCarRental.Name = "txtPersonalAmountCarRental";
            this.txtPersonalAmountCarRental.Size = new System.Drawing.Size(204, 33);
            this.txtPersonalAmountCarRental.TabIndex = 6;
            this.txtPersonalAmountCarRental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalAmountCarRental_KeyPress);
            // 
            // lblPersonalAmountCarRental
            // 
            this.lblPersonalAmountCarRental.AutoSize = true;
            this.lblPersonalAmountCarRental.Location = new System.Drawing.Point(37, 19);
            this.lblPersonalAmountCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonalAmountCarRental.Name = "lblPersonalAmountCarRental";
            this.lblPersonalAmountCarRental.Size = new System.Drawing.Size(496, 25);
            this.lblPersonalAmountCarRental.TabIndex = 5;
            this.lblPersonalAmountCarRental.Text = "Please write the amount that you used for personal issues";
            // 
            // pUsePersonalCarRental
            // 
            this.pUsePersonalCarRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUsePersonalCarRental.Controls.Add(this.rbNoPersonalUseCarRental);
            this.pUsePersonalCarRental.Controls.Add(this.rbYesPersonalUseCarRental);
            this.pUsePersonalCarRental.Controls.Add(this.lblPersonalUseCarRental);
            this.pUsePersonalCarRental.Location = new System.Drawing.Point(42, 421);
            this.pUsePersonalCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.pUsePersonalCarRental.Name = "pUsePersonalCarRental";
            this.pUsePersonalCarRental.Size = new System.Drawing.Size(1208, 58);
            this.pUsePersonalCarRental.TabIndex = 4;
            // 
            // rbNoPersonalUseCarRental
            // 
            this.rbNoPersonalUseCarRental.AutoSize = true;
            this.rbNoPersonalUseCarRental.Checked = true;
            this.rbNoPersonalUseCarRental.Location = new System.Drawing.Point(1100, 12);
            this.rbNoPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoPersonalUseCarRental.Name = "rbNoPersonalUseCarRental";
            this.rbNoPersonalUseCarRental.Size = new System.Drawing.Size(62, 29);
            this.rbNoPersonalUseCarRental.TabIndex = 4;
            this.rbNoPersonalUseCarRental.TabStop = true;
            this.rbNoPersonalUseCarRental.Text = "No";
            this.rbNoPersonalUseCarRental.UseVisualStyleBackColor = true;
            this.rbNoPersonalUseCarRental.CheckedChanged += new System.EventHandler(this.rbNoPersonalUseCarRental_CheckedChanged);
            // 
            // rbYesPersonalUseCarRental
            // 
            this.rbYesPersonalUseCarRental.AutoSize = true;
            this.rbYesPersonalUseCarRental.Location = new System.Drawing.Point(964, 12);
            this.rbYesPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesPersonalUseCarRental.Name = "rbYesPersonalUseCarRental";
            this.rbYesPersonalUseCarRental.Size = new System.Drawing.Size(64, 29);
            this.rbYesPersonalUseCarRental.TabIndex = 3;
            this.rbYesPersonalUseCarRental.Text = "Yes";
            this.rbYesPersonalUseCarRental.UseVisualStyleBackColor = true;
            this.rbYesPersonalUseCarRental.CheckedChanged += new System.EventHandler(this.rbYesPersonalUseCarRental_CheckedChanged);
            // 
            // lblPersonalUseCarRental
            // 
            this.lblPersonalUseCarRental.AutoSize = true;
            this.lblPersonalUseCarRental.Location = new System.Drawing.Point(37, 19);
            this.lblPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPersonalUseCarRental.Name = "lblPersonalUseCarRental";
            this.lblPersonalUseCarRental.Size = new System.Drawing.Size(456, 25);
            this.lblPersonalUseCarRental.TabIndex = 2;
            this.lblPersonalUseCarRental.Text = "Did you use any of the car rental for personal issues?";
            // 
            // lblTaxesAndFeesCarRental
            // 
            this.lblTaxesAndFeesCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFeesCarRental.AutoSize = true;
            this.lblTaxesAndFeesCarRental.Location = new System.Drawing.Point(37, 23);
            this.lblTaxesAndFeesCarRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTaxesAndFeesCarRental.Name = "lblTaxesAndFeesCarRental";
            this.lblTaxesAndFeesCarRental.Size = new System.Drawing.Size(140, 25);
            this.lblTaxesAndFeesCarRental.TabIndex = 12;
            this.lblTaxesAndFeesCarRental.Text = "Taxes and Fees:";
            this.lblTaxesAndFeesCarRental.Visible = false;
            // 
            // txtCarTaxesAndFees
            // 
            this.txtCarTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarTaxesAndFees.Location = new System.Drawing.Point(205, 17);
            this.txtCarTaxesAndFees.Margin = new System.Windows.Forms.Padding(6);
            this.txtCarTaxesAndFees.Name = "txtCarTaxesAndFees";
            this.txtCarTaxesAndFees.Size = new System.Drawing.Size(37, 33);
            this.txtCarTaxesAndFees.TabIndex = 13;
            this.txtCarTaxesAndFees.Visible = false;
            this.txtCarTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarTaxesAndFees_KeyPress);
            this.txtCarTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtExtraInsuranceAmount
            // 
            this.txtExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraInsuranceAmount.Enabled = false;
            this.txtExtraInsuranceAmount.Location = new System.Drawing.Point(1212, 19);
            this.txtExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtExtraInsuranceAmount.Name = "txtExtraInsuranceAmount";
            this.txtExtraInsuranceAmount.Size = new System.Drawing.Size(37, 33);
            this.txtExtraInsuranceAmount.TabIndex = 23;
            this.txtExtraInsuranceAmount.Visible = false;
            this.txtExtraInsuranceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraInsuranceAmount_KeyPress);
            this.txtExtraInsuranceAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExtraInsuranceAmount_KeyUp);
            // 
            // txtSupplementalInsurance
            // 
            this.txtSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplementalInsurance.Location = new System.Drawing.Point(922, 17);
            this.txtSupplementalInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.txtSupplementalInsurance.Name = "txtSupplementalInsurance";
            this.txtSupplementalInsurance.Size = new System.Drawing.Size(37, 33);
            this.txtSupplementalInsurance.TabIndex = 19;
            this.txtSupplementalInsurance.Visible = false;
            this.txtSupplementalInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplementalInsurance_KeyPress);
            this.txtSupplementalInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplementalInsurance_KeyUp);
            // 
            // lblExtraInsuranceAmount
            // 
            this.lblExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsuranceAmount.AutoSize = true;
            this.lblExtraInsuranceAmount.Location = new System.Drawing.Point(974, 23);
            this.lblExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtraInsuranceAmount.Name = "lblExtraInsuranceAmount";
            this.lblExtraInsuranceAmount.Size = new System.Drawing.Size(217, 25);
            this.lblExtraInsuranceAmount.TabIndex = 22;
            this.lblExtraInsuranceAmount.Text = "Extra Insurance Amount:";
            this.lblExtraInsuranceAmount.Visible = false;
            // 
            // lblSupplementalInsurance
            // 
            this.lblSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplementalInsurance.AutoSize = true;
            this.lblSupplementalInsurance.Location = new System.Drawing.Point(689, 25);
            this.lblSupplementalInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSupplementalInsurance.Name = "lblSupplementalInsurance";
            this.lblSupplementalInsurance.Size = new System.Drawing.Size(219, 25);
            this.lblSupplementalInsurance.TabIndex = 18;
            this.lblSupplementalInsurance.Text = "Supplemental Insurance:";
            this.lblSupplementalInsurance.Visible = false;
            // 
            // lblExtraInsurance
            // 
            this.lblExtraInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsurance.AutoSize = true;
            this.lblExtraInsurance.Location = new System.Drawing.Point(257, 23);
            this.lblExtraInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtraInsurance.Name = "lblExtraInsurance";
            this.lblExtraInsurance.Size = new System.Drawing.Size(145, 25);
            this.lblExtraInsurance.TabIndex = 20;
            this.lblExtraInsurance.Text = "Extra Insurance:";
            this.lblExtraInsurance.Visible = false;
            // 
            // chxExtraInsurance
            // 
            this.chxExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxExtraInsurance.AutoSize = true;
            this.chxExtraInsurance.Location = new System.Drawing.Point(422, 23);
            this.chxExtraInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.chxExtraInsurance.Name = "chxExtraInsurance";
            this.chxExtraInsurance.Size = new System.Drawing.Size(22, 21);
            this.chxExtraInsurance.TabIndex = 21;
            this.chxExtraInsurance.UseVisualStyleBackColor = true;
            this.chxExtraInsurance.Visible = false;
            this.chxExtraInsurance.CheckedChanged += new System.EventHandler(this.chxExtraInsurance_CheckedChanged);
            // 
            // lblLDWInsurance
            // 
            this.lblLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLDWInsurance.AutoSize = true;
            this.lblLDWInsurance.Location = new System.Drawing.Point(460, 25);
            this.lblLDWInsurance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLDWInsurance.Name = "lblLDWInsurance";
            this.lblLDWInsurance.Size = new System.Drawing.Size(143, 25);
            this.lblLDWInsurance.TabIndex = 16;
            this.lblLDWInsurance.Text = "LDW Insurance:";
            this.lblLDWInsurance.Visible = false;
            // 
            // txtLDWInsurance
            // 
            this.txtLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLDWInsurance.Location = new System.Drawing.Point(627, 19);
            this.txtLDWInsurance.Margin = new System.Windows.Forms.Padding(6);
            this.txtLDWInsurance.Name = "txtLDWInsurance";
            this.txtLDWInsurance.Size = new System.Drawing.Size(48, 33);
            this.txtLDWInsurance.TabIndex = 17;
            this.txtLDWInsurance.Visible = false;
            this.txtLDWInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLDWInsurance_KeyPress);
            this.txtLDWInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLDWInsurance_KeyUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddCarRental, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(446, 798);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(889, 88);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnAddCarRental
            // 
            this.btnAddCarRental.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddCarRental.BackColor = System.Drawing.Color.Azure;
            this.btnAddCarRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCarRental.FlatAppearance.BorderSize = 5;
            this.btnAddCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCarRental.Image = global::TravelExpenses.Properties.Resources._1494979605_sign_add;
            this.btnAddCarRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCarRental.Location = new System.Drawing.Point(578, 6);
            this.btnAddCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddCarRental.Name = "btnAddCarRental";
            this.btnAddCarRental.Size = new System.Drawing.Size(305, 76);
            this.btnAddCarRental.TabIndex = 16;
            this.btnAddCarRental.Text = "Add Car Rental to the List";
            this.btnAddCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCarRental.UseVisualStyleBackColor = false;
            this.btnAddCarRental.Click += new System.EventHandler(this.btnAddCarRental_Click);
            // 
            // dgvCarRental
            // 
            this.dgvCarRental.AllowUserToAddRows = false;
            this.dgvCarRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PickUp,
            this.DropOff,
            this.CarType,
            this.Company,
            this.Days,
            this.CarCost,
            this.TaxesAndFees,
            this.DistricPay,
            this.PersonalUse,
            this.PersonalAmount,
            this.LDWInsuranse,
            this.SupplementalInsurance,
            this.ExtraInsura,
            this.ExtraInsuranceAmount,
            this.Total,
            this.Notes,
            this.Delete});
            this.dgvCarRental.Location = new System.Drawing.Point(37, 990);
            this.dgvCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCarRental.Name = "dgvCarRental";
            this.dgvCarRental.ReadOnly = true;
            this.dgvCarRental.RowHeadersWidth = 62;
            this.dgvCarRental.RowTemplate.Height = 30;
            this.dgvCarRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarRental.Size = new System.Drawing.Size(1298, 265);
            this.dgvCarRental.TabIndex = 2;
            this.dgvCarRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarRental_CellContentClick);
            // 
            // tlpCarRentalNavigationButtons
            // 
            this.tlpCarRentalNavigationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCarRentalNavigationButtons.ColumnCount = 3;
            this.tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2F));
            this.tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.8F));
            this.tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlpCarRentalNavigationButtons.Controls.Add(this.btnNextCarRental, 2, 0);
            this.tlpCarRentalNavigationButtons.Controls.Add(this.btnBackCarRental, 0, 0);
            this.tlpCarRentalNavigationButtons.Controls.Add(this.label1, 1, 0);
            this.tlpCarRentalNavigationButtons.Location = new System.Drawing.Point(1058, 1275);
            this.tlpCarRentalNavigationButtons.Margin = new System.Windows.Forms.Padding(6);
            this.tlpCarRentalNavigationButtons.Name = "tlpCarRentalNavigationButtons";
            this.tlpCarRentalNavigationButtons.RowCount = 1;
            this.tlpCarRentalNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCarRentalNavigationButtons.Size = new System.Drawing.Size(277, 69);
            this.tlpCarRentalNavigationButtons.TabIndex = 8;
            // 
            // btnNextCarRental
            // 
            this.btnNextCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextCarRental.FlatAppearance.BorderSize = 0;
            this.btnNextCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextCarRental.Image = ((System.Drawing.Image)(resources.GetObject("btnNextCarRental.Image")));
            this.btnNextCarRental.Location = new System.Drawing.Point(166, 6);
            this.btnNextCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.btnNextCarRental.Name = "btnNextCarRental";
            this.btnNextCarRental.Size = new System.Drawing.Size(95, 57);
            this.btnNextCarRental.TabIndex = 2;
            this.btnNextCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextCarRental.UseVisualStyleBackColor = true;
            this.btnNextCarRental.Click += new System.EventHandler(this.btnNextCarRental_Click);
            // 
            // btnBackCarRental
            // 
            this.btnBackCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackCarRental.FlatAppearance.BorderSize = 0;
            this.btnBackCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackCarRental.Image = ((System.Drawing.Image)(resources.GetObject("btnBackCarRental.Image")));
            this.btnBackCarRental.Location = new System.Drawing.Point(6, 6);
            this.btnBackCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackCarRental.Name = "btnBackCarRental";
            this.btnBackCarRental.Size = new System.Drawing.Size(71, 57);
            this.btnBackCarRental.TabIndex = 1;
            this.btnBackCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackCarRental.UseVisualStyleBackColor = true;
            this.btnBackCarRental.Click += new System.EventHandler(this.btnBackCarRental_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarList
            // 
            this.lblCarList.AutoSize = true;
            this.lblCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCarList.Location = new System.Drawing.Point(31, 915);
            this.lblCarList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarList.Name = "lblCarList";
            this.lblCarList.Size = new System.Drawing.Size(197, 29);
            this.lblCarList.TabIndex = 9;
            this.lblCarList.Text = "Car Rentals List";
            // 
            // btnCancelCarRental
            // 
            this.btnCancelCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelCarRental.FlatAppearance.BorderSize = 0;
            this.btnCancelCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCarRental.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCarRental.Image")));
            this.btnCancelCarRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelCarRental.Location = new System.Drawing.Point(9, 1279);
            this.btnCancelCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelCarRental.Name = "btnCancelCarRental";
            this.btnCancelCarRental.Size = new System.Drawing.Size(134, 65);
            this.btnCancelCarRental.TabIndex = 0;
            this.btnCancelCarRental.Text = "Cancel";
            this.btnCancelCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelCarRental.UseVisualStyleBackColor = true;
            this.btnCancelCarRental.Click += new System.EventHandler(this.btnCancelCarRental_Click);
            // 
            // PickUp
            // 
            this.PickUp.HeaderText = "Pick Up";
            this.PickUp.MinimumWidth = 8;
            this.PickUp.Name = "PickUp";
            this.PickUp.ReadOnly = true;
            this.PickUp.Width = 110;
            // 
            // DropOff
            // 
            this.DropOff.HeaderText = "Drop Off";
            this.DropOff.MinimumWidth = 8;
            this.DropOff.Name = "DropOff";
            this.DropOff.ReadOnly = true;
            this.DropOff.Width = 110;
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
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 8;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Visible = false;
            this.Company.Width = 150;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 8;
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Width = 110;
            // 
            // CarCost
            // 
            this.CarCost.HeaderText = "Car Cost";
            this.CarCost.MinimumWidth = 8;
            this.CarCost.Name = "CarCost";
            this.CarCost.ReadOnly = true;
            this.CarCost.Visible = false;
            this.CarCost.Width = 150;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Taxes & Fees";
            this.TaxesAndFees.MinimumWidth = 8;
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            this.TaxesAndFees.Width = 95;
            // 
            // DistricPay
            // 
            this.DistricPay.HeaderText = "District Pay";
            this.DistricPay.MinimumWidth = 8;
            this.DistricPay.Name = "DistricPay";
            this.DistricPay.ReadOnly = true;
            this.DistricPay.Width = 150;
            // 
            // PersonalUse
            // 
            this.PersonalUse.HeaderText = "Personal Use";
            this.PersonalUse.MinimumWidth = 8;
            this.PersonalUse.Name = "PersonalUse";
            this.PersonalUse.ReadOnly = true;
            this.PersonalUse.Visible = false;
            this.PersonalUse.Width = 150;
            // 
            // PersonalAmount
            // 
            this.PersonalAmount.HeaderText = "Personal Amount";
            this.PersonalAmount.MinimumWidth = 8;
            this.PersonalAmount.Name = "PersonalAmount";
            this.PersonalAmount.ReadOnly = true;
            this.PersonalAmount.Visible = false;
            this.PersonalAmount.Width = 150;
            // 
            // LDWInsuranse
            // 
            this.LDWInsuranse.HeaderText = "LDW Insurance";
            this.LDWInsuranse.MinimumWidth = 8;
            this.LDWInsuranse.Name = "LDWInsuranse";
            this.LDWInsuranse.ReadOnly = true;
            this.LDWInsuranse.Visible = false;
            this.LDWInsuranse.Width = 150;
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
            // ExtraInsura
            // 
            this.ExtraInsura.HeaderText = "Extra Insurance";
            this.ExtraInsura.MinimumWidth = 8;
            this.ExtraInsura.Name = "ExtraInsura";
            this.ExtraInsura.ReadOnly = true;
            this.ExtraInsura.Visible = false;
            this.ExtraInsura.Width = 150;
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
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 110;
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
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 150;
            // 
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 1356);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblCarList);
            this.Controls.Add(this.btnCancelCarRental);
            this.Controls.Add(this.tlpCarRentalNavigationButtons);
            this.Controls.Add(this.dgvCarRental);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCarRentalHeader);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CarRental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rentals";
            this.Load += new System.EventHandler(this.CarRental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.tblCarRentalNotes.ResumeLayout(false);
            this.tblCarRentalNotes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pPersonalAmount.ResumeLayout(false);
            this.pPersonalAmount.PerformLayout();
            this.pUsePersonalCarRental.ResumeLayout(false);
            this.pUsePersonalCarRental.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRental)).EndInit();
            this.tlpCarRentalNavigationButtons.ResumeLayout(false);
            this.tlpCarRentalNavigationButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarRentalHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblDropOffDateCarRental;
        private System.Windows.Forms.DateTimePicker dtpPickUpDateCarRental;
        private System.Windows.Forms.DateTimePicker dtpDropOffDateCarRental;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cbRentalCompany;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblCarCost;
        private System.Windows.Forms.TextBox txtCarCost;
        private System.Windows.Forms.Label lblTaxesAndFeesCarRental;
        private System.Windows.Forms.TextBox txtCarTaxesAndFees;
        private System.Windows.Forms.Button btnAddCarRental;
        private System.Windows.Forms.DataGridView dgvCarRental;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDistrictPayCarRental;
        private System.Windows.Forms.RadioButton rbNoDistrictPayCarRental;
        private System.Windows.Forms.RadioButton rbYesDistrictPayCarRental;
        private System.Windows.Forms.Label lblPersonalUseCarRental;
        private System.Windows.Forms.Panel pUsePersonalCarRental;
        private System.Windows.Forms.RadioButton rbNoPersonalUseCarRental;
        private System.Windows.Forms.RadioButton rbYesPersonalUseCarRental;
        private System.Windows.Forms.Label lblPersonalAmountCarRental;
        private System.Windows.Forms.Panel pPersonalAmount;
        private System.Windows.Forms.TextBox txtPersonalAmountCarRental;
        private System.Windows.Forms.TableLayoutPanel tblCarRentalNotes;
        private System.Windows.Forms.Label lblCarRentalNotes;
        private System.Windows.Forms.TextBox txtNotesCarRental;
        private System.Windows.Forms.TableLayoutPanel tlpCarRentalNavigationButtons;
        private System.Windows.Forms.Button btnCancelCarRental;
        private System.Windows.Forms.Button btnBackCarRental;
        private System.Windows.Forms.Button btnNextCarRental;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLDWInsurance;
        private System.Windows.Forms.TextBox txtLDWInsurance;
        private System.Windows.Forms.Label lblSupplementalInsurance;
        private System.Windows.Forms.TextBox txtSupplementalInsurance;
        private System.Windows.Forms.Label lblExtraInsurance;
        private System.Windows.Forms.CheckBox chxExtraInsurance;
        private System.Windows.Forms.Label lblExtraInsuranceAmount;
        private System.Windows.Forms.TextBox txtExtraInsuranceAmount;
        private System.Windows.Forms.Label lblTotalCarRental;
        private System.Windows.Forms.TextBox txtTotalCarRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistricPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDWInsuranse;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplementalInsurance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExtraInsura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraInsuranceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}