using System;
using System.Threading;

namespace gameLib {

	public static class Dice {
		private static Random r = new Random();
		public static int diceThrow(int size = 6, int throws = 1) {
			int sum = 0;
			for ( int i = 1; i <= throws; i++ ) sum += (r.Next(1, size + 1));
			return sum;
		}
		public static int dice6() { return r.Next(1, 7); }
	}
}