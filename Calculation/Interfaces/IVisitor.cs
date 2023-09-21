namespace Calculation.Interfaces;

public interface IVisitor
{
	double CalculateArea(ICircle circle);
	double CalculateArea(ITriangle triangle);
}