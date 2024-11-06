namespace AdapterPattern;

public interface IBaseAnalogClock
{
    /// <summary>
    /// Устанавливает текущую дату
    /// </summary>
    /// <param name="year">Год</param>
    /// <param name="month">Месяц</param>
    /// <param name="day">День</param>
    /// <param name="hourAngle">Угол стрелки часов</param>
    /// <param name="minuteAngle">Угол минутной стрелки</param>
    /// <param name="secondAngle">Угол секундной стрелки</param>
    /// <param name="dayNightDivision">Текущее время суток (день / ночь)</param>
    void SetDateTime(int year, int month, int day, float hourAngle, float minuteAngle, float secondAngle, DayNightDivision dayNightDivision);
}
