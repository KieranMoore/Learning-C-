using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorsExpressionsStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y, a, b;

			// Assignment operator
			x = 3;
			y = 2;
			a = 1;
			b = 0;

			// There are many mathmatical operators ...
			
			// Addition operator
			x = 3 + 4;

			// Subtraction operator
			x = 4 - 3;

			// Multiplication operator
			x = 10 * 5;

			// Division opertor
			x = 10 / 5;

			// There are operators to evaluate values ...

			// Equality operator
			if (x == y){

			}

			// Greater than operator
			if (x > y){
				
			}

			// Less than operator
			if (x < y){
							
			}

			// Greater than or euqual to operator
			if (x >= y){
							
			}

			// Less than or euqual to operator
			if (x <= y){
							
			}

			// There are two "conditional" operators as well that can be used to expand / enhance an evaluation
			// ... and they can be combined together multiple times.

			// Conditional AND operator 
			if ((x > y) && (a > b)){
							
			}

			// Conditional OR operator
			if ((x > y) || (a > b)){
							
			}

			// In-line conditional operator

			string message = (x == 1) ? "Car" : "Boat";

			// Member access and Method invocation
			Console.WriteLine("Hello, World!");


		}
	}
}