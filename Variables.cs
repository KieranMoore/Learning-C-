using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			int x;
			int y;

			x = 7;
			y = x + 3;
			Console.WriteLine(y);

			
			string myFirstName;
			myFirstName = "Kieran";
			//or
			//string myFirstName = "Kieran";

			Console.WriteLine(myFirstName);
			*/

			int x = 7;
			//string y = "Kieran";
			string y = "5";
			string myFirstTry = x.ToString() + y;

			// int mySecondTry = x + y; [can not perform implicit conversion from string to int]
			int mySecondTry = x + int.Parse(y);

			Console.WriteLine(myFirstTry);

			Console.ReadLine();

		}
	}
}