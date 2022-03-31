using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    internal class Paralellogram : Shape
    {
        private double sideB;
        private double angleV;

        public Paralellogram(double a, double b, double v) : base(a)
        {
            sideB = b;
            angleV = v;
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public override double Area()
        {
            return sideA * sideB * Math.Sin(angleV);
        }

    }
}
