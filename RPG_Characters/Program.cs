using System;
using RPG_Characters.CharacterClasses;
using RPG_Characters.ItemsClasses;

namespace RPG_Characters
{
	class Program
	{
		/// <summary>
		/// A simple test for showing character sheet. 
		/// Test example with Warrier.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Warrior character = new("Geirhet");

			Weapon Axe = new()
			{
				ItemName = "Common Axe",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_AXE,
				WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
			};

			Armor PlateBody = new()
			{
				ItemName = "Common plate armor",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_BODY,
				ArmorType = ArmorType.ARMOR_PLATE,
				Attributes = new PrimaryAttributes() { Dexterity = 1 }
			};
			character.LevelUp();
			character.Equip(Axe);
			character.Equip(PlateBody);
			Console.WriteLine(CharacterSheet.PrintCharacterSheet(character));
		}
	}
	
}

