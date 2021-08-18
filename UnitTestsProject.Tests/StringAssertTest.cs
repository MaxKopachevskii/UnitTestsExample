using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsProject.Tests
{
	[TestClass]
	public class StringAssertTest
	{
		[TestMethod]
		public void ContainsTest() {
			StringAssert.Contains("Hello world", "lo");
		}

		[TestMethod]
		public void MatchTest() {
			StringAssert.Matches("123", new Regex(@"\d{3}"));
		}
	}
}
