namespace Calendar
{
    partial class ComplaintCreator
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
            btnCreateComplaint = new Button();
            lblTitle = new Label();
            lblContent = new Label();
            tbContent = new RichTextBox();
            tbTitle = new TextBox();
            SuspendLayout();
            // 
            // btnCreateComplaint
            // 
            btnCreateComplaint.Location = new Point(193, 268);
            btnCreateComplaint.Name = "btnCreateComplaint";
            btnCreateComplaint.Size = new Size(129, 31);
            btnCreateComplaint.TabIndex = 0;
            btnCreateComplaint.Text = "Create Complaint";
            btnCreateComplaint.UseVisualStyleBackColor = true;
            btnCreateComplaint.Click += btnCreateComplaint_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(44, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(12, 119);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(68, 21);
            lblContent.TabIndex = 2;
            lblContent.Text = "Content:";
            // 
            // tbContent
            // 
            tbContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbContent.Location = new Point(86, 119);
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(148, 116);
            tbContent.TabIndex = 3;
            tbContent.Text = "";
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(92, 32);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(152, 29);
            tbTitle.TabIndex = 4;
            // 
            // ComplaintCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 211, 213);
            ClientSize = new Size(334, 311);
            Controls.Add(tbTitle);
            Controls.Add(tbContent);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Controls.Add(btnCreateComplaint);
            Name = "ComplaintCreator";
            Text = "ComplaintCreator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateComplaint;
        private Label lblTitle;
        private Label lblContent;
        private RichTextBox tbContent;
        private TextBox tbTitle;
    }
}