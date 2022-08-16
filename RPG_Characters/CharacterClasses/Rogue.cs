
using RPG_Characters.ItemsClasses;

namespace RPG_Characters.CharacterClasses
{
	public class Rogue : BaseCharacter
	{
		public Rogue(string name) : base(name)
		{
			BaseAttributes = new PrimaryAttributes() { Strength = 2, Dexterity = 6, Intelligence = 1 };
			LevelUpAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 4, Intelligence = 1 };
		}

		protected override bool CheckClassForValidArmorType(Armor armor)
		{
			return (armor.ArmorType == ArmorType.ARMOR_MAIL || armor.ArmorType == ArmorType.ARMOR_LEATHER);
		}

		protected override bool CheckClassForValidWeaponType(Weapon weapon)
		{
			return (weapon.WeaponType == WeaponType.WEAPON_DAGGER || weapon.WeaponType == WeaponType.WEAPON_SWORD);
		}

		protected override double PrimaryClassAttribute(PrimaryAttributes total)
		{
			return total.Dexterity;
		}
	}
}
