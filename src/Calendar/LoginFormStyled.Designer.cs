namespace Calendar
{
    partial class LoginFormStyled
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
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            panel1=new Panel();
            btnLogin=new Button();
            chbShowHidePassword=new CheckBox();
            txtPassword=new TextBox();
            label3=new Label();
            txtUsername=new TextBox();
            label2=new Label();
            label1=new Label();
            pictureBox3=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.FromArgb(205, 211, 213);
            pictureBox1.Dock=DockStyle.Top;
            pictureBox1.Location=new Point(0, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(1666, 494);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor=Color.FromArgb(117, 184, 200);
            pictureBox2.Dock=DockStyle.Bottom;
            pictureBox2.Location=new Point(0, 492);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(1666, 634);
            pictureBox2.TabIndex=1;
            pictureBox2.TabStop=false;
            // 
            // panel1
            // 
            panel1.BackColor=Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(chbShowHidePassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location=new Point(329, 146);
            panel1.Name="panel1";
            panel1.Size=new Size(996, 854);
            panel1.TabIndex=2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor=Color.FromArgb(205, 211, 213);
            btnLogin.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location=new Point(373, 746);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(204, 83);
            btnLogin.TabIndex=7;
            btnLogin.Text="Log in";
            btnLogin.UseVisualStyleBackColor=false;
            btnLogin.Click+=btnLogin_Click;
            // 
            // chbShowHidePassword
            // 
            chbShowHidePassword.AutoSize=true;
            chbShowHidePassword.Location=new Point(239, 666);
            chbShowHidePassword.Name="chbShowHidePassword";
            chbShowHidePassword.Size=new Size(210, 36);
            chbShowHidePassword.TabIndex=6;
            chbShowHidePassword.Text="Show password";
            chbShowHidePassword.UseVisualStyleBackColor=true;
            chbShowHidePassword.CheckedChanged+=chbShowHidePassword_CheckChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle=BorderStyle.None;
            txtPassword.Location=new Point(240, 557);
            txtPassword.Multiline=true;
            txtPassword.Name="txtPassword";
            txtPassword.PlaceholderText="Password";
            txtPassword.Size=new Size(524, 38);
            txtPassword.TabIndex=4;
            txtPassword.PasswordChar = '*';
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.Transparent;
            label3.Location=new Point(233, 579);
            label3.Name="label3";
            label3.Size=new Size(524, 32);
            label3.TabIndex=5;
            label3.Text="___________________________________________________";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle=BorderStyle.None;
            txtUsername.Location=new Point(239, 398);
            txtUsername.Multiline=true;
            txtUsername.Name="txtUsername";
            txtUsername.PlaceholderText="Username";
            txtUsername.Size=new Size(524, 38);
            txtUsername.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(232, 420);
            label2.Name="label2";
            label2.Size=new Size(524, 32);
            label2.TabIndex=3;
            label2.Text="___________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Light", 22.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(407, 270);
            label1.Name="label1";
            label1.Size=new Size(170, 78);
            label1.TabIndex=1;
            label1.Text="Login";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor=Color.Black;
            pictureBox3.Location=new Point(342, 47);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(286, 218);
            pictureBox3.TabIndex=0;
            pictureBox3.TabStop=false;
            // 
            // LoginFormStyled
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1666, 1126);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name="LoginFormStyled";
            StartPosition=FormStartPosition.CenterScreen;
            Text="LoginFormStyled";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private CheckBox chbShowHidePassword;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
    }
}