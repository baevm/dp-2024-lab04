
namespace AdapterPattern;

/// <summary>
/// Адаптер аналоговых часов к цифровым часам
/// </summary>
public class AnalogToDigitalClock : IBaseDigitalClock
{
    private readonly AnalogClock _analogClock;

    public AnalogToDigitalClock(AnalogClock analogClock)
    {
        _analogClock = analogClock;
    }

    /// <summary>
    /// Получить текущее время
    /// </summary>
    /// <returns></returns>
    public DateTime GetDateTime()
    {
        var year = _analogClock.Year;
        var month = _analogClock.Month;
        var day = _analogClock.Day;

        var hourAngle = _analogClock.HourAngle;
        var minuteAngle = _analogClock.MinuteAngle;
        var secondAngle = _analogClock.SecondAngle;

        var (hours, minutes, seconds) = DateConverter.ConvertAnglesToTime(hourAngle, minuteAngle, secondAngle);

        return new DateTime(year, month, day, hours, minutes, seconds);
    }

    /// <summary>
    /// Устанавливает время на часах
    /// </summary>
    /// <param name="date"></param>
    public void SetDateTime(DateTime date)
    {
        var year = date.Year;
        var month = date.Month;
        var day = date.Day;

        var (hourAngle, minuteAngle, secondAngle) = DateConverter.ConvertTimeToAngles(date);

        DayNightDivision division = DateConverter.CalculateDayNightDivision(date.Hour);

        _analogClock.SetDateTime(year, month, day, hourAngle, minuteAngle, secondAngle, division);
    }
}

