using System;

namespace ExercisesOop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Exercises in OOP");
			Animal cat = new Animal("David", "cat", true);
			cat.PrintProps();
			Animal fish = new Animal("Nemo", "clownfish", false);
			fish.PrintProps();
		}
	}
}
