using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsProject.Tests
{
	[TestClass]
	public class ExceptionTest
	{
		[ExpectedException(typeof(ArgumentException), "Failed ExceptionTest")]
		[TestMethod]
		public void ExceptionMethodTest() {
			Calulator.SayHello(null);
		}
	}
}
