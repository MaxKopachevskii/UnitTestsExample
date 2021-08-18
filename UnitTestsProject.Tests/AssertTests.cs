using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsProject.Tests
{
	[TestClass]
	public class AssertTests
	{
		[TestMethod]
		public void AssertAreEqualTest() {
			int a = 10;
			int b = 15;
			int expected = 25;
			int actual = Calulator.Sum(a, b);
			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void AssertAreEqualTest2() {
			int a = 10;
			int b = 15;
			int expected = 25;
			int actual = Calulator.Sum(a, b);
			Assert.AreEqual(actual, expected,"{0} not equal {1}", actual, expected);
		}

		[TestMethod]
		public void AssertAreEqualDelta() {
			double a = 10;
			double b = 15;
			double delta = 0.1;
			double expected = 150;
			double actual = a * b;
			Assert.AreEqual(actual, expected, delta, "Fail delta test!!!");
		}

		[TestMethod]
		public void AssertAreSameTest() {
			string a = "Hello world";
			string b = "Hello world";
			Assert.AreSame(a, b, "Failed AssertAreSameTest!!!");
		}

		/*[TestMethod]
		public void AssertAreSameTest2() {
			int a = 2;
			int b = 2;
			Assert.AreSame(a, b, "Failed AssertAreSameTest2!!!");
		}*/
	}
}
