class ReceptionEvent : Event
{
    string _rsvpEmail;
    public ReceptionEvent(string title, string description, string date, string time, Address address,
                 string rsvpEmail): base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        string baseDetails = base.FullDetails();
        return $"{baseDetails}\nRSVP Email: {_rsvpEmail}";
    }
}