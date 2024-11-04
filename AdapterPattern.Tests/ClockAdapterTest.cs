namespace AdapterPattern.Tests;

public class ClockAdapterTest
{
    [Fact]
    public void SetDateTime_SetsCorrectValuesInAnalogClock()
    {
        var analogClock = new AnalogClock();
        var adapter = new AnalogToDigitalClock(analogClock);

        var dateTime = new DateTime(2025, 11, 4, 10, 30, 15); // November 4, 2025, 10:30:15 AM

        adapter.SetDateTime(dateTime);

        Assert.Equal(2025, analogClock.GetYear());
        Assert.Equal(11, analogClock.GetMonth());
        Assert.Equal(4, analogClock.GetDay());

        Assert.Equal(10 * 30, analogClock.GetHourAngle(), 1); // 10 hours = 300 degrees
        Assert.Equal(30 * 6, analogClock.GetMinuteAngle(), 1); // 30 minutes = 180 degrees
        Assert.Equal(15 * 6, analogClock.GetSecondAngle(), 1); // 15 seconds = 90 degrees
        Assert.Equal(DayNightDivision.AM, analogClock.GetDayNightDivision());
    }

    [Theory]
    [InlineData(15, DayNightDivision.PM)]
    [InlineData(3, DayNightDivision.AM)]
    [InlineData(23, DayNightDivision.PM)]
    public void SetDateTime_CorrectlySetsDayNightDivision(int hour, DayNightDivision expectedDivision)
    {
        var analogClock = new AnalogClock();
        var adapter = new AnalogToDigitalClock(analogClock);
        var dateTime = new DateTime(2023, 11, 4, hour, 0, 0);

        adapter.SetDateTime(dateTime);

        Assert.Equal(expectedDivision, analogClock.GetDayNightDivision());
    }
}