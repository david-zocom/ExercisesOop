using System;
using System.Collections.Generic;

namespace ExercisesOop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Exercises in OOP");
			Animal cat = new Animal("David", "cat", true);
			//cat.PrintProps();
			Animal fish = new Animal("Nemo", "clownfish", false);
			//fish.PrintProps();

			Animal[] animalsFixed = new Animal[] { cat, fish };
			List<Animal> animals = new List<Animal>() { cat, fish };

			Animal horse = new Animal("Åke", "horse", true);
			animals.Add(horse);
			animals.Remove(fish);
			//animals.RemoveAt(1);
			foreach (var animal in animals)
			{
				animal.PrintProps();
			}
		}
	}
}
