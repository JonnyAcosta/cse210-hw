using System;

class Program
{
    private static Scripture scripture;
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        scripture = new Scripture(reference, text);
        
        Run();
    }
    
    private static void Run()
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            scripture.DisplayCompleteScripture();

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "quit")
            {
                continueProgram = false;
            }
            else 
            {
                scripture.HideWords();
                ClearConsole();
            }
        }
    }
    private static void ClearConsole()
    {
        Console.Clear();
    }
}