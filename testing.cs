using System;
using System.Collections.Generic;
using System.Linq;

public sealed class Person
{
	public string Name { get; }
	public int Age { get; }

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
}

public static class Program
{
	public static void Main()
	{
		var people = new List<Person>
		{
			new Person("Ava", 24),
			new Person("Noah", 17),
			new Person("Mia", 31)
		};

		var adults = people.Where(person => person.Age >= 18).ToList();
		var averageAge = people.Average(person => person.Age);

		Console.WriteLine("Adults:");
		foreach (var person in adults)
		{
			Console.WriteLine($"- {person.Name} ({person.Age})");
		}

		Console.WriteLine($"Average age: {averageAge:F1}");
	}
}
