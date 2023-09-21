using Calculation.Core;
using Calculation.Figures;

namespace Calculation;

public static class AreaMath
{
	/// <summary>
	///     Возвращает площадь фигуры.
	/// </summary>
	/// <param name="baseFigure"></param>
	/// <returns></returns>
	public static double GetArea(BaseFigure baseFigure)
	{
		return baseFigure.GetArea(new VisitorFigure());
	}

	/// <summary>
	///     Создать круг.
	/// </summary>
	/// <param name="radius"></param>
	/// <returns></returns>
	public static Circle CreateCircle(double radius)
	{
		return new Circle(radius);
	}

	/// <summary>
	///     Создать треугольник.
	/// </summary>
	/// <param name="sideA"></param>
	/// <param name="sideB"></param>
	/// <param name="sideC"></param>
	/// <returns></returns>
	public static Triangle CreateTriangle(double sideA, double sideB, double sideC)
	{
		return new Triangle(sideA, sideB, sideC);
	}
}