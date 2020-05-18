namespace gameLib {

	public class Weapon {
		private string name;
		private EWeaponType type;
		private double strength = 10, defense = 5, durability = 100, speed = 3;
		public string Name { get => name; set => name = value; }
		public double Strength { get => strength; set => strength = value; }
		public double Defense { get => defense; set => defense = value; }
		public double Durability { get => durability; set => durability = value; }
		public double Speed { get => speed; set => speed = value; }
		public EWeaponType Type { get => type; set => type = value; }

		public Weapon(string name, double strength, double defense, double durability, double speed, EWeaponType type) {
			this.Name = name;
			this.Strength = strength;
			this.Defense = defense;
			this.Durability = durability;
			this.Speed = speed;
			this.Type = type;
		}
	}

	public class Sword1 : Weapon {
		public Sword1(string name, double strength, double defense, double durability, double speed) : base(name, strength, defense, durability, speed, EWeaponType.close) {
			this.Name = name;
			this.Defense = defense;
			this.Durability = durability;
			this.Strength = strength;
			this.Speed = speed;
			this.Type = EWeaponType.close;
		}
		//public class Sword1 : Weapon {
		//	public Sword1(EWeaponType type) {
		//		this.Name = name;
		//		this.Defense = defense;
		//		this.Durability = durability;
		//		this.Strength = strength;
		//		this.Speed = speed;
		//	}
	}

	public class Axe1 : Weapon {
		public Axe1(string name, double strength, double defense, double durability, double speed, EWeaponType type) : base(name, strength, defense, durability, speed, type) {
		}
	}
	public class Bow1 : Weapon {
		public Bow1(string name, double strength, double defense, double durability, double speed, EWeaponType type) : base(name, strength, defense, durability, speed, type) {
		}
	}
	public class Hammer1 : Weapon {
		public Hammer1(string name, double strength, double defense, double durability, double speed, EWeaponType type) : base(name, strength, defense, durability, speed, type) {
		}
	}
}