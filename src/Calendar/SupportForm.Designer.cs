namespace Calendar
{
    partial class SupportForm
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
            txtChatHistory=new RichTextBox();
            txtUserMessage=new RichTextBox();
            lblChatHistory=new Label();
            btnSendMessage=new Button();
            btnEndChat=new Button();
            cmbProfession=new ComboBox();
            SuspendLayout();
            // 
            // txtChatHistory
            // 
            txtChatHistory.Location=new Point(499, 58);
            txtChatHistory.Name="txtChatHistory";
            txtChatHistory.Size=new Size(499, 510);
            txtChatHistory.TabIndex=0;
            txtChatHistory.Text="";
            // 
            // txtUserMessage
            // 
            txtUserMessage.Location=new Point(12, 210);
            txtUserMessage.Name="txtUserMessage";
            txtUserMessage.Size=new Size(270, 246);
            txtUserMessage.TabIndex=1;
            txtUserMessage.Text="";
            // 
            // lblChatHistory
            // 
            lblChatHistory.AutoSize=true;
            lblChatHistory.Location=new Point(711, 9);
            lblChatHistory.Name="lblChatHistory";
            lblChatHistory.Size=new Size(89, 32);
            lblChatHistory.TabIndex=2;
            lblChatHistory.Text="History";
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location=new Point(12, 518);
            btnSendMessage.Name="btnSendMessage";
            btnSendMessage.Size=new Size(270, 50);
            btnSendMessage.TabIndex=3;
            btnSendMessage.Text="Send";
            btnSendMessage.UseVisualStyleBackColor=true;
            btnSendMessage.Click+=btnSend_Click;
            // 
            // btnEndChat
            // 
            btnEndChat.Location=new Point(685, 574);
            btnEndChat.Name="btnEndChat";
            btnEndChat.Size=new Size(150, 46);
            btnEndChat.TabIndex=4;
            btnEndChat.Text="End chat";
            btnEndChat.UseVisualStyleBackColor=true;
            btnEndChat.Click+=btnEndChat_Click;
            // 
            // cmbProfession
            // 
            cmbProfession.FormattingEnabled=true;
            cmbProfession.Location=new Point(12, 472);
            cmbProfession.Name="cmbProfession";
            cmbProfession.Size=new Size(270, 40);
            cmbProfession.TabIndex=5;
            cmbProfession.SelectedIndexChanged+=cmbProfession_SelectedIndexChanged;
            // 
            // SupportForm
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1010, 624);
            Controls.Add(cmbProfession);
            Controls.Add(btnEndChat);
            Controls.Add(btnSendMessage);
            Controls.Add(lblChatHistory);
            Controls.Add(txtUserMessage);
            Controls.Add(txtChatHistory);
            Name="SupportForm";
            Text="SupportForm";
            Load+=SupportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtChatHistory;
        private RichTextBox txtUserMessage;
        private Label lblChatHistory;
        private Button btnSendMessage;
        private Button btnEndChat;
        private ComboBox cmbProfession;
    }
}