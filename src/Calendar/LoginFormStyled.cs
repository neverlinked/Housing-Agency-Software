using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Calendar
{
    public partial class LoginFormStyled : Form
    {
        private const string connectionString = "server = mssqlstud; Database = dbi522361; User Id = dbi522361; Password = P@ssvvord;";
        private bool isLoggedIn;
        private Account LoggedInAccount;
        public LoginFormStyled()
        {
            InitializeComponent();
            this.Text = "Login Form";
            //By default - false
            isLoggedIn = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show($"Please input correct username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidateLogin(username, password))
                {
                    // Login successful
                    isLoggedIn = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }

        //Validating credentials
        public bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                        SELECT a.ID AS AccountID, a.Username AS Username, a.Password AS Password, a.Email AS Email, a.FullName AS FullName, a.ContactInformation AS ContactInformation, a.Role AS Role, a.DateOfBirth AS DateOfBirth, 
                               r.ID AS RoomID, r.Number As RoomNumber, r.Status AS RoomStatus,
                               b.ID AS BuildingID, b.Number AS BuildingNumber,b.Name AS BuildingName
                        FROM [Account] a
                        INNER JOIN [Room] r
                            ON a.RoomID = r.ID
                        INNER JOIN [Building] b
                            ON r.BuildingID = b.ID
                        WHERE a.Username = @Username AND a.Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int accountID = (int)reader["AccountID"];
                            string email = (string)reader["Email"];
                            string fullName = (string)reader["FullName"];
                            DateTime dateOfBirth = (DateTime)reader["DateOfBirth"];
                            string contactInformation = (string)reader["ContactInformation"];
                            string role = (string)reader["Role"];

                            int roomID = (int)reader["RoomID"];
                            int roomNumber = (int)reader["RoomNumber"];
                            string roomStatus = (string)reader["RoomStatus"];

                            int buildingID = (int)reader["BuildingID"];
                            int buildingNumber = (int)reader["BuildingNumber"];
                            string buildingName = (string)reader["BuildingName"];

                            Building assignedBuilding = new Building(buildingID, buildingNumber, buildingName);
                            Room assignedRoom = new Room(roomID, roomNumber, roomStatus, assignedBuilding);

                            LoggedInAccount = new Account(username, email, contactInformation, fullName, dateOfBirth, role, assignedRoom, accountID, password);

                            return true; // Login successful
                        }
                    }
                }
            }

            return false; //Login failed
        }

        public static bool ShowLogin(out Account loggedInAccount)
        {
            loggedInAccount = null;

            LoginFormStyled loginFormStyled = new LoginFormStyled();
            loginFormStyled.ShowDialog();

            if (loginFormStyled.isLoggedIn)
            {
                loggedInAccount = loginFormStyled.LoggedInAccount;
                return true;
            }
            return false;
        }

        public void chbShowHidePassword_CheckChanged(object sender, EventArgs e)
        {
            if (chbShowHidePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
