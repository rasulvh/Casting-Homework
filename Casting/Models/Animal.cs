using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();
    }
}
