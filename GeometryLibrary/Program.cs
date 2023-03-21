using System;

namespace GeometryLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            Console.WriteLine("Площадь круга = " + circle.GetArea());

            IShape triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Площадь треугольника = " + triangle.GetArea());
            Console.WriteLine("Прямоугольный треугольник? " + ((Triangle)triangle).IsRightTriangle());
        }
    }
}
