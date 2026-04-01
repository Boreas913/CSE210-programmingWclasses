class Swimming: Activity
{
    private double _numOfLaps;
    public Swimming(string date, int lengthInMinutes, double numOfLaps):base(date, lengthInMinutes)
    {
        _numOfLaps = numOfLaps;
    }
    public override string Distance()
    {
        return $"Distance: {((_numOfLaps*50.0)/1000.0)*0.62} miles";
    }
    public override string Speed()
    {
        return$"Speed: {(((_numOfLaps*50.0)/1000.0)*0.62)/(_lengthInMinutes/60)} mph";
    }
    public override string Pace()
    {
        double distance = ((_numOfLaps*50.0)/1000.0)*0.62;
        double minutesPerMile = _lengthInMinutes / distance;
        return $"Pace: {minutesPerMile} min per mile";
    }
}