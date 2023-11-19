public class GoalManager
    {
        public List<Goal> goals;
        private int totalScore;

        public GoalManager()
        {
            goals = new List<Goal>();
            totalScore = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                totalScore += goals[goalIndex].RecordEvent();
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void DisplayGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine($"[{(goal is ChecklistGoal && ((ChecklistGoal)goal).CompletedCount > 0 ? "X" : " ")}] {goal.Name} " +
                                $"{(goal is ChecklistGoal ? $"Completed {((ChecklistGoal)goal).CompletedCount}/{((ChecklistGoal)goal).TargetCount} times" : "")}");
            }
        }

        public int TotalScore
        {
            get { return totalScore; }
        }
    }