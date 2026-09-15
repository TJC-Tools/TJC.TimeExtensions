namespace TJC.TimeExtensions.Tests.ElapsedTime;

public class GetElapsedTimeExtensionTests
{
    [Fact]
    public void GetElapsedTime_TotalMinutes_ReturnsCorrectElapsedTime()
    {
        // Arrange
        TimeSpan timeSpan = TimeSpan.FromMinutes(5);

        // Act
        string result = timeSpan.GetElapsedTime();

        // Assert
        Assert.Equal("5.00m", result);
    }

    [Fact]
    public void GetElapsedTime_TotalMinutes_LongName_ReturnsCorrectElapsedTime()
    {
        // Arrange
        TimeSpan timeSpan = TimeSpan.FromMinutes(5);

        // Act
        string result = timeSpan.GetElapsedTime(useLongName: true);

        // Assert
        Assert.Equal("5.00 minutes", result);
    }

    [Fact]
    public void GetElapsedTime_TotalMinutes_SigFigs0_LongName_ReturnsCorrectElapsedTime()
    {
        // Arrange
        TimeSpan timeSpan = TimeSpan.FromMinutes(5);

        // Act
        string result = timeSpan.GetElapsedTime(useLongName: true, significantFigures: 0);

        // Assert
        Assert.Equal("5 minutes", result);
    }

    [Fact]
    public void GetElapsedTime_NanosecondsWithoutDecimals_ReturnsWholeNanoseconds()
    {
        var timeSpan = TimeSpan.FromTicks(1);

        var result = timeSpan.GetElapsedTime();

        Assert.Equal("100ns", result);
    }
}
