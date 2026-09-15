namespace TJC.TimeExtensions.Tests.ElapsedTime;


public class GetElapsedTimeValueExtensionTests
{
    [Fact]
    public void GetElapsedTimeValue_TotalSeconds_ReturnsCorrectValue()
    {
        // Arrange
        var timeSpan = TimeSpan.FromSeconds(12);

        // Act
        var result = timeSpan.GetElapsedTimeValue();

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void GetElapsedTimeValue_TotalMinutes_ReturnsCorrectValue()
    {
        // Arrange
        var timeSpan = TimeSpan.FromMinutes(5);

        // Act
        var result = timeSpan.GetElapsedTimeValue();

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void GetElapsedTimeValue_TotalNanoseconds_ReturnsCorrectValue()
    {
        // Arrange
        var timeSpan = TimeSpan.FromTicks(42);

        // Act
        var result = timeSpan.GetElapsedTimeValue();

        // Assert
        Assert.Equal(4.2, result);
    }
}
