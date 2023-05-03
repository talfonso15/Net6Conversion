namespace TravelExpenses
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowTravels = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinalizeTravel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTravels = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupervisorApproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHideApproved = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSupervisorAppr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShowTravels);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(51, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 106);
            this.panel1.TabIndex = 0;
            // 
            // btnShowTravels
            // 
            this.btnShowTravels.FlatAppearance.BorderSize = 0;
            this.btnShowTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowTravels.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTravels.Image")));
            this.btnShowTravels.Location = new System.Drawing.Point(664, 19);
            this.btnShowTravels.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowTravels.Name = "btnShowTravels";
            this.btnShowTravels.Size = new System.Drawing.Size(70, 68);
            this.btnShowTravels.TabIndex = 1;
            this.btnShowTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowTravels.UseVisualStyleBackColor = true;
            this.btnShowTravels.Click += new System.EventHandler(this.btnShowTravels_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94479F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05521F));
            this.tableLayoutPanel1.Controls.Add(this.lblSelectEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployee, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectEmployee.Location = new System.Drawing.Point(6, 17);
            this.lblSelectEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(244, 20);
            this.lblSelectEmployee.TabIndex = 0;
            this.lblSelectEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(262, 10);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(330, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dgvTravels);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(51, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1714, 656);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.51724F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.Controls.Add(this.btnFinalizeTravel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1158, 33);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(95, 85);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnFinalizeTravel
            // 
            this.btnFinalizeTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizeTravel.FlatAppearance.BorderSize = 0;
            this.btnFinalizeTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizeTravel.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizeTravel.Image")));
            this.btnFinalizeTravel.Location = new System.Drawing.Point(6, 6);
            this.btnFinalizeTravel.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalizeTravel.Name = "btnFinalizeTravel";
            this.btnFinalizeTravel.Size = new System.Drawing.Size(50, 73);
            this.btnFinalizeTravel.TabIndex = 2;
            this.btnFinalizeTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnFinalizeTravel, "Finalize travel");
            this.btnFinalizeTravel.UseVisualStyleBackColor = true;
            this.btnFinalizeTravel.Visible = false;
            this.btnFinalizeTravel.Click += new System.EventHandler(this.btnFinalizeTravel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80769F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.19231F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1603, 33);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(96, 85);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(34, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 67);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClose, "Close Window");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(112, 85);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 20);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Sending Notification Emails......";
            this.lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dgvTravels
            // 
            this.dgvTravels.AllowUserToAddRows = false;
            this.dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Return,
            this.Event,
            this.Purpose,
            this.Status,
            this.Origin,
            this.TravelDest,
            this.Total,
            this.TravelID,
            this.UserID,
            this.User,
            this.UserDepartment,
            this.SupervisorApproval});
            this.dgvTravels.Location = new System.Drawing.Point(50, 129);
            this.dgvTravels.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTravels.Name = "dgvTravels";
            this.dgvTravels.RowHeadersWidth = 62;
            this.dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravels.Size = new System.Drawing.Size(1634, 485);
            this.dgvTravels.TabIndex = 0;
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
            this.Event.Width = 120;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.MinimumWidth = 8;
            this.Purpose.Name = "Purpose";
            this.Purpose.Visible = false;
            this.Purpose.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Visible = false;
            this.Status.Width = 80;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.MinimumWidth = 8;
            this.Origin.Name = "Origin";
            this.Origin.Visible = false;
            this.Origin.Width = 120;
            // 
            // TravelDest
            // 
            this.TravelDest.HeaderText = "Destination";
            this.TravelDest.MinimumWidth = 8;
            this.TravelDest.Name = "TravelDest";
            this.TravelDest.Visible = false;
            this.TravelDest.Width = 120;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 60;
            // 
            // TravelID
            // 
            this.TravelID.HeaderText = "TravelID";
            this.TravelID.MinimumWidth = 8;
            this.TravelID.Name = "TravelID";
            this.TravelID.Visible = false;
            this.TravelID.Width = 150;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            this.UserID.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.Width = 150;
            // 
            // UserDepartment
            // 
            this.UserDepartment.HeaderText = "Department";
            this.UserDepartment.MinimumWidth = 8;
            this.UserDepartment.Name = "UserDepartment";
            this.UserDepartment.Visible = false;
            this.UserDepartment.Width = 150;
            // 
            // SupervisorApproval
            // 
            this.SupervisorApproval.HeaderText = "Approved";
            this.SupervisorApproval.MinimumWidth = 8;
            this.SupervisorApproval.Name = "SupervisorApproval";
            this.SupervisorApproval.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHideApproved, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDF, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnView, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSupervisorAppr, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1253, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 85);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHideApproved
            // 
            this.btnHideApproved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHideApproved.FlatAppearance.BorderSize = 0;
            this.btnHideApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHideApproved.Image = ((System.Drawing.Image)(resources.GetObject("btnHideApproved.Image")));
            this.btnHideApproved.Location = new System.Drawing.Point(6, 6);
            this.btnHideApproved.Margin = new System.Windows.Forms.Padding(6);
            this.btnHideApproved.Name = "btnHideApproved";
            this.btnHideApproved.Size = new System.Drawing.Size(48, 73);
            this.btnHideApproved.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnHideApproved, "Hide Approved Travels");
            this.btnHideApproved.UseVisualStyleBackColor = true;
            this.btnHideApproved.Click += new System.EventHandler(this.btnHideApproved_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(101, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(52, 73);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPDF, "Generate PDF");
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(256, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(284, 6);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(59, 73);
            this.btnView.TabIndex = 0;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnView, "View Travel Details");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSupervisorAppr
            // 
            this.btnSupervisorAppr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupervisorAppr.FlatAppearance.BorderSize = 0;
            this.btnSupervisorAppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupervisorAppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupervisorAppr.Image = ((System.Drawing.Image)(resources.GetObject("btnSupervisorAppr.Image")));
            this.btnSupervisorAppr.Location = new System.Drawing.Point(197, 6);
            this.btnSupervisorAppr.Margin = new System.Windows.Forms.Padding(6);
            this.btnSupervisorAppr.Name = "btnSupervisorAppr";
            this.btnSupervisorAppr.Size = new System.Drawing.Size(47, 73);
            this.btnSupervisorAppr.TabIndex = 6;
            this.btnSupervisorAppr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSupervisorAppr, "Supervisor Approval");
            this.btnSupervisorAppr.UseVisualStyleBackColor = true;
            this.btnSupervisorAppr.Click += new System.EventHandler(this.btnSupervisorAppr_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Supervisor
            // 
            this.AcceptButton = this.btnShowTravels;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 1006);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Supervisor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "-";
            this.Text = "  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Supervisor_FormClosed);
            this.Load += new System.EventHandler(this.Supervisor_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnShowTravels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFinalizeTravel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupervisorAppr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorApproval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHideApproved;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
private System.Windows.Forms.DataGridViewTextBoxColumn Status;
private System.Windows.Forms.DataGridViewTextBoxColumn Origin;*/
    }
}