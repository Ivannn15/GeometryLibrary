using System;

namespace GeometryLibrary
{
    internal class Library
    {
        // Объявляем интерфейс IShape, определяющий метод GetArea(), который должны реализовывать все фигуры для вычисления площади
        public interface IShape
        {
            public double GetArea();
        }

        // Определяем класс Circle, который реализует интерфейс IShape
        public class Circle : IShape
        {
            private double Radius;

            public Circle(double radius)
            {
                Radius = radius; // Присваиваем значение радиуса при создании объекта класса Circle
            }

            // Реализация метода GetArea() для круга
            public double GetArea()
            {
                return Math.PI * Radius * Radius; // Формула вычисления площади круга
            }
        }

        public class Triangle : IShape
        {
            private double Side1; // Длина первой стороны треугольника
            private double Side2;
            private double Side3;

            public Triangle(double side1, double side2, double side3)
            {
                Side1 = side1;  // Присваиваем значение первой стороны при создании объекта класса Triangle
                Side2 = side2;
                Side3 = side3;
            }

            // Реализация метода GetArea() для треугольника
            public double GetArea()
            {
                double p = (Side1 + Side2 + Side3) / 2; // Полупериметр треугольника
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)); // Формула вычисления площади треугольника
            }

            // Метод для определения, является ли треугольник прямоугольным
            public bool IsRightTriangle()
            {
                double[] sides = new double[] { Side1, Side2, Side3 }; // Создаем массив сторон треугольника
                Array.Sort(sides); // Сортируем стороны по возрастанию
                return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2); // Проверяем, удовлетворяет ли треугольник теореме Пифагора
            }
        }
    }
}
