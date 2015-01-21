using System;
using System.Collections.Generic;

public class Start
{
	public static void Main(string[] args)
	{
		NamesCount namesCount = new NamesCount();

		namesCount.AddName("James");
		namesCount.AddName("James");
		namesCount.AddName("John");
		namesCount.AddName("Mary");
		namesCount.AddName("Mary");

		Console.WriteLine("Fraction of Johns: {0}", namesCount.NameProportion("John"));
		Console.WriteLine("Fraction of Marys: {0}", namesCount.NameProportion("Mary"));

		Console.ReadKey();
	}
}


public class NamesCount
{
	//number of time method was ran
	private double count;
	
	private Dictionary<string, int> counts = new Dictionary<string, int>();

	//number of particular name in the dictonary
	int nameCount = 0;
	

	/// <summary>
	/// Adds the name.
	/// </summary>
	/// <param name="name">Name.</param>
	public void AddName(string name)
	{
		//when key exists increase count only

		if (!(counts.TryGetValue(name, out nameCount)))
		{
			nameCount++;
			counts[name] = nameCount;

		}
		else 
		{
			nameCount++;
			counts[name] = nameCount;
		}
		count++;
	}

	/// <summary>
	/// Returns proportion of parameter name in all calls to AddName.
	/// </summary>
	/// <returns>Double in interval [0, 1]. Returns 0 if AddName has not been called.</returns>
	/// <param name="name">Name.</param>
	public double NameProportion(string name)
	{
		return counts[name] / count;
	}

	
}