
namespace AdapterPattern;

public class AnalogToDigitalClock : IBaseDigitalClock
{
    private readonly AnalogClock _analogClock;

    public AnalogToDigitalClock(AnalogClock analogClock)
    {
        _analogClock = analogClock;
    }

    public DateTime GetDateTime()
    {
        var year = _analogClock.Year;
        var month = _analogClock.Month;
        var day = _analogClock.Day;

        var hourAngle = _analogClock.HourAngle;
        var minuteAngle = _analogClock.MinuteAngle;
        var secondAngle = _analogClock.SecondAngle;

        ConvertAnglesToTime(hourAngle, minuteAngle, secondAngle, out int hours, out int minutes, out int seconds);

        return new DateTime(year, month, day, hours, minutes, seconds);
    }

    public void SetDateTime(DateTime date)
    {
        var year = date.Year;
        var month = date.Month;
        var day = date.Day;

        ConvertTimeToAngles(date, out float hourAngle, out float minuteAngle, out float secondAngle);

        DayNightDivision division = CalculateDayNightDivision(date.Hour);

        _analogClock.SetDateTime(year, month, day, hourAngle, minuteAngle, secondAngle, division);
    }

    /// <summary>
    /// Переводит время на часах в градусы
    /// </summary>
    /// <param name="date"></param>
    /// <param name="hourAngle"></param>
    /// <param name="minuteAngle"></param>
    /// <param name="secondAngle"></param>
    private void ConvertTimeToAngles(DateTime date, out float hourAngle, out float minuteAngle, out float secondAngle)
    {
        hourAngle = date.Hour % 12 * 30f;
        minuteAngle = date.Minute * 6f;
        secondAngle = date.Second * 6f;
    }


    /// <summary>
    /// Переводит градусы в время
    /// </summary>
    /// <param name="hourAngle"></param>
    /// <param name="minuteAngle"></param>
    /// <param name="secondAngle"></param>
    /// <param name="hours"></param>
    /// <param name="minutes"></param>
    /// <param name="seconds"></param>
    private void ConvertAnglesToTime(float hourAngle, float minuteAngle, float secondAngle, out int hours, out int minutes, out int seconds)
    {
        hours = (int)hourAngle / 30 % 12;
        minutes = (int)minuteAngle / 6;
        seconds = (int)secondAngle / 6;
    }


    /// <summary>
    /// Расчитывает DayNightDivision из часов 
    /// </summary>
    /// <param name="hour"></param>
    /// <returns></returns>
    private DayNightDivision CalculateDayNightDivision(int hour)
    {
        return hour >= 0 && hour < 12 ? DayNightDivision.AM : DayNightDivision.PM;
    }
}