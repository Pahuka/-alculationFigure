using Calculation.Interfaces;

namespace Calculation.Core;

internal class VisitorFigure : IVisitor
{
	public double CalculateArea(ICircle circle)
	{
		return Math.PI * Math.Pow(circle.GetRadius(), 2);
	}

	public double CalculateArea(ITriangle triangle)
	{
		var perimeter = triangle.GetSidesLength().Sum() / 2;
		return Math.Sqrt(perimeter *
		                 (perimeter - triangle.GetSidesLength()[0]) *
		                 (perimeter - triangle.GetSidesLength()[1]) *
		                 (perimeter - triangle.GetSidesLength()[2]));
	}
}