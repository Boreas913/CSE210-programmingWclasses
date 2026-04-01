class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double lengthInMinutes, double speed): base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override string Distance()
    {
        return $"Distance: {_speed * (_lengthInMinutes / 60.0)} miles";
    }
    public override string Speed()
    {
        return$"Speed: {_speed}";
    }
    public override string Pace()
    {
        double minutesPerMile = _lengthInMinutes / (_speed * (_lengthInMinutes / 60.0));
        return $"Pace: {minutesPerMile} min per mile";
    }
}