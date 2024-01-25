using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class SupportForm : Form
    {
        private Account loggedInAccount;
        private ProfessionsForChatBot selectedProfession;
        private string description;
        DataBase database = new DataBase();
        public SupportForm(Account loggedInAccount)
        {
            InitializeComponent();
            this.loggedInAccount = loggedInAccount;

            cmbProfession.DataSource = Enum.GetValues(typeof(ProfessionsForChatBot));
        }

        private void SupportForm_Load(object sender, EventArgs e)
        {
            DisplayBotMessage($"Welcome to the Support Chat Bot, {loggedInAccount.Username}!");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cmbProfession.SelectedItem == null)
            {
                MessageBox.Show("Please select a profession.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userMessage = txtUserMessage.Text;
            description = userMessage;
            DisplayUserMessage(userMessage);

            selectedProfession = (ProfessionsForChatBot)cmbProfession.SelectedItem;

            if (selectedProfession != null)
            {
                string response = GenerateResponse(selectedProfession, userMessage);

                if (string.IsNullOrEmpty(response))
                {
                    response = "I'm sorry, I cannot assist with that request.";
                }

                DisplayBotMessage(response);
            }
            else
            {
                MessageBox.Show("Please select a profession.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserMessage.Text = string.Empty;
        }

        private void cmbProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProfession =(ProfessionsForChatBot)cmbProfession.SelectedItem;
        }

        private string GenerateResponse(ProfessionsForChatBot profession, string userMessage)
        {
            string response = string.Empty;

            if (profession == ProfessionsForChatBot.Other)
            {
                response = "Your request is being received and processed. A manager will contact you soon.";
            }
            else
            {
                switch (profession)
                {
                    case ProfessionsForChatBot.Plumber:
                        if (userMessage.ToLower().Contains("tap") || userMessage.ToLower().Contains("shower") || userMessage.ToLower().Contains("sink"))
                        {
                            response = "For any plumbing-related issues, make sure to turn off the main water supply. Your request is being received and processed. A manager will contact you soon.";
                        }
                        else
                        {
                            response = "I'm sorry, but I'm not able to assist with that plumbing request at the moment.";
                        }
                        break;
                    case ProfessionsForChatBot.WoodWorker:
                        if (userMessage.ToLower().Contains("broken") && (userMessage.ToLower().Contains("chair") ||userMessage.ToLower().Contains("table") || userMessage.ToLower().Contains("storage")))
                        {
                            response = "Your request is being received and processed. A manager will contact you soon.";
                        }
                        else
                        {
                            response = "I apologize, but I don't have the expertise to provide guidance on that woodworking request.";
                        }
                        break;
                    case ProfessionsForChatBot.Electrician:
                        if (userMessage.ToLower().Contains("wire") || userMessage.ToLower().Contains("lamp"))
                        {
                            response = "Make sure to turn off the main electrical panel. Your request is being received and processed. A manager will contact you soon.";
                        }
                        else
                        {
                            response = "If you need assistance with electrical issues, please provide more details regarding the problem via this number: +XXXXXXXXXX.";
                        }
                        break;
                }
            }

            return response;
        }

        private void DisplayUserMessage(string message)
        {
            txtChatHistory.AppendText("You: " + message + Environment.NewLine);
        }

        private void DisplayBotMessage(string message)
        {
            txtChatHistory.AppendText("Support: " + message + Environment.NewLine);
        }

        private void btnEndChat_Click(object sender, EventArgs e)
        {
            database.InsertInquiryToDatabase(description, loggedInAccount, selectedProfession);
            Close();
        }
    }
}

