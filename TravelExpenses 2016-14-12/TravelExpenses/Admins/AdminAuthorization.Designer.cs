namespace TravelExpenses
{
    partial class AdminAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAuthorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.dgvAthorizations = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHideApproved = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnApprEstimateDirector = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelTOtal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MileagePersonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ApprovedBySupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(57, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 123);
            this.panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(1034, 25);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(71, 75);
            this.btnShow.TabIndex = 1;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41037F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployee, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 29);
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
            this.lblEmployee.Size = new System.Drawing.Size(239, 22);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(257, 15);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(586, 33);
            this.cbEmployee.TabIndex = 1;
            // 
            // dgvAthorizations
            // 
            this.dgvAthorizations.AllowUserToAddRows = false;
            this.dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthorizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepDate,
            this.RetDate,
            this.Event,
            this.Purpose,
            this.Budgeted,
            this.User,
            this.TravelTOtal,
            this.TravelID,
            this.UserID,
            this.District,
            this.Department1,
            this.MileagePersonal,
            this.ApprovedBySupervisor});
            this.dgvAthorizations.Location = new System.Drawing.Point(48, 150);
            this.dgvAthorizations.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAthorizations.MultiSelect = false;
            this.dgvAthorizations.Name = "dgvAthorizations";
            this.dgvAthorizations.ReadOnly = true;
            this.dgvAthorizations.RowHeadersWidth = 62;
            this.dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthorizations.Size = new System.Drawing.Size(1439, 454);
            this.dgvAthorizations.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.dgvAthorizations);
            this.panel2.Location = new System.Drawing.Point(57, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1505, 631);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6101F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38989F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.Controls.Add(this.btnHideApproved, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1063, 48);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(94, 92);
            this.tableLayoutPanel4.TabIndex = 6;
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
            this.btnHideApproved.Size = new System.Drawing.Size(53, 80);
            this.btnHideApproved.TabIndex = 2;
            this.btnHideApproved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnHideApproved, "Hide Approved Authorization");
            this.btnHideApproved.UseVisualStyleBackColor = true;
            this.btnHideApproved.Visible = false;
            this.btnHideApproved.Click += new System.EventHandler(this.btnHideApproved_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.15385F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.84615F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1396, 48);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(100, 92);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(33, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 77);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClose, "Close Window");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(118, 105);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(258, 20);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Sending Email to Employee....";
            this.lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71137F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.43294F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.43294F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71138F));
            this.tableLayoutPanel2.Controls.Add(this.btnView, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnApprEstimateDirector, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPDF, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1158, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(237, 92);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(180, 15);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(51, 62);
            this.btnView.TabIndex = 0;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnView, "View");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnApprEstimateDirector
            // 
            this.btnApprEstimateDirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApprEstimateDirector.FlatAppearance.BorderSize = 0;
            this.btnApprEstimateDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprEstimateDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprEstimateDirector.Image = ((System.Drawing.Image)(resources.GetObject("btnApprEstimateDirector.Image")));
            this.btnApprEstimateDirector.Location = new System.Drawing.Point(93, 6);
            this.btnApprEstimateDirector.Margin = new System.Windows.Forms.Padding(6);
            this.btnApprEstimateDirector.Name = "btnApprEstimateDirector";
            this.btnApprEstimateDirector.Size = new System.Drawing.Size(48, 80);
            this.btnApprEstimateDirector.TabIndex = 1;
            this.btnApprEstimateDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnApprEstimateDirector, "Director Approval");
            this.btnApprEstimateDirector.UseVisualStyleBackColor = true;
            this.btnApprEstimateDirector.Click += new System.EventHandler(this.btnApprEstimateDirector_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(6, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(48, 80);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnPDF, "Create PDF");
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // DepDate
            // 
            this.DepDate.HeaderText = "Departure";
            this.DepDate.MinimumWidth = 8;
            this.DepDate.Name = "DepDate";
            this.DepDate.ReadOnly = true;
            // 
            // RetDate
            // 
            this.RetDate.HeaderText = "Return";
            this.RetDate.MinimumWidth = 8;
            this.RetDate.Name = "RetDate";
            this.RetDate.ReadOnly = true;
            this.RetDate.Width = 80;
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
            this.Purpose.Visible = false;
            this.Purpose.Width = 80;
            // 
            // Budgeted
            // 
            this.Budgeted.HeaderText = "Budgeted";
            this.Budgeted.MinimumWidth = 8;
            this.Budgeted.Name = "Budgeted";
            this.Budgeted.ReadOnly = true;
            this.Budgeted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Budgeted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 140;
            // 
            // TravelTOtal
            // 
            this.TravelTOtal.HeaderText = "Estimate Total";
            this.TravelTOtal.MinimumWidth = 8;
            this.TravelTOtal.Name = "TravelTOtal";
            this.TravelTOtal.ReadOnly = true;
            this.TravelTOtal.Visible = false;
            this.TravelTOtal.Width = 150;
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
            this.Department1.HeaderText = "Department";
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
            // ApprovedBySupervisor
            // 
            this.ApprovedBySupervisor.HeaderText = "Approved";
            this.ApprovedBySupervisor.MinimumWidth = 8;
            this.ApprovedBySupervisor.Name = "ApprovedBySupervisor";
            this.ApprovedBySupervisor.ReadOnly = true;
            this.ApprovedBySupervisor.Visible = false;
            this.ApprovedBySupervisor.Width = 150;
            // 
            // AdminAuthorization
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 975);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminAuthorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminAuthorization_FormClosed);
            this.Load += new System.EventHandler(this.AdminAuthorization_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthorizations)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnApprEstimateDirector;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnHideApproved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelTOtal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MileagePersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBySupervisor;
    }
}