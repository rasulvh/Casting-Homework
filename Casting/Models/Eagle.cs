using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating");
        }
    }
}
