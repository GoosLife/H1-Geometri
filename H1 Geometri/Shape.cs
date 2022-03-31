using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Geometri
{
    abstract class Shape
    {
        protected double sideA;

        public Shape(double a)
        {
            sideA = a;
        }

        public abstract double Perimeter();
        public abstract double Area();

        public override string ToString()
        {
            double area = Area();
            double perimeter = Perimeter();

            return GetType().Name + "\nArea: " + area + "\nPerimeter: " + perimeter + "\n";
        }
    }
}
