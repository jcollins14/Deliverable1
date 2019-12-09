using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationLocation = "";
            string groupTransportation = "";
            string vacationType = "";
            int groupSize = 0;
            string result = "";

            while (vacationLocation == "")
            {
                Console.Write("Hello! What kind of vacation would you like to go on? ");
                vacationType = Console.ReadLine();
                vacationType = vacationType.Trim();
                vacationType = vacationType.ToLower();


                if (vacationType == "musical")
                {
                    vacationLocation = "to New Orleans";
                }

                else if (vacationType == "tropical")
                {
                    vacationLocation = "on a beach vacation in Mexico";
                }

                else if (vacationType == "adventurous")
                {
                    vacationLocation = "whitewater rafting in the Grand Canyon";
                }

                else
                {
                    Console.WriteLine("I'm sorry, I was unable to understand what kind of vacation you would like. Please try again.");
                    Console.WriteLine("Available options are Musical, Tropical, and Adventurous");
                }
            }

            while (groupTransportation == "")
            {
                Console.Write("How many people are in your group? Please only input a number.");
                groupSize = int.Parse(Console.ReadLine());
                    if (groupSize >= 6)
                    {
                        groupTransportation = "charter flight";
                    }

                    else if (groupSize >= 3)
                    {
                        groupTransportation = "helicopter";
                    }

                    else if (groupSize >= 1)
                    {
                        groupTransportation = "first class flight";
                    }

                    else
                    {
                        Console.WriteLine("I'm sorry, I was unable to understand how many people you wanted to take with you. Please try again.");
                    }
                }

            result = "Since you are a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + groupTransportation + " so you can go " + vacationLocation + ".";
            Console.WriteLine(result);
        }
    }
}
