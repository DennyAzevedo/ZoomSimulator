using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public class Felino : Animal
	{
		public new string MakeNoise()
		{
			return "Ruuaauuuu";
		}

		public new string Eat()
		{
			return "Carne saborosa";
		}
	}
}
