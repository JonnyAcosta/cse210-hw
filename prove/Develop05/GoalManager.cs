
using System.IO;
using System.IO.Enumeration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

class GoalManager 
{
    private List<User> users = new List<User>();
    public void SaveUserGoals(User user, string fileName)
    {
        try
        {
            string json = JsonSerializer.Serialize(user);
            File.WriteAllText(fileName, json);
    
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public User LoadUserGoals(string fileName)
    {
        try
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<User>(json);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            return null;
        }
    }
}