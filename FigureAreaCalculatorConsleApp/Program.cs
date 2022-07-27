using System;
using System.Collections.Generic;
using FigureAreaCalculator;
using FigureAreaCalculator.Figures;

namespace FigureSquareConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var param = new Dictionary<string, double>()
            {
            {Parameters.Radius, 5},
            };
            Figure figure = FigureCreator.Create(param);

            Console.WriteLine("Circle area = " + figure.GetArea());

            var param2 = new Dictionary<string, double>()
            {
            { Parameters.EdgeA, 3},
            { Parameters.EdgeB, 4},
            { Parameters.EdgeC, 5},
            };
            figure = FigureCreator.Create(param2);
            Console.WriteLine("Triangle area = " + figure.GetArea());

            Triangle triangle = ((Triangle)figure);
            Console.WriteLine("Triangle is straight = " + triangle.GetIsStraightTriangle());

            var param3 = new Dictionary<string, double>()
            {
            { Parameters.EdgeA, 2},
            };
            figure = FigureCreator.Create(param3);
            Console.WriteLine("Square area = " + figure.GetArea());

            var param4 = new Dictionary<string, double>()
            {
            { Parameters.EdgeA, 2},
            { Parameters.EdgeB, 4},
            };
            figure = FigureCreator.Create(param4);
            Console.WriteLine("Rectangle area = " + figure.GetArea());
        }
    }
}
