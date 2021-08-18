using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsProject.Tests
{
	[TestClass]
	public class CollectionAssertTests
	{
		static List<string> users { get; set; }

		[ClassInitialize]
		public static void InitCollectionAssertTests(TestContext ts) {
			users = new List<string>();
			users.Add("Max");
			users.Add("Ivan");
			users.Add("Maria");
			Debug.WriteLine("Hey, it`s ClassInitialize!!!");
		}

		[TestMethod]
		public void AllItemsAreNotEqualTest() {
			CollectionAssert.AllItemsAreNotNull(users, "Failed AllItemsAreNotEqualTest!!!");
		}

		[TestMethod]
		public void AreUniqueTest() {
			CollectionAssert.AllItemsAreUnique(users, "Failed AreUniqueTest");
		}

		[TestMethod]
		public void	AreEqualTest() {
			var otherUsers = new List<string>();
			otherUsers.Add("Max");
			otherUsers.Add("Ivan");
			otherUsers.Add("Maria");
			CollectionAssert.AreEqual(users, otherUsers, "Failed AreEqualTest");
		}

		[TestMethod]
		public void AreEquivalentTest() {
			var otherUsers = new List<string>();
			otherUsers.Add("Ivan");
			otherUsers.Add("Max");
			otherUsers.Add("Maria");
			CollectionAssert.AreEquivalent(users, otherUsers, "Failed AreEuqivalentTest");
		}

		[TestMethod]
		public void SubsetTest() {
			var list = new List<string>();
			list.Add(users[1]);
			CollectionAssert.IsSubsetOf(list, users, "Failed SubsetTest");
		}
	}
}
