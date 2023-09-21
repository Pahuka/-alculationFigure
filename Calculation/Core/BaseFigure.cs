using Calculation.Interfaces;

namespace Calculation.Core;

public abstract class BaseFigure
{
	public double GetArea(IVisitor visitor)
	{
		return visitor.CalculateArea((dynamic)this);
	}
}