﻿namespace TravelExpenses
{
    partial class SuperAdminTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminTravels));
            this.pnCriteria = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblShowBy = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.cbtravels = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTravels = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnCriteria.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCriteria
            // 
            this.pnCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCriteria.Controls.Add(this.tableLayoutPanel1);
            this.pnCriteria.Controls.Add(this.btnShow);
            this.pnCriteria.Location = new System.Drawing.Point(38, 58);
            this.pnCriteria.Margin = new System.Windows.Forms.Padding(6);
            this.pnCriteria.Name = "pnCriteria";
            this.pnCriteria.Size = new System.Drawing.Size(1155, 192);
            this.pnCriteria.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.28685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.71315F));
            this.tableLayoutPanel1.Controls.Add(this.lblShowBy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDepartments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbtravels, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartments, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 165);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblShowBy
            // 
            this.lblShowBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowBy.AutoSize = true;
            this.lblShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShowBy.Location = new System.Drawing.Point(6, 15);
            this.lblShowBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowBy.Name = "lblShowBy";
            this.lblShowBy.Size = new System.Drawing.Size(248, 25);
            this.lblShowBy.TabIndex = 0;
            this.lblShowBy.Text = "Filter travels by:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(6, 71);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(248, 22);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Select Employee:";
            // 
            // lblDepartments
            // 
            this.lblDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartments.Location = new System.Drawing.Point(6, 126);
            this.lblDepartments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(248, 22);
            this.lblDepartments.TabIndex = 2;
            this.lblDepartments.Text = "Select Department:";
            // 
            // cbtravels
            // 
            this.cbtravels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtravels.FormattingEnabled = true;
            this.cbtravels.Items.AddRange(new object[] {
            "All",
            "Department",
            "Employee"});
            this.cbtravels.Location = new System.Drawing.Point(266, 11);
            this.cbtravels.Margin = new System.Windows.Forms.Padding(6);
            this.cbtravels.Name = "cbtravels";
            this.cbtravels.Size = new System.Drawing.Size(648, 33);
            this.cbtravels.TabIndex = 3;
            this.cbtravels.SelectedIndexChanged += new System.EventHandler(this.cbtravels_SelectedIndexChanged);
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(266, 66);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(648, 33);
            this.cbEmployee.TabIndex = 4;
            // 
            // cbDepartments
            // 
            this.cbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cbDepartments.Location = new System.Drawing.Point(266, 121);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(6);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(648, 33);
            this.cbDepartments.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(1082, 121);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 63);
            this.btnShow.TabIndex = 1;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.dgvTravels);
            this.panel2.Location = new System.Drawing.Point(38, 321);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1824, 790);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.262537F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78906F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.265651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78906F));
            this.tableLayoutPanel2.Controls.Add(this.btnChangeStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDF, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnView, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1280, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 79);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Image = global::TravelExpenses.Properties.Resources.Change_status_1;
            this.btnChangeStatus.Location = new System.Drawing.Point(6, 6);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(72, 67);
            this.btnChangeStatus.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnChangeStatus, "Change Status");
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Visible = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(455, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 67);
            this.btnClose.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(426, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(342, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(72, 67);
            this.btnPDF.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPDF, "Generate PDF");
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(314, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(230, 6);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 67);
            this.btnView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnView, "View Details");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(118, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 67);
            this.btnDelete.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Travel");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTravels
            // 
            this.dgvTravels.AllowUserToAddRows = false;
            this.dgvTravels.AllowUserToResizeRows = false;
            this.dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Return,
            this.Event,
            this.Destination,
            this.Employee,
            this.Status,
            this.Total,
            this.TravelID,
            this.UserID});
            this.dgvTravels.Location = new System.Drawing.Point(33, 113);
            this.dgvTravels.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTravels.MultiSelect = false;
            this.dgvTravels.Name = "dgvTravels";
            this.dgvTravels.ReadOnly = true;
            this.dgvTravels.RowHeadersWidth = 62;
            this.dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravels.Size = new System.Drawing.Size(1756, 638);
            this.dgvTravels.TabIndex = 0;
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
            this.Event.Width = 250;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 8;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.Width = 225;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 8;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
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
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // SuperAdminTravels
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1160);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCriteria);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuperAdminTravels";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Admin Travels";
            this.Load += new System.EventHandler(this.SuperAdminTravels_Load);
            this.pnCriteria.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCriteria;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShowBy;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbtravels;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label label4;
    }
}