namespace AdapterPattern;

/// <summary>
/// Хелпер класс для преобразования времени/градусов
/// </summary>
public static class DateConverter
{
    private const int DegreesPerHour = 30;
    private const int DegreesPerMinute = 6;
    private const int HoursInHalfDay = 12;
    private const int StartOfDay = 0;
    private const int Midday = 12;

    /// <summary>
    /// Переводит градусы в время
    /// </summary>
    /// <param name="hourAngle"></param>
    /// <param name="minuteAngle"></param>
    /// <param name="secondAngle"></param>
    public static (int hours, int minutes, int seconds) ConvertAnglesToTime(float hourAngle, float minuteAngle, float secondAngle)
    {
        var hours = (int)hourAngle / DegreesPerHour % HoursInHalfDay;
        var minutes = (int)minuteAngle / DegreesPerMinute;
        var seconds = (int)secondAngle / DegreesPerMinute;

        return (hours, minutes, seconds);
    }

    /// <summary>
    /// Переводит время на часах в градусы
    /// </summary>
    /// <param name="date"></param>
    public static (float hourAngle, float minuteAngle, float secondAngle) ConvertTimeToAngles(DateTime date)
    {
        var hourAngle = date.Hour % HoursInHalfDay * DegreesPerHour;
        var minuteAngle = date.Minute * DegreesPerMinute;
        var secondAngle = date.Second * DegreesPerMinute;

        return (hourAngle, minuteAngle, secondAngle);
    }

    /// <summary>
    /// Расчитывает DayNightDivision из часов 
    /// </summary>
    /// <param name="hour"></param>
    /// <returns></returns>
    public static DayNightDivision CalculateDayNightDivision(int hour)
    {
        return hour >= StartOfDay && hour < Midday ? DayNightDivision.AM : DayNightDivision.PM;
    }
}