using gameLib;
using System;
using System.Threading;

namespace gameLib {

	public static class Attack {
		private static Random r = new Random();

		public static int fight(Character warrior1, Character warrior2) {

			if ( Dice.dice6() % 2 == 0 )
			{

				//warrior1.Weapon.

				return 11;
			}
			else
			{ return 12; }
		}

		public static int phaseAttack(params Character[] count) {

			/// TODO	- rozdělit sides a poslat je proti sobě
			///				- pokud nebudou rozdílné frakce: postih za boj proti stejné frakci

			//if ( count.Length == 2 )
			fight(count[0], count[1]);

			return 2;
		}
	}
}