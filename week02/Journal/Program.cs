// Creativity and exceeding requirements:
// I exceeded the requirements by adding extra prompts,
// providing confirmation messages after saving and loading,
// and using separate classes with methods to demonstrate abstraction.
// The Journal class manages journal operations without exposing
// unnecessary details to the main program.

using System;

namespace JournalProgram;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Select an option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine(prompt);

                    Console.Write("> ");

                    string response = Console.ReadLine();

                    Entry entry = new Entry();

                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;

                    journal.AddEntry(entry);

                    Console.WriteLine("Entry added.");

                    break;

                case 2:

                    journal.DisplayAll();

                    break;

                case 3:

                    Console.Write("Filename: ");

                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;

                case 4:

                    Console.Write("Filename: ");

                    string loadFile = Console.ReadLine();

                    journal.LoadFromFile(loadFile);

                    break;

                case 5:

                    Console.WriteLine("Goodbye!");

                    break;

                default:

                    Console.WriteLine("Invalid option.");

                    break;
            }
        }
    }
}