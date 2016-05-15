using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugSample
{
	class DebugSample
	{
		static void Main(string[] args)
		{
			int agevalue;

			// Ask for user's age:
			Console.Write("Enter your age: ");
			agevalue = Convert.ToInt32(Console.ReadLine());

			// Display statement based on results
			if (agevalue > 13 && agevalue < 20)
			{
				Console.WriteLine("You are a teenager.");
			}
			else
			{
				Console.WriteLine("You are not a teenager.");
			}

			Console.WriteLine("Press any key to continue.");
			Console.ReadKey();
		}
	}
}