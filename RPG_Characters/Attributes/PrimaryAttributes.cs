

namespace RPG_Characters.CharacterClasses
{
	public class PrimaryAttributes
	{
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Intelligence { get; set; }

		public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
		{
			return new PrimaryAttributes()
			{
				Strength = lhs.Strength + rhs.Strength,
				Dexterity = lhs.Dexterity + rhs.Dexterity,
				Intelligence = lhs.Intelligence + rhs.Intelligence
			};
		}
	}
}
