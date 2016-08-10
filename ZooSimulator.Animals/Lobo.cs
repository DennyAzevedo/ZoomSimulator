using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public class Lobo : Canino, IRace
	{
		public string Raca { get; set;}

		public string Correr()
		{
			return "Velocidade máxima";
		}

		public new string MakeNoise()
		{
			return "Auauauauuuuuuuuuu";
		}
	}
}
