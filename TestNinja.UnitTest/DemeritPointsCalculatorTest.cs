using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest;

[TestFixture]
public class DemeritPointsCalculatorTest
{
    private DemeritPointsCalculator _demeritPointsCalculator;

    [SetUp]
    public void SetUp()
    {
        _demeritPointsCalculator = new DemeritPointsCalculator();
    }

    [Test]
    [TestCase(-1)]
    [TestCase(301)]
    public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowOutOfRangeException(int speed)
    {
        //Act & Assert
        Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(64, 0)]
    [TestCase(65, 0)]
    [TestCase(66, 0)]
    [TestCase(70, 1)]
    [TestCase(75, 2)]
    public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoint(int speed, int expectedResult)
    {
        var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
