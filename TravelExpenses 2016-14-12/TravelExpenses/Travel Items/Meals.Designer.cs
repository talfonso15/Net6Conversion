﻿namespace TravelExpenses
{
    partial class Meals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meals));
            this.dtgMeals = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProvidedMeal = new System.Windows.Forms.Label();
            this.pProvidedMeal = new System.Windows.Forms.Panel();
            this.rbNoProvidedMeal = new System.Windows.Forms.RadioButton();
            this.rbYesProvidedMeal = new System.Windows.Forms.RadioButton();
            this.pbUncheckMeal = new System.Windows.Forms.Panel();
            this.lblUncheckMeal = new System.Windows.Forms.Label();
            this.lbMealsNotes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMealsNotes = new System.Windows.Forms.TextBox();
            this.tlNavButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextMeal = new System.Windows.Forms.Button();
            this.btnBackMeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMealsTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMealsTotal = new System.Windows.Forms.TextBox();
            this.lblMealsPerDiemRate = new System.Windows.Forms.Label();
            this.txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            this.btnCalculateMeals = new System.Windows.Forms.Button();
            this.lblInfoLink = new System.Windows.Forms.Label();
            this.linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.lblLunch = new System.Windows.Forms.Label();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblTotalPerDiemRate = new System.Windows.Forms.Label();
            this.lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            this.gbZipCode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeals)).BeginInit();
            this.pProvidedMeal.SuspendLayout();
            this.pbUncheckMeal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlNavButtons.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbZipCode.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMeals
            // 
            this.dtgMeals.AllowUserToAddRows = false;
            this.dtgMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Breakfast,
            this.Lunch,
            this.Dinner,
            this.Total});
            this.dtgMeals.Location = new System.Drawing.Point(38, 300);
            this.dtgMeals.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgMeals.Name = "dtgMeals";
            this.dtgMeals.RowHeadersWidth = 62;
            this.dtgMeals.Size = new System.Drawing.Size(1006, 517);
            this.dtgMeals.TabIndex = 0;
            this.dtgMeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMeals_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Breakfast
            // 
            this.Breakfast.HeaderText = "Breakfast";
            this.Breakfast.MinimumWidth = 8;
            this.Breakfast.Name = "Breakfast";
            this.Breakfast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Breakfast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Breakfast.Width = 150;
            // 
            // Lunch
            // 
            this.Lunch.HeaderText = "Lunch";
            this.Lunch.MinimumWidth = 8;
            this.Lunch.Name = "Lunch";
            this.Lunch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lunch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Lunch.Width = 150;
            // 
            // Dinner
            // 
            this.Dinner.HeaderText = "Dinner";
            this.Dinner.MinimumWidth = 8;
            this.Dinner.Name = "Dinner";
            this.Dinner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dinner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Dinner.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // lblProvidedMeal
            // 
            this.lblProvidedMeal.AutoSize = true;
            this.lblProvidedMeal.Location = new System.Drawing.Point(33, 38);
            this.lblProvidedMeal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProvidedMeal.Name = "lblProvidedMeal";
            this.lblProvidedMeal.Size = new System.Drawing.Size(476, 25);
            this.lblProvidedMeal.TabIndex = 1;
            this.lblProvidedMeal.Text = "Were any of the checked meals above provided to you?";
            // 
            // pProvidedMeal
            // 
            this.pProvidedMeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProvidedMeal.Controls.Add(this.rbNoProvidedMeal);
            this.pProvidedMeal.Controls.Add(this.rbYesProvidedMeal);
            this.pProvidedMeal.Controls.Add(this.lblProvidedMeal);
            this.pProvidedMeal.Location = new System.Drawing.Point(38, 938);
            this.pProvidedMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pProvidedMeal.Name = "pProvidedMeal";
            this.pProvidedMeal.Size = new System.Drawing.Size(1005, 102);
            this.pProvidedMeal.TabIndex = 2;
            // 
            // rbNoProvidedMeal
            // 
            this.rbNoProvidedMeal.AutoSize = true;
            this.rbNoProvidedMeal.Checked = true;
            this.rbNoProvidedMeal.Location = new System.Drawing.Point(829, 35);
            this.rbNoProvidedMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbNoProvidedMeal.Name = "rbNoProvidedMeal";
            this.rbNoProvidedMeal.Size = new System.Drawing.Size(62, 29);
            this.rbNoProvidedMeal.TabIndex = 3;
            this.rbNoProvidedMeal.TabStop = true;
            this.rbNoProvidedMeal.Text = "No";
            this.rbNoProvidedMeal.UseVisualStyleBackColor = true;
            this.rbNoProvidedMeal.CheckedChanged += new System.EventHandler(this.rbNoProvidedMeal_CheckedChanged);
            // 
            // rbYesProvidedMeal
            // 
            this.rbYesProvidedMeal.AutoSize = true;
            this.rbYesProvidedMeal.Location = new System.Drawing.Point(715, 35);
            this.rbYesProvidedMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbYesProvidedMeal.Name = "rbYesProvidedMeal";
            this.rbYesProvidedMeal.Size = new System.Drawing.Size(64, 29);
            this.rbYesProvidedMeal.TabIndex = 2;
            this.rbYesProvidedMeal.Text = "Yes";
            this.rbYesProvidedMeal.UseVisualStyleBackColor = true;
            this.rbYesProvidedMeal.CheckedChanged += new System.EventHandler(this.rbYesProvidedMeal_CheckedChanged);
            // 
            // pbUncheckMeal
            // 
            this.pbUncheckMeal.BackColor = System.Drawing.Color.Red;
            this.pbUncheckMeal.Controls.Add(this.lblUncheckMeal);
            this.pbUncheckMeal.Location = new System.Drawing.Point(38, 1190);
            this.pbUncheckMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbUncheckMeal.Name = "pbUncheckMeal";
            this.pbUncheckMeal.Size = new System.Drawing.Size(1006, 104);
            this.pbUncheckMeal.TabIndex = 3;
            this.pbUncheckMeal.Visible = false;
            // 
            // lblUncheckMeal
            // 
            this.lblUncheckMeal.AutoSize = true;
            this.lblUncheckMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUncheckMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUncheckMeal.Location = new System.Drawing.Point(262, 29);
            this.lblUncheckMeal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUncheckMeal.Name = "lblUncheckMeal";
            this.lblUncheckMeal.Size = new System.Drawing.Size(407, 33);
            this.lblUncheckMeal.TabIndex = 0;
            this.lblUncheckMeal.Text = "Please uncheck the free meal.";
            // 
            // lbMealsNotes
            // 
            this.lbMealsNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMealsNotes.AutoSize = true;
            this.lbMealsNotes.Location = new System.Drawing.Point(97, 37);
            this.lbMealsNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMealsNotes.Name = "lbMealsNotes";
            this.lbMealsNotes.Size = new System.Drawing.Size(65, 25);
            this.lbMealsNotes.TabIndex = 0;
            this.lbMealsNotes.Text = "Notes:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.68306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.31694F));
            this.tableLayoutPanel1.Controls.Add(this.lbMealsNotes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsNotes, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 1065);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtMealsNotes
            // 
            this.txtMealsNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMealsNotes.Location = new System.Drawing.Point(270, 12);
            this.txtMealsNotes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsNotes.Multiline = true;
            this.txtMealsNotes.Name = "txtMealsNotes";
            this.txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMealsNotes.Size = new System.Drawing.Size(723, 75);
            this.txtMealsNotes.TabIndex = 1;
            // 
            // tlNavButtons
            // 
            this.tlNavButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlNavButtons.ColumnCount = 3;
            this.tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.73913F));
            this.tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.26087F));
            this.tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlNavButtons.Controls.Add(this.btnNextMeal, 2, 0);
            this.tlNavButtons.Controls.Add(this.btnBackMeal, 0, 0);
            this.tlNavButtons.Controls.Add(this.label1, 1, 0);
            this.tlNavButtons.Location = new System.Drawing.Point(883, 1333);
            this.tlNavButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlNavButtons.Name = "tlNavButtons";
            this.tlNavButtons.RowCount = 1;
            this.tlNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlNavButtons.Size = new System.Drawing.Size(182, 100);
            this.tlNavButtons.TabIndex = 5;
            // 
            // btnNextMeal
            // 
            this.btnNextMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextMeal.FlatAppearance.BorderSize = 0;
            this.btnNextMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnNextMeal.Image")));
            this.btnNextMeal.Location = new System.Drawing.Point(110, 17);
            this.btnNextMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNextMeal.Name = "btnNextMeal";
            this.btnNextMeal.Size = new System.Drawing.Size(66, 65);
            this.btnNextMeal.TabIndex = 2;
            this.btnNextMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextMeal.UseVisualStyleBackColor = true;
            this.btnNextMeal.Click += new System.EventHandler(this.btnNextMeal_Click);
            // 
            // btnBackMeal
            // 
            this.btnBackMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackMeal.FlatAppearance.BorderSize = 0;
            this.btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMeal.Image")));
            this.btnBackMeal.Location = new System.Drawing.Point(11, 17);
            this.btnBackMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBackMeal.Name = "btnBackMeal";
            this.btnBackMeal.Size = new System.Drawing.Size(53, 65);
            this.btnBackMeal.TabIndex = 1;
            this.btnBackMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMeal.UseVisualStyleBackColor = true;
            this.btnBackMeal.Click += new System.EventHandler(this.btnBackMeal_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealsTotal
            // 
            this.lblMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMealsTotal.AutoSize = true;
            this.lblMealsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMealsTotal.Location = new System.Drawing.Point(705, 24);
            this.lblMealsTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealsTotal.Name = "lblMealsTotal";
            this.lblMealsTotal.Size = new System.Drawing.Size(80, 29);
            this.lblMealsTotal.TabIndex = 6;
            this.lblMealsTotal.Text = "Total:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68852F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            this.tableLayoutPanel3.Controls.Add(this.lblMealsTotal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMealsTotal, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(38, 837);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1006, 77);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txtMealsTotal
            // 
            this.txtMealsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsTotal.Location = new System.Drawing.Point(797, 22);
            this.txtMealsTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsTotal.Name = "txtMealsTotal";
            this.txtMealsTotal.ReadOnly = true;
            this.txtMealsTotal.Size = new System.Drawing.Size(203, 33);
            this.txtMealsTotal.TabIndex = 7;
            // 
            // lblMealsPerDiemRate
            // 
            this.lblMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealsPerDiemRate.AutoSize = true;
            this.lblMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMealsPerDiemRate.Location = new System.Drawing.Point(9, 60);
            this.lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            this.lblMealsPerDiemRate.Size = new System.Drawing.Size(153, 20);
            this.lblMealsPerDiemRate.TabIndex = 8;
            this.lblMealsPerDiemRate.Text = "Per Diem Rate:";
            // 
            // txtMealsPerDiemRate
            // 
            this.txtMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMealsPerDiemRate.Location = new System.Drawing.Point(177, 57);
            this.txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            this.txtMealsPerDiemRate.Size = new System.Drawing.Size(146, 26);
            this.txtMealsPerDiemRate.TabIndex = 9;
            this.txtMealsPerDiemRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMealsPerDiemRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnCalculateMeals
            // 
            this.btnCalculateMeals.Enabled = false;
            this.btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            this.btnCalculateMeals.Location = new System.Drawing.Point(845, 202);
            this.btnCalculateMeals.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalculateMeals.Name = "btnCalculateMeals";
            this.btnCalculateMeals.Size = new System.Drawing.Size(138, 44);
            this.btnCalculateMeals.TabIndex = 10;
            this.btnCalculateMeals.Text = "Calculate";
            this.btnCalculateMeals.UseVisualStyleBackColor = true;
            this.btnCalculateMeals.Click += new System.EventHandler(this.btnCalculateMeals_Click);
            // 
            // lblInfoLink
            // 
            this.lblInfoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoLink.AutoSize = true;
            this.lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoLink.Location = new System.Drawing.Point(9, 16);
            this.lblInfoLink.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfoLink.Name = "lblInfoLink";
            this.lblInfoLink.Size = new System.Drawing.Size(406, 20);
            this.lblInfoLink.TabIndex = 11;
            this.lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // linkLabelMealPerDiemRate
            // 
            this.linkLabelMealPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelMealPerDiemRate.AutoSize = true;
            this.linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelMealPerDiemRate.Location = new System.Drawing.Point(430, 16);
            this.linkLabelMealPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            this.linkLabelMealPerDiemRate.Size = new System.Drawing.Size(522, 20);
            this.linkLabelMealPerDiemRate.TabIndex = 12;
            this.linkLabelMealPerDiemRate.TabStop = true;
            this.linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            this.linkLabelMealPerDiemRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMealPerDiemRate_LinkClicked);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBreakfast.Location = new System.Drawing.Point(177, 12);
            this.lblBreakfast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(146, 20);
            this.lblBreakfast.TabIndex = 13;
            this.lblBreakfast.Text = "Breakfast";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            this.txtLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLunch.Location = new System.Drawing.Point(338, 57);
            this.txtLunch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(153, 26);
            this.txtLunch.TabIndex = 14;
            this.txtLunch.TextChanged += new System.EventHandler(this.txtLunch_TextChanged);
            this.txtLunch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunch_KeyPress);
            // 
            // lblLunch
            // 
            this.lblLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLunch.AutoSize = true;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLunch.Location = new System.Drawing.Point(338, 12);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(153, 20);
            this.lblLunch.TabIndex = 15;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinner
            // 
            this.txtDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDinner.Location = new System.Drawing.Point(506, 57);
            this.txtDinner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(147, 26);
            this.txtDinner.TabIndex = 16;
            this.txtDinner.TextChanged += new System.EventHandler(this.txtDinner_TextChanged);
            this.txtDinner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinner_KeyPress);
            // 
            // lblDinner
            // 
            this.lblDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinner.Location = new System.Drawing.Point(506, 12);
            this.lblDinner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(147, 20);
            this.lblDinner.TabIndex = 17;
            this.lblDinner.Text = "Dinner";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            this.lblTotalPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRate.AutoSize = true;
            this.lblTotalPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPerDiemRate.Location = new System.Drawing.Point(668, 12);
            this.lblTotalPerDiemRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            this.lblTotalPerDiemRate.Size = new System.Drawing.Size(135, 20);
            this.lblTotalPerDiemRate.TabIndex = 18;
            this.lblTotalPerDiemRate.Text = "Total";
            this.lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRateValue
            // 
            this.lblTotalPerDiemRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRateValue.AutoSize = true;
            this.lblTotalPerDiemRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPerDiemRateValue.Location = new System.Drawing.Point(668, 60);
            this.lblTotalPerDiemRateValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            this.lblTotalPerDiemRateValue.Size = new System.Drawing.Size(135, 20);
            this.lblTotalPerDiemRateValue.TabIndex = 19;
            this.lblTotalPerDiemRateValue.Text = "0";
            this.lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbZipCode
            // 
            this.gbZipCode.Controls.Add(this.tableLayoutPanel5);
            this.gbZipCode.Controls.Add(this.tableLayoutPanel4);
            this.gbZipCode.Controls.Add(this.tableLayoutPanel2);
            this.gbZipCode.Controls.Add(this.btnCalculateMeals);
            this.gbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbZipCode.Location = new System.Drawing.Point(38, 23);
            this.gbZipCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbZipCode.Name = "gbZipCode";
            this.gbZipCode.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbZipCode.Size = new System.Drawing.Size(988, 265);
            this.gbZipCode.TabIndex = 20;
            this.gbZipCode.TabStop = false;
            this.gbZipCode.Text = "U.S.  General Services Administration Per Diem Data";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.95393F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.04607F));
            this.tableLayoutPanel5.Controls.Add(this.lblInfoLink, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.linkLabelMealPerDiemRate, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(22, 31);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(961, 52);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.92593F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07407F));
            this.tableLayoutPanel4.Controls.Add(this.lblZipCode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtZipCode, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(22, 87);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(500, 56);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(9, 18);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(311, 20);
            this.lblZipCode.TabIndex = 13;
            this.lblZipCode.Text = "Zip code of the travel location:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipCode.Location = new System.Drawing.Point(335, 15);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(156, 26);
            this.txtZipCode.TabIndex = 14;
            this.txtZipCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86456F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09029F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28442F));
            this.tableLayoutPanel2.Controls.Add(this.lblMealsPerDiemRate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalPerDiemRateValue, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBreakfast, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalPerDiemRate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMealsPerDiemRate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDinner, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDinner, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLunch, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLunch, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 146);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(812, 100);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::TravelExpenses.Properties.Resources.Help2;
            this.btnHelp.Location = new System.Drawing.Point(1030, 50);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(55, 58);
            this.btnHelp.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnHelp, "Click here to see what you have to look for on the GSA page");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelMeal.FlatAppearance.BorderSize = 0;
            this.btnCancelMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMeal.Image")));
            this.btnCancelMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelMeal.Location = new System.Drawing.Point(38, 1365);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(133, 65);
            this.btnCancelMeal.TabIndex = 0;
            this.btnCancelMeal.Text = "Cancel";
            this.btnCancelMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            this.btnCancelMeal.Click += new System.EventHandler(this.btnCancelMeal_Click);
            // 
            // Meals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 1456);
            this.ControlBox = false;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbZipCode);
            this.Controls.Add(this.btnCancelMeal);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tlNavButtons);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbUncheckMeal);
            this.Controls.Add(this.pProvidedMeal);
            this.Controls.Add(this.dtgMeals);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Meals";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meals";
            this.Load += new System.EventHandler(this.Meals_Load);
            this.VisibleChanged += new System.EventHandler(this.Meals_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeals)).EndInit();
            this.pProvidedMeal.ResumeLayout(false);
            this.pProvidedMeal.PerformLayout();
            this.pbUncheckMeal.ResumeLayout(false);
            this.pbUncheckMeal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlNavButtons.ResumeLayout(false);
            this.tlNavButtons.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbZipCode.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMeals;
        private System.Windows.Forms.Label lblProvidedMeal;
        private System.Windows.Forms.Panel pProvidedMeal;
        private System.Windows.Forms.RadioButton rbNoProvidedMeal;
        private System.Windows.Forms.RadioButton rbYesProvidedMeal;
        private System.Windows.Forms.Panel pbUncheckMeal;
        private System.Windows.Forms.Label lblUncheckMeal;
        private System.Windows.Forms.Label lbMealsNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TableLayoutPanel tlNavButtons;
        private System.Windows.Forms.Button btnCancelMeal;
        private System.Windows.Forms.Button btnBackMeal;
        private System.Windows.Forms.Button btnNextMeal;
        private System.Windows.Forms.Label lblMealsTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtMealsTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Breakfast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lunch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
        private System.Windows.Forms.Button btnCalculateMeals;
        private System.Windows.Forms.Label lblInfoLink;
        private System.Windows.Forms.LinkLabel linkLabelMealPerDiemRate;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblTotalPerDiemRate;
        private System.Windows.Forms.Label lblTotalPerDiemRateValue;
        private System.Windows.Forms.GroupBox gbZipCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}