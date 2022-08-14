using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
  public class Equipment
  {
    private Dictionary<int, Equipment> ItemsEquipment { get; set; }


    public int GetEquipmentSize()
    {
      // Counting the elements i our dictionary and returning that value

      return ItemsEquipment.Count;
    }

    //public int AddItem(Equipment itemToAdd)
    //{
    //  //Check first slot where item == null
    //  foreach (KeyValuePair<int, Equipment> item in ItemsEquipment)
    //  {
    //    if (Equipment. == null)
    //    {
    //      ItemsEquipment[Equipment.Key] = itemToAdd;
    //      return Equipment.Key;

    //    }

    //  }
    //  return 0;
    //}


  }
}
