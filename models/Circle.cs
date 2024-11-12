using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1practice
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public override double CalculateArea()
        {            
            return Math.PI * radius * radius;            
        }
    }
}
