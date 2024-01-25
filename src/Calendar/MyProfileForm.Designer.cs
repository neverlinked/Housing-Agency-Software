namespace Calendar
{
    partial class MyProfileForm
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
            lblFullName=new Label();
            lblEmail=new Label();
            lblContactInformation=new Label();
            lblUsername=new Label();
            lblPassword=new Label();
            btnEditInfo=new Button();
            pictureBox1=new PictureBox();
            btnChangePicture=new Button();
            txtBoxFullName=new TextBox();
            txtBoxEmail=new TextBox();
            txtBoxContactInformation=new TextBox();
            txtBoxUsername=new TextBox();
            txtBoxPassword=new TextBox();
            btnSaveInfo=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize=true;
            lblFullName.Location=new Point(415, 56);
            lblFullName.Name="lblFullName";
            lblFullName.Size=new Size(119, 32);
            lblFullName.TabIndex=0;
            lblFullName.Text="Full name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize=true;
            lblEmail.Location=new Point(415, 148);
            lblEmail.Name="lblEmail";
            lblEmail.Size=new Size(71, 32);
            lblEmail.TabIndex=1;
            lblEmail.Text="Email";
            // 
            // lblContactInformation
            // 
            lblContactInformation.AutoSize=true;
            lblContactInformation.Location=new Point(415, 256);
            lblContactInformation.Name="lblContactInformation";
            lblContactInformation.Size=new Size(228, 32);
            lblContactInformation.TabIndex=2;
            lblContactInformation.Text="Contact information";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize=true;
            lblUsername.Location=new Point(415, 360);
            lblUsername.Name="lblUsername";
            lblUsername.Size=new Size(121, 32);
            lblUsername.TabIndex=3;
            lblUsername.Text="Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize=true;
            lblPassword.Location=new Point(415, 464);
            lblPassword.Name="lblPassword";
            lblPassword.Size=new Size(111, 32);
            lblPassword.TabIndex=4;
            lblPassword.Text="Password";
            // 
            // btnEditInfo
            // 
            btnEditInfo.Location=new Point(581, 578);
            btnEditInfo.Name="btnEditInfo";
            btnEditInfo.Size=new Size(150, 46);
            btnEditInfo.TabIndex=5;
            btnEditInfo.Text="Edit";
            btnEditInfo.UseVisualStyleBackColor=true;
            btnEditInfo.Click+=btnEditInfo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(292, 274);
            pictureBox1.TabIndex=6;
            pictureBox1.TabStop=false;
            // 
            // btnChangePicture
            // 
            btnChangePicture.Location=new Point(83, 318);
            btnChangePicture.Name="btnChangePicture";
            btnChangePicture.Size=new Size(150, 46);
            btnChangePicture.TabIndex=7;
            btnChangePicture.Text="Change";
            btnChangePicture.UseVisualStyleBackColor=true;
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location=new Point(658, 53);
            txtBoxFullName.Name="txtBoxFullName";
            txtBoxFullName.Size=new Size(200, 39);
            txtBoxFullName.TabIndex=8;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location=new Point(658, 145);
            txtBoxEmail.Name="txtBoxEmail";
            txtBoxEmail.Size=new Size(200, 39);
            txtBoxEmail.TabIndex=9;
            // 
            // txtBoxContactInformation
            // 
            txtBoxContactInformation.Location=new Point(658, 253);
            txtBoxContactInformation.Name="txtBoxContactInformation";
            txtBoxContactInformation.Size=new Size(200, 39);
            txtBoxContactInformation.TabIndex=10;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location=new Point(658, 357);
            txtBoxUsername.Name="txtBoxUsername";
            txtBoxUsername.Size=new Size(200, 39);
            txtBoxUsername.TabIndex=11;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location=new Point(658, 461);
            txtBoxPassword.Name="txtBoxPassword";
            txtBoxPassword.Size=new Size(200, 39);
            txtBoxPassword.TabIndex=12;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location=new Point(769, 578);
            btnSaveInfo.Name="btnSaveInfo";
            btnSaveInfo.Size=new Size(150, 46);
            btnSaveInfo.TabIndex=13;
            btnSaveInfo.Text="Save";
            btnSaveInfo.UseVisualStyleBackColor=true;
            btnSaveInfo.Visible=false;
            btnSaveInfo.Click+=btnSaveInfo_Click;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1014, 652);
            Controls.Add(btnSaveInfo);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(txtBoxContactInformation);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxFullName);
            Controls.Add(btnChangePicture);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditInfo);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblContactInformation);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Name="MyProfileForm";
            Text="MyProfileForm";
            Load+=MyProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblEmail;
        private Label lblContactInformation;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnEditInfo;
        private PictureBox pictureBox1;
        private Button btnChangePicture;
        private TextBox txtBoxFullName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxContactInformation;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Button btnSaveInfo;
    }
}