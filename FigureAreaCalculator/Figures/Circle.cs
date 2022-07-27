using System;

namespace FigureAreaCalculator.Figures
{
	public class Circle : Figure
	{
		private readonly double _radius;

		public Circle(double radius)
		{
			GetIsExist(radius);
			_radius = radius;
		}
		private void GetIsExist(double radius)
		{
			if (radius < 0)
				throw new ArgumentException("Circle not exist(radius < 0)");
		}

		public override double GetArea()
		{
			return Math.PI * _radius * _radius;
		}

    }
}