using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Rectangle : GeometricFigures
    {
        public double Base { get; set; }
        public double Height { get; set; }

        //constructor
        public Rectangle(double b, double h)
        {
            this.Base = b;
            this.Height = h;
        }
        public override double Area(double b, double h)
        {
            return b * h;
        }
    }
}
