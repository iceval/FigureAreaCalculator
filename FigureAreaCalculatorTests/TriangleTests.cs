using NUnit.Framework;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3,4,5)]
        public void GetAreaTest_ShouldReturnTrue(double edgeA, double edgeB, double edgeC)
        {
            // arrange
            double expectedSquare = 6;
            var triangle = new Triangle(edgeA, edgeB, edgeC);

            // act
            var result = triangle.GetArea();

            // assert
            Assert.AreEqual(expectedSquare, result);
        }

        [TestCase(3, 4, 5)]
        public void GetAreaTest_ShouldReturnFalse(double edgeA, double edgeB, double edgeC)
        {
            // arrange
            double expectedSquare = 5;
            var triangle = new Triangle(edgeA, edgeB, edgeC);

            // act
            var result = triangle.GetArea();

            // assert
            Assert.AreNotEqual(expectedSquare, result);
        }

        [TestCase(3, 4, 5)]
        public void GetIsStraightTriangleTest_ShouldReturnTrue(double edgeA, double edgeB, double edgeC)
        {
            // arrange
            var triangle = new Triangle(edgeA, edgeB, edgeC);

            // act
            bool result = triangle.GetIsStraightTriangle();
            // assert
            Assert.IsTrue(result);
        }

        [TestCase(5, 5, 5)]
        public void GetIsStraightTriangleTest_ShouldReturnFalse(double edgeA, double edgeB, double edgeC)
        {
            // arrange
            var triangle = new Triangle(edgeA, edgeB, edgeC);

            // act
            bool result = triangle.GetIsStraightTriangle();
            // assert
            Assert.IsFalse(result);
        }
    }
}
