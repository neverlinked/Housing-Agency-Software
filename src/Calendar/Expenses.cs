using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Expenses
    {
        public int? ID { get; set; } 
        public int ExtendedPrice { get; set; }
        public int ParticipantCount { get; set; }
        public Account Account { get; set; } 
        public DateTime DateTime { get; set; }
        

        public Expenses(int extendedPrice, int participantCount, Account account, int? id = null)
        {
            ID = id; 
            ExtendedPrice = extendedPrice;
            ParticipantCount = participantCount;
            Account = account;
            DateTime = DateTime.Now;
        }

        
    }
}
