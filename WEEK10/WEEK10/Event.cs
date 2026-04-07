namespace WEEK10;

public class Event
{
    public int TurnNumber { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string StatsChange { get; set; }

    public Event(int turnNumber, string description, string type, string statsChange)
    {
        TurnNumber = turnNumber;
        Description = description;
        Type = type;
        StatsChange = statsChange;
    }

}