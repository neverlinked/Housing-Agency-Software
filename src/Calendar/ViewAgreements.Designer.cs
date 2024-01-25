namespace Calendar
{
    partial class ViewAgreements
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
            listBox1 = new ListBox();
            btnCreateAgreement = new Button();
            btnViewAgreement = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(451, 274);
            listBox1.TabIndex = 1;
            // 
            // btnCreateAgreement
            // 
            btnCreateAgreement.Location = new Point(324, 307);
            btnCreateAgreement.Name = "btnCreateAgreement";
            btnCreateAgreement.Size = new Size(148, 42);
            btnCreateAgreement.TabIndex = 2;
            btnCreateAgreement.Text = "Propose a new agreement";
            btnCreateAgreement.UseVisualStyleBackColor = true;
            btnCreateAgreement.Click += btnCreateAgreement_Click;
            // 
            // btnViewAgreement
            // 
            btnViewAgreement.Location = new Point(12, 307);
            btnViewAgreement.Name = "btnViewAgreement";
            btnViewAgreement.Size = new Size(129, 42);
            btnViewAgreement.TabIndex = 3;
            btnViewAgreement.Text = "View Agreement";
            btnViewAgreement.UseVisualStyleBackColor = true;
            btnViewAgreement.Click += btnViewAgreement_Click;
            // 
            // ViewAgreements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnViewAgreement);
            Controls.Add(btnCreateAgreement);
            Controls.Add(listBox1);
            Name = "ViewAgreements";
            Text = "ViewAgreements";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button btnCreateAgreement;
        private Button btnViewAgreement;
    }
}