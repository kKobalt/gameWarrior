using System.Collections;

namespace gameLib {
	public class Character {

		#region fields
		private string name;
		private double health;
		private double speed = 100;
		private ERace race;
		private ESide side;
		private EWeapon weapon;
		private EArmor armor;
		public string Name { get => name; set => name = value; }
		public double Health { get => health; set => health = value; }
		public ERace Race { get => race; set => race = value; }
		public ESide Side { get => side; set => side = value; }
		public EWeapon Weapon { get => weapon; set => weapon = value; }
		public EArmor Armor { get => armor; set => armor = value; }
		public double Speed { get => speed; set => speed = value; }
		#endregion fields

		public Character(string name, int health, int speed, ERace race, ESide side, EWeapon weapon, EArmor armor) {
			this.Name = name;
			this.Health = health;
			this.Race = race;
			this.Side = side;
			this.Weapon = weapon;
			this.Armor = armor;
		}
	}
}