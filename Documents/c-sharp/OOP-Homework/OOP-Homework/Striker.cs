﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
     class Striker : footballPlayer 
    {
        public Striker(string name, int number, int age, double height)
        : base(name, number, age, height)
        {
        }
    }
}
