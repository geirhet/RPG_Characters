using RPG_Characters.ItemsClasses;


namespace RPG_Characters.CharacterClasses
{
	/// <summary>
	/// Mage class based upon the base character class. Adds all the properties and overrides methods specifically for mages.
	/// </summary>
	public class Mage : BaseCharacter
	{
		public Mage(string name) : base(name)
		{
			BaseAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 8 };
			LevelUpAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 5 };
		}

		protected override bool CheckClassForValidArmorType(Armor armor)
		{
			return (armor.ArmorType == ArmorType.ARMOR_CLOTH);
		}

		protected override bool CheckClassForValidWeaponType(Weapon weapon)
		{
			return (weapon.WeaponType == WeaponType.WEAPON_STAFF || weapon.WeaponType == WeaponType.WEAPON_WAND);
		}

		protected override double PrimaryClassAttribute(PrimaryAttributes total)
		{
			return total.Intelligence;
		}
	}
}
