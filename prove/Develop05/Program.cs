using System;

class Program
{
    static void Main(string[] args)
        {
        GoalManager goalManager = LoadGoalsFromFile(); // Load goals from file

        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Display your score");
            Console.WriteLine("3. Display current goals");
            Console.WriteLine("4. Mark a goal as completed");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    Console.WriteLine($"Total Score: {goalManager.TotalScore}");
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    MarkGoalAsCompleted(goalManager);
                    break;
                case "5":
                    SaveGoalsToFile(goalManager); // Save goals to file before quitting
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nCreate a new goal:");

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the type of goal (1 for Simple, 2 for Eternal, 3 for Checklist): ");
        string typeChoice = Console.ReadLine();

        Goal newGoal = null;

        switch (typeChoice)
        {
            case "1":
                Console.Write("Enter the points for completing the goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                newGoal = new SimpleGoal(name, simplePoints);
                break;
            case "2":
                Console.Write("Enter the points for recording the goal: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                newGoal = new EternalGoal(name, eternalPoints);
                break;
            case "3":
                Console.Write("Enter the points for each completion of the goal: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the target completion count: ");
                int targetCount = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, checklistPoints, targetCount);
                break;
            default:
                Console.WriteLine("Invalid goal type. Please enter 1, 2, or 3.");
                return;
        }

        goalManager.AddGoal(newGoal);
        Console.WriteLine($"Goal '{name}' created successfully!");
    }

    static void MarkGoalAsCompleted(GoalManager goalManager)
    {
        Console.WriteLine("\nMark a goal as completed:");
        goalManager.DisplayGoals();

        Console.Write("Enter the name of the goal to mark as completed: ");
        string goalName = Console.ReadLine();

        foreach (var goal in goalManager.goals)
        {
            if (goal.Name == goalName)
            {
                goalManager.RecordEvent(goalManager.goals.IndexOf(goal));
                Console.WriteLine($"Goal '{goalName}' marked as completed!");
                return;
            }
        }

        Console.WriteLine($"Goal '{goalName}' not found.");
    }

    static GoalManager LoadGoalsFromFile()
    {
        GoalManager goalManager = new GoalManager();

        if (File.Exists("goals.txt"))
        {
            try
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');

                        string name = data[0];
                        int points = int.Parse(data[1]);
                        int type = int.Parse(data[2]);
                        int targetCount = int.Parse(data[3]);

                        Goal goal = null;

                        switch (type)
                        {
                            case 1:
                                goal = new SimpleGoal(name, points);
                                break;
                            case 2:
                                goal = new EternalGoal(name, points);
                                break;
                            case 3:
                                goal = new ChecklistGoal(name, points, targetCount);
                                break;
                        }

                        goalManager.AddGoal(goal);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }

        return goalManager;
    }

    static void SaveGoalsToFile(GoalManager goalManager)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in goalManager.goals)
                {
                    int type = 0;

                    if (goal is SimpleGoal)
                        type = 1;
                    else if (goal is EternalGoal)
                        type = 2;
                    else if (goal is ChecklistGoal)
                        type = 3;

                    writer.WriteLine($"{goal.Name},{goal.Points},{type},{(goal is ChecklistGoal ? ((ChecklistGoal)goal).TargetCount : 0)}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }
}