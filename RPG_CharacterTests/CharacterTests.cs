
using Xunit;
using RPG_Characters.CharacterClasses;

namespace RPG_CharacterTests
{
	public class CharacterTests
	{
		#region Character levels
		/// <summary>
		/// Method for testing that character is level one (1) after being created.
		/// </summary>
		[Fact]
		public void Character_WhenCreated_IsLevelOne()
		{
			// Arrange
			int expected = 1;

			// Act
			Warrior character = new("");
			int actual = character.Level;

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for testing that character is level two (2)  after being leveled up.
		/// </summary>
		[Fact]
		public void Character_OnLevelUp_IsLevelTwo()
		{
			// Arrange
			int expected = 2;

			// Act
			Warrior character = new("");
			character.LevelUp();
			int actual = character.Level;

			// Assert
			Assert.Equal(expected, actual);
		}
		#endregion

		#region Character attributes at level one (1)
		/// <summary>
		/// Method for checking if the warrior class is created with the correct attributes.
		/// </summary>
		[Fact]
		public void Character_WhenWarriorCreated_HasWarriorLevelOneAttributes()
		{
			// Arrange
			int[] expected = { 5, 2, 1 };

			// Act
			Warrior character = new("");
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the ranger class is created with the correct attributes.
		/// </summary>
		[Fact]
		public void Character_WhenRangerCreated_HasRangerLevelOneAttributes()
		{
			// Arrange
			int[] expected = { 1, 7, 1 };

			// Act
			Ranger character = new("");
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the rogue class is created with the correct attributes.
		/// </summary>
		[Fact]
		public void Character_WhenRogueCreated_HasRogueLevelOneAttributes()
		{
			// Arrange
			int[] expected = { 2, 6, 1 };

			// Act
			Rogue character = new("");
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the mage class is created with the correct attributes.
		/// </summary>
		[Fact]
		public void Character_WhenMageCreated_HasMageLevelOneAttributes()
		{
			// Arrange
			int[] expected = { 1, 1, 8 };

			// Act
			Mage character = new("");
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}
		#endregion


		#region Character attributes at level two (2)
		/// <summary>
		/// Method for checking if the warrior class has correct attributes after leveling up.
		/// </summary>
		[Fact]
		public void Character_OnWarriorLevelTwo_HasLevelTwoWarriorAttributes()
		{
			// Arrange
			int[] expected = { 8, 4, 2 };

			// Act
			Warrior character = new("");
			character.LevelUp();
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the ranger class has correct attributes after leveling up.
		/// </summary>
		[Fact]
		public void Character_OnRangerLevelTwo_HasLevelTwoRangerAttributes()
		{
			// Arrange
			int[] expected = { 2, 12, 2 };

			// Act
			Ranger character = new("");
			character.LevelUp();
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the rogue class has correct attributes after leveling up.
		/// </summary>
		[Fact]
		public void Character_OnRogueLevelTwo_HasLevelTwoRogueAttributes()
		{
			// Arrange
			int[] expected = { 3, 10, 2 };

			// Act
			Rogue character = new("");
			character.LevelUp();
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Method for checking if the mage class has correct attributes after leveling up.
		/// </summary>
		[Fact]
		public void Character_OnMageLevelTwo_HasLevelTwoMageAttributes()
		{
			// Arrange
			int[] expected = { 2, 2, 13 };

			// Act
			Mage character = new("");
			character.LevelUp();
			int[] actual = { character.BaseAttributes.Strength, character.BaseAttributes.Dexterity, character.BaseAttributes.Intelligence };

			// Assert
			Assert.Equal(expected, actual);
		}
		#endregion
	}
}
