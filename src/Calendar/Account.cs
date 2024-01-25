using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Account
    {
        public int? ID { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }    
        public string Email { get; set; }   
        public string? FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ContactInformation { get; set; }
        public string? Role { get; set; }
        public Room? AssignedRoom { get; set; }
        public AccountPicture Picture { get; set; }

        public Account(string username, string email, string contactInformation, string? fullName = null, DateTime? dateOfBirth = null, string? role = null, Room? assignedRoom = null, int? ID = null, string? password = null)
        {
            this.ID=ID;
            Username=username;
            Password=password;
            Email=email;
            FullName=fullName;
            DateOfBirth=dateOfBirth;
            ContactInformation=contactInformation;
            Role=role;
            AssignedRoom = assignedRoom;        
        }
    }
}
