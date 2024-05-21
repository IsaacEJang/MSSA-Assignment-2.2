using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    // base class
    internal abstract class Shape
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public abstract double CalculateArea();
    }
}
