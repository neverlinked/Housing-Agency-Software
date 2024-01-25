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
    public partial class UserControlDays : UserControl
    {
        private string day;
        private string month;
        private Account loggedInAccount;
        
        DataBase dataBase = new DataBase();

        public UserControlDays(int day, int month, Account loggedInAccount)
        {
            InitializeComponent();

            this.day = day.ToString();
            this.month = month.ToString();
            this.loggedInAccount = loggedInAccount;
        }

        public string GetDay()
        {
            return day;
        }

        public string GetMonth()
        {
            return month;
        }

        public void SetDay(int numday)
        {
            labelDays.Text = numday.ToString();
        }

        public void SetLabelColor(Color color)
        {
            labelDays.ForeColor = color;
        }

        private void labelDays_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(DateTime.Now.Year, int.Parse(month), int.Parse(day));
            dataBase.GetEventInfo(selectedDate,loggedInAccount);
        }
    }
}
