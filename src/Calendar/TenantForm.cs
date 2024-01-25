using System;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Calendar
{
    public partial class TenantForm : Form
    {
        bool sidebarExpand = true;
        private CalendarManager calendarManager;
        private Account loggedInAccount;
        private List<string> eventDateList;

        DataBase dataBase = new DataBase();

        public TenantForm(Account loggedInAccount)
        {
            InitializeComponent();
            this.Text = "Tenant Form. Active user - " + loggedInAccount.Username;
            this.loggedInAccount = loggedInAccount;
            calendarManager = new CalendarManager();
            eventDateList = new List<string>();
            PopulateTodayEvents();
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            calendarManager.SetCurrentDate(now.Month, now.Year);

            // Update YEAR MONTH label
            labelDate.Text = calendarManager.GetFormattedDate();

            // Add blank days
            int dayOfWeek = calendarManager.GetStartOfWeekDay();
            AddBlankDays(dayOfWeek);

            // Populate calendar with UserControlDays when Form is loaded
            int daysInMonth = calendarManager.GetDaysInMonth();
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucdays = new UserControlDays(i, now.Month, loggedInAccount); // Pass the day and month values
                ucdays.SetDay(i);
                dayLayout.Controls.Add(ucdays);
            }

            // Get selected dates from the database
            PaintLabels(now);
        }

        private void PopulateTodayEvents()
        {
            List<string> todayEvents = dataBase.GetUserEventsForToday(loggedInAccount);


            if (todayEvents.Count > 0)
            {
                textBoxUserActions.ReadOnly = true;
                textBoxUserActions.Text = string.Join("| also ", todayEvents);
            }
            else
            {
                textBoxUserActions.ReadOnly = true;
                textBoxUserActions.Text = "No events for today.";
            }
        }

        private void PaintLabels(DateTime date)
        {
            eventDateList = dataBase.GetSelectedDatesForPaint(date, eventDateList, loggedInAccount);
            UpdateDayAppearances(eventDateList);
        }
        public void UpdateDayAppearances(List<string> eventDateList)
        {
            foreach (UserControlDays dayControl in dayLayout.Controls.OfType<UserControlDays>())
            {
                int day = Convert.ToInt32(dayControl.GetDay());
                int month = Convert.ToInt32(dayControl.GetMonth());

                foreach (var date in eventDateList)
                {
                    string[] dateParts = date.Split('|');
                    string eventType = dateParts[0];
                    string eventDate = dateParts[1];

                    string[] eventDateParts = eventDate.Split('/');
                    int monthPart = Convert.ToInt32(eventDateParts[1]);
                    int dayPart = Convert.ToInt32(eventDateParts[0]);

                    if (dayPart == day && monthPart == month)
                    {
                        if (eventType == "Event")
                        {
                            dayControl.SetLabelColor(Color.Navy);
                        }
                        else if (eventType == "Chore")
                        {
                            dayControl.SetLabelColor(Color.Green);
                        }
                    }
                }
            }
        }

        public List<string> GetEventDateList()
        {
            return eventDateList;
        }

        //adds blanks ONLY at the first week of the month
        private void AddBlankDays(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayLayout.Controls.Add(ucblank);
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            dayLayout.Controls.Clear();
            calendarManager.MoveToNextMonth();

            labelDate.Text = calendarManager.GetFormattedDate();

            int dayOfWeek = calendarManager.GetStartOfWeekDay();
            AddBlankDays(dayOfWeek);

            int daysInMonth = calendarManager.GetDaysInMonth();
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucdays = new UserControlDays(i, calendarManager.GetMonth(), loggedInAccount);
                ucdays.SetDay(i); // Set the day value
                dayLayout.Controls.Add(ucdays);
            }
            PaintLabels(DateTime.Now);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            dayLayout.Controls.Clear();
            calendarManager.MoveToPreviousMonth();

            labelDate.Text = calendarManager.GetFormattedDate();

            int dayOfWeek = calendarManager.GetStartOfWeekDay();
            AddBlankDays(dayOfWeek);

            int daysInMonth = calendarManager.GetDaysInMonth();
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucdays = new UserControlDays(i, calendarManager.CurrentMonth, loggedInAccount);
                ucdays.SetDay(i);
                dayLayout.Controls.Add(ucdays);
            }
            PaintLabels(DateTime.Now);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm myProfile = new MyProfileForm(loggedInAccount);
            myProfile.ShowDialog();
        }

        private void eventFormOpenButton_Click(object sender, EventArgs e)
        {
            EventCreator childForm = new EventCreator(loggedInAccount);
            childForm.ShowDialog();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            SupportForm supportForm = new SupportForm(loggedInAccount);
            supportForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Log out the user
            loggedInAccount = null;

            // Close the TenantForm
            Close();

            // Start a new instance of the application with the LoginForm as the main form
            Application.Restart();
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            CreateComplaint();
        }
        //Show the Agreements form
        private void btnAgreements_Click(object sender, EventArgs e)
        {
            ViewAgreements newAgreement = new ViewAgreements(loggedInAccount);
            DialogResult dialogResult = newAgreement.ShowDialog();
        }
        //Method where we create the complaint
        private void CreateComplaint()
        {
            ComplaintCreator newComplaint = new ComplaintCreator(loggedInAccount);
            DialogResult dialogResult = newComplaint.ShowDialog();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and Maximum size of sidebar Panel

            if (sidebarExpand)
            {
                //If sidebar expand, minimize
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
                else
                {
                    sidebarContainer.Width += 10;
                    if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                    {
                        sidebarExpand = false;
                        sidebarTimer.Stop();
                    }
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            HouseRules childForm = new HouseRules();
            childForm.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ExpensesForm expensesForm = new ExpensesForm(loggedInAccount);
            expensesForm.ShowDialog();
        }
    }
}