using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest;

[TestFixture]
public class MathTests
{
    private Math _math;

    [SetUp]
    public void SetUp()
    {
        _math = new Math();
    }

    [Test]
    public void Add_WhenCalled_SummingTwoIntegerValue()
    {
        var result = _math.Add(1, 2);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(1, 2, 2)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnGreaterParameter(int a, int b, int expected)
    {
        var result = _math.Max(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetOddNumbers_LimitGreaterThanZero_CountNumberOffOddNumberUntilLimit()
    {
        var result = _math.GetOddNumbers(5);

        Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
    }
    
    [Test]
    public void GetOddNumbers_LimitEqualToZero_ReturnZero()
    {
        var result = _math.GetOddNumbers(0);

        Assert.That(result.Count(), Is.EqualTo(0));
    }

        [Test]
    public void GetOddNumbers_LimitLesserThanZero_ReturnZero()
    {
        var result = _math.GetOddNumbers(-1);

        Assert.That(result.Count(), Is.EqualTo(0));
    }
}
 