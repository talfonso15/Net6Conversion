
namespace TravelExpenses
{
    partial class CreateNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewAccount));
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIsSupervisor = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.Department = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDigitalSignature = new System.Windows.Forms.Label();
            this.btnSiganture = new System.Windows.Forms.Button();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.chxSupervisor = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorWarnings = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbUserInfo.Controls.Add(this.btnViewPassword);
            this.gbUserInfo.Controls.Add(this.tableLayoutPanel1);
            this.gbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUserInfo.Location = new System.Drawing.Point(44, 48);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(6);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(6);
            this.gbUserInfo.Size = new System.Drawing.Size(1377, 587);
            this.gbUserInfo.TabIndex = 5;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.FlatAppearance.BorderSize = 0;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPassword.Image = global::TravelExpenses.Properties.Resources._6351930_eye_password_see_view_icon;
            this.btnViewPassword.Location = new System.Drawing.Point(1327, 287);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(38, 37);
            this.btnViewPassword.TabIndex = 9;
            this.btnViewPassword.UseVisualStyleBackColor = true;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.93103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.Controls.Add(this.lblIsSupervisor, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartment, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrict, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDistrict, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Department, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDigitalSignature, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSiganture, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSupervisor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbSupervisor, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chxSupervisor, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblIsSupervisor
            // 
            this.lblIsSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsSupervisor.AutoSize = true;
            this.lblIsSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsSupervisor.Location = new System.Drawing.Point(643, 432);
            this.lblIsSupervisor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIsSupervisor.Name = "lblIsSupervisor";
            this.lblIsSupervisor.Size = new System.Drawing.Size(208, 20);
            this.lblIsSupervisor.TabIndex = 2;
            this.lblIsSupervisor.Text = "Are you a Supervisor?";
            this.lblIsSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(242, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(363, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
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
            this.cbDepartment.Location = new System.Drawing.Point(863, 133);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(6);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(360, 28);
            this.cbDepartment.TabIndex = 13;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(643, 39);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(208, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(863, 36);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(360, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistrict.Location = new System.Drawing.Point(6, 137);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(224, 20);
            this.lblDistrict.TabIndex = 4;
            this.lblDistrict.Text = "District:";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDistrict
            // 
            this.cbDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Items.AddRange(new object[] {
            "Mosquito",
            "Hyacinth",
            "Both"});
            this.cbDistrict.Location = new System.Drawing.Point(242, 133);
            this.cbDistrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(363, 28);
            this.cbDistrict.TabIndex = 5;
            // 
            // Department
            // 
            this.Department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Department.Location = new System.Drawing.Point(643, 137);
            this.Department.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(208, 20);
            this.Department.TabIndex = 12;
            this.Department.Text = "Department:";
            this.Department.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(6, 235);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(224, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(242, 232);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(363, 26);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(643, 235);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(208, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(863, 232);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(360, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(6, 333);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(224, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(242, 330);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // lblDigitalSignature
            // 
            this.lblDigitalSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDigitalSignature.AutoSize = true;
            this.lblDigitalSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigitalSignature.Location = new System.Drawing.Point(6, 432);
            this.lblDigitalSignature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDigitalSignature.Name = "lblDigitalSignature";
            this.lblDigitalSignature.Size = new System.Drawing.Size(224, 20);
            this.lblDigitalSignature.TabIndex = 16;
            this.lblDigitalSignature.Text = "Digital Signature:";
            this.lblDigitalSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSiganture
            // 
            this.btnSiganture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSiganture.FlatAppearance.BorderSize = 0;
            this.btnSiganture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiganture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiganture.Image = ((System.Drawing.Image)(resources.GetObject("btnSiganture.Image")));
            this.btnSiganture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiganture.Location = new System.Drawing.Point(242, 407);
            this.btnSiganture.Margin = new System.Windows.Forms.Padding(6);
            this.btnSiganture.Name = "btnSiganture";
            this.btnSiganture.Size = new System.Drawing.Size(193, 69);
            this.btnSiganture.TabIndex = 17;
            this.btnSiganture.Text = "Create Signature";
            this.btnSiganture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiganture.UseVisualStyleBackColor = true;
            this.btnSiganture.Click += new System.EventHandler(this.btnSiganture_Click);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisor.Location = new System.Drawing.Point(643, 333);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(208, 20);
            this.lblSupervisor.TabIndex = 0;
            this.lblSupervisor.Text = "Supervisor:";
            this.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Location = new System.Drawing.Point(863, 329);
            this.cbSupervisor.Margin = new System.Windows.Forms.Padding(6);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(360, 28);
            this.cbSupervisor.TabIndex = 1;
            // 
            // chxSupervisor
            // 
            this.chxSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxSupervisor.AutoSize = true;
            this.chxSupervisor.Location = new System.Drawing.Point(863, 431);
            this.chxSupervisor.Margin = new System.Windows.Forms.Padding(6);
            this.chxSupervisor.Name = "chxSupervisor";
            this.chxSupervisor.Size = new System.Drawing.Size(22, 21);
            this.chxSupervisor.TabIndex = 18;
            this.chxSupervisor.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(6, 39);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(224, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First and Middle Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelUser, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(776, 644);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 104);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Location = new System.Drawing.Point(446, 19);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(193, 65);
            this.btnSaveUser.TabIndex = 0;
            this.btnSaveUser.Text = "Save Account";
            this.btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelUser.FlatAppearance.BorderSize = 0;
            this.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelUser.Image")));
            this.btnCancelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUser.Location = new System.Drawing.Point(305, 19);
            this.btnCancelUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(119, 65);
            this.btnCancelUser.TabIndex = 1;
            this.btnCancelUser.Text = "Close";
            this.btnCancelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblErrorWarnings
            // 
            this.lblErrorWarnings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblErrorWarnings.AutoSize = true;
            this.lblErrorWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorWarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorWarnings.Location = new System.Drawing.Point(150, 687);
            this.lblErrorWarnings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErrorWarnings.Name = "lblErrorWarnings";
            this.lblErrorWarnings.Size = new System.Drawing.Size(417, 20);
            this.lblErrorWarnings.TabIndex = 8;
            this.lblErrorWarnings.Text = "Please check the info you provided, it has errors";
            this.lblErrorWarnings.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 663);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 758);
            this.Controls.Add(this.lblErrorWarnings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gbUserInfo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateNewAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Account";
            this.Load += new System.EventHandler(this.CreateNewAccount_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIsSupervisor;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDigitalSignature;
        private System.Windows.Forms.Button btnSiganture;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox chxSupervisor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancelUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorWarnings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewPassword;
    }
}