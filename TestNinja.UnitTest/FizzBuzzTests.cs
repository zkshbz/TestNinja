using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest;

[TestFixture]
public class FizzBuzzTests
{

    [Test]
    public void GetOutput_WhenNumberDividedThree_ReturnFizzz()
    {
        var result = FizzBuzz.GetOutput(3);

        Assert.That(result, Is.EqualTo("Fizzz"));
    }

    [Test]
    public void GetOutput_WhenNumberDividedFive_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(5);

        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetOutput_WhenNumberDividedFiveAndThree_ReturnFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);

        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void GetOutput_WhenNumberIsNotDividedFiveAndThree_ReturnNumber()
    {
        var result = FizzBuzz.GetOutput(1);

        Assert.That(result, Is.EqualTo("1"));
    }
}
