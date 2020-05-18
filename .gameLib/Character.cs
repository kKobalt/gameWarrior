namespace gameLib {
	public class Character {
		public enum EChar { good, bad }

		private string name;
		private double strength;
		private EChar state;
		public string Name { get => name; set => name = value; }
		public double Strength { get => strength; set => strength = value; }
		public EChar State { get => state; set => state = value; }

		public Character(string name, int str, EChar state) {
			this.Name = name;
			this.Strength = str;
			this.State = state;
		}
	}
}