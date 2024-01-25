using System.Data;
using System.Text;

namespace Calendar
{
    public partial class ManagerForm : Form
    {
        DataBase database = new DataBase();
        private List<UserAction> complaints;
        private int listIndexComplaints;
        private int listSizeComplaints;
        List<string> tenantNames;
        private Random random;
        private Account managerAccount;
        private string houseRules;
        public ManagerForm(Account loggedInAccount)
        {
            InitializeComponent();
            managerAccount = loggedInAccount;
            cmbRoom.DisplayMember = "Number";
            cmbBuilding.DisplayMember = "Name";
            cmbSelectRoomSearchTenant.DisplayMember = "Number";
            cmbSelectBuildingSearchTenant.DisplayMember = "Name";
            this.Text = "Manager Form. Active user - " + managerAccount.Username;
            tenantNames = database.GetTenantNames();
            cmbStartInputtingName.Items.AddRange(tenantNames.ToArray());
        }

        public void ManagerForm_Load(object sender, EventArgs e)
        {
            database.PopulateBuildings(cmbBuilding);
            database.PopulateBuildings(cmbSelectBuildingSearchTenant);
            PopulateComplaints();
            UpdateLabels();
            PopulateExpenses();
        }

        //Adds new Tenant 'Add tenant' tab
        private void addTenantButton_Click(object sender, EventArgs e)
        {
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            DateTime dateOfBirth = dateOfBirthPicker.Value;
            string email = txtBoxEmail.Text;
            string phoneNumber = txtBoxPhoneNumber.Text;
            Building assignedBuilding = cmbBuilding.SelectedItem as Building;
            Room assignedRoom = cmbRoom.SelectedItem as Room;

            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
               && dateOfBirth != null && !string.IsNullOrWhiteSpace(email)
               && !string.IsNullOrWhiteSpace(phoneNumber) && assignedBuilding != null
               && assignedRoom != null)
            {
                string username = GenerateUsername(firstName, lastName);
                string password = GeneratePassword();

                Account newAccount = new Account(username, email, phoneNumber, firstName + " " + lastName, dateOfBirth, "User", assignedRoom, null, password);

                database.SaveTenant(newAccount);

                MessageBox.Show("Tenant was successfully added!" +
                    $"\n Personal information:" +
                    $"\n Full name: {firstName + " " + lastName}" +
                    $"\n Date of birth: {dateOfBirth}" +
                    $"\n Contact information:" +
                    $"\n Phone number: {phoneNumber}" +
                    $"\n Email: {email}" +
                    $"\n Account credentials:" +
                    $"\n Username: {username}" +
                    $"\n Password: {password}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields above.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetValues();
        }

        //Delete Tenant in 'Search/Delete' tab
        private void btnDeleteTenant_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this tenant?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (chbSearchByBuilding.Checked)
                {
                    Building selectedBuilding = cmbSelectBuildingSearchTenant.SelectedItem as Building;
                    Room selectedRoom = cmbSelectRoomSearchTenant.SelectedItem as Room;

                    if (selectedBuilding != null && selectedRoom != null)
                    {
                        Account searchParameters = database.SearchByBuildingAndRoom(selectedBuilding, selectedRoom);
                        if (searchParameters != null)
                        {
                            database.DeleteTenant(searchParameters);
                        }
                        else
                        {
                            MessageBox.Show("Tenant not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select building and room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (chbSearchByName.Checked)
                {
                    string selectedName = cmbStartInputtingName.Text;

                    if (!string.IsNullOrWhiteSpace(selectedName))
                    {
                        Account searchParameters = database.SearchByName(selectedName);

                        if (searchParameters != null)
                        {
                            database.DeleteTenant(searchParameters);
                        }
                        else
                        {
                            MessageBox.Show("Tenant not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please choose search type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Searches for tenant based on the preference 'Search/Delete' teb
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chbSearchByBuilding.Checked)
            {
                Building selectedBuilding = cmbSelectBuildingSearchTenant.SelectedItem as Building;
                Room selectedRoom = cmbSelectRoomSearchTenant.SelectedItem as Room;

                if (selectedBuilding != null && selectedRoom != null)
                {
                    Account searchParameters = database.SearchByBuildingAndRoom(selectedBuilding, selectedRoom);

                    MessageBox.Show($"Tenant found: building number: {searchParameters.AssignedRoom.AssignedBuilding.Number}, building name: {searchParameters.AssignedRoom.AssignedBuilding.Name}, room: {searchParameters.AssignedRoom.Number}" +
                        $"\n" +
                        $"\n Full name: {searchParameters.FullName}" +
                        $"\n Date of birth: {searchParameters.DateOfBirth}" +
                        $"\n Email: {searchParameters.Email}" +
                        $"\n Phone number: {searchParameters.ContactInformation}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select building and room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chbSearchByName.Checked)
            {
                string selectedName = cmbStartInputtingName.Text;

                Account searchParameters = database.SearchByName(selectedName);

                if (searchParameters != null)
                {
                    MessageBox.Show($"Tenant found: building number: {searchParameters.AssignedRoom.AssignedBuilding.Number}, building name: {searchParameters.AssignedRoom.AssignedBuilding.Name}, room: {searchParameters.AssignedRoom.Number}" +
                        $"\n" +
                        $"\n Full name: {searchParameters.FullName}" +
                        $"\n Date of birth: {searchParameters.DateOfBirth}" +
                        $"\n Email: {searchParameters.Email}" +
                        $"\n Phone number: {searchParameters.ContactInformation}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose search type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Depending on building chosen populating rooms in 'Add tenant' tab
        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            Building building = cmbBuilding.SelectedItem as Building;

            if (building != null)
            {
                database.PopulateVacantRooms(cmbRoom, building);
            }
        }

        //Username generator for new tenant in 'Add tenant' tab
        private string GenerateUsername(string firstName, string lastName)
        {
            string username = string.Empty;

            username = firstName.ToLower() + "." + lastName.ToLower();

            return username;
        }

        //Password generator for new tenant in 'Add tenant' tab
        private string GeneratePassword()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int passwordLength = 8; // Desired password length

            // Create a StringBuilder to store the generated password
            StringBuilder password = new StringBuilder();

            // Create a random number generator
            random = new Random();

            // Generate the password
            for (int i = 0; i < passwordLength; i++)
            {
                // Get a random index within the allowedChars string
                int randomIndex = random.Next(0, allowedChars.Length);

                // Append the random character to the password string
                password.Append(allowedChars[randomIndex]);
            }

            return password.ToString();
        }

        //Resets values from inputs in 'Add tenant' tab
        private void ResetValues()
        {
            txtBoxFirstName.Text = string.Empty;
            txtBoxLastName.Text = string.Empty;
            dateOfBirthPicker.Value = DateTime.Today;
            txtBoxEmail.Text = string.Empty;
            txtBoxPhoneNumber.Text = string.Empty;
            cmbBuilding.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
        }

        //Depending on building chosen populating rooms in 'Search/Delete' tab
        private void cmbSelectBuildingSearchTenant_SelectIndexChanged(object sender, EventArgs e)
        {
            Building building = cmbSelectBuildingSearchTenant.SelectedItem as Building;

            if (building != null)
            {
                database.PopulateOccupiedRooms(cmbSelectRoomSearchTenant, building);
            }
        }

        //Dynamic search for comboBox with names 'Search/Delete' tab
        private void cmbStartInputtingName_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = cmbStartInputtingName.Text.ToLower();

            List<string> filteredNames = tenantNames.Where(name => name.ToLower().StartsWith(searchQuery)).ToList();

            cmbStartInputtingName.Items.Clear();
            cmbStartInputtingName.Items.AddRange(filteredNames.ToArray());
            cmbStartInputtingName.SelectionStart = searchQuery.Length;
            cmbStartInputtingName.SelectionLength = cmbStartInputtingName.Text.Length - searchQuery.Length;
            cmbStartInputtingName.DroppedDown = true;
        }

        //Checking the checker 'Search/Delete' tab
        private void chbSearchByBuilding_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSearchByBuilding.Checked)
            {
                chbSearchByName.Checked = false;
            }
        }

        //Checking the checker 'Search/Delete' tab
        private void chbSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSearchByName.Checked)
            {
                chbSearchByBuilding.Checked = false;
            }
        }

        //Logs out user
        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Log out the user
            managerAccount = null;

            // Close the TenantForm
            Close();

            // Start a new instance of the application with the LoginForm as the main form
            Application.Restart();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listIndexComplaints > 0)
            {
                listIndexComplaints--;
                UpdateLabels();
            }
        }

        //Goes to the next complaint
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listIndexComplaints < listSizeComplaints)
            {
                listIndexComplaints++;
                UpdateLabels();
            }
        }

        //Method to update the labels with Complaint Data
        private void UpdateLabels()
        {
            UserAction userActionAtIndex = complaints[listIndexComplaints];

            lblIndex.Text = Convert.ToString(listIndexComplaints + 1);
            lblDate.Text = Convert.ToString(userActionAtIndex.Date);
            lblTitle.Text = userActionAtIndex.Name;
            tbContent.Text = userActionAtIndex.Description;
        }

        //Method which is used to get the data of the complaint from the database
        private void PopulateComplaints()
        {
            complaints = new List<UserAction>();
            complaints = database.PopulateComplaints();
            listSizeComplaints = complaints.Count - 1;
        }



        private void PopulateCurrentRules()
        {
            houseRules = database.GetHouseRules();
            richTextBox1.Text = string.Join(Environment.NewLine, houseRules);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newHouseRules = richTextBox1.Text;

            bool success = database.UpdateHouseRules(newHouseRules);

            if (success)
            {
                MessageBox.Show("House rules updated successfully.");
                PopulateCurrentRules();
            }
            else
            {
                MessageBox.Show("Failed to update house rules.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PopulateCurrentRules();
        }

        private void PopulateExpenses()
        {
            DataTable expenses = database.GetExpenses();

            dataGridView1.DataSource = expenses;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateExpenses();
        }
    }
}