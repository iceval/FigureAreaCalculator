using System;

namespace FigureAreaCalculator.Figures
{
    public class Rectangle : Figure
	{
		private readonly double _edgeA, _edgeB;
		public double EdgeA { get { return _edgeA; } init { _edgeA = value; } }

		public Rectangle(double edgeA, double edgeB)
		{
			GetIsExist(edgeA, edgeB);

			_edgeA = edgeA;
			_edgeB = edgeB;
		}
		public void GetIsExist(double edgeA, double edgeB)
		{
			if (edgeA < 0 || edgeB < 0)
				throw new ArgumentException("Triangle not exist(edge < 0)");
		}

		public override double GetArea()
		{
			return _edgeA * _edgeB;
		}
	}
}
