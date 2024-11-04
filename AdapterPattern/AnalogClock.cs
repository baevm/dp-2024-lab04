namespace AdapterPattern;

public class AnalogClock : IBaseAnalogClock
{
    private int year;
    private int month;
    private int day;
    private float hourAngle;
    private float minuteAngle;
    private float secondAngle;
    private DayNightDivision dayNightDivision;

    public AnalogClock()
    {
        year = 0;
        month = 0;
        day = 0;
        hourAngle = 0.0f;
        minuteAngle = 0.0f;
        secondAngle = 0.0f;
        dayNightDivision = DayNightDivision.AM;
    }

    public void SetDateTime(int year, int month, int day, float hourAngle, float minuteAngle, float secondAngle, DayNightDivision dayNightDivision)
    {
        this.year = year;
        this.month = month;
        this.day = day;
        this.hourAngle = hourAngle;
        this.minuteAngle = minuteAngle;
        this.secondAngle = secondAngle;
        this.dayNightDivision = dayNightDivision;
    }

    public float GetHourAngle()
    {
        return hourAngle;
    }

    public float GetMinuteAngle()
    {
        return minuteAngle;
    }

    public float GetSecondAngle()
    {
        return secondAngle;
    }

    public int GetYear()
    {
        return year;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetDay()
    {
        return day;
    }

    public DayNightDivision GetDayNightDivision()
    {
        return dayNightDivision;
    }
}
