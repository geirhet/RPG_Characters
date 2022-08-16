
using RPG_Characters.ItemsClasses;

namespace RPG_Characters.CharacterClasses
{/// <summary>
 /// Ranger class based upon the base character class. Adds all the properties and overrides methods specifically for rangers.
 /// </summary>
	public class Ranger : BaseCharacter
	{
		public Ranger(string name) : base(name)
		{
			BaseAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 7, Intelligence = 1 };
			LevelUpAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 5, Intelligence = 1 };
		}

		protected override bool CheckClassForValidArmorType(Armor armor)
		{
			return (armor.ArmorType == ArmorType.ARMOR_MAIL || armor.ArmorType == ArmorType.ARMOR_LEATHER);
		}

		protected override bool CheckClassForValidWeaponType(Weapon weapon)
		{
			return (weapon.WeaponType == WeaponType.WEAPON_BOW);
		}

		protected override double PrimaryClassAttribute(PrimaryAttributes total)
		{
			return total.Dexterity;
		}
	}
}
