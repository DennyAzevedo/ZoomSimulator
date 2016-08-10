using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSimulator.Animals
{
	public interface IRace
	{
		string Raca { get; set; }

		string Correr();
	}
}
