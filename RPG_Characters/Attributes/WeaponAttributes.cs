

namespace RPG_Characters.ItemsClasses
{
	/// <summary>
	/// Creates the weapon attributes that stores the weapons damage, attack speed and damage per second
	/// </summary>
	public class WeaponAttributes
	{
		public double Damage { get; set; }
		public double AttackSpeed { get; set; }
		public double DPS => Damage * AttackSpeed;
	}
}