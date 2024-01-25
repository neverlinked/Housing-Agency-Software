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
    public partial class EventCreator : Form
    {
        private Account loggedInAccount;
        public DateTime SelectedDate { get; set; }

        DataBase dataBase = new DataBase();

        public EventCreator(Account loggedInAccount)
        {
            InitializeComponent();
            PopulateCMB();
            this.loggedInAccount = loggedInAccount;
        }

        public void PopulateCMB()
        {
            comboBoxName.Items.Clear();
            comboBoxName.DataSource = Enum.GetValues(typeof(Chores));
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            int? accountID = loggedInAccount.ID;
            DateTime date = dateTimePicker1.Value.Date;
            string name = comboBoxName.Text;
            string description = descriptionBox.Text;
            SelectedDate = date;
            string type;

            if (Enum.IsDefined(typeof(Chores), name))
            {
                type = "Chore";
            }
            else
            {
                type = "Event";
            }

            bool success = dataBase.CreateEvent(date, name, description, type, accountID);
            if (success)
            {
                MessageBox.Show("Event added to calendar successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add event.", "Error");
            }

            TenantForm tenantForm = new TenantForm(loggedInAccount);
            tenantForm.UpdateDayAppearances(tenantForm.GetEventDateList());
        }
    }
}
