using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MyProfileForm : Form
    {
        private const string connectionString = "server = mssqlstud; Database = dbi522361; User Id = dbi522361; Password = P@ssvvord;";
        private Account loggedInAccount;
        private Account initialAccountInfo;
        private bool isEditMode = false;
        public MyProfileForm(Account loggedInAccount)
        {
            InitializeComponent();
            this.loggedInAccount = loggedInAccount;

            txtBoxFullName.Text = loggedInAccount.FullName;
            RevertToInitialAccountInfo(loggedInAccount);

            txtBoxFullName.Enabled = false;
            SetTextBoxesEnabled(false);

            initialAccountInfo = new Account(txtBoxEmail.Text, txtBoxContactInformation.Text, txtBoxUsername.Text, txtBoxPassword.Text, null, null, null, null, null);
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            this.Text = "My Profile. Username - " + loggedInAccount.Username;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (IsAccountInfoChanged())
                {
                    DialogResult result = MessageBox.Show("You have made some changes to account information. Do you want to save them?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        RevertToInitialAccountInfo(initialAccountInfo);
                    }
                }
                btnSaveInfo.Visible = false;
                isEditMode = false;
                btnEditInfo.Text = "Edit";
            }
            else
            {
                btnSaveInfo.Visible = true;
                isEditMode = true;
                btnEditInfo.Text = "Cancel";
            }

            SetTextBoxesEnabled(isEditMode);

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            UpdateDatabase();

            btnSaveInfo.Visible = false;
            isEditMode = false;
            btnEditInfo.Text = "Edit";
            SetTextBoxesEnabled(isEditMode);
        }

        private void UpdateDatabase()
        {
            UpdateAccountInfo(loggedInAccount);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE [Account]
                                 SET Email = @Email,
                                 ContactInformation = @ContactInformation,
                                 Username = @Username,
                                 Password = @Password
                                 WHERE ID = @AccountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", loggedInAccount.Email);
                    command.Parameters.AddWithValue("@ContactInformation", loggedInAccount.ContactInformation);
                    command.Parameters.AddWithValue("@Username", loggedInAccount.Username);
                    command.Parameters.AddWithValue("@Password", loggedInAccount.Password);
                    command.Parameters.AddWithValue("@AccountID", loggedInAccount.ID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connection.Close();
            }
            UpdateAccountInfo(initialAccountInfo);
        }

        private void SetTextBoxesEnabled(bool enabled)
        {
            txtBoxEmail.Enabled = enabled;
            txtBoxContactInformation.Enabled = enabled;
            txtBoxUsername.Enabled = enabled;
            txtBoxPassword.Enabled = enabled;
        }

        private void UpdateAccountInfo(Account account)
        {
            if (account == null)
            {
                MessageBox.Show("No object.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account.Email = txtBoxEmail.Text;
                account.ContactInformation = txtBoxContactInformation.Text;
                account.Username = txtBoxUsername.Text;
                account.Password = txtBoxPassword.Text;
            }
        }

        private void RevertToInitialAccountInfo(Account account)
        {
            txtBoxEmail.Text = account.Email;
            txtBoxContactInformation.Text = account.ContactInformation;
            txtBoxUsername.Text = account.Username;
            txtBoxPassword.Text = account.Password;
        }

        private bool IsAccountInfoChanged()
        {
            if (initialAccountInfo.Email != txtBoxEmail.Text || initialAccountInfo.ContactInformation != txtBoxContactInformation.Text ||
                initialAccountInfo.Username != txtBoxUsername.Text || initialAccountInfo.Password != txtBoxPassword.Text)
            {
                return true;
            }

            return false;
        }
    }
}
