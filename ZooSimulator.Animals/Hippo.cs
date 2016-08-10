using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public class Hippo : Animal
	{
		public new string MakeNoise()
		{
			return "Hipoooooo";
		}

		public new string Eat()
		{
			return "Hippo alimentado";
		}
	}
}
