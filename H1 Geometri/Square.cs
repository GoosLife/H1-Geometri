using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    internal class Square : Shape
    {
        public Square(double a) : base(a)
        {
        }

        public override double Area()
        {
            return sideA * sideA;
        }

        public override double Perimeter()
        {
            return sideA * 4;
        }
    }
}
