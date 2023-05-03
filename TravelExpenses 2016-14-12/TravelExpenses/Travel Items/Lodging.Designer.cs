﻿namespace TravelExpenses
{
    partial class Lodging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lodging));
            this.dtgLodgings = new System.Windows.Forms.DataGridView();
            this.FacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfNights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DirectorApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFeesPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblLodgingHeader = new System.Windows.Forms.Label();
            this.tblLodging = new System.Windows.Forms.TableLayoutPanel();
            this.lblFacilityName = new System.Windows.Forms.Label();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.txtCostPerNight = new System.Windows.Forms.TextBox();
            this.lblCostPerNight = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.nudNumberNights = new System.Windows.Forms.NumericUpDown();
            this.lblDifferentRates = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbYesDiffRates = new System.Windows.Forms.RadioButton();
            this.rbNoDifRates = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtLodgingNotes = new System.Windows.Forms.TextBox();
            this.txtTaxesAndFees = new System.Windows.Forms.TextBox();
            this.lblTaxesFeesOther = new System.Windows.Forms.Label();
            this.txtOtherTaxesAndFees = new System.Windows.Forms.TextBox();
            this.lblTaxesAndFees = new System.Windows.Forms.Label();
            this.pLodging = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnDirectorApprovedLodging = new System.Windows.Forms.Panel();
            this.rbNoApprovedLodging = new System.Windows.Forms.RadioButton();
            this.rbYesApprovedLodging = new System.Windows.Forms.RadioButton();
            this.lblDIrectorApprovedLodging = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPayLodging = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPayLodging = new System.Windows.Forms.RadioButton();
            this.lblDistrictPayLodging = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddLodging = new System.Windows.Forms.Button();
            this.tblLodgingNavigationButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLodgingList = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLodgings)).BeginInit();
            this.tblLodging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberNights)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pLodging.SuspendLayout();
            this.pnDirectorApprovedLodging.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLodgingNavigationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLodgings
            // 
            this.dtgLodgings.AllowUserToAddRows = false;
            this.dtgLodgings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLodgings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacilityName,
            this.NumberOfNights,
            this.CostPerNight,
            this.TaxesAndFees,
            this.Total,
            this.DistrictPay,
            this.DirectorApproved,
            this.Notes,
            this.TaxesAndFeesPerNight,
            this.Edit});
            this.dtgLodgings.Location = new System.Drawing.Point(64, 983);
            this.dtgLodgings.Margin = new System.Windows.Forms.Padding(6);
            this.dtgLodgings.Name = "dtgLodgings";
            this.dtgLodgings.ReadOnly = true;
            this.dtgLodgings.RowHeadersWidth = 62;
            this.dtgLodgings.RowTemplate.Height = 30;
            this.dtgLodgings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLodgings.Size = new System.Drawing.Size(1166, 252);
            this.dtgLodgings.TabIndex = 0;
            this.dtgLodgings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLodgings_CellContentClick);
            // 
            // FacilityName
            // 
            this.FacilityName.HeaderText = "Facility Name";
            this.FacilityName.MinimumWidth = 8;
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.ReadOnly = true;
            this.FacilityName.Width = 150;
            // 
            // NumberOfNights
            // 
            this.NumberOfNights.HeaderText = "Number of Nights";
            this.NumberOfNights.MinimumWidth = 8;
            this.NumberOfNights.Name = "NumberOfNights";
            this.NumberOfNights.ReadOnly = true;
            this.NumberOfNights.Width = 120;
            // 
            // CostPerNight
            // 
            this.CostPerNight.HeaderText = "Cost per Night";
            this.CostPerNight.MinimumWidth = 8;
            this.CostPerNight.Name = "CostPerNight";
            this.CostPerNight.ReadOnly = true;
            this.CostPerNight.Width = 150;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Other Fees";
            this.TaxesAndFees.MinimumWidth = 8;
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            this.TaxesAndFees.Width = 120;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "District Pay";
            this.DistrictPay.MinimumWidth = 8;
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
            this.DistrictPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DistrictPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DistrictPay.Visible = false;
            this.DistrictPay.Width = 150;
            // 
            // DirectorApproved
            // 
            this.DirectorApproved.HeaderText = "Director Approved";
            this.DirectorApproved.MinimumWidth = 8;
            this.DirectorApproved.Name = "DirectorApproved";
            this.DirectorApproved.ReadOnly = true;
            this.DirectorApproved.Visible = false;
            this.DirectorApproved.Width = 150;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            this.Notes.Width = 200;
            // 
            // TaxesAndFeesPerNight
            // 
            this.TaxesAndFeesPerNight.HeaderText = "Taxes and Fees Per Night";
            this.TaxesAndFeesPerNight.MinimumWidth = 8;
            this.TaxesAndFeesPerNight.Name = "TaxesAndFeesPerNight";
            this.TaxesAndFeesPerNight.ReadOnly = true;
            this.TaxesAndFeesPerNight.Visible = false;
            this.TaxesAndFeesPerNight.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 150;
            // 
            // lblLodgingHeader
            // 
            this.lblLodgingHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLodgingHeader.AutoSize = true;
            this.lblLodgingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLodgingHeader.Location = new System.Drawing.Point(62, 77);
            this.lblLodgingHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLodgingHeader.Name = "lblLodgingHeader";
            this.lblLodgingHeader.Size = new System.Drawing.Size(265, 29);
            this.lblLodgingHeader.TabIndex = 1;
            this.lblLodgingHeader.Text = "Enter Lodging Details";
            // 
            // tblLodging
            // 
            this.tblLodging.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLodging.ColumnCount = 2;
            this.tblLodging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tblLodging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40601F));
            this.tblLodging.Controls.Add(this.lblFacilityName, 0, 0);
            this.tblLodging.Controls.Add(this.txtFacilityName, 1, 0);
            this.tblLodging.Controls.Add(this.txtCostPerNight, 1, 3);
            this.tblLodging.Controls.Add(this.lblCostPerNight, 0, 3);
            this.tblLodging.Controls.Add(this.lblNumberOfNights, 0, 1);
            this.tblLodging.Controls.Add(this.nudNumberNights, 1, 1);
            this.tblLodging.Controls.Add(this.lblDifferentRates, 0, 2);
            this.tblLodging.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tblLodging.Controls.Add(this.lblTotal, 0, 4);
            this.tblLodging.Controls.Add(this.txtTotal, 1, 4);
            this.tblLodging.Controls.Add(this.lblNotes, 0, 5);
            this.tblLodging.Controls.Add(this.txtLodgingNotes, 1, 5);
            this.tblLodging.Location = new System.Drawing.Point(31, 25);
            this.tblLodging.Margin = new System.Windows.Forms.Padding(6);
            this.tblLodging.Name = "tblLodging";
            this.tblLodging.RowCount = 6;
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLodging.Size = new System.Drawing.Size(1076, 427);
            this.tblLodging.TabIndex = 2;
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFacilityName.AutoSize = true;
            this.lblFacilityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFacilityName.Location = new System.Drawing.Point(7, 26);
            this.lblFacilityName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.Size = new System.Drawing.Size(391, 20);
            this.lblFacilityName.TabIndex = 0;
            this.lblFacilityName.Text = "Facility Name:";
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFacilityName.Location = new System.Drawing.Point(411, 13);
            this.txtFacilityName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFacilityName.Multiline = true;
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFacilityName.Size = new System.Drawing.Size(658, 46);
            this.txtFacilityName.TabIndex = 1;
            // 
            // txtCostPerNight
            // 
            this.txtCostPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostPerNight.Location = new System.Drawing.Point(411, 232);
            this.txtCostPerNight.Margin = new System.Windows.Forms.Padding(6);
            this.txtCostPerNight.Name = "txtCostPerNight";
            this.txtCostPerNight.Size = new System.Drawing.Size(658, 33);
            this.txtCostPerNight.TabIndex = 5;
            this.txtCostPerNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPerNight_KeyPress);
            this.txtCostPerNight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCostPerNight_KeyUp);
            // 
            // lblCostPerNight
            // 
            this.lblCostPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostPerNight.AutoSize = true;
            this.lblCostPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostPerNight.Location = new System.Drawing.Point(7, 239);
            this.lblCostPerNight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCostPerNight.Name = "lblCostPerNight";
            this.lblCostPerNight.Size = new System.Drawing.Size(391, 20);
            this.lblCostPerNight.TabIndex = 4;
            this.lblCostPerNight.Text = "Cost Per Night:";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfNights.Location = new System.Drawing.Point(7, 97);
            this.lblNumberOfNights.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(391, 20);
            this.lblNumberOfNights.TabIndex = 2;
            this.lblNumberOfNights.Text = "Number Of Nights:";
            // 
            // nudNumberNights
            // 
            this.nudNumberNights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudNumberNights.Location = new System.Drawing.Point(411, 90);
            this.nudNumberNights.Margin = new System.Windows.Forms.Padding(6);
            this.nudNumberNights.Name = "nudNumberNights";
            this.nudNumberNights.Size = new System.Drawing.Size(220, 33);
            this.nudNumberNights.TabIndex = 3;
            this.nudNumberNights.ValueChanged += new System.EventHandler(this.nudNumberNights_ValueChanged);
            this.nudNumberNights.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumberNights_KeyUp);
            // 
            // lblDifferentRates
            // 
            this.lblDifferentRates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDifferentRates.AutoSize = true;
            this.lblDifferentRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDifferentRates.Location = new System.Drawing.Point(7, 168);
            this.lblDifferentRates.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDifferentRates.Name = "lblDifferentRates";
            this.lblDifferentRates.Size = new System.Drawing.Size(391, 20);
            this.lblDifferentRates.TabIndex = 15;
            this.lblDifferentRates.Text = "Do you have different rates per night??";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16667F));
            this.tableLayoutPanel2.Controls.Add(this.rbYesDiffRates, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbNoDifRates, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(411, 149);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 46);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // rbYesDiffRates
            // 
            this.rbYesDiffRates.AutoSize = true;
            this.rbYesDiffRates.Location = new System.Drawing.Point(6, 6);
            this.rbYesDiffRates.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesDiffRates.Name = "rbYesDiffRates";
            this.rbYesDiffRates.Size = new System.Drawing.Size(64, 29);
            this.rbYesDiffRates.TabIndex = 0;
            this.rbYesDiffRates.TabStop = true;
            this.rbYesDiffRates.Text = "Yes";
            this.rbYesDiffRates.UseVisualStyleBackColor = true;
            // 
            // rbNoDifRates
            // 
            this.rbNoDifRates.AutoSize = true;
            this.rbNoDifRates.Checked = true;
            this.rbNoDifRates.Location = new System.Drawing.Point(117, 6);
            this.rbNoDifRates.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoDifRates.Name = "rbNoDifRates";
            this.rbNoDifRates.Size = new System.Drawing.Size(62, 29);
            this.rbNoDifRates.TabIndex = 1;
            this.rbNoDifRates.TabStop = true;
            this.rbNoDifRates.Text = "No";
            this.rbNoDifRates.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(7, 310);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(391, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(411, 303);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(658, 33);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyUp);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.Location = new System.Drawing.Point(7, 381);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(391, 20);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notes:";
            // 
            // txtLodgingNotes
            // 
            this.txtLodgingNotes.Location = new System.Drawing.Point(411, 362);
            this.txtLodgingNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtLodgingNotes.Multiline = true;
            this.txtLodgingNotes.Name = "txtLodgingNotes";
            this.txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLodgingNotes.Size = new System.Drawing.Size(655, 58);
            this.txtLodgingNotes.TabIndex = 12;
            // 
            // txtTaxesAndFees
            // 
            this.txtTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxesAndFees.Location = new System.Drawing.Point(1129, 17);
            this.txtTaxesAndFees.Margin = new System.Windows.Forms.Padding(6);
            this.txtTaxesAndFees.Name = "txtTaxesAndFees";
            this.txtTaxesAndFees.Size = new System.Drawing.Size(130, 33);
            this.txtTaxesAndFees.TabIndex = 7;
            this.txtTaxesAndFees.Text = "0";
            this.txtTaxesAndFees.Visible = false;
            this.txtTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxesAndFees_KeyPress);
            this.txtTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxesAndFees_KeyUp);
            // 
            // lblTaxesFeesOther
            // 
            this.lblTaxesFeesOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesFeesOther.AutoSize = true;
            this.lblTaxesFeesOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxesFeesOther.Location = new System.Drawing.Point(836, 69);
            this.lblTaxesFeesOther.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTaxesFeesOther.Name = "lblTaxesFeesOther";
            this.lblTaxesFeesOther.Size = new System.Drawing.Size(201, 20);
            this.lblTaxesFeesOther.TabIndex = 13;
            this.lblTaxesFeesOther.Text = "Other Taxes and Fees:";
            this.lblTaxesFeesOther.Visible = false;
            // 
            // txtOtherTaxesAndFees
            // 
            this.txtOtherTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherTaxesAndFees.Location = new System.Drawing.Point(1129, 69);
            this.txtOtherTaxesAndFees.Margin = new System.Windows.Forms.Padding(6);
            this.txtOtherTaxesAndFees.Name = "txtOtherTaxesAndFees";
            this.txtOtherTaxesAndFees.Size = new System.Drawing.Size(130, 33);
            this.txtOtherTaxesAndFees.TabIndex = 14;
            this.txtOtherTaxesAndFees.Text = "0";
            this.txtOtherTaxesAndFees.Visible = false;
            this.txtOtherTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherTaxesAndFees_KeyPress);
            this.txtOtherTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtherTaxesAndFees_KeyUp);
            // 
            // lblTaxesAndFees
            // 
            this.lblTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFees.AutoSize = true;
            this.lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxesAndFees.Location = new System.Drawing.Point(836, 23);
            this.lblTaxesAndFees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTaxesAndFees.Name = "lblTaxesAndFees";
            this.lblTaxesAndFees.Size = new System.Drawing.Size(197, 20);
            this.lblTaxesAndFees.TabIndex = 6;
            this.lblTaxesAndFees.Text = "Taxes/Fees Per Night:";
            this.lblTaxesAndFees.Visible = false;
            // 
            // pLodging
            // 
            this.pLodging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLodging.Controls.Add(this.button3);
            this.pLodging.Controls.Add(this.button1);
            this.pLodging.Controls.Add(this.pnDirectorApprovedLodging);
            this.pLodging.Controls.Add(this.panel1);
            this.pLodging.Controls.Add(this.tblLodging);
            this.pLodging.Location = new System.Drawing.Point(64, 127);
            this.pLodging.Margin = new System.Windows.Forms.Padding(6);
            this.pLodging.Name = "pLodging";
            this.pLodging.Size = new System.Drawing.Size(1164, 639);
            this.pLodging.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.button3.Location = new System.Drawing.Point(1111, 242);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 48);
            this.button3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button3, "If you have different rates each night, please type the average of the rates in t" +
        "his box");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.button1.Location = new System.Drawing.Point(1111, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 58);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "The total shown is calculated base on the numbers you entered \r\nabove but is just" +
        " an aproximation,  please enter the total in your invoice\r\n if it is different f" +
        "rom the calculated one.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnDirectorApprovedLodging
            // 
            this.pnDirectorApprovedLodging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDirectorApprovedLodging.Controls.Add(this.rbNoApprovedLodging);
            this.pnDirectorApprovedLodging.Controls.Add(this.rbYesApprovedLodging);
            this.pnDirectorApprovedLodging.Controls.Add(this.lblDIrectorApprovedLodging);
            this.pnDirectorApprovedLodging.Location = new System.Drawing.Point(29, 563);
            this.pnDirectorApprovedLodging.Margin = new System.Windows.Forms.Padding(6);
            this.pnDirectorApprovedLodging.Name = "pnDirectorApprovedLodging";
            this.pnDirectorApprovedLodging.Size = new System.Drawing.Size(1074, 48);
            this.pnDirectorApprovedLodging.TabIndex = 5;
            this.pnDirectorApprovedLodging.Visible = false;
            // 
            // rbNoApprovedLodging
            // 
            this.rbNoApprovedLodging.AutoSize = true;
            this.rbNoApprovedLodging.Location = new System.Drawing.Point(997, 8);
            this.rbNoApprovedLodging.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoApprovedLodging.Name = "rbNoApprovedLodging";
            this.rbNoApprovedLodging.Size = new System.Drawing.Size(62, 29);
            this.rbNoApprovedLodging.TabIndex = 2;
            this.rbNoApprovedLodging.TabStop = true;
            this.rbNoApprovedLodging.Text = "No";
            this.rbNoApprovedLodging.UseVisualStyleBackColor = true;
            // 
            // rbYesApprovedLodging
            // 
            this.rbYesApprovedLodging.AutoSize = true;
            this.rbYesApprovedLodging.Location = new System.Drawing.Point(908, 8);
            this.rbYesApprovedLodging.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesApprovedLodging.Name = "rbYesApprovedLodging";
            this.rbYesApprovedLodging.Size = new System.Drawing.Size(64, 29);
            this.rbYesApprovedLodging.TabIndex = 1;
            this.rbYesApprovedLodging.TabStop = true;
            this.rbYesApprovedLodging.Text = "Yes";
            this.rbYesApprovedLodging.UseVisualStyleBackColor = true;
            // 
            // lblDIrectorApprovedLodging
            // 
            this.lblDIrectorApprovedLodging.AutoSize = true;
            this.lblDIrectorApprovedLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDIrectorApprovedLodging.Location = new System.Drawing.Point(6, 12);
            this.lblDIrectorApprovedLodging.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDIrectorApprovedLodging.Name = "lblDIrectorApprovedLodging";
            this.lblDIrectorApprovedLodging.Size = new System.Drawing.Size(723, 20);
            this.lblDIrectorApprovedLodging.TabIndex = 0;
            this.lblDIrectorApprovedLodging.Text = "Did the director gave you his approval to be reimbursed for paying for your lodgi" +
    "ngs?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictPayLodging);
            this.panel1.Controls.Add(this.rbYesDistrictPayLodging);
            this.panel1.Controls.Add(this.lblDistrictPayLodging);
            this.panel1.Location = new System.Drawing.Point(31, 471);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 65);
            this.panel1.TabIndex = 5;
            // 
            // rbNoDistrictPayLodging
            // 
            this.rbNoDistrictPayLodging.AutoSize = true;
            this.rbNoDistrictPayLodging.Location = new System.Drawing.Point(996, 13);
            this.rbNoDistrictPayLodging.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoDistrictPayLodging.Name = "rbNoDistrictPayLodging";
            this.rbNoDistrictPayLodging.Size = new System.Drawing.Size(62, 29);
            this.rbNoDistrictPayLodging.TabIndex = 2;
            this.rbNoDistrictPayLodging.Text = "No";
            this.rbNoDistrictPayLodging.UseVisualStyleBackColor = true;
            this.rbNoDistrictPayLodging.CheckedChanged += new System.EventHandler(this.rbNoDistrictPayLodging_CheckedChanged);
            // 
            // rbYesDistrictPayLodging
            // 
            this.rbYesDistrictPayLodging.AutoSize = true;
            this.rbYesDistrictPayLodging.Checked = true;
            this.rbYesDistrictPayLodging.Location = new System.Drawing.Point(906, 13);
            this.rbYesDistrictPayLodging.Margin = new System.Windows.Forms.Padding(6);
            this.rbYesDistrictPayLodging.Name = "rbYesDistrictPayLodging";
            this.rbYesDistrictPayLodging.Size = new System.Drawing.Size(64, 29);
            this.rbYesDistrictPayLodging.TabIndex = 1;
            this.rbYesDistrictPayLodging.TabStop = true;
            this.rbYesDistrictPayLodging.Text = "Yes";
            this.rbYesDistrictPayLodging.UseVisualStyleBackColor = true;
            this.rbYesDistrictPayLodging.CheckedChanged += new System.EventHandler(this.rbYesDistrictPayLodging_CheckedChanged);
            // 
            // lblDistrictPayLodging
            // 
            this.lblDistrictPayLodging.AutoSize = true;
            this.lblDistrictPayLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistrictPayLodging.Location = new System.Drawing.Point(6, 21);
            this.lblDistrictPayLodging.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrictPayLodging.Name = "lblDistrictPayLodging";
            this.lblDistrictPayLodging.Size = new System.Drawing.Size(327, 20);
            this.lblDistrictPayLodging.TabIndex = 0;
            this.lblDistrictPayLodging.Text = "Did the district pay for your lodgings?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddLodging, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 775);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 90);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnAddLodging
            // 
            this.btnAddLodging.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddLodging.BackColor = System.Drawing.Color.Azure;
            this.btnAddLodging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddLodging.FlatAppearance.BorderSize = 5;
            this.btnAddLodging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLodging.Image = global::TravelExpenses.Properties.Resources._1494979605_sign_add;
            this.btnAddLodging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLodging.Location = new System.Drawing.Point(788, 6);
            this.btnAddLodging.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddLodging.Name = "btnAddLodging";
            this.btnAddLodging.Size = new System.Drawing.Size(282, 77);
            this.btnAddLodging.TabIndex = 10;
            this.btnAddLodging.Text = "Add Lodging to the List";
            this.btnAddLodging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLodging.UseVisualStyleBackColor = false;
            this.btnAddLodging.Click += new System.EventHandler(this.btnAddLodging_Click);
            // 
            // tblLodgingNavigationButtons
            // 
            this.tblLodgingNavigationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLodgingNavigationButtons.ColumnCount = 3;
            this.tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0685F));
            this.tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.93151F));
            this.tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblLodgingNavigationButtons.Controls.Add(this.btnBack, 0, 0);
            this.tblLodgingNavigationButtons.Controls.Add(this.label1, 1, 0);
            this.tblLodgingNavigationButtons.Controls.Add(this.btnNext, 2, 0);
            this.tblLodgingNavigationButtons.Location = new System.Drawing.Point(977, 1285);
            this.tblLodgingNavigationButtons.Margin = new System.Windows.Forms.Padding(6);
            this.tblLodgingNavigationButtons.Name = "tblLodgingNavigationButtons";
            this.tblLodgingNavigationButtons.RowCount = 1;
            this.tblLodgingNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLodgingNavigationButtons.Size = new System.Drawing.Size(286, 75);
            this.tblLodgingNavigationButtons.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(167, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 63);
            this.btnNext.TabIndex = 2;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(6, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 63);
            this.btnBack.TabIndex = 1;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLodgingList
            // 
            this.lblLodgingList.AutoSize = true;
            this.lblLodgingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLodgingList.Location = new System.Drawing.Point(57, 921);
            this.lblLodgingList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLodgingList.Name = "lblLodgingList";
            this.lblLodgingList.Size = new System.Drawing.Size(169, 29);
            this.lblLodgingList.TabIndex = 5;
            this.lblLodgingList.Text = "Lodgings List";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(18, 1285);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 65);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Lodging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1367);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblLodgingList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTaxesAndFees);
            this.Controls.Add(this.tblLodgingNavigationButtons);
            this.Controls.Add(this.pLodging);
            this.Controls.Add(this.lblLodgingHeader);
            this.Controls.Add(this.dtgLodgings);
            this.Controls.Add(this.lblTaxesAndFees);
            this.Controls.Add(this.lblTaxesFeesOther);
            this.Controls.Add(this.txtOtherTaxesAndFees);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Lodging";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lodgings";
            this.Load += new System.EventHandler(this.Lodging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLodgings)).EndInit();
            this.tblLodging.ResumeLayout(false);
            this.tblLodging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberNights)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pLodging.ResumeLayout(false);
            this.pnDirectorApprovedLodging.ResumeLayout(false);
            this.pnDirectorApprovedLodging.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLodgingNavigationButtons.ResumeLayout(false);
            this.tblLodgingNavigationButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLodgings;
        private System.Windows.Forms.Label lblLodgingHeader;
        private System.Windows.Forms.TableLayoutPanel tblLodging;
        private System.Windows.Forms.Label lblFacilityName;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.NumericUpDown nudNumberNights;
        private System.Windows.Forms.Label lblCostPerNight;
        private System.Windows.Forms.TextBox txtCostPerNight;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.TextBox txtTaxesAndFees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddLodging;
        private System.Windows.Forms.Panel pLodging;
        private System.Windows.Forms.TableLayoutPanel tblLodgingNavigationButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPayLodging;
        private System.Windows.Forms.RadioButton rbYesDistrictPayLodging;
        private System.Windows.Forms.Label lblDistrictPayLodging;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnDirectorApprovedLodging;
        private System.Windows.Forms.RadioButton rbNoApprovedLodging;
        private System.Windows.Forms.RadioButton rbYesApprovedLodging;
        private System.Windows.Forms.Label lblDIrectorApprovedLodging;
        private System.Windows.Forms.Label lblTaxesFeesOther;
        private System.Windows.Forms.TextBox txtOtherTaxesAndFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLodgingList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDifferentRates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbYesDiffRates;
        private System.Windows.Forms.RadioButton rbNoDifRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNights;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DirectorApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFeesPerNight;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}