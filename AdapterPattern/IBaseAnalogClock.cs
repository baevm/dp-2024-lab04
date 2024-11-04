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

    /// <summary>
    /// Возвращает текущий угол стрелки часов
    /// </summary>
    /// <returns>Угол стрелки часов</returns>
    float GetHourAngle();

    /// <summary>
    /// Возвращает текущий угол минутной стрелки
    /// </summary>
    /// <returns>Угол минутной стрелки</returns>
    float GetMinuteAngle();

    /// <summary>
    /// Возвращает текущий угол секундной стрелки
    /// </summary>
    /// <returns>Угол секундной стрелки</returns>
    float GetSecondAngle();

    /// <summary>
    /// Возвращает текущий год (от установленного пользователем)
    /// </summary>
    /// <returns>Текущий год</returns>
    int GetYear();

    /// <summary>
    /// Возвращает текущий месяц (от установленного пользователем)
    /// </summary>
    /// <returns>Текущий месяц</returns>
    int GetMonth();

    /// <summary>
    /// Возвращает текущий день (от установленного пользователем)
    /// </summary>
    /// <returns>Текущий день</returns>
    int GetDay();
}
