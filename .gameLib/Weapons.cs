using System;
using System.Collections.Generic;
using System.Text;

namespace gameLib {
	public enum EWeaponType { close, distance }

	public class Weapon {
		private string name;
		private double strength, defense, durability, speed;
		public string Name { get => name; set => name = value; }
		public double Strength { get => strength; set => strength = value; }
		public double Defense { get => defense; set => defense = value; }
		public double Durability { get => durability; set => durability = value; }
		public double Speed { get => speed; set => speed = value; }

		public Weapon(string name, double strength, double defense, double durability, double speed) {
			Name = name;
			Strength = strength;
			Defense = defense;
			Durability = durability;
			Speed = speed;
		}
	}

	public class Axe1 : Weapon {
		public Axe1(string name, double strength, double defense, double durability, double speed) : base(name, strength, defense, durability, speed) {
		}
	}
}