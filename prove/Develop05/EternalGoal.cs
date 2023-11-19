public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override int RecordEvent()
        {
            Console.WriteLine($"Goal '{Name}' recorded! Gained {Points} points.");
            return Points;
        }
    }