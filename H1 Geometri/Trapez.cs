using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    internal class Trapez : Shape
    {
        private double sideB;
        private double sideC;
        private double sideD;

        /// <summary>
        /// Create a trapez.
        /// </summary>
        /// <param name="a">The longest side of the trapez.</param>
        /// <param name="b">The two parallel sides of the trapez.</param>
        /// <param name="c">The shortest side of the trapez.</param>
        public Trapez(double a, double b, double c) : base(a)
        {
            if (a < c)
            {
                sideC = a;
                sideA = c;
            }
            else
            {
                sideC = c;
            }

            sideB = b;
            sideD = b; // Two of the sides must be parallel
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC + sideD;
        }

        public override double Area()
        {
            double s = FindS();
            double h = FindH(s);

            return 0.5 * (sideA + sideC) * h;
        }

        private double FindS()
        {
            return (sideA + sideB - sideC + sideD) / 2;
        }

        private double FindH(double s)
        {
            return (2 / (sideA - sideC)) * (Math.Sqrt(s * (s - sideA + sideC) * (s - sideB) * (s - sideD)));
        }
    }
}
