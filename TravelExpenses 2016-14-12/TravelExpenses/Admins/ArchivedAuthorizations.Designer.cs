namespace TravelExpenses
{
    partial class ArchivedAuthorizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivedAuthorizations));
            this.dgvAthorizations = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAthorizations
            // 
            this.dgvAthorizations.AllowUserToAddRows = false;
            this.dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthorizations.Location = new System.Drawing.Point(24, 105);
            this.dgvAthorizations.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAthorizations.Name = "dgvAthorizations";
            this.dgvAthorizations.RowHeadersWidth = 62;
            this.dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthorizations.Size = new System.Drawing.Size(1377, 973);
            this.dgvAthorizations.TabIndex = 0;
            this.dgvAthorizations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAthorizations_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dgvAthorizations);
            this.panel1.Location = new System.Drawing.Point(38, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 1110);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.28571F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPDF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1168, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(150, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 75);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(8, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(81, 75);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cbEmployee);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Location = new System.Drawing.Point(38, 127);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 96);
            this.panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(851, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 67);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(270, 29);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(526, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(24, 35);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(155, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Select Employee:";
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 8;
            this.Departure.Name = "Departure";
            this.Departure.Width = 80;
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.MinimumWidth = 8;
            this.Return.Name = "Return";
            this.Return.Width = 80;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.MinimumWidth = 8;
            this.Event.Name = "Event";
            this.Event.Width = 100;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.MinimumWidth = 8;
            this.Purpose.Name = "Purpose";
            this.Purpose.Visible = false;
            this.Purpose.Width = 100;
            // 
            // Budgeted
            // 
            this.Budgeted.HeaderText = "Budgeted";
            this.Budgeted.MinimumWidth = 8;
            this.Budgeted.Name = "Budgeted";
            this.Budgeted.Width = 60;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.User.Width = 100;
            // 
            // EstimatedTotal
            // 
            this.EstimatedTotal.HeaderText = "Estimate Total";
            this.EstimatedTotal.MinimumWidth = 8;
            this.EstimatedTotal.Name = "EstimatedTotal";
            this.EstimatedTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EstimatedTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EstimatedTotal.Width = 100;
            // 
            // TravelID
            // 
            this.TravelID.HeaderText = "TravelID";
            this.TravelID.MinimumWidth = 8;
            this.TravelID.Name = "TravelID";
            this.TravelID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TravelID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TravelID.Visible = false;
            this.TravelID.Width = 100;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            this.UserID.Width = 100;
            // 
            // District
            // 
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 8;
            this.District.Name = "District";
            this.District.Visible = false;
            this.District.Width = 100;
            
            // 
            // ArchivedAuthorizations
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 1385);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ArchivedAuthorizations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archived Authorizations";
            this.Load += new System.EventHandler(this.ArchivedAuthorizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
       
    }
}