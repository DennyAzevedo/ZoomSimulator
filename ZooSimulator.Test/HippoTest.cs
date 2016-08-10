using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooSimulator.Animals;

namespace ZooSimulator.Test
{
	[TestClass]
	public class HippoTest
	{
		[TestMethod]
		public void CriacaoObjetoHippo()
		{
			Hippo hippo = new Hippo();

			Assert.IsNotNull(hippo);
		}

		[TestMethod]
		public void VerificaFieldHippo()
		{
			Hippo hippo = new Hippo();
			//hippo = 4;

			//Assert.Equals(hippo.food, 4);
		}
	}
}
