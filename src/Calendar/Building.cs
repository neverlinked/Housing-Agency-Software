﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Building
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public Building(int id, int number, string name)
        {
            ID = id;
            Number = number;
            Name = name;
        }
    }
}
