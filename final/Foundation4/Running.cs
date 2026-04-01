class Running : Activity
{
    private double _distance;
    public Running(string date, double lengthInMinutes, double distance): base(date, lengthInMinutes)
    {
        _distance = distance;
    }
    public override string Distance()
    {
        return $"Distance: {_distance} miles";
    }
    public override string Speed()
    {
        double hoursInMinutes = _lengthInMinutes / 60.0;
        double mph = _distance / hoursInMinutes;
        return$"Speed: {mph} mph";
    }
    public override string Pace()
    {
        double minutesPerMile = _lengthInMinutes / _distance;
        return $"Pace: {minutesPerMile} min per mile";
    }

}