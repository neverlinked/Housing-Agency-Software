namespace Calendar
{
    partial class ManagerForm
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
            tabControl1 = new TabControl();
            tabPageAddTenant = new TabPage();
            dateOfBirthPicker = new DateTimePicker();
            lblRoom = new Label();
            lblBuilding = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblDateOfBirth = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            cmbRoom = new ComboBox();
            cmbBuilding = new ComboBox();
            txtBoxPhoneNumber = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            addTenantButton = new Button();
            tabPageSearchDeleteTenant = new TabPage();
            btnDeleteTenant = new Button();
            btnSearch = new Button();
            label3 = new Label();
            cmbStartInputtingName = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbSelectRoomSearchTenant = new ComboBox();
            cmbSelectBuildingSearchTenant = new ComboBox();
            chbSearchByName = new CheckBox();
            chbSearchByBuilding = new CheckBox();
            tabViewComplaints = new TabPage();
            btnNext = new Button();
            lblNumberStatic = new Label();
            lblIndex = new Label();
            lblTitleStatic = new Label();
            lblTitle = new Label();
            lblDateStatic = new Label();
            lblDate = new Label();
            btnPrevious = new Button();
            tbContent = new RichTextBox();
            tbpHouseRules = new TabPage();
            btnLoad = new Button();
            btnChange = new Button();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            logOutButton = new Button();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPageAddTenant.SuspendLayout();
            tabPageSearchDeleteTenant.SuspendLayout();
            tabViewComplaints.SuspendLayout();
            tbpHouseRules.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAddTenant);
            tabControl1.Controls.Add(tabPageSearchDeleteTenant);
            tabControl1.Controls.Add(tabViewComplaints);
            tabControl1.Controls.Add(tbpHouseRules);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(7, 10);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(836, 432);
            tabControl1.TabIndex = 1;
            // 
            // tabPageAddTenant
            // 
            tabPageAddTenant.BackgroundImageLayout = ImageLayout.Center;
            tabPageAddTenant.BorderStyle = BorderStyle.Fixed3D;
            tabPageAddTenant.Controls.Add(dateOfBirthPicker);
            tabPageAddTenant.Controls.Add(lblRoom);
            tabPageAddTenant.Controls.Add(lblBuilding);
            tabPageAddTenant.Controls.Add(lblPhoneNumber);
            tabPageAddTenant.Controls.Add(lblEmail);
            tabPageAddTenant.Controls.Add(lblDateOfBirth);
            tabPageAddTenant.Controls.Add(lblLastName);
            tabPageAddTenant.Controls.Add(lblFirstName);
            tabPageAddTenant.Controls.Add(cmbRoom);
            tabPageAddTenant.Controls.Add(cmbBuilding);
            tabPageAddTenant.Controls.Add(txtBoxPhoneNumber);
            tabPageAddTenant.Controls.Add(txtBoxEmail);
            tabPageAddTenant.Controls.Add(txtBoxLastName);
            tabPageAddTenant.Controls.Add(txtBoxFirstName);
            tabPageAddTenant.Controls.Add(addTenantButton);
            tabPageAddTenant.Location = new Point(4, 29);
            tabPageAddTenant.Margin = new Padding(2, 1, 2, 1);
            tabPageAddTenant.Name = "tabPageAddTenant";
            tabPageAddTenant.Padding = new Padding(2, 1, 2, 1);
            tabPageAddTenant.Size = new Size(828, 399);
            tabPageAddTenant.TabIndex = 0;
            tabPageAddTenant.Text = "Add tenant";
            tabPageAddTenant.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.CustomFormat = "DD-MM-YYYY";
            dateOfBirthPicker.Location = new Point(137, 124);
            dateOfBirthPicker.Margin = new Padding(2, 1, 2, 1);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(248, 27);
            dateOfBirthPicker.TabIndex = 27;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(26, 331);
            lblRoom.Margin = new Padding(2, 0, 2, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(49, 20);
            lblRoom.TabIndex = 26;
            lblRoom.Text = "Room";
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Location = new Point(26, 279);
            lblBuilding.Margin = new Padding(2, 0, 2, 0);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(64, 20);
            lblBuilding.TabIndex = 25;
            lblBuilding.Text = "Building";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(26, 227);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 24;
            lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 180);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(26, 127);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(91, 20);
            lblDateOfBirth.TabIndex = 22;
            lblDateOfBirth.Text = "DateOfBirth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(26, 74);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(83, 20);
            lblLastName.TabIndex = 21;
            lblLastName.Text = "Last name: ";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(26, 27);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "First name:";
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(137, 329);
            cmbRoom.Margin = new Padding(2, 1, 2, 1);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(125, 28);
            cmbRoom.TabIndex = 19;
            // 
            // cmbBuilding
            // 
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(137, 276);
            cmbBuilding.Margin = new Padding(2, 1, 2, 1);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(125, 28);
            cmbBuilding.TabIndex = 18;
            cmbBuilding.SelectedIndexChanged += cmbBuilding_SelectedIndexChanged;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(137, 226);
            txtBoxPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(125, 27);
            txtBoxPhoneNumber.TabIndex = 17;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(137, 178);
            txtBoxEmail.Margin = new Padding(2, 1, 2, 1);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(125, 27);
            txtBoxEmail.TabIndex = 16;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(137, 73);
            txtBoxLastName.Margin = new Padding(2, 1, 2, 1);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 14;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(137, 26);
            txtBoxFirstName.Margin = new Padding(2, 1, 2, 1);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 13;
            // 
            // addTenantButton
            // 
            addTenantButton.Location = new Point(479, 299);
            addTenantButton.Margin = new Padding(2, 1, 2, 1);
            addTenantButton.Name = "addTenantButton";
            addTenantButton.Size = new Size(188, 40);
            addTenantButton.TabIndex = 12;
            addTenantButton.Text = "Add Tenant";
            addTenantButton.UseVisualStyleBackColor = true;
            addTenantButton.Click += addTenantButton_Click;
            // 
            // tabPageSearchDeleteTenant
            // 
            tabPageSearchDeleteTenant.Controls.Add(btnDeleteTenant);
            tabPageSearchDeleteTenant.Controls.Add(btnSearch);
            tabPageSearchDeleteTenant.Controls.Add(label3);
            tabPageSearchDeleteTenant.Controls.Add(cmbStartInputtingName);
            tabPageSearchDeleteTenant.Controls.Add(label2);
            tabPageSearchDeleteTenant.Controls.Add(label1);
            tabPageSearchDeleteTenant.Controls.Add(cmbSelectRoomSearchTenant);
            tabPageSearchDeleteTenant.Controls.Add(cmbSelectBuildingSearchTenant);
            tabPageSearchDeleteTenant.Controls.Add(chbSearchByName);
            tabPageSearchDeleteTenant.Controls.Add(chbSearchByBuilding);
            tabPageSearchDeleteTenant.Location = new Point(4, 29);
            tabPageSearchDeleteTenant.Margin = new Padding(2, 1, 2, 1);
            tabPageSearchDeleteTenant.Name = "tabPageSearchDeleteTenant";
            tabPageSearchDeleteTenant.Padding = new Padding(2, 1, 2, 1);
            tabPageSearchDeleteTenant.Size = new Size(828, 399);
            tabPageSearchDeleteTenant.TabIndex = 1;
            tabPageSearchDeleteTenant.Text = "Search/Delete tenant";
            tabPageSearchDeleteTenant.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTenant
            // 
            btnDeleteTenant.Location = new Point(321, 280);
            btnDeleteTenant.Margin = new Padding(2, 1, 2, 1);
            btnDeleteTenant.Name = "btnDeleteTenant";
            btnDeleteTenant.Size = new Size(92, 29);
            btnDeleteTenant.TabIndex = 9;
            btnDeleteTenant.Text = "Delete";
            btnDeleteTenant.UseVisualStyleBackColor = true;
            btnDeleteTenant.Click += btnDeleteTenant_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(151, 280);
            btnSearch.Margin = new Padding(2, 1, 2, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 7;
            label3.Text = "Start inputting name";
            // 
            // cmbStartInputtingName
            // 
            cmbStartInputtingName.FormattingEnabled = true;
            cmbStartInputtingName.Location = new Point(486, 100);
            cmbStartInputtingName.Margin = new Padding(2, 1, 2, 1);
            cmbStartInputtingName.Name = "cmbStartInputtingName";
            cmbStartInputtingName.Size = new Size(150, 28);
            cmbStartInputtingName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Select room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 4;
            label1.Text = "Select building";
            // 
            // cmbSelectRoomSearchTenant
            // 
            cmbSelectRoomSearchTenant.FormattingEnabled = true;
            cmbSelectRoomSearchTenant.Location = new Point(151, 100);
            cmbSelectRoomSearchTenant.Margin = new Padding(2, 1, 2, 1);
            cmbSelectRoomSearchTenant.Name = "cmbSelectRoomSearchTenant";
            cmbSelectRoomSearchTenant.Size = new Size(150, 28);
            cmbSelectRoomSearchTenant.TabIndex = 3;
            // 
            // cmbSelectBuildingSearchTenant
            // 
            cmbSelectBuildingSearchTenant.FormattingEnabled = true;
            cmbSelectBuildingSearchTenant.Location = new Point(151, 34);
            cmbSelectBuildingSearchTenant.Margin = new Padding(2, 1, 2, 1);
            cmbSelectBuildingSearchTenant.Name = "cmbSelectBuildingSearchTenant";
            cmbSelectBuildingSearchTenant.Size = new Size(150, 28);
            cmbSelectBuildingSearchTenant.TabIndex = 2;
            cmbSelectBuildingSearchTenant.SelectedIndexChanged += cmbSelectBuildingSearchTenant_SelectIndexChanged;
            // 
            // chbSearchByName
            // 
            chbSearchByName.AutoSize = true;
            chbSearchByName.Location = new Point(330, 180);
            chbSearchByName.Margin = new Padding(2, 1, 2, 1);
            chbSearchByName.Name = "chbSearchByName";
            chbSearchByName.Size = new Size(136, 24);
            chbSearchByName.TabIndex = 1;
            chbSearchByName.Text = "Search by name";
            chbSearchByName.UseVisualStyleBackColor = true;
            chbSearchByName.CheckedChanged += chbSearchByName_CheckedChanged;
            // 
            // chbSearchByBuilding
            // 
            chbSearchByBuilding.AutoSize = true;
            chbSearchByBuilding.Location = new Point(9, 180);
            chbSearchByBuilding.Margin = new Padding(2, 1, 2, 1);
            chbSearchByBuilding.Name = "chbSearchByBuilding";
            chbSearchByBuilding.Size = new Size(154, 24);
            chbSearchByBuilding.TabIndex = 0;
            chbSearchByBuilding.Text = "Search by building";
            chbSearchByBuilding.UseVisualStyleBackColor = true;
            chbSearchByBuilding.CheckedChanged += chbSearchByBuilding_CheckedChanged;
            // 
            // tabViewComplaints
            // 
            tabViewComplaints.Controls.Add(btnNext);
            tabViewComplaints.Controls.Add(lblNumberStatic);
            tabViewComplaints.Controls.Add(lblIndex);
            tabViewComplaints.Controls.Add(lblTitleStatic);
            tabViewComplaints.Controls.Add(lblTitle);
            tabViewComplaints.Controls.Add(lblDateStatic);
            tabViewComplaints.Controls.Add(lblDate);
            tabViewComplaints.Controls.Add(btnPrevious);
            tabViewComplaints.Controls.Add(tbContent);
            tabViewComplaints.Location = new Point(4, 29);
            tabViewComplaints.Margin = new Padding(4);
            tabViewComplaints.Name = "tabViewComplaints";
            tabViewComplaints.Padding = new Padding(4);
            tabViewComplaints.Size = new Size(828, 399);
            tabViewComplaints.TabIndex = 2;
            tabViewComplaints.Text = "View Complaints";
            tabViewComplaints.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(734, 187);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblNumberStatic
            // 
            lblNumberStatic.AutoSize = true;
            lblNumberStatic.Location = new Point(0, 72);
            lblNumberStatic.Margin = new Padding(4, 0, 4, 0);
            lblNumberStatic.Name = "lblNumberStatic";
            lblNumberStatic.Size = new Size(157, 20);
            lblNumberStatic.TabIndex = 15;
            lblNumberStatic.Text = "Number of Complaint:";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(34, 109);
            lblIndex.Margin = new Padding(4, 0, 4, 0);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(63, 20);
            lblIndex.TabIndex = 14;
            lblIndex.Text = "Number";
            // 
            // lblTitleStatic
            // 
            lblTitleStatic.AutoSize = true;
            lblTitleStatic.Location = new Point(34, 27);
            lblTitleStatic.Margin = new Padding(4, 0, 4, 0);
            lblTitleStatic.Name = "lblTitleStatic";
            lblTitleStatic.Size = new Size(41, 20);
            lblTitleStatic.TabIndex = 13;
            lblTitleStatic.Text = "Title:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 27);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 20);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "title";
            // 
            // lblDateStatic
            // 
            lblDateStatic.AutoSize = true;
            lblDateStatic.Location = new Point(574, 27);
            lblDateStatic.Margin = new Padding(4, 0, 4, 0);
            lblDateStatic.Name = "lblDateStatic";
            lblDateStatic.Size = new Size(122, 20);
            lblDateStatic.TabIndex = 11;
            lblDateStatic.Text = "Date of Creation:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(690, 27);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(39, 20);
            lblDate.TabIndex = 10;
            lblDate.Text = "date";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(7, 174);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 31);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(166, 164);
            tbContent.Margin = new Padding(4);
            tbContent.Name = "tbContent";
            tbContent.ReadOnly = true;
            tbContent.Size = new Size(440, 224);
            tbContent.TabIndex = 7;
            tbContent.Text = "";
            // 
            // tbpHouseRules
            // 
            tbpHouseRules.Controls.Add(btnLoad);
            tbpHouseRules.Controls.Add(btnChange);
            tbpHouseRules.Controls.Add(richTextBox1);
            tbpHouseRules.Controls.Add(label4);
            tbpHouseRules.Location = new Point(4, 29);
            tbpHouseRules.Name = "tbpHouseRules";
            tbpHouseRules.Padding = new Padding(3);
            tbpHouseRules.Size = new Size(828, 399);
            tbpHouseRules.TabIndex = 3;
            tbpHouseRules.Text = "HouseRules";
            tbpHouseRules.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(411, 350);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(411, 40);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load rules";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.Location = new Point(6, 350);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(399, 40);
            btnChange.TabIndex = 2;
            btnChange.Text = "Apply changes";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(816, 296);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(342, 13);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 0;
            label4.Text = "House rules";
            // 
            // logOutButton
            // 
            logOutButton.BackColor = SystemColors.ActiveBorder;
            logOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.Image = Properties.Resources.logout;
            logOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logOutButton.Location = new Point(7, 447);
            logOutButton.Margin = new Padding(2, 1, 2, 1);
            logOutButton.Name = "logOutButton";
            logOutButton.Padding = new Padding(369, 0, 0, 0);
            logOutButton.Size = new Size(836, 51);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "     Log out";
            logOutButton.TextAlign = ContentAlignment.MiddleLeft;
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(828, 399);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Expense tracking";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(816, 282);
            dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 21);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 1;
            label5.Text = "Tenant expenses";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(6, 344);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(816, 49);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 504);
            Controls.Add(logOutButton);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageAddTenant.ResumeLayout(false);
            tabPageAddTenant.PerformLayout();
            tabPageSearchDeleteTenant.ResumeLayout(false);
            tabPageSearchDeleteTenant.PerformLayout();
            tabViewComplaints.ResumeLayout(false);
            tabViewComplaints.PerformLayout();
            tbpHouseRules.ResumeLayout(false);
            tbpHouseRules.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageAddTenant;
        private Button addTenantButton;
        private TabPage tabPageSearchDeleteTenant;
        private Button logOutButton;
        private Label lblRoom;
        private Label lblBuilding;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblDateOfBirth;
        private Label lblLastName;
        private Label lblFirstName;
        private ComboBox cmbRoom;
        private ComboBox cmbBuilding;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxEmail;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private DateTimePicker dateOfBirthPicker;
        private Label label3;
        private ComboBox cmbStartInputtingName;
        private Label label2;
        private Label label1;
        private ComboBox cmbSelectRoomSearchTenant;
        private ComboBox cmbSelectBuildingSearchTenant;
        private CheckBox chbSearchByName;
        private CheckBox chbSearchByBuilding;
        private Button btnSearch;
        private Button btnDeleteTenant;
        private TabPage tabViewComplaints;
        private Button btnNext;
        private Label lblNumberStatic;
        private Label lblIndex;
        private Label lblTitleStatic;
        private Label lblTitle;
        private Label lblDateStatic;
        private Label lblDate;
        private Button btnPrevious;
        private RichTextBox tbContent;
        private TabPage tbpHouseRules;
        private Button btnChange;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button btnLoad;
        private TabPage tabPage1;
        private Button btnRefresh;
        private Label label5;
        private DataGridView dataGridView1;
    }
}