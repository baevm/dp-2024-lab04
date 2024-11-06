namespace AdapterPattern;

/// <summary>
/// Класс аналоговых часов
/// </summary>
public class AnalogClock : IBaseAnalogClock
{
    public int Year { get; private set; }
    public int Month { get; private set; }
    public int Day { get; private set; }
    public float HourAngle { get; private set; }
    public float MinuteAngle { get; private set; }
    public float SecondAngle { get; private set; }
    public DayNightDivision DayNightDivision { get; private set; }

    public AnalogClock()
    {
        Year = 0;
        Month = 0;
        Day = 0;
        HourAngle = 0.0f;
        MinuteAngle = 0.0f;
        SecondAngle = 0.0f;
        DayNightDivision = DayNightDivision.AM;
    }

    /// <summary>
    /// Задает время для часов
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <param name="day"></param>
    /// <param name="hourAngle"></param>
    /// <param name="minuteAngle"></param>
    /// <param name="secondAngle"></param>
    /// <param name="dayNightDivision"></param>
    public void SetDateTime(int year, int month, int day, float hourAngle, float minuteAngle, float secondAngle, DayNightDivision dayNightDivision)
    {
        Year = year;
        Month = month;
        Day = day;
        HourAngle = hourAngle;
        MinuteAngle = minuteAngle;
        SecondAngle = secondAngle;
        DayNightDivision = dayNightDivision;
    }
}
