using System;

class Program
{
    static void Main()
    {
        int number;

        while (true)
        {
            Console.Write("Enter a number between 1 and 50: ");

            // Try parsing user input to an integer
            bool isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid || number < 1 || number > 50)
            {
                Console.WriteLine("Invalid");
                continue; // Ask again
            }

            // Check if number is a multiple of 2 or 3
            if (number % 2 == 0 || number % 3 == 0)
            {
                Console.WriteLine("Success");
            }

            break; // Exit loop after valid input
        }
    }
}