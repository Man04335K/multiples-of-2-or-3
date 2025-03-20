using System;
namespace Multiplesof2or3
{

    class Multiples
    {
        static void Main()
        {
            int number;

            while (true)
            {
                //For printing the number between 1 to 50
                Console.Write("Enter a number between 1 and 50: ");

                // Try parsing the input to an integer given by user
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
}
/// START
/// PRINT "Enter a number between 1 to 50"
/// READ the user input
/// IF the user input is NOT a number OR user input is NOT a number between 1 to 50 THEN
/// PRINT"Invalid"
/// ELSE
/// IF user input is multiple of 2 or is multiple of 3
/// PRINT"Success"
/// EXIT the loop after valid input
/// END