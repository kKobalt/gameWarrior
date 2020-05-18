using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using gameLib;

namespace game {
	public static class WarriorGame {

		public static void Main(string[] args) {

			ArrayList squad = new ArrayList();

			Character warrior = new Character("Sivana", 200, 50, ERace.human, ESide.light, EWeapon.sword, EArmor.shield);
			Character orc = new Character("TrAAskGHia", 315, 50, ERace.orc, ESide.dark, EWeapon.axe, EArmor.parry);
			Character elf = new Character("Ankhar Lumia", 185, 50, ERace.elf, ESide.light, EWeapon.bow, EArmor.deflect);
			Character dwarf = new Character("BalKrum", 205, 50, ERace.dwarf, ESide.dark, EWeapon.hammer, EArmor.shield);

			squad.Add(warrior);
			squad.Add(orc);
			squad.Add(elf);
			squad.Add(dwarf);

			foreach ( Character being in squad )
			{
				Console.WriteLine(being.Health);
			}

			Attack.phaseAttack(warrior, orc);

			Console.WriteLine();
		}
	}
}