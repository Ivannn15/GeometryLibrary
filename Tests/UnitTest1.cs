using System;
using Xunit;
using namespace.

namespace Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaTest()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            Assert.AreEqual(Math.PI * radius * radius, circle.GetArea());
        }

        [Test]
        public void TriangleAreaTest()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            double p = (side1 + side2 + side3) / 2;
            double expectedArea = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            Assert.AreEqual(expectedArea, triangle.GetArea());
        }

        [Test]
        public void IsRightTriangleTest()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}
