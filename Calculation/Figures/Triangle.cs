using Calculation.Core;
using Calculation.Interfaces;

namespace Calculation.Figures;

public class Triangle : BaseFigure, ITriangle
{
	private readonly double _sideA;
	private readonly double _sideB;
	private readonly double _sideC;

	public Triangle(double sideA, double sideB, double sideC)
	{
		if (sideA <= 0 || sideB <= 0 || sideC <= 0)
			throw new ArgumentException("Все стороны треугольника болжны быть больше 0.");

		if (!IsExist(sideA, sideB, sideC))
			throw new ArgumentException("Треугольник с указанными сторонами не может существовать.");

		_sideA = sideA;
		_sideB = sideB;
		_sideC = sideC;
	}

	public double[] GetSidesLength()
	{
		return new[] { _sideA, _sideB, _sideC };
	}

	public bool IsRight()
	{
		var firstLegSqr = Math.Pow(_sideA, 2);
		var secondLegSqr = Math.Pow(_sideB, 2);
		var hypotenuseSqr = Math.Pow(_sideC, 2);

		return hypotenuseSqr == firstLegSqr + secondLegSqr;
	}

	private bool IsExist(double sideA, double sideB, double sideC)
	{
		return sideA + sideB > sideC &&
		       sideA + sideC > sideB &&
		       sideB + sideC > sideA;
	}
}