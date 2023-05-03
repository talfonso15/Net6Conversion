namespace TravelExpenses
{
    partial class SuperAdminAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminAuthorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAthorizations = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnArchive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MileagePersonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(48, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 123);
            this.panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(925, 27);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(70, 75);
            this.btnShow.TabIndex = 1;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78618F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployee, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(6, 20);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(219, 22);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(237, 15);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(606, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvAthorizations);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(48, 254);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1507, 839);
            this.panel2.TabIndex = 1;
            // 
            // dgvAthorizations
            // 
            this.dgvAthorizations.AllowUserToAddRows = false;
            this.dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthorizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Return,
            this.Event,
            this.Purpose,
            this.Budgeted,
            this.User,
            this.EstimateTotal,
            this.TravelID,
            this.UserID,
            this.District,
            this.Department1,
            this.MileagePersonal});
            this.dgvAthorizations.Location = new System.Drawing.Point(42, 119);
            this.dgvAthorizations.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAthorizations.MultiSelect = false;
            this.dgvAthorizations.Name = "dgvAthorizations";
            this.dgvAthorizations.ReadOnly = true;
            this.dgvAthorizations.RowHeadersWidth = 62;
            this.dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthorizations.Size = new System.Drawing.Size(1430, 681);
            this.dgvAthorizations.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.285436F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.285436F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.232582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69774F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.234442F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69542F));
            this.tableLayoutPanel2.Controls.Add(this.btnArchive, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDF, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnView, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1010, 21);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.Location = new System.Drawing.Point(6, 6);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(6);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(63, 75);
            this.btnArchive.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnArchive, "Archive Authorization");
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Visible = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(181, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(406, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 73);
            this.btnClose.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(306, 7);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(63, 73);
            this.btnPDF.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPDF, "PDF");
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(281, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 25);
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
            this.btnView.Location = new System.Drawing.Point(206, 6);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(63, 75);
            this.btnView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnView, "View Details");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(106, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 75);
            this.btnDelete.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Authorization");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 8;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Departure.Width = 110;
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.MinimumWidth = 8;
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Return.Width = 110;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.MinimumWidth = 8;
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 250;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.MinimumWidth = 8;
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            this.Purpose.Width = 130;
            // 
            // Budgeted
            // 
            this.Budgeted.HeaderText = "Budgeted";
            this.Budgeted.MinimumWidth = 8;
            this.Budgeted.Name = "Budgeted";
            this.Budgeted.ReadOnly = true;
            this.Budgeted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Budgeted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Budgeted.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 200;
            // 
            // EstimateTotal
            // 
            this.EstimateTotal.HeaderText = "Estimate Total";
            this.EstimateTotal.MinimumWidth = 8;
            this.EstimateTotal.Name = "EstimateTotal";
            this.EstimateTotal.ReadOnly = true;
            this.EstimateTotal.Width = 200;
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
            // District
            // 
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 8;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Visible = false;
            this.District.Width = 150;
            // 
            // Department1
            // 
            this.Department1.HeaderText = "Department1";
            this.Department1.MinimumWidth = 8;
            this.Department1.Name = "Department1";
            this.Department1.ReadOnly = true;
            this.Department1.Visible = false;
            this.Department1.Width = 150;
            // 
            // MileagePersonal
            // 
            this.MileagePersonal.HeaderText = "MileagePersonal";
            this.MileagePersonal.MinimumWidth = 8;
            this.MileagePersonal.Name = "MileagePersonal";
            this.MileagePersonal.ReadOnly = true;
            this.MileagePersonal.Visible = false;
            this.MileagePersonal.Width = 150;
            // 
            // SuperAdminAuthorization
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1117);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuperAdminAuthorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Admin Authorization";
            this.Load += new System.EventHandler(this.SuperAdminAuthorization_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MileagePersonal;
    }
}