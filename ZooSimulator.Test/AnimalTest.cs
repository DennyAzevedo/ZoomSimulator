using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooSimulator.Animals;

namespace ZooSimulator.Test
{
	[TestClass]
	public class AnimalTest
	{
		[TestMethod]
		public void CriacaoObjetoAnimal()
		{
			Animal animal = new Animal();

			Assert.IsNotNull(animal);
		}
	}
}
