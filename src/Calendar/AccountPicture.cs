using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class AccountPicture
    {
        public int ID { get; set; }
        public string PicturePath { get; set; }
        
        public AccountPicture(int id,  string picturePath)
        {
            ID = id;
            PicturePath = picturePath;
        }
    }
}
