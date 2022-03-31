using System;

namespace H1_Geometri
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Rectangle r = new Rectangle(4, 8);
            Trapez t = new Trapez(10,9,8);
            Paralellogram p = new Paralellogram(3, 5, 20);
            RightAngledTriangle tri = new RightAngledTriangle(4, 8);
            Square s = new Square(4);

            shapes.Add(r);
            shapes.Add(t);
            shapes.Add(p);
            shapes.Add(tri);
            shapes.Add(s);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.ReadKey();
        }
    }
}