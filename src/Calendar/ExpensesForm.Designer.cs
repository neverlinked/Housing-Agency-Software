namespace Calendar
{
    partial class ExpensesForm
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
            lbxTenatns = new ListBox();
            label1 = new Label();
            tbxExtendedPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            label4 = new Label();
            lbxParticipants = new ListBox();
            btnCalculate = new Button();
            lblPricePerPerson = new Label();
            SuspendLayout();
            // 
            // lbxTenatns
            // 
            lbxTenatns.FormattingEnabled = true;
            lbxTenatns.ItemHeight = 20;
            lbxTenatns.Location = new Point(37, 52);
            lbxTenatns.Name = "lbxTenatns";
            lbxTenatns.Size = new Size(227, 344);
            lbxTenatns.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(521, 55);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "Extended price:";
            // 
            // tbxExtendedPrice
            // 
            tbxExtendedPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxExtendedPrice.Location = new Point(683, 55);
            tbxExtendedPrice.Name = "tbxExtendedPrice";
            tbxExtendedPrice.Size = new Size(125, 34);
            tbxExtendedPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 103);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 4;
            label2.Text = "Price for person:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 9);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 5;
            label3.Text = "Tenants:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(227, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(270, 402);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(227, 36);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(270, 9);
            label4.Name = "label4";
            label4.Size = new Size(195, 28);
            label4.TabIndex = 8;
            label4.Text = "Expence participants:";
            // 
            // lbxParticipants
            // 
            lbxParticipants.FormattingEnabled = true;
            lbxParticipants.ItemHeight = 20;
            lbxParticipants.Location = new Point(270, 52);
            lbxParticipants.Name = "lbxParticipants";
            lbxParticipants.Size = new Size(227, 344);
            lbxParticipants.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(521, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(306, 36);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPricePerPerson
            // 
            lblPricePerPerson.AutoSize = true;
            lblPricePerPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPricePerPerson.Location = new Point(683, 103);
            lblPricePerPerson.Name = "lblPricePerPerson";
            lblPricePerPerson.Size = new Size(77, 28);
            lblPricePerPerson.TabIndex = 11;
            lblPricePerPerson.Text = "[ price ]";
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(lblPricePerPerson);
            Controls.Add(btnCalculate);
            Controls.Add(btnRemove);
            Controls.Add(label4);
            Controls.Add(lbxParticipants);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxExtendedPrice);
            Controls.Add(label1);
            Controls.Add(lbxTenatns);
            Name = "ExpensesForm";
            Text = "ExpensesForm";
            Load += ExpensesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxTenatns;
        private Label label1;
        private TextBox tbxExtendedPrice;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnRemove;
        private Label label4;
        private ListBox lbxParticipants;
        private Button btnCalculate;
        private Label lblPricePerPerson;
    }
}