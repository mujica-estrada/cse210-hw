using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, this your personal journal.");

        List<string> prompts = new List<string>
        {
            "What did you learn from class today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What is something worth remembering from today?",
            "What are some things you wish to improve?"
        };

        Journal myJournal = new Journal();
        string fileName = "myjournal.txt";

        myJournal.LoadFromFile(fileName);

        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save entry");
            Console.WriteLine("4. Exit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                Random rand = new Random();
                int index = rand.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added.");
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                myJournal.SaveToFile(fileName);
                Console.WriteLine("Journal saved to 'myjournal.txt'.");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please, try again.");
            }
        }
    }
}