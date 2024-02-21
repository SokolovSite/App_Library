using NUnit.Framework;
using System;
using ClassLibrary;


namespace Tests
{
    [TestFixture]
    public class ShapeTests : LibraryClass
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;
            Assert.(expectedArea, circle.CalculateArea());
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.(expectedArea, triangle.CalculateArea());
        }

        [Test]
        public void RightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightTriangle.IsRightTriangle());
        }

        [Test]
        public void NonExistentTriangleCheck()
        {
            Triangle nonExistentTriangle = new Triangle(1, 2, 7);
            Assert.IsFalse(nonExistentTriangle.IsRightTriangle());
        }

        [Test]
        public void NegativeSideLengthTriangleCheck()
        {
            Triangle negativeSideTriangle = new Triangle(-1, 2, 3);
            Assert.IsFalse(negativeSideTriangle.IsRightTriangle());
        }
    }
}