namespace TravelExpenses
{
    partial class EditThirdPartyTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditThirdPartyTravel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowTravels = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditTravel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTravels = new System.Windows.Forms.DataGridView();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShowTravels);
            this.panel1.Controls.Add(this.cbEmployee);
            this.panel1.Controls.Add(this.lblEmployees);
            this.panel1.Location = new System.Drawing.Point(77, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnShowTravels
            // 
            this.btnShowTravels.FlatAppearance.BorderSize = 0;
            this.btnShowTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowTravels.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTravels.Image")));
            this.btnShowTravels.Location = new System.Drawing.Point(673, 17);
            this.btnShowTravels.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowTravels.Name = "btnShowTravels";
            this.btnShowTravels.Size = new System.Drawing.Size(90, 79);
            this.btnShowTravels.TabIndex = 2;
            this.btnShowTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowTravels.UseVisualStyleBackColor = true;
            this.btnShowTravels.Click += new System.EventHandler(this.btnShowTravels_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(246, 39);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(380, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.Location = new System.Drawing.Point(48, 46);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(155, 20);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Select Employee:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.dgvTravels);
            this.panel2.Location = new System.Drawing.Point(77, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 581);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditTravel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(897, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(109, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 67);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditTravel
            // 
            this.btnEditTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditTravel.FlatAppearance.BorderSize = 0;
            this.btnEditTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTravel.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTravel.Image")));
            this.btnEditTravel.Location = new System.Drawing.Point(6, 6);
            this.btnEditTravel.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditTravel.Name = "btnEditTravel";
            this.btnEditTravel.Size = new System.Drawing.Size(66, 67);
            this.btnEditTravel.TabIndex = 1;
            this.btnEditTravel.UseVisualStyleBackColor = true;
            this.btnEditTravel.Click += new System.EventHandler(this.btnEditTravel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTravels
            // 
            this.dgvTravels.AllowUserToAddRows = false;
            this.dgvTravels.AllowUserToDeleteRows = false;
            this.dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.Event,
            this.UserName,
            this.TravelID,
            this.UserID});
            this.dgvTravels.Location = new System.Drawing.Point(31, 94);
            this.dgvTravels.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTravels.MultiSelect = false;
            this.dgvTravels.Name = "dgvTravels";
            this.dgvTravels.ReadOnly = true;
            this.dgvTravels.RowHeadersWidth = 62;
            this.dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravels.Size = new System.Drawing.Size(1023, 458);
            this.dgvTravels.TabIndex = 0;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure";
            this.DepartureDate.MinimumWidth = 8;
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 150;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.MinimumWidth = 8;
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 200;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
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
            // EditThirdPartyTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 835);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditThirdPartyTravel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Third Party Travel";
            this.Load += new System.EventHandler(this.EditThirdPartyTravel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnShowTravels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditTravel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}