using Xunit;

namespace Sandbox.Tests;

public class SandcastleTests
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(5, false)]
    public void NumberOfTowers_ShouldReturn_ExpectedNumber(int expectedNumberOfTowers, bool expected)
    {
        //Arrange
        Tower[] towers = new Tower[]
        {
            new Tower(),
            new Tower(),
            new Tower(),
        };

        Sandcastle sandcastle = new(towers);

        //Act
        bool actual = expectedNumberOfTowers == sandcastle.NumberOfTowers;

        //Assert
        Assert.Equal(actual, expected);
    }
}