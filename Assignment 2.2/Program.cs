using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 2.2");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*1. Write a base class: ‘Shape’ and add properties like id, 
             * name and color and method like ‘calculate area’ .

            Inherit circle shape from base class and 
            add properties like radius. override calculate area logic for circle.

            Inherit square class from shape and 
            add change the calculate area logic. Add property
            like side of square.

            Take the input from user to select circle
            or square and display the calculated area . 
            no hard coded values!*/

            StartPoint:

            Console.WriteLine("\nI can calculate the area of a circle or square:");
            Console.WriteLine("Type the letter next to your option: \n\n" +
                "   A: Calculate Area of Circle\n" +
                "   B: Calcualte Area of Square\n");
            Console.Write("Your Choice: ");
            string choice = Console.ReadLine().ToUpper();

            // creating objects in respective classes
            Circle circle = new Circle();
            Square square = new Square();

            switch (choice)
            {
                // Calculate Area of Circle
                case "A":
                    // ask user for radius
                    Console.Write("\nEnter lenght of radius: ");
                    circle.Radius = int.Parse(Console.ReadLine()); // sets radius of circle to user input

                    // prints are of circle
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe area of the circle is {circle.CalculateArea()}"); // calls CalculateArea function in circle class
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                // Calcualte Area of Square
                case "B":
                    // ask user for side lenght
                    Console.Write("\nEnter lenght of side: ");
                    square.Side = int.Parse(Console.ReadLine()); // sets side of square to user input

                    // prints are of square
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe area of the square is {square.CalculateArea()}"); // calls CalculateArea function in circle class
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                // error message
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou didn't enter one of the options. Please try again.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }

            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();
        }
    }
}
