namespace AdapterPattern;

class Program
{
    static void Main(string[] args)
    {
        var analogClock = new AnalogClock();

        var digitalClock = new AnalogToDigitalClock(analogClock);

        var currentTime = new DateTime(2024, 12, 31, 12, 30, 55);
        digitalClock.SetDateTime(currentTime);

        var timeFromDigitalClock = digitalClock.GetDateTime();

        Console.WriteLine($"Time from digital clock: {timeFromDigitalClock}");
    }
}