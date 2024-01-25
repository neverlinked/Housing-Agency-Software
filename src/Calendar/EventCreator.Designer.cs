namespace Calendar
{
    partial class EventCreator
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxName = new ComboBox();
            descriptionBox = new RichTextBox();
            label5 = new Label();
            createEventButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 109);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 153);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Description :";
            // 
            // comboBoxName
            // 
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(151, 109);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(250, 28);
            comboBoxName.TabIndex = 6;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(54, 176);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(347, 102);
            descriptionBox.TabIndex = 7;
            descriptionBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(136, 20);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 8;
            label5.Text = "Creating an event";
            // 
            // createEventButton
            // 
            createEventButton.Location = new Point(54, 292);
            createEventButton.Name = "createEventButton";
            createEventButton.Size = new Size(347, 42);
            createEventButton.TabIndex = 10;
            createEventButton.Text = "Create event";
            createEventButton.UseVisualStyleBackColor = true;
            createEventButton.Click += createEventButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // EventCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 211, 213);
            ClientSize = new Size(454, 371);
            Controls.Add(dateTimePicker1);
            Controls.Add(createEventButton);
            Controls.Add(label5);
            Controls.Add(descriptionBox);
            Controls.Add(comboBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EventCreator";
            Text = "Event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxName;
        private RichTextBox descriptionBox;
        private Label label5;
        private Button createEventButton;
        private DateTimePicker dateTimePicker1;
    }
}