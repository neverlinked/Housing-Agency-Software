using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class CalendarManager
    {
        private int month;
        private int year;

        public int CurrentMonth
        {
            get { return month; }
        }

        public int CurrentYear
        {
            get { return year; }
        }

        public void SetCurrentDate(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public void MoveToNextMonth()
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
        }

        public void MoveToPreviousMonth()
        {
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
        }

        public string GetFormattedDate()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            return monthName + " " + year;
        }

        // sets the first day of the week
        public int GetStartOfWeekDay()
        {
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int dayOfWeek = (int)startOfTheMonth.DayOfWeek;
            if (dayOfWeek == 0)
            {
                dayOfWeek = 6;
            }
            else
            {
                dayOfWeek--;
            }

            return dayOfWeek;
        }

        public int GetDaysInMonth()
        {
            return DateTime.DaysInMonth(year, month);
        }

        public int GetMonth()
        {
            return month;
        }
    }
}
