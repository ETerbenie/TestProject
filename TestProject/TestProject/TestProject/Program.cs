﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info 

            GreetUser(); // Ask for user's name and greet

            while (true)
            {



                // Init correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;


                    }

                    // Turn string into integer and put in as guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Wrong number error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                        
                    }
                }

                // Tells user they're correct
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!!");
                
            
                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");


                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N" )
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }


        // Get and display app info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Numer Randomizer";
            string appVersion = "1.0.0";
            string appAuthor = "Erick Terbenie";


            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info, color
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Resets text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser()
        {
            // Prompts user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it's not a number 
            Console.WriteLine(message);

            // Resets text color
            Console.ResetColor();
        }
    }
}
