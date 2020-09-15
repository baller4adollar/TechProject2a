// Author: Nikhil Patel
// Date: 09/14/2020
// Commments: This C# console application demonstrates the use of iterative statements after getting the input from users.

using System;

namespace TechProject2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("enter an integer value between 1 and 25 to execute an iterative statement");

            try
            {
                // this variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perfrom the various iterative statements and parsed as an integer
                int value_of_input = int.Parse(input);

                //This statement is used to test the values of user input.

                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a for loop");
                    Console.WriteLine("You have entered: " + value_of_input.ToString());
                    // Here is the for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("This is the current integer value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    // Pause the progam and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                // if the user doesn't enter a value between 1 and 25, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
                {
                    Console.WriteLine("please enter an integer value and try running the progam again...");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }

                   
                     
        }
    } 

