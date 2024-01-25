using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SqlMoney Price { get; set; }

        public Item(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
