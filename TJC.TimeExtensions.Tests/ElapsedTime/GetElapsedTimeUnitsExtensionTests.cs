namespace TJC.TimeExtensions.Tests.ElapsedTime;


public class GetElapsedTimeUnitsExtensionTests
{
    [InlineData(1, "d", false)]
    [InlineData(2, "d", false)]
    [InlineData(1, "day", true)]
    [InlineData(1.5, "days", true)]
    [InlineData(2, "days", true)]
    [InlineData(2.5, "days", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalDays_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromDays(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(1, "h", false)]
    [InlineData(2, "h", false)]
    [InlineData(1, "hour", true)]
    [InlineData(1.5, "hours", true)]
    [InlineData(2, "hours", true)]
    [InlineData(2.5, "hours", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalHours_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromHours(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(1, "m", false)]
    [InlineData(2, "m", false)]
    [InlineData(1, "minute", true)]
    [InlineData(1.5, "minutes", true)]
    [InlineData(2, "minutes", true)]
    [InlineData(2.5, "minutes", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalMinutes_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromMinutes(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(1, "s", false)]
    [InlineData(2, "s", false)]
    [InlineData(1, "second", true)]
    [InlineData(1.5, "seconds", true)]
    [InlineData(2, "seconds", true)]
    [InlineData(2.5, "seconds", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalSeconds_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromSeconds(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(1, "ms", false)]
    [InlineData(2, "ms", false)]
    [InlineData(1, "millisecond", true)]
    [InlineData(1.5, "milliseconds", true)]
    [InlineData(2, "milliseconds", true)]
    [InlineData(2.5, "milliseconds", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalMilliseconds_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromMilliseconds(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(1, "μs", false)]
    [InlineData(2, "μs", false)]
    [InlineData(1, "microsecond", true)]
    [InlineData(1.5, "microseconds", true)]
    [InlineData(2, "microseconds", true)]
    [InlineData(2.5, "microseconds", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalMicroseconds_ReturnsCorrectUnits(
        double number,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromMicroseconds(number);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(0, "ns", false)]
    [InlineData(1, "ns", false)]
    [InlineData(2, "ns", false)]
    [InlineData(0, "nanoseconds", true)]
    [InlineData(1, "nanoseconds", true)] // Note: 1 tick is 100 nanoseconds, so 1 nanosecond is not possible
    [InlineData(2, "nanoseconds", true)]
    [Theory]
    public void GetElapsedTimeUnits_TotalNanoseconds_ReturnsCorrectUnits(
        long ticks,
        string expected,
        bool useLongName
    )
    {
        // Arrange
        var timeSpan = TimeSpan.FromTicks(ticks / 1000);

        // Act
        var result = timeSpan.GetElapsedTimeUnits(useLongName: useLongName).Trim();

        // Assert
        Assert.Equal(expected, result);
    }
}
