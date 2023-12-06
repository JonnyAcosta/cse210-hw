using System.Security.Cryptography.X509Certificates;

class User
{
    private List<Goal> goals = new List<Goal>();
    private int score;

    public List<Goal> Goals
    {
        get{return goals; }
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        score += goal.GetPoints();
    }
    
    public void DisplayGoals()
    {
        foreach(var goal in goals)
        {
            goal.Display();

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"(Completed {checklistGoal.CompletedCount}/{checklistGoal.TargetCount} times)");

            }
        }
    }
    public int GetScore()
                {
                    return score;
                }
}