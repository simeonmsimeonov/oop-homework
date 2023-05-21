using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class footballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public footballPlayer(string name, int number, int age, double height):base(name, age)
        {
           
            Number = number;
            
            Height = height;
        }
    }
}
