using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsProject.Tests
{
	[TestClass]
	public class CalulatorTests
	{
		[TestMethod]
		public void Sum_10plus15_25returned() {
			int a = 10;
			int b = 15;
			int expected = 25;
			int actual = Calulator.Sum(a, b);
			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void Multiple_10multiple2_20returned() {
			int a = 10;
			int b = 2;
			int expected = 20;
			int actual = Calulator.Multiple(a, b);
			Assert.AreEqual(actual, expected);
		}
	}
}
