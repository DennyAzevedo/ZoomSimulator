using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public class Canino : Animal
	{
		public new string Eat()
		{
			return "Comi ração";
		}

		public new string MakeNoise()
		{
			return "Grrrrrrr";
		}
	}
}
