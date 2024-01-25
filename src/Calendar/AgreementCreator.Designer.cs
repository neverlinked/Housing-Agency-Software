namespace Calendar
{
    partial class AgreementCreator
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
            lblAgreement = new Label();
            tbAgreement = new TextBox();
            btnCreateAgreement = new Button();
            lblTitle = new Label();
            tbTitle = new TextBox();
            SuspendLayout();
            // 
            // lblAgreement
            // 
            lblAgreement.AutoSize = true;
            lblAgreement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgreement.Location = new Point(12, 121);
            lblAgreement.Name = "lblAgreement";
            lblAgreement.Size = new Size(69, 15);
            lblAgreement.TabIndex = 0;
            lblAgreement.Text = "Agreement:";
            // 
            // tbAgreement
            // 
            tbAgreement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbAgreement.Location = new Point(87, 121);
            tbAgreement.Multiline = true;
            tbAgreement.Name = "tbAgreement";
            tbAgreement.Size = new Size(197, 101);
            tbAgreement.TabIndex = 1;
            // 
            // btnCreateAgreement
            // 
            btnCreateAgreement.Location = new Point(229, 257);
            btnCreateAgreement.Name = "btnCreateAgreement";
            btnCreateAgreement.Size = new Size(75, 23);
            btnCreateAgreement.TabIndex = 2;
            btnCreateAgreement.Text = "Propose";
            btnCreateAgreement.UseVisualStyleBackColor = true;
            btnCreateAgreement.Click += btnCreateAgreement_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(59, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(107, 30);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(100, 23);
            tbTitle.TabIndex = 4;
            // 
            // AgreementCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 211, 213);
            ClientSize = new Size(334, 311);
            Controls.Add(tbTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnCreateAgreement);
            Controls.Add(tbAgreement);
            Controls.Add(lblAgreement);
            Name = "AgreementCreator";
            Text = "Create Agreement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgreement;
        private TextBox tbAgreement;
        private Button btnCreateAgreement;
        private Label lblTitle;
        private TextBox tbTitle;
    }
}