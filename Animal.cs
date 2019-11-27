using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesOop
{
	class Animal
	{
		// In larger projects, avoid using public - it's a security risk
		public string name;
		public string species;
		public bool hasLegs;

		public Animal(string name, string  species, bool hasLegs)
		{
			this.name = name;
			this.species = species;
			this.hasLegs = hasLegs;
		}

		public void PrintProps()
		{
			string legStatus = "does not";
			if (hasLegs) { legStatus = "does"; }
			Console.WriteLine($"{name} is a {species} and it {legStatus} have legs.");
		}
		// see also ToString()
	}
}
