using System;

namespace FigureAreaCalculator.Figures
{
    public class Triangle : Figure
	{
		private readonly double _edgeA, _edgeB, _edgeC;

		public Triangle(double edgeA, double edgeB, double edgeC)
		{
			GetIsExist(edgeA, edgeB, edgeC);
			
			_edgeA = edgeA;
			_edgeB = edgeB;
			_edgeC = edgeC;
		}
		private void GetIsExist(double edgeA, double edgeB, double edgeC)
		{
			if (edgeA < 0 || edgeB < 0 || edgeC < 0)
				throw new ArgumentException("Triangle not exist(edge < 0)");

			if (edgeA > (edgeB + edgeC) || edgeB > (edgeA + edgeC) || edgeC > (edgeA + edgeB))
				throw new ArgumentException("Triangle not exist(edge_1 > (edge_2 + edge_3)");
		}

		public override double GetArea()
		{
			var halfPerimeter = (_edgeA + _edgeB + _edgeC) / 2;

			return Math.Sqrt(halfPerimeter * (halfPerimeter - _edgeA) * (halfPerimeter - _edgeB) * (halfPerimeter - _edgeC));
		}

		public bool GetIsStraightTriangle()
		{
			bool isStraight = (_edgeA == Math.Sqrt(_edgeB * _edgeB + _edgeC * _edgeC)
							   || _edgeB == Math.Sqrt(_edgeA * _edgeA + _edgeC * _edgeC)
							   || _edgeC == Math.Sqrt(_edgeA * _edgeA + _edgeB * _edgeB));
			return isStraight;
		}
	}
}
