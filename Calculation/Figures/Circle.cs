using Calculation.Core;
using Calculation.Interfaces;

namespace Calculation.Figures;

public class Circle : BaseFigure, ICircle
{
	private readonly double _radius;

	public Circle(double radius)
	{
		if (radius <= 0)
			throw new ArgumentException("Радиус должен быть больше 0.");

		_radius = radius;
	}

	public double GetRadius()
	{
		return _radius;
	}
}