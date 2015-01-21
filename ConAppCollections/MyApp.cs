using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppCollections
{
	class MyApp
	{
		static void Main(string[] args)
		{
			char[] answer = {'y', 'n'};
			while (answer[0] != 'n')
			{
				Console.Write("Enter number: ");
				int value = 0;
				
				if(int.TryParse(Console.ReadLine(), out value))
				{
					Helper.MakeDecision(value);
				}
				
				//Adding a test comment
				Console.Write("Run Again: [y/n] ");
				answer[0] = Convert.ToChar(Console.ReadLine().ToLower());

				Console.Clear();
			}
		}
	}
}
