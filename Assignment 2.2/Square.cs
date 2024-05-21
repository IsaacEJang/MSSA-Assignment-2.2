using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    /*Inherit square class from shape and add change the 
     * calculate area logic. Add property like side of square.*/
    internal class Square : Shape
    {
        public int Side { get; set; }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
