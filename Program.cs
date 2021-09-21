// Name: Duy
// Date: 09/19/2021
// Class: Managing Information Resource
// Prof: David Traivs
// Assginment: Tech Project 3

using System;

namespace TechProject3_IterativeStatement
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the interge KM value here: ");
			Console.WriteLine("Greetings, this is Distance Conversion Manager!");
			Console.WriteLine("**********************************************");

			// 1. Input
			int userInput; //must be declared outside of do-while loop
			double mileValue = 0;
			double kiloValue = 0;
			do
			{
				Console.WriteLine("Please enter an INTEGER as KM-increment(10 - 25): ");
				userInput = Convert.ToInt32(Console.ReadLine());
				if (userInput < 10 || userInput > 25)
				{
					Console.WriteLine("Please enter interger from 10 to 25..."); // Show the message when the userinput is not in range from 10 to 25
				}
				else break;
			} while (true); // "true" here means the loops ends only when user input the correct number

			// 2. Calculation
			Console.WriteLine("Provided that Kilometer Increment Value = " + userInput + "\n");
			Console.WriteLine("Kilometers \t Equity Miles \n");

			while (kiloValue <= 200)
			{
				mileValue = kiloValue * 0.621371;
				kiloValue = kiloValue + userInput;
				Console.WriteLine(kiloValue + " \t\t" + mileValue); // Display the value
			}
			Console.WriteLine("Press any key to exist");
			Console.ReadKey(true);
		}
    }
}
