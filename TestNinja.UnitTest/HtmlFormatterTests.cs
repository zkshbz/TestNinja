using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest;

[TestFixture]
public class HtmlFormatterTests
{
    [Test]
    public void FormatAsBold_WhenCallled_ShouldEnclosedTheStringWithStronElement()
    {
        //Arrange
        var formatter = new HtmlFormatter();

        //Act
        var result = formatter.FormatAsBold("abc");

        //Assert 

        //Specific
        Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

        //General
        Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
        Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        Assert.That(result, Does.Contain("abc").IgnoreCase);


    }

}