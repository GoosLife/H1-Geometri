using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    internal class RightAngledTriangle : Shape
    {
        private double sideB;

        public RightAngledTriangle(double a, double b) : base(a)
        {
            sideB = b;
        }

        public override double Area()
        {
            return 0.5 * sideA * sideB;
        }

        public override double Perimeter()
        {
            double c = FindC();
            return sideA + sideB + c;
        }

        private double FindC()
        {
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
    }
}
