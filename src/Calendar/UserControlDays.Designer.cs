namespace Calendar
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDays = new Label();
            SuspendLayout();
            // 
            // labelDays
            // 
            labelDays.Font = new Font("Segoe UI", 38F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDays.Location = new Point(0, 0);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(120, 80);
            labelDays.TabIndex = 0;
            labelDays.Text = "00";
            labelDays.TextAlign = ContentAlignment.TopCenter;
            labelDays.Click += labelDays_Click;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(labelDays);
            Name = "UserControlDays";
            Size = new Size(120, 80);
            ResumeLayout(false);
        }

        #endregion

        private Label labelDays;
    }
}
