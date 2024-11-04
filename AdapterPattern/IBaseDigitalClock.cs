namespace AdapterPattern;

public interface IBaseDigitalClock
{
    /// <summary>
    /// Задает текущую дату
    /// </summary>
    /// <param name="date">Дата в формате DateTime</param>
    void SetDateTime(DateTime date);

    /// <summary>
    /// Возвращает текущую дату в формате DateTime
    /// </summary>
    /// <returns>Текущая дата</returns>
    DateTime GetDateTime();
}
