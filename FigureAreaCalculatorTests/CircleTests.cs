using NUnit.Framework;
using System;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5)]
        public void GetAreaTest_ShouldReturnTrue(double radius)
        {
            // arrange
            var expectedSquare = Math.PI * radius * radius;
            var circle = new Circle(radius);

            // act
            var result = circle.GetArea();

            // assert
            Assert.AreEqual(expectedSquare, result);
        }

        [TestCase(5)]
        public void GetAreaTest_ShouldReturnFalse(double radius)
        {
            // arrange
            var expectedSquare = 70;
            var circle = new Circle(radius);

            // act
            var result = circle.GetArea();

            // assert
            Assert.AreNotEqual(expectedSquare, result);
        }
    }
}