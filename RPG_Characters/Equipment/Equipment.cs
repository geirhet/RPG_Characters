using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.ItemsClasses
{
	/// <summary>
	/// Creates a dictionary using Slot as key for the equipment equipped.
	/// </summary>
	public class Equipment
	{
		public Dictionary<Slot, Item> Equipped { get; set; }

		public Equipment()
		{
			Equipped = new Dictionary<Slot, Item>();
		}
	}


}

