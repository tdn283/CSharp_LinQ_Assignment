﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
