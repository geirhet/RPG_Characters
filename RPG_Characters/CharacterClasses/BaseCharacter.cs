using System;
using System.Collections.Generic;
using RPG_Characters.Exceptions;
using RPG_Characters.ItemsClasses;

namespace RPG_Characters.CharacterClasses
{
  public abstract class BaseCharacter
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public Equipment Equipment { get; set; }
    public PrimaryAttributes BaseAttributes;
    public PrimaryAttributes LevelUpAttributes;

    

		protected BaseCharacter(string name)
		{
			Name = name;
			Level = 1;
			Equipment = new Equipment();
		}

		/// <summary>
		/// Increases character level and increases attributes according to class.
		/// </summary>
		/// <returns>Characters level</returns>
		public int LevelUp()
		{
			BaseAttributes += LevelUpAttributes;
			Level++;
			return Level;
		}

		/// <summary>
		/// Equips weapon or armor to character in the item slot specified for the item.
		/// Throws errors if it was not able to equip item.
		/// </summary>
		/// <param name="item"></param>
		/// <returns>String with success message</returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="InvalidWeaponException"></exception>
		/// <exception cref="InvalidArmorException"></exception>
		/// <exception cref="Exception"></exception>
		public string Equip(Item item)
		{
			if (item == null)
			{
				throw new NullReferenceException();
			}

			if (item is Weapon weapon)
			{
				if (weapon.ItemLevel > Level)
				{
					throw new InvalidWeaponException("Character level is not high enough to carry this weapon!");
				}
				if (CheckClassForValidWeaponType(weapon))
				{
					Equipment.Equipped.Add(item.ItemSlot, item);
					return "New weapon equipped!";
				}
				throw new InvalidWeaponException("Character can not use this weapon type!");
			}

			if (item is Armor armor)
			{
				if (armor.ItemLevel > Level)
				{
					throw new InvalidArmorException("Character level is not high enough to carry this armor!");
				}
				if (CheckClassForValidArmorType(armor))
				{
					Equipment.Equipped.Add(item.ItemSlot, item);
					return "New armor equipped!";
				}
				throw new InvalidArmorException("Character can not use this armor type!");
			}

			throw new Exception("You are trying to equip an invalid item!");

		}

		/// <summary>
		/// Calculates the damage done by the character. 
		/// Checks and calculates accordingly if character is equipped with a weapon or is bare-handed.
		/// </summary>
		/// <returns>Damage value as double</returns>
		public double Attack()
		{
			if (Equipment.Equipped.ContainsKey(Slot.SLOT_WEAPON))
			{
				Weapon? weapon = Equipment.Equipped[Slot.SLOT_WEAPON] as Weapon;
				return weapon!.WeaponAttributes.DPS * (1.0 + (PrimaryClassAttribute(TotalPrimaryAttributes()) / 100));
			}

			return 1.0 * (1.0 + (PrimaryClassAttribute(TotalPrimaryAttributes()) / 100.0));
		}

		/// <summary>
		/// Calculates primary attributes with attributes added by armor
		/// </summary>
		/// <returns>Calculated attributes as double</returns>
		public PrimaryAttributes TotalPrimaryAttributes()
		{
			PrimaryAttributes TotalAttributes = BaseAttributes;
			foreach (KeyValuePair<Slot, Item> item in Equipment.Equipped)
			{
				if (item.Value is Armor armor)
				{
					TotalAttributes += armor.Attributes;
				}
			}
			return TotalAttributes;
		}

		/// <summary>
		/// Finds the characters primary attribute bound to the character class.
		/// </summary>
		/// <param name="total"></param>
		/// <returns>The primary class attribute as a double</returns>
		protected abstract double PrimaryClassAttribute(PrimaryAttributes total);

		/// <summary>
		/// Checks if the armor type is valid for the characters class.
		/// </summary>
		/// <param name="armor"></param>
		/// <returns>true if class can equip the armor, otherwise false</returns>
		protected abstract bool CheckClassForValidArmorType(Armor armor);

		/// <summary>
		/// Checks if the weapon type is valid for the characters class.
		/// </summary>
		/// <param name="weapon"></param>
		/// <returns>true if class can equip the weapon, otherwise false</returns>
		protected abstract bool CheckClassForValidWeaponType(Weapon weapon);
	}
}
