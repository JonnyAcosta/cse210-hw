using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Enter goal Type (1. Simple / 2. Eternal / 3. Checklist):");
                    int goalType = int.Parse(Console.ReadLine());

                    Goal newGoal = CreateGoal(goalName, goalType);
                    user.AddGoal(newGoal);
                    Console.WriteLine("Goal added");
                    break;

                case "2":
                    Console.WriteLine("Select a goal to record an event:");
                    user.DisplayGoals();
                    Console.Write("Enter the goal number: ");
                    int goalNumber = int.Parse(Console.ReadLine());

                    if (goalNumber >= 1 && goalNumber <= user.Goals.Count)
                    {
                        Goal selectedGoal = user.Goals[goalNumber - 1];
                        user.RecordEvent(selectedGoal);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;

                    case "3":
                        Console.WriteLine("User's Goals:");
                        user.DisplayGoals();
                        break;

                    case "4":
                        Console.WriteLine($"Total Score: {user.GetScore()} points");
                        break;
                    
                    case "5": 
                    Console.Write("Enter the name to save goals: ");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveUserGoals(user, saveFileName);
                    Console.WriteLine("Goals saved");
                    break;

                    case "6":
                    Console.Write("Enter the name to load goals: ");
                    string loadFileName = Console.ReadLine();
                    User loadedUser = goalManager.LoadUserGoals(loadFileName);

                    if (loadedUser != null)
                    {
                        user = loadedUser;
                        Console.WriteLine("Goals loaded");
                    }
                    break;

                    case "0": 
                    Environment.Exit(0);
                    break;

                    default: 
                    Console.WriteLine("Wrong Choice. Try again");
                    break;
            }
        }
    }

    static Goal CreateGoal(string name, int type)
    {
        Console.Write("Enter points:");
        int points = int.Parse(Console.ReadLine());

        switch(type)
        {
            case 1:
            return new SimpleGoal(name, points);

            case 2: 
            return new EternalGoal(name, points);

            case 3: 
            Console.Write("Enter target count for checklist goal: ");
            int targetCount = int.Parse(Console.ReadLine());
            return new ChecklistGoal(name, points, targetCount);

            default: 
            throw new ArgumentException("Wrong goal type.");
        }
    }
}