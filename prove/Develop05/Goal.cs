public abstract class Goal
{
    private string name;
    private int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    // Abstract method to record an event and calculate points
    public abstract int RecordEvent();
}