
namespace TravelExpenses
{
    partial class ViewPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPDF));
            this.btnClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnApproveSIgn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSendingEmails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(14, 683);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnApproveSIgn
            // 
            this.btnApproveSIgn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApproveSIgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnApproveSIgn.FlatAppearance.BorderSize = 0;
            this.btnApproveSIgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveSIgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApproveSIgn.Image = global::TravelExpenses.Properties.Resources.contract__2_1;
            this.btnApproveSIgn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveSIgn.Location = new System.Drawing.Point(758, 675);
            this.btnApproveSIgn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApproveSIgn.Name = "btnApproveSIgn";
            this.btnApproveSIgn.Size = new System.Drawing.Size(148, 47);
            this.btnApproveSIgn.TabIndex = 2;
            this.btnApproveSIgn.Text = "Approve and Sign";
            this.btnApproveSIgn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApproveSIgn.UseVisualStyleBackColor = false;
            this.btnApproveSIgn.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 683);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblSendingEmails
            // 
            this.lblSendingEmails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSendingEmails.AutoSize = true;
            this.lblSendingEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSendingEmails.Location = new System.Drawing.Point(216, 697);
            this.lblSendingEmails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendingEmails.Name = "lblSendingEmails";
            this.lblSendingEmails.Size = new System.Drawing.Size(182, 13);
            this.lblSendingEmails.TabIndex = 4;
            this.lblSendingEmails.Text = "Sending Notification Emails.....";
            this.lblSendingEmails.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 617);
            this.panel1.TabIndex = 5;
            // 
            // ViewPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSendingEmails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApproveSIgn);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "ViewPDF";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcroPDFLib.AcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnApproveSIgn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSendingEmails;
        private System.Windows.Forms.Panel panel1;
    }
}