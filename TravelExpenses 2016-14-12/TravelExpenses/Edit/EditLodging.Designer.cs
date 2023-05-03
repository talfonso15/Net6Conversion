﻿namespace TravelExpenses
{
    partial class EditLodging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLodging));
            this.dgvEditLodgings = new System.Windows.Forms.DataGridView();
            this.FacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberofNights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostperNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherTaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LodgingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxesPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DirectorApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlGridviewButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelEditLod = new System.Windows.Forms.Button();
            this.btnEditLod = new System.Windows.Forms.Button();
            this.btnAddNewLod = new System.Windows.Forms.Button();
            this.btnDeleteLod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pEditing = new System.Windows.Forms.Panel();
            this.pDirectorApp = new System.Windows.Forms.Panel();
            this.rbNoDirectorApp = new System.Windows.Forms.RadioButton();
            this.rbYesDIrectorApp = new System.Windows.Forms.RadioButton();
            this.lblDirectorApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            this.lblDistrictPay = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFaciltyName = new System.Windows.Forms.Label();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.nudNumberOfNights = new System.Windows.Forms.NumericUpDown();
            this.lblCostPerNight = new System.Windows.Forms.Label();
            this.txtCostPerNight = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalLod = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblTaxesAndFeesPerNight = new System.Windows.Forms.Label();
            this.txtTaxesAndFeesPerNight = new System.Windows.Forms.TextBox();
            this.lblOtherTaxesAndFees = new System.Windows.Forms.Label();
            this.txtOtherTaxesAndFees = new System.Windows.Forms.TextBox();
            this.btnSaveLod = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditLodgings)).BeginInit();
            this.tlGridviewButtons.SuspendLayout();
            this.pEditing.SuspendLayout();
            this.pDirectorApp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfNights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditLodgings
            // 
            this.dgvEditLodgings.AllowUserToAddRows = false;
            this.dgvEditLodgings.AllowUserToResizeColumns = false;
            this.dgvEditLodgings.AllowUserToResizeRows = false;
            this.dgvEditLodgings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditLodgings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacilityName,
            this.NumberofNights,
            this.CostperNight,
            this.OtherTaxesAndFees,
            this.Total,
            this.LodgingId,
            this.taxesPerNight,
            this.DistrictPay,
            this.DirectorApproved,
            this.Notes});
            this.dgvEditLodgings.Location = new System.Drawing.Point(35, 98);
            this.dgvEditLodgings.Name = "dgvEditLodgings";
            this.dgvEditLodgings.ReadOnly = true;
            this.dgvEditLodgings.RowHeadersWidth = 62;
            this.dgvEditLodgings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditLodgings.Size = new System.Drawing.Size(839, 150);
            this.dgvEditLodgings.TabIndex = 1;
            // 
            // FacilityName
            // 
            this.FacilityName.HeaderText = "Facility Name";
            this.FacilityName.MinimumWidth = 8;
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.ReadOnly = true;
            this.FacilityName.Width = 250;
            // 
            // NumberofNights
            // 
            this.NumberofNights.HeaderText = "Number of Nights";
            this.NumberofNights.MinimumWidth = 8;
            this.NumberofNights.Name = "NumberofNights";
            this.NumberofNights.ReadOnly = true;
            this.NumberofNights.Width = 150;
            // 
            // CostperNight
            // 
            this.CostperNight.HeaderText = "Cost per Night";
            this.CostperNight.MinimumWidth = 8;
            this.CostperNight.Name = "CostperNight";
            this.CostperNight.ReadOnly = true;
            this.CostperNight.Width = 150;
            // 
            // OtherTaxesAndFees
            // 
            this.OtherTaxesAndFees.HeaderText = "Other Taxes & Fees";
            this.OtherTaxesAndFees.MinimumWidth = 8;
            this.OtherTaxesAndFees.Name = "OtherTaxesAndFees";
            this.OtherTaxesAndFees.ReadOnly = true;
            this.OtherTaxesAndFees.Visible = false;
            this.OtherTaxesAndFees.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // LodgingId
            // 
            this.LodgingId.HeaderText = "LodgingId";
            this.LodgingId.MinimumWidth = 8;
            this.LodgingId.Name = "LodgingId";
            this.LodgingId.ReadOnly = true;
            this.LodgingId.Visible = false;
            this.LodgingId.Width = 150;
            // 
            // taxesPerNight
            // 
            this.taxesPerNight.HeaderText = "taxes Per Night";
            this.taxesPerNight.MinimumWidth = 8;
            this.taxesPerNight.Name = "taxesPerNight";
            this.taxesPerNight.ReadOnly = true;
            this.taxesPerNight.Visible = false;
            this.taxesPerNight.Width = 150;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "DistrictPay";
            this.DistrictPay.MinimumWidth = 8;
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
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
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Notes.Visible = false;
            this.Notes.Width = 150;
            // 
            // tlGridviewButtons
            // 
            this.tlGridviewButtons.ColumnCount = 7;
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91667F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33333F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.916667F));
            this.tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tlGridviewButtons.Controls.Add(this.btnCancelEditLod, 0, 0);
            this.tlGridviewButtons.Controls.Add(this.btnEditLod, 6, 0);
            this.tlGridviewButtons.Controls.Add(this.btnAddNewLod, 4, 0);
            this.tlGridviewButtons.Controls.Add(this.btnDeleteLod, 2, 0);
            this.tlGridviewButtons.Controls.Add(this.label1, 1, 0);
            this.tlGridviewButtons.Controls.Add(this.label2, 3, 0);
            this.tlGridviewButtons.Controls.Add(this.label3, 5, 0);
            this.tlGridviewButtons.Location = new System.Drawing.Point(571, 27);
            this.tlGridviewButtons.Name = "tlGridviewButtons";
            this.tlGridviewButtons.RowCount = 1;
            this.tlGridviewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlGridviewButtons.Size = new System.Drawing.Size(316, 59);
            this.tlGridviewButtons.TabIndex = 2;
            // 
            // btnCancelEditLod
            // 
            this.btnCancelEditLod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEditLod.FlatAppearance.BorderSize = 0;
            this.btnCancelEditLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelEditLod.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEditLod.Image")));
            this.btnCancelEditLod.Location = new System.Drawing.Point(3, 3);
            this.btnCancelEditLod.Name = "btnCancelEditLod";
            this.btnCancelEditLod.Size = new System.Drawing.Size(50, 53);
            this.btnCancelEditLod.TabIndex = 2;
            this.btnCancelEditLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancelEditLod, "Close");
            this.btnCancelEditLod.UseVisualStyleBackColor = true;
            this.btnCancelEditLod.Click += new System.EventHandler(this.btnCancelEditLod_Click);
            // 
            // btnEditLod
            // 
            this.btnEditLod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLod.FlatAppearance.BorderSize = 0;
            this.btnEditLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditLod.Image = ((System.Drawing.Image)(resources.GetObject("btnEditLod.Image")));
            this.btnEditLod.Location = new System.Drawing.Point(251, 3);
            this.btnEditLod.Name = "btnEditLod";
            this.btnEditLod.Size = new System.Drawing.Size(62, 53);
            this.btnEditLod.TabIndex = 0;
            this.btnEditLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditLod, "Edit Logging");
            this.btnEditLod.UseVisualStyleBackColor = true;
            this.btnEditLod.Click += new System.EventHandler(this.btnEditLod_Click);
            // 
            // btnAddNewLod
            // 
            this.btnAddNewLod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewLod.FlatAppearance.BorderSize = 0;
            this.btnAddNewLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewLod.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewLod.Image")));
            this.btnAddNewLod.Location = new System.Drawing.Point(168, 3);
            this.btnAddNewLod.Name = "btnAddNewLod";
            this.btnAddNewLod.Size = new System.Drawing.Size(52, 53);
            this.btnAddNewLod.TabIndex = 3;
            this.btnAddNewLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddNewLod, "New Lodging");
            this.btnAddNewLod.UseVisualStyleBackColor = true;
            this.btnAddNewLod.Click += new System.EventHandler(this.btnAddNewLod_Click);
            // 
            // btnDeleteLod
            // 
            this.btnDeleteLod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLod.FlatAppearance.BorderSize = 0;
            this.btnDeleteLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLod.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLod.Image")));
            this.btnDeleteLod.Location = new System.Drawing.Point(85, 3);
            this.btnDeleteLod.Name = "btnDeleteLod";
            this.btnDeleteLod.Size = new System.Drawing.Size(51, 53);
            this.btnDeleteLod.TabIndex = 1;
            this.btnDeleteLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteLod, "Delete Lodging");
            this.btnDeleteLod.UseVisualStyleBackColor = true;
            this.btnDeleteLod.Click += new System.EventHandler(this.btnDeleteLod_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEditing
            // 
            this.pEditing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEditing.Controls.Add(this.pDirectorApp);
            this.pEditing.Controls.Add(this.panel1);
            this.pEditing.Controls.Add(this.tableLayoutPanel2);
            this.pEditing.Location = new System.Drawing.Point(35, 298);
            this.pEditing.Name = "pEditing";
            this.pEditing.Size = new System.Drawing.Size(839, 413);
            this.pEditing.TabIndex = 3;
            // 
            // pDirectorApp
            // 
            this.pDirectorApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDirectorApp.Controls.Add(this.rbNoDirectorApp);
            this.pDirectorApp.Controls.Add(this.rbYesDIrectorApp);
            this.pDirectorApp.Controls.Add(this.lblDirectorApp);
            this.pDirectorApp.Enabled = false;
            this.pDirectorApp.Location = new System.Drawing.Point(28, 340);
            this.pDirectorApp.Name = "pDirectorApp";
            this.pDirectorApp.Size = new System.Drawing.Size(779, 56);
            this.pDirectorApp.TabIndex = 2;
            // 
            // rbNoDirectorApp
            // 
            this.rbNoDirectorApp.AutoSize = true;
            this.rbNoDirectorApp.Location = new System.Drawing.Point(705, 17);
            this.rbNoDirectorApp.Name = "rbNoDirectorApp";
            this.rbNoDirectorApp.Size = new System.Drawing.Size(55, 24);
            this.rbNoDirectorApp.TabIndex = 2;
            this.rbNoDirectorApp.Text = "No";
            this.rbNoDirectorApp.UseVisualStyleBackColor = true;
            // 
            // rbYesDIrectorApp
            // 
            this.rbYesDIrectorApp.AutoSize = true;
            this.rbYesDIrectorApp.Location = new System.Drawing.Point(635, 17);
            this.rbYesDIrectorApp.Name = "rbYesDIrectorApp";
            this.rbYesDIrectorApp.Size = new System.Drawing.Size(62, 24);
            this.rbYesDIrectorApp.TabIndex = 1;
            this.rbYesDIrectorApp.Text = "Yes";
            this.rbYesDIrectorApp.UseVisualStyleBackColor = true;
            // 
            // lblDirectorApp
            // 
            this.lblDirectorApp.AutoSize = true;
            this.lblDirectorApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirectorApp.Location = new System.Drawing.Point(12, 18);
            this.lblDirectorApp.Name = "lblDirectorApp";
            this.lblDirectorApp.Size = new System.Drawing.Size(597, 20);
            this.lblDirectorApp.TabIndex = 0;
            this.lblDirectorApp.Text = "Did the director gave you his approval for the lodging reimbursement?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictPay);
            this.panel1.Controls.Add(this.rbYesDistrictPay);
            this.panel1.Controls.Add(this.lblDistrictPay);
            this.panel1.Location = new System.Drawing.Point(28, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 57);
            this.panel1.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            this.rbNoDistrictPay.AutoSize = true;
            this.rbNoDistrictPay.Location = new System.Drawing.Point(709, 17);
            this.rbNoDistrictPay.Name = "rbNoDistrictPay";
            this.rbNoDistrictPay.Size = new System.Drawing.Size(55, 24);
            this.rbNoDistrictPay.TabIndex = 2;
            this.rbNoDistrictPay.TabStop = true;
            this.rbNoDistrictPay.Text = "No";
            this.rbNoDistrictPay.UseVisualStyleBackColor = true;
            this.rbNoDistrictPay.CheckedChanged += new System.EventHandler(this.rbNoDistrictPay_CheckedChanged);
            // 
            // rbYesDistrictPay
            // 
            this.rbYesDistrictPay.AutoSize = true;
            this.rbYesDistrictPay.Location = new System.Drawing.Point(637, 17);
            this.rbYesDistrictPay.Name = "rbYesDistrictPay";
            this.rbYesDistrictPay.Size = new System.Drawing.Size(62, 24);
            this.rbYesDistrictPay.TabIndex = 1;
            this.rbYesDistrictPay.TabStop = true;
            this.rbYesDistrictPay.Text = "Yes";
            this.rbYesDistrictPay.UseVisualStyleBackColor = true;
            this.rbYesDistrictPay.CheckedChanged += new System.EventHandler(this.rbYesDistrictPay_CheckedChanged);
            // 
            // lblDistrictPay
            // 
            this.lblDistrictPay.AutoSize = true;
            this.lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistrictPay.Location = new System.Drawing.Point(12, 19);
            this.lblDistrictPay.Name = "lblDistrictPay";
            this.lblDistrictPay.Size = new System.Drawing.Size(341, 20);
            this.lblDistrictPay.TabIndex = 0;
            this.lblDistrictPay.Text = "Did the district pay for your lodging(s)?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.79661F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.20339F));
            this.tableLayoutPanel2.Controls.Add(this.lblFaciltyName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFacilityName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNumberOfNights, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudNumberOfNights, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCostPerNight, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCostPerNight, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalLod, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblNotes, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(117, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87301F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.50794F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(590, 247);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblFaciltyName
            // 
            this.lblFaciltyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFaciltyName.AutoSize = true;
            this.lblFaciltyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFaciltyName.Location = new System.Drawing.Point(4, 10);
            this.lblFaciltyName.Name = "lblFaciltyName";
            this.lblFaciltyName.Size = new System.Drawing.Size(215, 20);
            this.lblFaciltyName.TabIndex = 0;
            this.lblFaciltyName.Text = "Facility Name:";
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFacilityName.Location = new System.Drawing.Point(226, 5);
            this.txtFacilityName.Multiline = true;
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFacilityName.Size = new System.Drawing.Size(360, 30);
            this.txtFacilityName.TabIndex = 1;
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfNights.Location = new System.Drawing.Point(4, 49);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(215, 20);
            this.lblNumberOfNights.TabIndex = 2;
            this.lblNumberOfNights.Text = "Number of Nights:";
            // 
            // nudNumberOfNights
            // 
            this.nudNumberOfNights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudNumberOfNights.Location = new System.Drawing.Point(226, 46);
            this.nudNumberOfNights.Name = "nudNumberOfNights";
            this.nudNumberOfNights.Size = new System.Drawing.Size(120, 26);
            this.nudNumberOfNights.TabIndex = 3;
            this.nudNumberOfNights.ValueChanged += new System.EventHandler(this.nudNumberOfNights_ValueChanged);
            this.nudNumberOfNights.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumberOfNights_KeyUp);
            // 
            // lblCostPerNight
            // 
            this.lblCostPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostPerNight.AutoSize = true;
            this.lblCostPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostPerNight.Location = new System.Drawing.Point(4, 88);
            this.lblCostPerNight.Name = "lblCostPerNight";
            this.lblCostPerNight.Size = new System.Drawing.Size(215, 20);
            this.lblCostPerNight.TabIndex = 4;
            this.lblCostPerNight.Text = "Cost per Night:";
            // 
            // txtCostPerNight
            // 
            this.txtCostPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostPerNight.Location = new System.Drawing.Point(226, 85);
            this.txtCostPerNight.Name = "txtCostPerNight";
            this.txtCostPerNight.Size = new System.Drawing.Size(360, 26);
            this.txtCostPerNight.TabIndex = 5;
            this.txtCostPerNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPerNight_KeyPress);
            this.txtCostPerNight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCostPerNight_KeyUp);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(4, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(215, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotalLod
            // 
            this.txtTotalLod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalLod.Location = new System.Drawing.Point(226, 124);
            this.txtTotalLod.Name = "txtTotalLod";
            this.txtTotalLod.Size = new System.Drawing.Size(360, 26);
            this.txtTotalLod.TabIndex = 11;
            this.txtTotalLod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalLod_KeyPress);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.Location = new System.Drawing.Point(4, 191);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(215, 20);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(226, 161);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(360, 80);
            this.txtNotes.TabIndex = 13;
            // 
            // lblTaxesAndFeesPerNight
            // 
            this.lblTaxesAndFeesPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFeesPerNight.AutoSize = true;
            this.lblTaxesAndFeesPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxesAndFeesPerNight.Location = new System.Drawing.Point(560, 766);
            this.lblTaxesAndFeesPerNight.Name = "lblTaxesAndFeesPerNight";
            this.lblTaxesAndFeesPerNight.Size = new System.Drawing.Size(231, 20);
            this.lblTaxesAndFeesPerNight.TabIndex = 6;
            this.lblTaxesAndFeesPerNight.Text = "Taxes and Fees per Night:";
            this.lblTaxesAndFeesPerNight.Visible = false;
            // 
            // txtTaxesAndFeesPerNight
            // 
            this.txtTaxesAndFeesPerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxesAndFeesPerNight.Location = new System.Drawing.Point(590, 733);
            this.txtTaxesAndFeesPerNight.Name = "txtTaxesAndFeesPerNight";
            this.txtTaxesAndFeesPerNight.Size = new System.Drawing.Size(84, 26);
            this.txtTaxesAndFeesPerNight.TabIndex = 7;
            this.txtTaxesAndFeesPerNight.Text = "0";
            this.txtTaxesAndFeesPerNight.Visible = false;
            this.txtTaxesAndFeesPerNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxesAndFeesPerNight_KeyPress);
            this.txtTaxesAndFeesPerNight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxesAndFeesPerNight_KeyUp);
            // 
            // lblOtherTaxesAndFees
            // 
            this.lblOtherTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherTaxesAndFees.AutoSize = true;
            this.lblOtherTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOtherTaxesAndFees.Location = new System.Drawing.Point(339, 766);
            this.lblOtherTaxesAndFees.Name = "lblOtherTaxesAndFees";
            this.lblOtherTaxesAndFees.Size = new System.Drawing.Size(201, 20);
            this.lblOtherTaxesAndFees.TabIndex = 8;
            this.lblOtherTaxesAndFees.Text = "Other Taxes and Fees:";
            this.lblOtherTaxesAndFees.Visible = false;
            // 
            // txtOtherTaxesAndFees
            // 
            this.txtOtherTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherTaxesAndFees.Location = new System.Drawing.Point(397, 733);
            this.txtOtherTaxesAndFees.Name = "txtOtherTaxesAndFees";
            this.txtOtherTaxesAndFees.Size = new System.Drawing.Size(83, 26);
            this.txtOtherTaxesAndFees.TabIndex = 9;
            this.txtOtherTaxesAndFees.Text = "0";
            this.txtOtherTaxesAndFees.Visible = false;
            this.txtOtherTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherTaxesAndFees_KeyPress);
            this.txtOtherTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtherTaxesAndFees_KeyUp);
            // 
            // btnSaveLod
            // 
            this.btnSaveLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveLod.FlatAppearance.BorderSize = 0;
            this.btnSaveLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveLod.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveLod.Image")));
            this.btnSaveLod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLod.Location = new System.Drawing.Point(812, 766);
            this.btnSaveLod.Name = "btnSaveLod";
            this.btnSaveLod.Size = new System.Drawing.Size(103, 50);
            this.btnSaveLod.TabIndex = 0;
            this.btnSaveLod.Text = "Save";
            this.btnSaveLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveLod.UseVisualStyleBackColor = true;
            this.btnSaveLod.Click += new System.EventHandler(this.btnSaveLod_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 766);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(35, 69);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(22, 23);
            this.btnInfo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnInfo, "Select a lodging from the list and then click on the option that you want to perf" +
        "orm on it.");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditLodging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 828);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveLod);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTaxesAndFeesPerNight);
            this.Controls.Add(this.pEditing);
            this.Controls.Add(this.tlGridviewButtons);
            this.Controls.Add(this.dgvEditLodgings);
            this.Controls.Add(this.txtOtherTaxesAndFees);
            this.Controls.Add(this.lblOtherTaxesAndFees);
            this.Controls.Add(this.txtTaxesAndFeesPerNight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditLodging";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Lodgings";
            this.Load += new System.EventHandler(this.EditLodging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditLodgings)).EndInit();
            this.tlGridviewButtons.ResumeLayout(false);
            this.tlGridviewButtons.PerformLayout();
            this.pEditing.ResumeLayout(false);
            this.pDirectorApp.ResumeLayout(false);
            this.pDirectorApp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfNights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEditLodgings;
        private System.Windows.Forms.TableLayoutPanel tlGridviewButtons;
        private System.Windows.Forms.Button btnEditLod;
        private System.Windows.Forms.Button btnDeleteLod;
        private System.Windows.Forms.Button btnCancelEditLod;
        private System.Windows.Forms.Panel pEditing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFaciltyName;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.NumericUpDown nudNumberOfNights;
        private System.Windows.Forms.Label lblCostPerNight;
        private System.Windows.Forms.TextBox txtCostPerNight;
        private System.Windows.Forms.Label lblTaxesAndFeesPerNight;
        private System.Windows.Forms.TextBox txtTaxesAndFeesPerNight;
        private System.Windows.Forms.Label lblOtherTaxesAndFees;
        private System.Windows.Forms.TextBox txtOtherTaxesAndFees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalLod;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistrictPay;
        private System.Windows.Forms.Label lblDistrictPay;
        private System.Windows.Forms.Panel pDirectorApp;
        private System.Windows.Forms.Label lblDirectorApp;
        private System.Windows.Forms.RadioButton rbNoDirectorApp;
        private System.Windows.Forms.RadioButton rbYesDIrectorApp;
        private System.Windows.Forms.Button btnSaveLod;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewLod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofNights;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostperNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherTaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn LodgingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxesPerNight;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DirectorApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}