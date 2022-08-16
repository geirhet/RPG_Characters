

namespace RPG_Characters.ItemsClasses
{
	/// <summary>
	/// Creates the abstract item class. Used for both Weapon and Armor. Stores item name, level and equipment slot used.
	/// </summary>
	public abstract class Item
	{
		public string ItemName { get; set; }
		public int ItemLevel { get; set; }
		public abstract Slot ItemSlot { get; set; }
	}
}
