namespace Calendar
{
    partial class TenantForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dayLayout = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonPrevious = new Button();
            buttonNext = new Button();
            labelDate = new Label();
            textBoxUserActions = new TextBox();
            sidebarContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            label8 = new Label();
            btnMenu = new PictureBox();
            panel4 = new Panel();
            btnMyProfile = new Button();
            panel5 = new Panel();
            btnCreateEvent = new Button();
            panel6 = new Panel();
            btnExpense = new Button();
            panel7 = new Panel();
            btnCreateComplaint = new Button();
            panel9 = new Panel();
            btnAgreements = new Button();
            panel2 = new Panel();
            btnRules = new Button();
            panel3 = new Panel();
            btnSupport = new Button();
            panel8 = new Panel();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel10 = new Panel();
            panel11 = new Panel();
            workingSpaceContainer = new Panel();
            sidebarContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            workingSpaceContainer.SuspendLayout();
            SuspendLayout();
            // 
            // dayLayout
            // 
            dayLayout.BackColor = Color.FromArgb(205, 211, 213);
            dayLayout.Dock = DockStyle.Fill;
            dayLayout.Location = new Point(0, 0);
            dayLayout.Margin = new Padding(3, 1, 3, 1);
            dayLayout.Name = "dayLayout";
            dayLayout.Size = new Size(807, 387);
            dayLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 1;
            label1.Text = "Monday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 49);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 2;
            label2.Text = "Tuesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 49);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 3;
            label3.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(237, 49);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 4;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(469, 49);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 5;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(575, 49);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 6;
            label6.Text = "Suturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(689, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 7;
            label7.Text = "Sunday";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(0, 11);
            buttonPrevious.Margin = new Padding(3, 1, 3, 1);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(82, 22);
            buttonPrevious.TabIndex = 8;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(748, 11);
            buttonNext.Margin = new Padding(3, 1, 3, 1);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(82, 22);
            buttonNext.TabIndex = 9;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(258, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(275, 21);
            labelDate.TabIndex = 10;
            labelDate.Text = "MONTH YEAR";
            labelDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxUserActions
            // 
            textBoxUserActions.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxUserActions.Location = new Point(5, 13);
            textBoxUserActions.Margin = new Padding(3, 1, 3, 1);
            textBoxUserActions.Name = "textBoxUserActions";
            textBoxUserActions.Size = new Size(826, 26);
            textBoxUserActions.TabIndex = 16;
            textBoxUserActions.TextAlign = HorizontalAlignment.Center;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(117, 184, 200);
            sidebarContainer.Controls.Add(panel1);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(panel6);
            sidebarContainer.Controls.Add(panel7);
            sidebarContainer.Controls.Add(panel9);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(panel3);
            sidebarContainer.Controls.Add(panel8);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.Margin = new Padding(2, 1, 2, 1);
            sidebarContainer.MaximumSize = new Size(229, 582);
            sidebarContainer.MinimumSize = new Size(47, 582);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(229, 582);
            sidebarContainer.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 74);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(56, 47);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 1;
            label8.Text = "Menu";
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.noun_menu_52969;
            btnMenu.Location = new Point(5, 36);
            btnMenu.Margin = new Padding(2, 1, 2, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(39, 35);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMyProfile);
            panel4.Location = new Point(2, 77);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 41);
            panel4.TabIndex = 21;
            // 
            // btnMyProfile
            // 
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyProfile.Image = Properties.Resources.account;
            btnMyProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyProfile.Location = new Point(-17, -5);
            btnMyProfile.Margin = new Padding(2, 1, 2, 1);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Padding = new Padding(22, 0, 0, 0);
            btnMyProfile.Size = new Size(274, 53);
            btnMyProfile.TabIndex = 0;
            btnMyProfile.Text = "          My profile";
            btnMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCreateEvent);
            panel5.Location = new Point(2, 120);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 41);
            panel5.TabIndex = 21;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.FlatStyle = FlatStyle.Flat;
            btnCreateEvent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateEvent.Image = Properties.Resources.calendar;
            btnCreateEvent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEvent.Location = new Point(-17, -5);
            btnCreateEvent.Margin = new Padding(2, 1, 2, 1);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Padding = new Padding(22, 0, 0, 0);
            btnCreateEvent.Size = new Size(274, 53);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "          Events";
            btnCreateEvent.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += eventFormOpenButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnExpense);
            panel6.Location = new Point(2, 163);
            panel6.Margin = new Padding(2, 1, 2, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 41);
            panel6.TabIndex = 21;
            // 
            // btnExpense
            // 
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExpense.Image = Properties.Resources.expenses;
            btnExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpense.Location = new Point(-17, -5);
            btnExpense.Margin = new Padding(2, 1, 2, 1);
            btnExpense.Name = "btnExpense";
            btnExpense.Padding = new Padding(22, 0, 0, 0);
            btnExpense.Size = new Size(274, 53);
            btnExpense.TabIndex = 0;
            btnExpense.Text = "          Expense";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnExpense_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCreateComplaint);
            panel7.Location = new Point(2, 206);
            panel7.Margin = new Padding(2, 1, 2, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(242, 41);
            panel7.TabIndex = 21;
            // 
            // btnCreateComplaint
            // 
            btnCreateComplaint.FlatStyle = FlatStyle.Flat;
            btnCreateComplaint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateComplaint.Image = Properties.Resources.report;
            btnCreateComplaint.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateComplaint.Location = new Point(-17, -5);
            btnCreateComplaint.Margin = new Padding(2, 1, 2, 1);
            btnCreateComplaint.Name = "btnCreateComplaint";
            btnCreateComplaint.Padding = new Padding(22, 0, 0, 0);
            btnCreateComplaint.Size = new Size(274, 53);
            btnCreateComplaint.TabIndex = 0;
            btnCreateComplaint.Text = "          Complaint";
            btnCreateComplaint.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateComplaint.UseVisualStyleBackColor = true;
            btnCreateComplaint.Click += btnComplaint_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnAgreements);
            panel9.Location = new Point(2, 249);
            panel9.Margin = new Padding(2, 1, 2, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(242, 41);
            panel9.TabIndex = 21;
            // 
            // btnAgreements
            // 
            btnAgreements.FlatStyle = FlatStyle.Flat;
            btnAgreements.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgreements.Image = Properties.Resources.handshake;
            btnAgreements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgreements.Location = new Point(-17, -5);
            btnAgreements.Margin = new Padding(2, 1, 2, 1);
            btnAgreements.Name = "btnAgreements";
            btnAgreements.Padding = new Padding(22, 0, 0, 0);
            btnAgreements.Size = new Size(274, 53);
            btnAgreements.TabIndex = 0;
            btnAgreements.Text = "          Agreements";
            btnAgreements.TextAlign = ContentAlignment.MiddleLeft;
            btnAgreements.UseVisualStyleBackColor = true;
            btnAgreements.Click += btnAgreements_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRules);
            panel2.Location = new Point(2, 292);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 41);
            panel2.TabIndex = 22;
            // 
            // btnRules
            // 
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRules.Image = Properties.Resources.rules;
            btnRules.ImageAlign = ContentAlignment.MiddleLeft;
            btnRules.Location = new Point(-17, -5);
            btnRules.Margin = new Padding(2, 1, 2, 1);
            btnRules.Name = "btnRules";
            btnRules.Padding = new Padding(22, 0, 0, 0);
            btnRules.Size = new Size(274, 53);
            btnRules.TabIndex = 0;
            btnRules.Text = "          Rules";
            btnRules.TextAlign = ContentAlignment.MiddleLeft;
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSupport);
            panel3.Location = new Point(2, 335);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 41);
            panel3.TabIndex = 22;
            // 
            // btnSupport
            // 
            btnSupport.FlatStyle = FlatStyle.Flat;
            btnSupport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupport.Image = Properties.Resources.support;
            btnSupport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupport.Location = new Point(-17, -5);
            btnSupport.Margin = new Padding(2, 1, 2, 1);
            btnSupport.Name = "btnSupport";
            btnSupport.Padding = new Padding(22, 0, 0, 0);
            btnSupport.Size = new Size(274, 53);
            btnSupport.TabIndex = 0;
            btnSupport.Text = "          Support";
            btnSupport.TextAlign = ContentAlignment.MiddleLeft;
            btnSupport.UseVisualStyleBackColor = true;
            btnSupport.Click += btnSupport_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(2, 378);
            panel8.Margin = new Padding(2, 1, 2, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(242, 41);
            panel8.TabIndex = 22;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-17, -5);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(22, 0, 0, 0);
            btnLogout.Size = new Size(274, 53);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "          Logout ";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += exitButton_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(205, 211, 213);
            panel10.Controls.Add(labelDate);
            panel10.Controls.Add(buttonPrevious);
            panel10.Controls.Add(buttonNext);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(229, 457);
            panel10.Margin = new Padding(2, 1, 2, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(807, 33);
            panel10.TabIndex = 20;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(205, 211, 213);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label1);
            panel11.Controls.Add(label2);
            panel11.Controls.Add(textBoxUserActions);
            panel11.Controls.Add(label3);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(label5);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(229, 0);
            panel11.Margin = new Padding(2, 1, 2, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(807, 70);
            panel11.TabIndex = 21;
            // 
            // workingSpaceContainer
            // 
            workingSpaceContainer.BackColor = Color.Silver;
            workingSpaceContainer.Controls.Add(dayLayout);
            workingSpaceContainer.Dock = DockStyle.Fill;
            workingSpaceContainer.Location = new Point(229, 70);
            workingSpaceContainer.Margin = new Padding(2, 1, 2, 1);
            workingSpaceContainer.Name = "workingSpaceContainer";
            workingSpaceContainer.Size = new Size(807, 387);
            workingSpaceContainer.TabIndex = 22;
            // 
            // TenantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1036, 490);
            Controls.Add(workingSpaceContainer);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(sidebarContainer);
            Margin = new Padding(3, 1, 3, 1);
            Name = "TenantForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Calendar";
            Load += TenantForm_Load;
            sidebarContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            workingSpaceContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel dayLayout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelDate;
        private TextBox textBoxUserActions;
        private FlowLayoutPanel sidebarContainer;
        private Panel panel1;
        private Button button1;
        private Label label8;
        private PictureBox btnMenu;
        private Button button2;
        private Panel panel4;
        private Button btnMyProfile;
        private Panel panel5;
        private Button btnCreateEvent;
        private Panel panel6;
        private Button btnExpense;
        private Panel panel7;
        private Button btnCreateComplaint;
        private Panel panel9;
        private Button btnAgreements;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel2;
        private Button btnRules;
        private Panel panel3;
        private Button btnSupport;
        private Panel panel8;
        private Button btnLogout;
        private Panel panel10;
        private Panel panel11;
        private Panel workingSpaceContainer;
    }
}