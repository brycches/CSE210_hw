public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! Gained {Points} points.");
        return Points;
    }
}