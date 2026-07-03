using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign (stretch challenge)
        int lastDigit = percentage % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Fix special cases
        if (letter == "A" && sign == "+")
        {
            sign = "-"; // no A+
        }

        if (letter == "F")
        {
            sign = ""; // no F+ or F-
        }

        // Output final grade
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Pass/Fail check (70 is passing)
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep trying, you can improve next time!");
        }
    }
}