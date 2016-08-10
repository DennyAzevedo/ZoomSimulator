using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public sealed class Cachorro : Canino
	{
		public new string MakeNoise()
		{
			return "Au au au";
		}
	}
}
