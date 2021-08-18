using System;

namespace UnitTestsProject
{
	public static class Calulator
	{
		public static int Sum(int x, int y, int z = default) {
			if (z > 0) {
				return x + z + y;
			} else {
				return x + y;
			}
		}

		public static int Multiple(int x, int y, int z = default) {
			if (z > 0) {
				return x * y * z;
			} else {
				return x * y;
			}
		}

		public static string SayHello(string name) {
			if (name == null) {
				throw new ArgumentException("Some msg!!!");
			}
			return "Name" + name;
		}
	}
}
