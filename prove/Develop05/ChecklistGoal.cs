public class ChecklistGoal : Goal
    {
        public int TargetCount;
        public int CompletedCount;

        public ChecklistGoal(string name, int points, int TargetCount) : base(name, points)
        {
            this.TargetCount = TargetCount;
            this.CompletedCount = 0;
        }

        public override int RecordEvent()
        {
            CompletedCount++;
            Console.WriteLine($"Goal '{Name}' completed {CompletedCount}/{TargetCount} times. Gained {Points} points.");

            if (CompletedCount == TargetCount)
            {
                int bonusPoints = 500; // Bonus points for completing the checklist
                Console.WriteLine($"Bonus! Goal '{Name}' completed {TargetCount} times. Gained {bonusPoints} bonus points.");
                return Points + bonusPoints;
            }

            return Points;
        }
    }