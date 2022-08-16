

namespace RPG_Characters.ItemsClasses
{
	/// <summary>
	/// Defines the item object weapon. Storing weapon type, item slot it uses and weapon attributes.
	/// </summary>
	public class Weapon : Item
	{
		public WeaponType WeaponType { get; set; }
		public override Slot ItemSlot { get; set; }
		public WeaponAttributes WeaponAttributes { get; set; }
	}
}
