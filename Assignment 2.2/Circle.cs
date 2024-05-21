using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    /*Inherit circle shape from base class and
    add properties like radius. override calculate area logic for circle.*/

    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override double CalculateArea()
        {

            // area of circle = raidus ^ 2 * pi
            return Math.PI * Radius * Radius;
        }

    }
}
