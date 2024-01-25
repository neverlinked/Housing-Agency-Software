namespace Calendar
{
    partial class HouseRules
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
            richTextBoxRules = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBoxRules
            // 
            richTextBoxRules.Location = new Point(12, 67);
            richTextBoxRules.Name = "richTextBoxRules";
            richTextBoxRules.ReadOnly = true;
            richTextBoxRules.Size = new Size(776, 371);
            richTextBoxRules.TabIndex = 0;
            richTextBoxRules.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 22);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 1;
            label1.Text = "House Rules";
            // 
            // HouseRules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 211, 213);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBoxRules);
            Name = "HouseRules";
            Text = "HouseRules";
            Load += HouseRules_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxRules;
        private Label label1;
    }
}