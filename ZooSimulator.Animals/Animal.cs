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
		protected struct Location
		{
			public int x;
			public int y;
		}

		#region Fields
		protected PictureBox picture;
		///<summary>Tipo de Comida: 1 - Grass, 2 - Meat</summary>
		protected int food;
		protected int hunger;
		private Boundaries boundaries;
		protected Location location;

		#endregion

		#region Properties
		public int Food
		{
			get { return food; }
			set
			{
				if ((value > 0) && (value < 10))
					food = value;
				else
					food = 1;
			}
		}

		public string Name { get; set; }

		#endregion


		#region Methods

		public void FoodSet(int food)
		{
			if ((food > 0) && (food < 10))
				this.food = food;
			else
				this.food = 1;
		}

		public int FoodGet()
		{
			return this.food;
		}


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
