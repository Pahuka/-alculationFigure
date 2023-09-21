using Calculation;

namespace CalculationTests;

public class Tests
{
	[Test]
	public void CircleNegativeRadius()
	{
		Assert.Throws<ArgumentException>(() => { AreaMath.CreateCircle(-3); });
	}

	[Test]
	public void CircleAreaCalculation()
	{
		var circle = AreaMath.CreateCircle(5);
		var actual = Math.Round(AreaMath.GetArea(circle), 1);
		var expected = 78.5;

		Assert.AreEqual(expected, actual);
	}

	[Test]
	public void TriangleAreaCalculation()
	{
		var triangle = AreaMath.CreateTriangle(5, 4, 6);
		var actual = Math.Round(AreaMath.GetArea(triangle), 1);
		var expected = 9.9d;

		Assert.AreEqual(expected, actual);
	}

	[Test]
	public void IsRightTriangle()
	{
		var triangle = AreaMath.CreateTriangle(6, 8, 10);
		var actual = triangle.IsRight();

		Assert.IsTrue(actual);
	}

	[Test]
	public void TriangleNotExistException()
	{
		Assert.Throws<ArgumentException>(() => { AreaMath.CreateTriangle(1, 1, 2); });
	}

	[Test]
	public void TriangleNegativeSideLengthException()
	{
		Assert.Throws<ArgumentException>(() => { AreaMath.CreateTriangle(-4, 1, 2); });
	}
}