using System;
using Microsoft.VisualBasic;

namespace AdvancedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Advanced Console App!");

            // Get user input
            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();
            Console.Write("Enter you'r date of Birth (MM/dd/yyyy): ");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(),out dob))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (MM/dd/yyyy).");
                Console.Write("Enter your Date of Birth (MM/dd/yyyy): ");
            } 

            // Display a menu
            Console.WriteLine("Welcome " + userName);
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display current date and time");
            Console.WriteLine("2. Display a random number");
            Console.WriteLine("3. Calculate Age");
            Console.WriteLine("4. Exit");

            // Get user choice
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Process user choice
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Current date and time: " + DateTime.Now);
                    break;
                case 2:
                    Random random = new Random();
                    Console.WriteLine("Random number: " + random.Next(1, 101));
                    break;
                case 3:
                    int Age = CalculateAge(dob);
                    Console.WriteLine("you are " + Age + "years old");
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Wait for user to press a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int CalculateAge(DateTime dob)
        {
            int Age =DateTime.Now.Year - dob.Year;
            if(DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day)){
                Age--;
            }
            return Age;
        }
    }
}