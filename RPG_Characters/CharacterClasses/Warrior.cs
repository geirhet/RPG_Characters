
using RPG_Characters.ItemsClasses;

namespace RPG_Characters.CharacterClasses
{
	public class Warrior : BaseCharacter
	{
		public Warrior(string name) : base(name)
		{
			BaseAttributes = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };
			LevelUpAttributes = new PrimaryAttributes() { Strength = 3, Dexterity = 2, Intelligence = 1 };
		}

		protected override bool CheckClassForValidArmorType(Armor armor)
		{
			return (armor.ArmorType == ArmorType.ARMOR_MAIL || armor.ArmorType == ArmorType.ARMOR_PLATE);
		}

		protected override bool CheckClassForValidWeaponType(Weapon weapon)
		{
			return (weapon.WeaponType == WeaponType.WEAPON_AXE || weapon.WeaponType == WeaponType.WEAPON_HAMMER || weapon.WeaponType == WeaponType.WEAPON_SWORD);
		}

		protected override double PrimaryClassAttribute(PrimaryAttributes total)
		{
			return total.Strength;
		}
	}
}

