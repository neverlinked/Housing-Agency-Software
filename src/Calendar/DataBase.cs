using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Calendar
{
    public class DataBase
    {
        private static string connectionString = "server = mssqlstud; Database = dbi522361; User Id = dbi522361; Password = P@ssvvord;";
        private static string logFilePath = "C:\\Users\\Serhii\\Desktop\\project\\housing-project-s-3-2\\src\\Calendar\\LogTenants.txt";
        public DataBase() { }

        //
        //MANAGER FORM
        //

        //Saves new object of Account(New tenant) to database
        public void SaveTenant(Account account)
        {
            account.AssignedRoom.Status = "Occupied";

            UpdateRoomStatus(account.AssignedRoom);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [Account] (RoomID, Username, Password, Email, FullName, DateOfBirth, ContactInformation, Role)
                    VALUES (@RoomID, @Username, @Password, @Email, @FullName, @DateOfBirth, @ContactInformation, @Role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", account.AssignedRoom.ID);
                    command.Parameters.AddWithValue("@Username", account.Username);
                    command.Parameters.AddWithValue("@Password", account.Password);
                    command.Parameters.AddWithValue("@Email", account.Email);
                    command.Parameters.AddWithValue("@FullName", account.FullName);
                    command.Parameters.AddWithValue("@DateOfBirth", account.DateOfBirth);
                    command.Parameters.AddWithValue("@ContactInformation", account.ContactInformation);
                    command.Parameters.AddWithValue("@Role", account.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Deletes Account(Tenant) from database
        public void DeleteTenant(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string logQuery = @"SELECT si.InquiryType, si.Description, si.DateOfSubmission, si.Status, ua.Date, ua.Time, ua.Name, ua.Description, ua.Type
                                FROM Account a
                                LEFT JOIN UserActions ua ON ua.AccountID = a.ID
                                LEFT JOIN SupportInquires si ON si.AccountID = a.ID
                                WHERE a.ID = @AccountID";

                    using (SqlCommand command = new SqlCommand(logQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", account.ID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
                            {
                                logWriter.WriteLine($"Tenant {account.FullName} - Date of birth {account.DateOfBirth} - Contact information: {account.ContactInformation}/{account.Email}");
                                logWriter.WriteLine();
                                logWriter.WriteLine("Support Inquiries:");

                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("InquiryType")))
                                    {
                                        string inquiryType = reader.GetString(reader.GetOrdinal("InquiryType"));
                                        string description = reader.GetString(reader.GetOrdinal("Description"));
                                        string dateOfSubmission = reader.GetDateTime(reader.GetOrdinal("DateOfSubmission")).ToString();
                                        string status = reader.GetString(reader.GetOrdinal("Status"));

                                        logWriter.WriteLine($"- Inquiry Type: {inquiryType}");
                                        logWriter.WriteLine($"  Description: {description}");
                                        logWriter.WriteLine($"  Date of Submission: {dateOfSubmission}");
                                        logWriter.WriteLine($"  Status: {status}");
                                        logWriter.WriteLine();
                                    }
                                }

                                reader.NextResult();

                                logWriter.WriteLine("User Actions:");

                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Date")))
                                    {
                                        string date = reader.GetDateTime(reader.GetOrdinal("Date")).ToString();
                                        string time = reader.GetString(reader.GetOrdinal("Time"));
                                        string name = reader.GetString(reader.GetOrdinal("Name"));
                                        string description = reader.GetString(reader.GetOrdinal("Description"));
                                        string type = reader.GetString(reader.GetOrdinal("Type"));

                                        logWriter.WriteLine($"- Date: {date}");
                                        logWriter.WriteLine($"  Time: {time}");
                                        logWriter.WriteLine($"  Name: {name}");
                                        logWriter.WriteLine($"  Description: {description}");
                                        logWriter.WriteLine($"  Type: {type}");
                                        logWriter.WriteLine();
                                    }
                                }
                            }
                        }
                    }

                    // Delete Tenant from [Account]
                    string deleteTenantQuery = @"DELETE FROM [Account] WHERE ID = @AccountID";

                    using (SqlCommand command = new SqlCommand(deleteTenantQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", account.ID);
                        command.ExecuteNonQuery();
                    }

                    account.AssignedRoom.Status = "Vacant";
                    UpdateRoomStatus(account.AssignedRoom);

                    MessageBox.Show("Tenant has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the tenant. Please contact your developer.\n\nError details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }


        //Updates status of the room
        private void UpdateRoomStatus(Room room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE [Room] SET Status = @Status WHERE ID = @RoomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", room.Status);
                    command.Parameters.AddWithValue("@RoomID", room.ID);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        //Search tenant by building and room 'Search/Delete' tab
        public Account SearchByBuildingAndRoom(Building building, Room room)
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
                        WHERE b.ID = @BuildingID AND r.ID = @RoomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuildingID", building.ID);
                    command.Parameters.AddWithValue("@RoomID", room.ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int accountID = (int)reader["AccountID"];
                            string username = (string)reader["Username"];
                            string password = (string)reader["Password"];
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

                            return new Account(username, email, contactInformation, fullName, dateOfBirth, role, assignedRoom, accountID, password);
                        }
                    }
                }
            }
            return null;
        }

        //Search tenant by full name 'Search/Delete' tab
        public Account SearchByName(string name)
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
                        WHERE a.FullName = @FullName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", name);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int accountID = (int)reader["AccountID"];
                            string username = (string)reader["Username"];
                            string password = (string)reader["Password"];
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

                            return new Account(username, email, contactInformation, fullName, dateOfBirth, role, assignedRoom, accountID, password);
                        }
                    }
                }
            }
            return null;
        }

        //Populates buildings
        public void PopulateBuildings(ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [Building]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int buildingID = (int)reader["ID"];
                            int buildingNumber = (int)reader["Number"];
                            string buildingName = (string)reader["Name"];

                            Building building = new Building(buildingID, buildingNumber, buildingName);
                            comboBox.Items.Add(building);
                        }
                    }
                }
            }
        }

        public void PopulateVacantRooms(ComboBox comboBox, Building building)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [Room] WHERE BuildingID = @BuildingID AND Status = 'Vacant'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("BuildingID", building.ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID"];
                            int number = (int)reader["Number"];
                            string status = (string)reader["Status"];

                            Room room = new Room(id, number, status, building);
                            comboBox.Items.Add(room);
                        }
                    }
                }
            }
        }

        public void PopulateOccupiedRooms(ComboBox comboBox, Building building)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [Room] WHERE BuildingID = @BuildingID AND Status = 'Occupied'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("BuildingID", building.ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID"];
                            int number = (int)reader["Number"];
                            string status = (string)reader["Status"];

                            Room room = new Room(id, number, status, building);
                            comboBox.Items.Add(room);
                        }
                    }
                }
            }
        }

        public List<string> GetTenantNames()
        {
            List<string> tenantNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT a.FullName AS FullName 
                                FROM [Account] a
                                INNER JOIN [Room] r
                                ON r.ID = a.RoomID
                                WHERE r.Status = 'Occupied'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = (string)reader["FullName"];
                            tenantNames.Add(fullName);
                        }
                    }
                }
            }

            return tenantNames;
        }

        //
        //
        //

        //
        //SUPPORT FORM
        //
        public void InsertInquiryToDatabase(string description, Account loggedInAccount, ProfessionsForChatBot selectedProfession)
        {
            string status = "Not solved";
            string descriptionDB = description;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [SupportInquires] (AccountID, InquiryType, Description, DateOfSubmission, Status)
                        VALUES (@AccountID, @InquiryType, @Description, @DateOfSubmission, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", loggedInAccount.ID);
                    command.Parameters.AddWithValue("@InquiryType", selectedProfession.ToString());
                    command.Parameters.AddWithValue("@Description", descriptionDB);
                    command.Parameters.AddWithValue("@DateOfSubmission", DateTime.Now);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        //
        //
        //

        //
        //FORM
        //

        //
        //
        //

        //HouseRules

        public string GetHouseRules()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HouseRules FROM HouseRules WHERE ID = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                string houseRules = command.ExecuteScalar() as string;
                return houseRules;
            }
        }

        public bool UpdateHouseRules(string newHouseRules)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE HouseRules SET HouseRules = @HouseRules WHERE ID = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HouseRules", newHouseRules);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        //
        //Expense
        //

        public bool AddExpenseToDB(Expenses expense)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO [ExpenseList] (BuildingID, Date, Quantity, ExtendedPrice)
                                VALUES (@BuildingID, @Date, @Quantity, @ExtendedPrice)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BuildingID", expense.Account.AssignedRoom.AssignedBuilding.ID);
                command.Parameters.AddWithValue("@Date", expense.DateTime);
                command.Parameters.AddWithValue("@Quantity", expense.ParticipantCount);
                command.Parameters.AddWithValue("@ExtendedPrice", expense.ExtendedPrice);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }

        }

        public DataTable GetExpenses()
        {
            DataTable expensesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ExpenseList";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(expensesTable);


                return expensesTable;
            }
        }

        public List<Account> GetTenantsForTheHouse(int buildingID)
        {
            List<Account> tenantNamesForTheHouse = new List<Account>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT a.*
                                FROM [Account] a
                                INNER JOIN Room r ON r.ID = a.RoomID
                                WHERE BuildingID = @BuildingID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuildingID", buildingID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //
                        while (reader.Read())
                        {
                            int ID = (int)reader["ID"];
                            string username = (string)reader["UserName"];
                            string email = (string)reader["Email"];
                            string fullName = (string)reader["FullName"];
                            DateTime dateOfBirth = (DateTime)reader["DateOfBirth"];
                            string contactInformation = (string)reader["ContactInformation"];
                            string role = (string)reader["Role"];

                            Account account = new Account(username, email, contactInformation, fullName, dateOfBirth, role, null, ID, null);
                            tenantNamesForTheHouse.Add(account);
                        }
                    }
                }
            }

            return tenantNamesForTheHouse;
        }

        //
        // UCDays
        //
        public void GetEventInfo(DateTime selectedDate, Account loggedInAccount)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
        SELECT Name, Description
        FROM UserActions
        WHERE Date = @date AND AccountID = @accountId;
    ", connection))
            {
                command.Parameters.AddWithValue("@date", selectedDate);
                command.Parameters.AddWithValue("@accountId", loggedInAccount.ID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        StringBuilder eventInfo = new StringBuilder();
                        eventInfo.AppendLine($"Date: {selectedDate.ToShortDateString()}");
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string description = reader["Description"].ToString();
                            eventInfo.AppendLine($"Name: {name}");
                            eventInfo.AppendLine($"Description: {description}");
                            eventInfo.AppendLine();
                        }

                        MessageBox.Show(eventInfo.ToString(), "Event Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No events on this day.", "Event Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //
        //Event
        //

        public List<string> GetUserEventsForToday(Account loggedInAccount)
        {
            DateTime today = DateTime.Today;
            List<string> userActionsForToday = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
        SELECT Name, Description
        FROM UserActions
        WHERE Date = @date AND AccountID = @accountId;
    ", connection))
            {
                command.Parameters.AddWithValue("@date", today);
                command.Parameters.AddWithValue("@accountId", loggedInAccount.ID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        string userAction = $"Today you have: {name}; Description: {description}";
                        userActionsForToday.Add(userAction);
                    }
                }
            }
            return userActionsForToday;
        }

        public List<string> GetSelectedDatesForPaint(DateTime date, List<string> eventDateList, Account loggedInAccount)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                SELECT Type, Date
                FROM UserActions
                WHERE Type = 'Event' AND AccountID = @accountID OR Type = 'Chore' AND AccountID = @accountId OR Type = 'Agreement';
            ", connection))
            {
                command.Parameters.AddWithValue("@accountId", loggedInAccount.ID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eventType = reader["Type"].ToString();
                        string eventDate = Convert.ToDateTime(reader["Date"]).ToString();

                        eventDateList.Add(eventType + "|" + eventDate);
                    }
                }
            }
            return eventDateList;
        }

        public bool CreateEvent(DateTime date, string name, string description, string type, int? AccountID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a new UserAction object with the retrieved AccountID
                UserAction userAction = new UserAction(date, name, description, type, AccountID);

                // Insert the UserAction into the database table
                string query = "INSERT INTO UserActions (AccountID, Date, Name, Description, Type) VALUES (@accountId, @date, @name, @description, @type)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountId", userAction.AccountID);
                command.Parameters.AddWithValue("@date", userAction.Date);
                command.Parameters.AddWithValue("@name", userAction.Name);
                command.Parameters.AddWithValue("@description", userAction.Description);
                command.Parameters.AddWithValue("@type", userAction.Type);

                int affectedRows = command.ExecuteNonQuery();
                connection.Close();
                return affectedRows > 0;
            }
        }

        public bool CreateComplaint(int? loggedInAccountID, string title, string content, DateTime date)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string complaintQuery = @"INSERT INTO [UserActions] (AccountID, Date, Time, Name, Description, Type)
                    VALUES (@AccountID, @Date, @Time, @Name, @Description, @Type)";
                    //Inputting the values in the database
                    using (SqlCommand command = new SqlCommand(complaintQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", loggedInAccountID);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Time", date);
                        command.Parameters.AddWithValue("@Name", title);
                        command.Parameters.AddWithValue("@Description", content);
                        command.Parameters.AddWithValue("@Type", "Complaint");

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    return true;
                }
            }
            return false;
        }

        public bool CreateAgreement(int? loggedInAccountID)
        {
            AgreementCreator agreement = new AgreementCreator();
            DialogResult dialogResult = agreement.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string title;
                string content;
                DateTime dateOfProposal;
                //getting the variables out of the pop-up
                agreement.GetAgreementInformation(out title, out content, out dateOfProposal);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string agreementQuery = @"INSERT INTO [UserActions] (AccountID, Date, Time, Name, Description, Type)
                    VALUES (@AccountID, @Date, @Time, @Name, @Description, @Type)";

                    using (SqlCommand command = new SqlCommand(agreementQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountID", loggedInAccountID);
                        command.Parameters.AddWithValue("@Date", dateOfProposal);
                        command.Parameters.AddWithValue("@Time", dateOfProposal);
                        command.Parameters.AddWithValue("@Name", title);
                        command.Parameters.AddWithValue("@Description", content);
                        command.Parameters.AddWithValue("@Type", "Agreement");

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    return true;
                }
            }
            return false;
        }

        public List<UserAction> GetAgreements()
        {
            string selectAgreements = "SELECT u.Name, u.Description, u.Date, a.FullName\r\nFROM UserActions AS u\r\nINNER JOIN Account AS a ON u.AccountID = a.ID\r\nWHERE u.Type = 'Agreement';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<UserAction> agreements = new List<UserAction>();
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectAgreements, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string proposedBy = reader.GetString(reader.GetOrdinal("FullName"));
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        string description = reader.GetString(reader.GetOrdinal("Description"));
                        DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));
                        //Get the data from the columns in a different variable per row

                        //DateTime date = datestring.Date;



                        //Put everything inside a constructor
                        UserAction agreement = new UserAction(date, name, description, proposedBy);
                        agreements.Add(agreement);

                    }

                    reader.Close();

                }

                connection.Close();
                return agreements;

            }
        }

        public List<UserAction> PopulateComplaints()
        {
            string selectComplaints = "SELECT * FROM UserActions WHERE Type = 'Complaint'";

            //List of userActions to store our Complaints
            List<UserAction> userActions = new List<UserAction>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectComplaints, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    //Read the data
                    while (reader.Read())
                    {
                        //We are getting each separate column in a separate variable
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        string description = reader.GetString(reader.GetOrdinal("Description"));
                        DateTime date = reader.GetDateTime(reader.GetOrdinal("Date"));

                        //Using the constructor with extracted data 
                        UserAction userAction = new UserAction(date, name, description);
                        //Adding to list of objects
                        userActions.Add(userAction);
                    }

                    reader.Close();
                }

                connection.Close();
                return userActions;
            }

        }
    }
}
