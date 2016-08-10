using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooSimulator.Animals
{
	public class Animal
	{
		private struct Location
		{
			public int x;
			public int y;
		}

		#region Fields
		private PictureBox picture;
		///<summary>Tipo de Comida: 1 - Grass, 2 - Meat</summary>
		protected int food;
		private int hunger;
		private Boundaries boundaries;
		private Location location;

		#endregion

		#region Methods
		public string MakeNoise()
		{
			return "Toimmmmm";
		}

		public string Eat()
		{
			return "Estou alimentado";
		}

		public string Sleep()
		{
			return "ZZZzzzzzz";
		}

		public string Roam()
		{
			location.x += 2;
			location.y += 1;
			return "passeando....";
		}
		#endregion

	}
}
