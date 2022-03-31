using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    internal class Rectangle : Shape
    {
        private double sideB;

        public Rectangle(double a, double b) : base(a)
        {
            sideB = b;
        }

        public override double Perimeter()
        {
            return sideA * 2 + sideB * 2;
        }

        public override double Area()
        {
            return sideA * sideB;
        }
    }
}
