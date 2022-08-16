
using RPG_Characters.CharacterClasses;
using RPG_Characters.Exceptions;
using RPG_Characters.ItemsClasses;
using Xunit;

namespace RPG_CharacterTests
{
	public class ItemTests
	{
		#region Equip high level equipment
		/// <summary>
		/// Method to test if an weapon exception is thrown when the character equips a too high level weapon.
		/// </summary>
		[Fact]
		public void Equip_WhenHighLevelWeapon_ShouldThrowWeaponException()
		{
			// Arrange
			Warrior Character = new("");
			Weapon TestAxe = new()
			{
				ItemName = "Common axe",
				ItemLevel = 2,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_AXE,
				WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
			};
			// Act & Assert
			Assert.Throws<InvalidWeaponException>(() => Character.Equip(TestAxe));
		}

		/// <summary>
		/// Method to test if an armor exception is thrown when the character equips a too high level armor.
		/// </summary>
		[Fact]
		public void Equip_WhenHighLevelArmor_ShouldThrowArmorException()
		{
			// Arrange
			Warrior Character = new("");
			Armor TestPlateBody = new()
			{
				ItemName = "Common plate body armor",
				ItemLevel = 2,
				ItemSlot = Slot.SLOT_BODY,
				ArmorType = ArmorType.ARMOR_PLATE,
				Attributes = new PrimaryAttributes() { Strength = 1 }
			};
			// Act & Assert
			Assert.Throws<InvalidArmorException>(() => Character.Equip(TestPlateBody));
		}
		#endregion


		#region Equip wrong equipment
		/// <summary>
		/// Method to test if an weapon exception is thrown when the character equips wrong weapon type.
		/// </summary>
		[Fact]
		public void Equip_WhenWrongWeaponType_ShouldThrowWeaponException()
		{
			// Arrange
			Warrior Character = new("");
			Weapon TestBow = new()
			{
				ItemName = "Common bow",
				ItemLevel = 2,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_BOW,
				WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
			};
			// Act & Assert
			Assert.Throws<InvalidWeaponException>(() => Character.Equip(TestBow));
		}
		/// <summary>
		/// Method to test if an armor exception is thrown when the character equips wrong armor type.
		/// </summary>
		[Fact]
		public void Equip_WhenWrongArmorType_ShouldThrowArmorException()
		{
			// Arrange
			Warrior Character = new("");
			Armor TestClothHead = new Armor()
			{
				ItemName = "Common cloth head armor",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_HEAD,
				ArmorType = ArmorType.ARMOR_CLOTH,
				Attributes = new PrimaryAttributes() { Intelligence = 5 }
			};
			// Act & Assert
			Assert.Throws<InvalidArmorException>(() => Character.Equip(TestClothHead));
		}
		#endregion

		#region Equip correct equipment
		/// <summary>
		/// Method for testing if the correct string is returned when successfully equipping a weapon.
		/// </summary>
		[Fact]
		public void Equip_WhenWrCorrectWeaponType_ShouldReturnNewWeaponEquipped()
		{
			// Arrange
			string Expected = "New weapon equipped!";
			Warrior Character = new("");
			Weapon TestHammer = new()
			{
				ItemName = "Common axe",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_HAMMER,
				WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
			};
			// Act 
			string Actual = Character.Equip(TestHammer);
			// Assert
			Assert.Equal(Expected, Actual);
		}

		/// <summary>
		/// Method for testing if the correct string is returned when successfully equipping an armor.
		/// </summary>
		[Fact]
		public void Equip_WhenWrCorrectArmorType_ShouldReturnNewArmorEquipped()
		{
			// Arrange
			string Expected = "New armor equipped!";
			Warrior Character = new("");
			Armor TestPlateBody = new()
			{
				ItemName = "Common plate body armor",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_BODY,
				ArmorType = ArmorType.ARMOR_PLATE,
				Attributes = new PrimaryAttributes() { Strength = 1 }
			};
			// Act 
			string Actual = Character.Equip(TestPlateBody);
			// Assert
			Assert.Equal(Expected, Actual);
		}
		#endregion

		#region Character attack damage
		/// <summary>
		/// Method for testing if the character deals the correct damage without any equipment.
		/// </summary>
		[Fact]
		public void AttackDamage_WarriorAtLevelOneWithNoItemsEquipped_ReturnAmountOfDamage()
		{
			// Arrange
			double Expected = 1.0 * (1.0 + (5.0 / 100.0)); // 1.05
			Warrior Character = new("");
			// Act
			double Actual = Character.Attack();
			// Assert
			Assert.Equal(Expected, Actual);
		}

		/// <summary>
		/// Method for testing if the character deals the correct damage with a weapon.
		/// </summary>
		[Fact]
		public void AttackDamage_WarriorAtLevelOneWithWeaponEquipped_ReturnAmountOfDamage()
		{
			// Arrange
			double Expected = (7.0 * 1.1) * (1.0 + (5.0 / 100.0)); // 8.085
			Warrior Character = new("");
			Weapon TestAxe = new()
			{
				ItemName = "Common axe",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_AXE,
				WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
			};
			// Act
			Character.Equip(TestAxe);
			double Actual = Character.Attack();
			// Assert
			Assert.Equal(Expected, Actual);
		}

		/// <summary>
		/// Method for testing if the character deals the correct damage with weapon and armor.
		/// </summary>
		[Fact]
		public void AttackDamage_WarriorAtLevelOneWithWeaponAndArmorEquipped_ReturnAmountOfDamage()
		{
			// Arrange
			double Expected = (7.0 * 1.1) * (1.0 + ((5.0 + 1.0) / 100.0)); // 8.162
			Warrior Character = new("");
			Weapon TestAxe = new()
			{
				ItemName = "Common axe",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_WEAPON,
				WeaponType = WeaponType.WEAPON_AXE,
				WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
			};
			Armor TestPlateBody = new()
			{
				ItemName = "Common plate body armor",
				ItemLevel = 1,
				ItemSlot = Slot.SLOT_BODY,
				ArmorType = ArmorType.ARMOR_PLATE,
				Attributes = new PrimaryAttributes() { Strength = 1 }
			};
			// Act
			Character.Equip(TestPlateBody);
			Character.Equip(TestAxe);
			double Actual = Character.Attack();
			// Assert
			Assert.Equal(Expected, Actual);
		}
		#endregion
	}
}
