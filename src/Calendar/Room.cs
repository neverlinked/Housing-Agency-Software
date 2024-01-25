using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }

        public Building AssignedBuilding { get; set; }

        public Room (int iD, int number, string status, Building assignedBuilding)
        {
            ID=iD;
            Number=number;
            Status=status;
            AssignedBuilding=assignedBuilding;
        }
    }
}
