﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string firstName, string lastName, string address, string city, string country, double salary) : base(firstName, lastName, address, city, country, salary * 0.75)
        {

        }


    }
}
