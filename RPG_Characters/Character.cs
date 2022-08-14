using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
  public abstract class Character
  {
    public string Name { get; set; }
    public double Level { get; set; }
    public double BasePrimaryAttribute { get; set; }
    public double TotalPrimaryAttribute { get; set; }

    //Default Constructor
    public Character() 
    {

    }


    public Character(string name, double level) //double basePrimaryAttribute, double totalPrimaryAttribute)
    {
      Name = name;
      Level = level;
      
    }

    public abstract void DoSomething();

    public virtual void DoSometingMore()
    {
      Console.WriteLine("Something is beeing done");
    }
  }
}
