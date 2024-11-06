
namespace AdapterPattern.Tests
{
    public class DateConverterTests
    {
        [Fact]
        public void ConvertAnglesToTime_ValidAngles_ReturnsCorrectTime()
        {
            float hourAngle = 90f; // 3 hours
            float minuteAngle = 180f; // 30 minutes
            float secondAngle = 270f; // 45 seconds

            var result = DateConverter.ConvertAnglesToTime(hourAngle, minuteAngle, secondAngle);

            Assert.Equal(3, result.hours);
            Assert.Equal(30, result.minutes);
            Assert.Equal(45, result.seconds);
        }

        [Fact]
        public void ConvertTimeToAngles_ValidTime_ReturnsCorrectAngles()
        {
            var date = new DateTime(2024, 1, 1, 15, 30, 45); // 3:30:45 PM

            var result = DateConverter.ConvertTimeToAngles(date);

            Assert.Equal(90f, result.hourAngle);
            Assert.Equal(180f, result.minuteAngle);
            Assert.Equal(270f, result.secondAngle);
        }

        [Theory]
        [InlineData(10, DayNightDivision.AM)]
        [InlineData(0, DayNightDivision.AM)]
        [InlineData(11, DayNightDivision.AM)]
        [InlineData(12, DayNightDivision.PM)]
        [InlineData(23, DayNightDivision.PM)]
        public void CalculateDayNightDivision_ValidHour_ReturnsCorrectDivision(int hour, DayNightDivision expected)
        {
            var result = DateConverter.CalculateDayNightDivision(hour);

            Assert.Equal(expected, result);
        }
    }
}