using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class UserAction
    {
        public int? AccountID { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string FullName { get; set; }


        public UserAction(DateTime date, string name, string description, string type, int? accountID = null)
        {
            AccountID = accountID;
            Date = date;
            Name = name;
            Description = description;
            Type = type;
        }
        //Constructor for Complaints
        public UserAction(DateTime complaintDate, string complaintTitle, string complaintDescription)
        {
            Date = complaintDate;
            Name = complaintTitle;
            Description = complaintDescription;
        }

        //Constructor for Agreements
        public UserAction(DateTime agreementDate, string AgreementTitle, string AgreementContent, string AgreementFullName)
        {
            Date = agreementDate;
            Name = AgreementTitle;
            Description = AgreementContent;
            FullName = AgreementFullName;

        }
    }

}
