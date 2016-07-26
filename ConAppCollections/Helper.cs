using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppCollections
{
	class Helper
	{
		public static void MakeDecision(int value)
		{
			switch(value)
			{
				case 1:
					RunOne();
					break;
				case 2:
					RunTwo();
					break;
				case 3:
					RunThree();
					break;
				case 4:
					RunFour();
					break;
				case 5:
					RunFive();
					break;
				case 6:
					RunSix();
					break;
				case 7:
					RunSeven();
					break;
				case 8:
					RunEight();
					break;
				default: 
					break;
			}
		}

		private static void RunOne()
		{
			Console.WriteLine("=== RunOne - List ===");
		}

		private static void RunTwo()
		{
			Random fRnd = new Random();
			Console.WriteLine("=== RunTwo - Generic List ===");
			List<float> myFloatList = new List<float>();

			for (int i = 0; i < 10; i++)
			{
				myFloatList.Add(fRnd.Next(1,49));
			}

			myFloatList.Sort();
			foreach (float item in myFloatList)
			{
				Console.WriteLine(item);
			}

		}

		private static void RunThree()
		{
			Console.WriteLine("=== RunThree - HashTable ===");
		}

		private static void RunFour()
		{
			Console.WriteLine("=== RunFour - Dictionary ===");
		}

		private static void RunFive()
		{
			Console.WriteLine("=== RunFive - ArrayList ===");
		}

		private static void RunSix()
		{
			Console.WriteLine("RunSix - Arrays");
			//new array
			int[] myIntArr = new int[20];

			string[] myStrArr = new string[10];

			Random rnd = new Random();

			for (int i = 1; i < myIntArr.Length; i++ )
			{
				myIntArr[i] = i;
			}

			for (int i = 0; i < myStrArr.Length; i++)
			{

				myStrArr[i] = "stringValue " + rnd.Next(1,49); 
			}

			int myMax = myIntArr.Max();


			for (int i = 0; i < myIntArr.Length; i++)
			{
				Console.WriteLine(myIntArr[i].ToString());
			}
			Console.WriteLine();
			Console.WriteLine("myArr max val: {0}", myMax);
		}

		private static void RunSeven()
		{
			Console.WriteLine(IsPalindrome("Noel sees Leon"));	
		}

		private static void RunEight()
		{
			var baseString = "TEST";
			IEnumerable<char> charString = baseString.ToCharArray();
			var reverse = charString.Reverse();

			var results = new StringBuilder();
			foreach (var item in reverse)
			{
				results.Append(item);
			}
			Console.WriteLine(results);
		}
		private static bool IsPalindrome(string myText)
		{
			//remove spaces and dot at the end
			string temp3 = myText.Replace(" ", string.Empty).ToLower();
			temp3.Replace(".", string.Empty);
			
			string output = string.Empty;
			char[] myTemp = temp3.ToCharArray();

			for (int i = myTemp.Length -1; i >=0; i--)
			{
				output += myTemp[i];
			}

			bool result = string.Equals(temp3, output);

			return result ? true : false;
		}
	}
}
