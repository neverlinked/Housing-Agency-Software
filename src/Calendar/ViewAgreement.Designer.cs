namespace Calendar
{
    partial class ViewAgreement
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
            lblBy = new Label();
            lblName = new Label();
            lblDate = new Label();
            lblDateDisplay = new Label();
            lblTitle = new Label();
            lblTItleDIsplay = new Label();
            tbDescription = new RichTextBox();
            SuspendLayout();
            // 
            // lblBy
            // 
            lblBy.AutoSize = true;
            lblBy.Location = new Point(12, 20);
            lblBy.Name = "lblBy";
            lblBy.Size = new Size(23, 15);
            lblBy.TabIndex = 0;
            lblBy.Text = "By:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(41, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(203, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // lblDateDisplay
            // 
            lblDateDisplay.AutoSize = true;
            lblDateDisplay.Location = new Point(243, 20);
            lblDateDisplay.Name = "lblDateDisplay";
            lblDateDisplay.Size = new Size(31, 15);
            lblDateDisplay.TabIndex = 3;
            lblDateDisplay.Text = "Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(42, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title:";
            // 
            // lblTItleDIsplay
            // 
            lblTItleDIsplay.AutoSize = true;
            lblTItleDIsplay.Location = new Point(80, 63);
            lblTItleDIsplay.Name = "lblTItleDIsplay";
            lblTItleDIsplay.Size = new Size(29, 15);
            lblTItleDIsplay.TabIndex = 5;
            lblTItleDIsplay.Text = "Title";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(59, 107);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(193, 143);
            tbDescription.TabIndex = 8;
            tbDescription.Text = "";
            // 
            // ViewAgreement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(tbDescription);
            Controls.Add(lblTItleDIsplay);
            Controls.Add(lblTitle);
            Controls.Add(lblDateDisplay);
            Controls.Add(lblDate);
            Controls.Add(lblName);
            Controls.Add(lblBy);
            Name = "ViewAgreement";
            Text = "ViewAgreement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBy;
        private Label lblName;
        private Label lblDate;
        private Label lblDateDisplay;
        private Label lblTitle;
        private Label lblTItleDIsplay;
        private RichTextBox tbDescription;
    }
}