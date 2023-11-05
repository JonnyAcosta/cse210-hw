using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;
            int duration = 0;

            if(choice == 4)
            {
                break;
            }
            else if (choice == 1)
            {
                Console.Write("Enter duration (in seconds) for the Breathing Activity: ");
                duration = int.Parse(Console.ReadLine());
                activity = new BreathingActivity("Breathing Exercise","Help with your breathing");
            }
            else if (choice == 2)
            {
                activity = new ReflectionActivity("Reflection Exercise", "Help you to think deeply");
            }
            else if (choice == 3)
            {
                Console.Write("Enter duration (in seconds) for the Listing Activity: ");
                duration = int.Parse(Console.ReadLine());
                activity = new ListingActivity("Listing Exercise", "Guide to think broadly");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a option");
                continue;
            }
            if (activity != null)
            {
                activity.Duration = duration;
                activity.Start();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}