namespace TravelExpenses
{
    partial class OtherExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherExpenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.lblPrepaid = new System.Windows.Forms.Label();
            this.chxPrepaid = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpensesNotes = new System.Windows.Forms.Label();
            this.txtExpensesNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpenseAmount = new System.Windows.Forms.Button();
            this.lblHeaderExpenses = new System.Windows.Forms.Label();
            this.dgvOtherExpenses = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextExpenses = new System.Windows.Forms.Button();
            this.btnBackExpenses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelExpenses = new System.Windows.Forms.Button();
            this.lblListExpenses = new System.Windows.Forms.Label();
            this.PCardPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherExpenses)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(44, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 365);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.19876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.80124F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenseDescription, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenseAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrepaid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chxPrepaid, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 190);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 19);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(332, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(350, 6);
            this.txtExpenseDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtExpenseDescription.Multiline = true;
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExpenseDescription.Size = new System.Drawing.Size(545, 46);
            this.txtExpenseDescription.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 82);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(332, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtExpenseAmount.Location = new System.Drawing.Point(350, 78);
            this.txtExpenseAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(180, 33);
            this.txtExpenseAmount.TabIndex = 4;
            this.txtExpenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpenseAmount_KeyPress);
            // 
            // lblPrepaid
            // 
            this.lblPrepaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrepaid.AutoSize = true;
            this.lblPrepaid.Location = new System.Drawing.Point(6, 145);
            this.lblPrepaid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrepaid.Name = "lblPrepaid";
            this.lblPrepaid.Size = new System.Drawing.Size(332, 25);
            this.lblPrepaid.TabIndex = 5;
            this.lblPrepaid.Text = "P-Card Paid?";
            // 
            // chxPrepaid
            // 
            this.chxPrepaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxPrepaid.AutoSize = true;
            this.chxPrepaid.Location = new System.Drawing.Point(350, 147);
            this.chxPrepaid.Margin = new System.Windows.Forms.Padding(6);
            this.chxPrepaid.Name = "chxPrepaid";
            this.chxPrepaid.Size = new System.Drawing.Size(546, 21);
            this.chxPrepaid.TabIndex = 6;
            this.chxPrepaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.11826F));
            this.tableLayoutPanel2.Controls.Add(this.lblExpensesNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtExpensesNotes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 256);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 88);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblExpensesNotes
            // 
            this.lblExpensesNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpensesNotes.AutoSize = true;
            this.lblExpensesNotes.Location = new System.Drawing.Point(6, 31);
            this.lblExpensesNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExpensesNotes.Name = "lblExpensesNotes";
            this.lblExpensesNotes.Size = new System.Drawing.Size(113, 25);
            this.lblExpensesNotes.TabIndex = 0;
            this.lblExpensesNotes.Text = "Notes:";
            // 
            // txtExpensesNotes
            // 
            this.txtExpensesNotes.Location = new System.Drawing.Point(131, 6);
            this.txtExpensesNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtExpensesNotes.Multiline = true;
            this.txtExpensesNotes.Name = "txtExpensesNotes";
            this.txtExpensesNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExpensesNotes.Size = new System.Drawing.Size(763, 73);
            this.txtExpensesNotes.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnExpenseAmount, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(154, 492);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(902, 90);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnExpenseAmount
            // 
            this.btnExpenseAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExpenseAmount.BackColor = System.Drawing.Color.Azure;
            this.btnExpenseAmount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpenseAmount.FlatAppearance.BorderSize = 5;
            this.btnExpenseAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpenseAmount.Image = global::TravelExpenses.Properties.Resources._1494979605_sign_add;
            this.btnExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseAmount.Location = new System.Drawing.Point(608, 6);
            this.btnExpenseAmount.Margin = new System.Windows.Forms.Padding(6);
            this.btnExpenseAmount.Name = "btnExpenseAmount";
            this.btnExpenseAmount.Size = new System.Drawing.Size(288, 77);
            this.btnExpenseAmount.TabIndex = 3;
            this.btnExpenseAmount.Text = "Add Expense to the List";
            this.btnExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpenseAmount.UseVisualStyleBackColor = false;
            this.btnExpenseAmount.Click += new System.EventHandler(this.btnExpenseAmount_Click);
            // 
            // lblHeaderExpenses
            // 
            this.lblHeaderExpenses.AutoSize = true;
            this.lblHeaderExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHeaderExpenses.Location = new System.Drawing.Point(37, 52);
            this.lblHeaderExpenses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeaderExpenses.Name = "lblHeaderExpenses";
            this.lblHeaderExpenses.Size = new System.Drawing.Size(278, 29);
            this.lblHeaderExpenses.TabIndex = 1;
            this.lblHeaderExpenses.Text = "Enter Expense Details:";
            // 
            // dgvOtherExpenses
            // 
            this.dgvOtherExpenses.AllowUserToAddRows = false;
            this.dgvOtherExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCardPaid,
            this.Description,
            this.Amount,
            this.Notes,
            this.Delete});
            this.dgvOtherExpenses.Location = new System.Drawing.Point(38, 683);
            this.dgvOtherExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.dgvOtherExpenses.Name = "dgvOtherExpenses";
            this.dgvOtherExpenses.ReadOnly = true;
            this.dgvOtherExpenses.RowHeadersWidth = 62;
            this.dgvOtherExpenses.RowTemplate.Height = 30;
            this.dgvOtherExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtherExpenses.Size = new System.Drawing.Size(1012, 300);
            this.dgvOtherExpenses.TabIndex = 2;
            this.dgvOtherExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtherExpenses_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.03278F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.96721F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.Controls.Add(this.btnNextExpenses, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackExpenses, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(894, 994);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 77);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnNextExpenses
            // 
            this.btnNextExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextExpenses.FlatAppearance.BorderSize = 0;
            this.btnNextExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnNextExpenses.Image")));
            this.btnNextExpenses.Location = new System.Drawing.Point(114, 6);
            this.btnNextExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.btnNextExpenses.Name = "btnNextExpenses";
            this.btnNextExpenses.Size = new System.Drawing.Size(66, 65);
            this.btnNextExpenses.TabIndex = 2;
            this.btnNextExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextExpenses.UseVisualStyleBackColor = true;
            this.btnNextExpenses.Click += new System.EventHandler(this.btnNextExpenses_Click);
            // 
            // btnBackExpenses
            // 
            this.btnBackExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackExpenses.FlatAppearance.BorderSize = 0;
            this.btnBackExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnBackExpenses.Image")));
            this.btnBackExpenses.Location = new System.Drawing.Point(6, 6);
            this.btnBackExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackExpenses.Name = "btnBackExpenses";
            this.btnBackExpenses.Size = new System.Drawing.Size(62, 65);
            this.btnBackExpenses.TabIndex = 1;
            this.btnBackExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackExpenses.UseVisualStyleBackColor = true;
            this.btnBackExpenses.Click += new System.EventHandler(this.btnBackExpenses_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelExpenses
            // 
            this.btnCancelExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelExpenses.FlatAppearance.BorderSize = 0;
            this.btnCancelExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelExpenses.Image")));
            this.btnCancelExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelExpenses.Location = new System.Drawing.Point(22, 1006);
            this.btnCancelExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelExpenses.Name = "btnCancelExpenses";
            this.btnCancelExpenses.Size = new System.Drawing.Size(130, 65);
            this.btnCancelExpenses.TabIndex = 0;
            this.btnCancelExpenses.Text = "Cancel";
            this.btnCancelExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelExpenses.UseVisualStyleBackColor = true;
            this.btnCancelExpenses.Click += new System.EventHandler(this.btnCancelExpenses_Click);
            // 
            // lblListExpenses
            // 
            this.lblListExpenses.AutoSize = true;
            this.lblListExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblListExpenses.Location = new System.Drawing.Point(37, 627);
            this.lblListExpenses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListExpenses.Name = "lblListExpenses";
            this.lblListExpenses.Size = new System.Drawing.Size(175, 29);
            this.lblListExpenses.TabIndex = 5;
            this.lblListExpenses.Text = "Expenses List";
            // 
            // PCardPaid
            // 
            this.PCardPaid.HeaderText = "PCard Paid";
            this.PCardPaid.MinimumWidth = 8;
            this.PCardPaid.Name = "PCardPaid";
            this.PCardPaid.ReadOnly = true;
            this.PCardPaid.Width = 110;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 240;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            this.Notes.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 150;
            // 
            // OtherExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 1094);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnCancelExpenses);
            this.Controls.Add(this.lblListExpenses);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvOtherExpenses);
            this.Controls.Add(this.lblHeaderExpenses);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OtherExpenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Expenses";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherExpenses)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtExpenseDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label lblHeaderExpenses;
        private System.Windows.Forms.DataGridView dgvOtherExpenses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblExpensesNotes;
        private System.Windows.Forms.TextBox txtExpensesNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelExpenses;
        private System.Windows.Forms.Button btnBackExpenses;
        private System.Windows.Forms.Button btnNextExpenses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPrepaid;
        private System.Windows.Forms.CheckBox chxPrepaid;
        private System.Windows.Forms.Label lblListExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PCardPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}