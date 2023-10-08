using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // create prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        
        Journal2 journal = new Journal2();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Show random prompt");
            Console.WriteLine("2. Add entry");
            Console.WriteLine("3. Display journal");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Load journal from file");
            Console.WriteLine("6. Exit");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ShowRandomPrompt(prompts);
                        break;

                    case 2:
                        CreateNewEntry();
                        break;

                    case 3:
                        DisplayJournal(journal);
                        break;

                    case 4:
                        SaveJournalToFile(journal);
                        break;

                    case 5:
                        LoadJournalFromFile(ref journal);
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
      }
              static void ShowRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine("Random Prompt: " + prompts[index]);
    }
        // 1. Show menu
        // 2. Get menu choice from user 
        // 3. decide what to do
        // ..

        // create a new entry
    static void CreateNewEntry()
    {
        Entry2 entry = new Entry2();
        
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // value of prompt displayed to user
        entry.Response=""; // value user entered

        // create a new journal option
        Journal2 journal = new Journal2();
        journal.Name =""; // user entered name
        journal.Entries.Add(entry);
    }  

        static void DisplayJournal(Journal2 journal)
    {
        Console.WriteLine($"Journal for: {journal.Name}");
        foreach (var entry in journal.Entries)
        {
            Console.WriteLine($"Date: {entry.EntryDate}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }
       // save to file
     static void SaveJournalToFile(Journal2 journal)
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
         File.ReadAllLines(filename);

        //string json = JsonConvert.SerializeObject(journal);
        //File.WriteAllText(filename);

        Console.WriteLine("Journal saved to " + filename);
    }

     static void LoadJournalFromFile(ref Journal2 journal)
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
          //  string json = File.ReadAllText(filename);
            //journal = JsonConvert.DeserializeObject<Journal2>(json);
            Console.WriteLine("Journal loaded from " + filename);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

       // read from file
}
}
