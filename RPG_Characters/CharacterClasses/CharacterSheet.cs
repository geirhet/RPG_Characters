using System.Text;


namespace RPG_Characters.CharacterClasses
{
  public class CharacterSheet
  {
    /// <summary>
    /// Creates a string showing the characters name, level and attributes.
    /// </summary>
    /// <param name="character"></param>
    /// <returns>The string showing the characters details.</returns>
    public static string PrintCharacterSheet(BaseCharacter character)
    {
      PrimaryAttributes TotalAttributes = character.TotalPrimaryAttributes();
      StringBuilder CharacterSheet = new();
      CharacterSheet.Append("Name: " + character.Name + "\n");
      CharacterSheet.Append("Level: " + character.Level + "\n");
      CharacterSheet.Append("Strength: " + TotalAttributes.Strength + "\n");
      CharacterSheet.Append("Dexterity: " + TotalAttributes.Dexterity + "\n");
      CharacterSheet.Append("Intelligence: " + TotalAttributes.Intelligence + "\n");
      CharacterSheet.Append("Damage: " + character.Attack() + "\n");
      return CharacterSheet.ToString();
    }


  }
}
