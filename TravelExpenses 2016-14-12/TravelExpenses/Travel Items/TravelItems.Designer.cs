namespace TravelExpenses
{
    partial class TravelItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelItems));
            this.lblSelectionHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chxMeals = new System.Windows.Forms.CheckBox();
            this.chxLodging = new System.Windows.Forms.CheckBox();
            this.chxFlight = new System.Windows.Forms.CheckBox();
            this.chxCarRental = new System.Windows.Forms.CheckBox();
            this.chxMileage = new System.Windows.Forms.CheckBox();
            this.chxOtherExpenses = new System.Windows.Forms.CheckBox();
            this.chxRegistration = new System.Windows.Forms.CheckBox();
            this.chxSelectAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextTravelItems = new System.Windows.Forms.Button();
            this.btnBackTravelItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelTravelItems = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectionHeader
            // 
            this.lblSelectionHeader.AutoSize = true;
            this.lblSelectionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectionHeader.Location = new System.Drawing.Point(213, 67);
            this.lblSelectionHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectionHeader.Name = "lblSelectionHeader";
            this.lblSelectionHeader.Size = new System.Drawing.Size(341, 32);
            this.lblSelectionHeader.TabIndex = 0;
            this.lblSelectionHeader.Text = "Select your Travel Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.53271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.46729F));
            this.tableLayoutPanel1.Controls.Add(this.chxMeals, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxLodging, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxFlight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chxCarRental, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chxMileage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chxOtherExpenses, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chxRegistration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chxSelectAll, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(154, 158);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 452);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chxMeals
            // 
            this.chxMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMeals.AutoSize = true;
            this.chxMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxMeals.Location = new System.Drawing.Point(6, 41);
            this.chxMeals.Margin = new System.Windows.Forms.Padding(6);
            this.chxMeals.Name = "chxMeals";
            this.chxMeals.Size = new System.Drawing.Size(278, 29);
            this.chxMeals.TabIndex = 0;
            this.chxMeals.Text = "Meals";
            this.chxMeals.UseVisualStyleBackColor = true;
            // 
            // chxLodging
            // 
            this.chxLodging.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxLodging.AutoSize = true;
            this.chxLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxLodging.Location = new System.Drawing.Point(296, 41);
            this.chxLodging.Margin = new System.Windows.Forms.Padding(6);
            this.chxLodging.Name = "chxLodging";
            this.chxLodging.Size = new System.Drawing.Size(108, 29);
            this.chxLodging.TabIndex = 1;
            this.chxLodging.Text = "Lodging";
            this.chxLodging.UseVisualStyleBackColor = true;
            // 
            // chxFlight
            // 
            this.chxFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxFlight.AutoSize = true;
            this.chxFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxFlight.Location = new System.Drawing.Point(6, 155);
            this.chxFlight.Margin = new System.Windows.Forms.Padding(6);
            this.chxFlight.Name = "chxFlight";
            this.chxFlight.Size = new System.Drawing.Size(278, 29);
            this.chxFlight.TabIndex = 2;
            this.chxFlight.Text = "Flight";
            this.chxFlight.UseVisualStyleBackColor = true;
            // 
            // chxCarRental
            // 
            this.chxCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxCarRental.AutoSize = true;
            this.chxCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxCarRental.Location = new System.Drawing.Point(296, 155);
            this.chxCarRental.Margin = new System.Windows.Forms.Padding(6);
            this.chxCarRental.Name = "chxCarRental";
            this.chxCarRental.Size = new System.Drawing.Size(130, 29);
            this.chxCarRental.TabIndex = 3;
            this.chxCarRental.Text = "Car Rental";
            this.chxCarRental.UseVisualStyleBackColor = true;
            // 
            // chxMileage
            // 
            this.chxMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMileage.AutoSize = true;
            this.chxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxMileage.Location = new System.Drawing.Point(6, 270);
            this.chxMileage.Margin = new System.Windows.Forms.Padding(6);
            this.chxMileage.Name = "chxMileage";
            this.chxMileage.Size = new System.Drawing.Size(278, 29);
            this.chxMileage.TabIndex = 4;
            this.chxMileage.Text = "Mileage";
            this.chxMileage.UseVisualStyleBackColor = true;
            // 
            // chxOtherExpenses
            // 
            this.chxOtherExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxOtherExpenses.AutoSize = true;
            this.chxOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxOtherExpenses.Location = new System.Drawing.Point(296, 270);
            this.chxOtherExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.chxOtherExpenses.Name = "chxOtherExpenses";
            this.chxOtherExpenses.Size = new System.Drawing.Size(179, 29);
            this.chxOtherExpenses.TabIndex = 5;
            this.chxOtherExpenses.Text = "Other Expenses";
            this.chxOtherExpenses.UseVisualStyleBackColor = true;
            // 
            // chxRegistration
            // 
            this.chxRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxRegistration.AutoSize = true;
            this.chxRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxRegistration.Location = new System.Drawing.Point(6, 382);
            this.chxRegistration.Margin = new System.Windows.Forms.Padding(6);
            this.chxRegistration.Name = "chxRegistration";
            this.chxRegistration.Size = new System.Drawing.Size(278, 29);
            this.chxRegistration.TabIndex = 6;
            this.chxRegistration.Text = "Registration";
            this.chxRegistration.UseVisualStyleBackColor = true;
            // 
            // chxSelectAll
            // 
            this.chxSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxSelectAll.AutoSize = true;
            this.chxSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chxSelectAll.Location = new System.Drawing.Point(296, 382);
            this.chxSelectAll.Margin = new System.Windows.Forms.Padding(6);
            this.chxSelectAll.Name = "chxSelectAll";
            this.chxSelectAll.Size = new System.Drawing.Size(120, 29);
            this.chxSelectAll.TabIndex = 7;
            this.chxSelectAll.Text = "Select All";
            this.chxSelectAll.UseVisualStyleBackColor = true;
            this.chxSelectAll.CheckedChanged += new System.EventHandler(this.chxSelectAll_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.14925F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.btnNextTravelItems, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackTravelItems, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(579, 717);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 81);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnNextTravelItems
            // 
            this.btnNextTravelItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextTravelItems.FlatAppearance.BorderSize = 0;
            this.btnNextTravelItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextTravelItems.Image = ((System.Drawing.Image)(resources.GetObject("btnNextTravelItems.Image")));
            this.btnNextTravelItems.Location = new System.Drawing.Point(125, 8);
            this.btnNextTravelItems.Margin = new System.Windows.Forms.Padding(6);
            this.btnNextTravelItems.Name = "btnNextTravelItems";
            this.btnNextTravelItems.Size = new System.Drawing.Size(69, 65);
            this.btnNextTravelItems.TabIndex = 0;
            this.btnNextTravelItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextTravelItems.UseVisualStyleBackColor = true;
            this.btnNextTravelItems.Click += new System.EventHandler(this.btnNextTravelItems_Click);
            // 
            // btnBackTravelItems
            // 
            this.btnBackTravelItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackTravelItems.FlatAppearance.BorderSize = 0;
            this.btnBackTravelItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackTravelItems.Image = ((System.Drawing.Image)(resources.GetObject("btnBackTravelItems.Image")));
            this.btnBackTravelItems.Location = new System.Drawing.Point(6, 8);
            this.btnBackTravelItems.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackTravelItems.Name = "btnBackTravelItems";
            this.btnBackTravelItems.Size = new System.Drawing.Size(72, 65);
            this.btnBackTravelItems.TabIndex = 1;
            this.btnBackTravelItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackTravelItems.UseVisualStyleBackColor = true;
            this.btnBackTravelItems.Click += new System.EventHandler(this.btnBackTravelItems_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelTravelItems
            // 
            this.btnCancelTravelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelTravelItems.FlatAppearance.BorderSize = 0;
            this.btnCancelTravelItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelTravelItems.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTravelItems.Image")));
            this.btnCancelTravelItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelTravelItems.Location = new System.Drawing.Point(22, 733);
            this.btnCancelTravelItems.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelTravelItems.Name = "btnCancelTravelItems";
            this.btnCancelTravelItems.Size = new System.Drawing.Size(130, 65);
            this.btnCancelTravelItems.TabIndex = 2;
            this.btnCancelTravelItems.Text = "Cancel";
            this.btnCancelTravelItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelTravelItems.UseVisualStyleBackColor = true;
            this.btnCancelTravelItems.Click += new System.EventHandler(this.btnCancelTravelItems_Click);
            // 
            // TravelItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 821);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancelTravelItems);
            this.Controls.Add(this.lblSelectionHeader);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TravelItems";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Items";
            this.Load += new System.EventHandler(this.TravelItems_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chxMeals;
        private System.Windows.Forms.CheckBox chxLodging;
        private System.Windows.Forms.CheckBox chxFlight;
        private System.Windows.Forms.CheckBox chxCarRental;
        private System.Windows.Forms.CheckBox chxMileage;
        private System.Windows.Forms.CheckBox chxOtherExpenses;
        private System.Windows.Forms.CheckBox chxRegistration;
        private System.Windows.Forms.CheckBox chxSelectAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNextTravelItems;
        private System.Windows.Forms.Button btnBackTravelItems;
        private System.Windows.Forms.Button btnCancelTravelItems;
        private System.Windows.Forms.Label label1;
    }
}