using RPG_Characters.CharacterClasses;



namespace RPG_Characters.ItemsClasses
{
	/// <summary>
	/// Defines the item object armor. Storing armor type, item slot it uses and attributes it increases.
	/// </summary>
	public class Armor : Item
	{
		public ArmorType ArmorType { get; set; }
		public override Slot ItemSlot { get; set; }
		public PrimaryAttributes Attributes { get; set; }
	}
}
